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
    public delegate void control_event (string data) ;
    public partial class header_name_req : Form
    {

        //event for adding nodes to the tree
        public event control_event addnode_event;
        //public static delegate string del(string n);

        //public static string return_header(string name)
        //{
        //    return name;
        //}

        //del handler = return_header;

        public header_name_req()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirm_header_Click(object sender, EventArgs e)
        {
            string header_name = header_textbox.Text;
            if (addnode_event != null)
            {
                addnode_event(header_name);
            }
            this.Hide();
        }
        public void header_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void header_name_req_Load(object sender, EventArgs e)
        {

        }


    }
}
