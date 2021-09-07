using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace main_project
{
    public delegate void control_2event(string data );

    public partial class all_data : Form
    {

        public event control_2event callnode_event;

        public all_data()
        {
            InitializeComponent();
            
            string [] a = File.ReadAllLines(@"c:\all_documnets.txt");
            for (int i = 0; i < a.Length; i++)
            {
                treeView1.Nodes.Add(a[i]);
            }
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
            string header_name = treeView1.SelectedNode.Text;
            a.load_object(header_name);
        }
    }
}
