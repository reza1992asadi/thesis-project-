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

    public partial class Form1 : Form
    {

        //the process of passing document's list to the form 3 
       // public event document_control passing_document_list ;

        public Form1()
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
            try
            {
                
                Form3 a = new Form3();
                a.Show();
    
            }
            catch
            {
                throw new Exception("can't open");
            }
        }
    }
}
