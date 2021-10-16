using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main_project
{
    class header
    {
        public string id_of_header;
        public string name_of_header;
        public string text_of_header;
        public List<header> headers;

        public header(string name)
        {
            headers = new List<header>();
            name_of_header = name;
            text_of_header = null;
        }
        public header()
        {
            headers = new List<header>();
        }

        public void add_header (header a)
        {
            headers.Add(a);
        }

        public void add_text (string text) 
        {
            this.text_of_header = text; 
        }

    }
}
