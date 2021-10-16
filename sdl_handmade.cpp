#include <iostream> 
using namespace std ;
#include <SDL.h>
#include <stdlib.h>
#include <stdint.h>
#include <sys/mman.h>

//types
typedef int8_t int8 ;
typedef int16_t int16 ;
typedef int32_t int32 ;
typedef int64_t int64 ;

typedef uint8_t uint8 ;
typedef uint16_t uint16 ;
typedef uint32_t uint32 ;
typedef uint64_t uint64 ;

//function prototype
bool HandleEvent (SDL_Event *Event) ;
void SDLResizeTexture (SDL_Window *Window , SDL_Renderer *Renderer , int width , int height) ;
void Update_window (SDL_Renderer *Renderer , SDL_Texture *Texture) ;
void pixelpainting (int Xoffset , int Yoffset); 

//global variables : 
bool ShouldQuit ;
SDL_Texture* Texture ;
void* BitmapMemory ;
int BytesPerPixel = 4 ;
int BitmapWidth ; 
int BitmapHeight ; 

bool HandleEvent (SDL_Event *Event) 
{
  return ShouldQuit ; 
}


void SDLResizeTexture (SDL_Window *Window , SDL_Renderer *Renderer , int width , int height)
{

  if (Texture)
    {
      SDL_DestroyTexture(Texture) ;
    }
  if (BitmapMemory)
    {
      free(BitmapMemory);
    } 
  Texture = SDL_CreateTexture(Renderer,
			      SDL_PIXELFORMAT_ARGB8888,
	 		      SDL_TEXTUREACCESS_STREAMING,
			      width,
			      height);
  BitmapMemory = malloc(width * height * BytesPerPixel) ;
  /*BitmapMemory = mmap (0 ,
		       width * height * BytesPerPixel ,
		       PROT_READ | PROT_WRITE ,
		       MAP_PRIVATE |MAP_ANONYMOUS ,
		       -1 ,
		       0) ; */

  BitmapWidth = width ;
  BitmapHeight = height ; 
  Update_window (Renderer , Texture ) ; 
}

void Update_window (SDL_Renderer *Renderer , SDL_Texture *Texture )
{
  
  if (SDL_UpdateTexture (Texture , 0 , BitmapMemory , BitmapWidth * BytesPerPixel ))
    {
      printf("failed to update texture : %s\n" , SDL_GetError()) ; 
    }

  pixelpainting(128 , 0);

  SDL_RenderCopy(Renderer , Texture , 0 , 0 ) ;
    
  SDL_RenderPresent(Renderer) ;
}

void pixelpainting (int Xoffset , int Yoffset)
{
  int local_width = BitmapWidth ;
  int pitch = local_width * BytesPerPixel ;
  uint8 *Row = (uint8 *)BitmapMemory ;

  for (int y = 0 ; y < BitmapHeight ; ++y)
    {
      uint8 *pixel = (uint8 *)Row ;
      for (int x = 0 ; x < BitmapWidth ; ++x)
	{
	  //pixels in memory bb gg rr xx
	  *pixel = (uint8)(x + Xoffset);
	  ++pixel ;

	  *pixel = (uint8)(y + Yoffset);
	  ++pixel ;

	  *pixel = 0 ;
	  ++pixel ;

	  *pixel = 0 ;
	  ++pixel ;
	}
      Row += pitch ; 
    }
} 

int main () 
{

  if (SDL_Init(SDL_INIT_VIDEO) != 0) ;
  {
    cout << "SDL INITIALIZED \n" ;
  }
	
  SDL_Window *Window ;

  int height ; 
  int width ;
  ShouldQuit = false ; 
  


  Window = SDL_CreateWindow("Handmade Hero" , SDL_WINDOWPOS_UNDEFINED ,
			    SDL_WINDOWPOS_UNDEFINED ,
			    640 , 
			    480 , 
			    SDL_WINDOW_RESIZABLE) ;

	
  SDL_Renderer *Renderer = SDL_CreateRenderer(Window , -1 , 0 ) ;

  Texture = SDL_CreateTexture(Renderer,
			      SDL_PIXELFORMAT_ARGB8888,
			      SDL_TEXTUREACCESS_STREAMING,
			      width,
			      height);

  BitmapMemory = malloc(width * height * BytesPerPixel) ;
  /*  BitmapMemory = mmap (0 ,
		       width * height * BytesPerPixel ,
		       PROT_READ | PROT_WRITE ,
		       MAP_PRIVATE |MAP_ANONYMOUS ,
		       -1 ,
		       0) ;    */
  

  Update_window (Renderer , Texture) ;

 
     
 for ( ; ; ) 
 {
        SDL_Event Event ;
	SDL_Window *current_window = SDL_GetWindowFromID(Event.window.windowID) ; 
    	SDL_Renderer *current_renderer = SDL_GetRenderer(current_window) ;
      	while (SDL_PollEvent (&Event))
	{
      	if (!HandleEvent(&Event))
	{
	      	
        	switch (Event.type ) 
	        {
			case SDL_QUIT :
				{
					cout << "sdl_quit \n" ;
					ShouldQuit = true  ; 
				}break;
                        case SDL_WINDOWEVENT : 
				{
					switch (Event.window.event)
				  	 {
						case SDL_WINDOWEVENT_SIZE_CHANGED :
							{
							     SDL_GetWindowSize(current_window , &width , &height) ;
							     cout << "after resize ---> width is : " << width << " height is : " << height <<endl ;
						      	     SDLResizeTexture (current_window , current_renderer , width , height) ;
						        }
						case SDL_WINDOWEVENT_EXPOSED : 
							{
							  Update_window (  current_renderer , Texture) ;
							} break ; 
					}

			        }break ;
				
	        }	
	}
	else
	  {
	    SDL_Quit() ;
	    break ; 
	  }
	}
 }
 return (0) ; 
}
