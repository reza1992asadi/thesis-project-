using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace main_project
{
    //the process of passing document's list to the form 3 
    //ublic delegate void document_control (document a);

    public partial class Opening_window : Form
    {

        //the process of passing document's list to the form 3 
       // public event document_control passing_document_list ;

        public Opening_window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void database_Click(object sender, EventArgs e)
        {
            all_data a = new all_data();
            a.Show();
        }

        private void create_Click(object sender, EventArgs e)
        {
           // try
            //{
                
                Main_window a = new Main_window();
                a.Show();
    
            //}
            //catch
            //{
                //Console.WriteLine("there was a problem"); 
            //}
        }
    }
}
