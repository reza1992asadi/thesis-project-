using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Json converter library ...
using System.Web.Script.Serialization;
using System.IO;

namespace main_project
{
    public partial class Main_window : Form
    {


        //create an object for document class 
        //document new_list_of_documents = new document();n
        header base_of_document;
        int header_counter = 0;
        header object_edit = null;

        // a list containing all headers of a single document 
        List<header> guide = new List<header>();

        //public void intialize_object (header current_object) ;

        public void load_object(string header_name)
        {
            treeView1.ContextMenuStrip = this.contextMenuStrip1;
            Neww.Visible = false;

            string path = string.Format(@"C:\Users\Reza\Documents\{0}.txt", header_name);
            string all = File.ReadAllText(path);

            char a = '"';
            string b = a.ToString();
            string[] trimed_all = all.Split(new string[] { b }, StringSplitOptions.RemoveEmptyEntries);

            Stack<header> mystack = new Stack<header>();
            bool stack_flag = false;

            int pop_count = 0;

            header temp_2nd = null;
            header temp = new header(header_name);
            treeView1.Nodes.Add("0", header_name);
            temp.id_of_header = "0";
            header_counter++;
            temp.text_of_header = null;
            guide.Add(temp);
            base_of_document = temp;
            if (trimed_all[12] == ":[]}")
            {
                MessageBox.Show("it's null");
                base_of_document.headers = null;
            }
            else
            {
                for (int i = 12; i < trimed_all.Length; i++)
                {
                    if (i == 12)
                        stack_flag = true;

                    if (trimed_all[i] == ":[{")
                    {
                        
                        
                        if (stack_flag != true)
                        {
                            mystack.Push(temp);
                            temp = temp_2nd;
                        }

                        temp_2nd = new header();
                        header_counter++;
                        guide.Add(temp_2nd);
                        temp.add_header(temp_2nd);
                        


                        while (trimed_all[i] != "id_of_header")
                        {
                            i++;
                        }
                        i++;
                        i++;
                        temp_2nd.id_of_header = trimed_all[i];
                        while (trimed_all[i] != "name_of_header")
                        {
                            i++;
                        }
                        
                        i++;
                        i++;
                        temp_2nd.name_of_header = trimed_all[i];
                        while (trimed_all[i] != "text_of_header")
                        {
                            i++;
                        }
                        i++;
                        if (trimed_all[i] == ":")
                        {
                            i++;
                            temp_2nd.text_of_header = trimed_all[i];
                        }
                        while (trimed_all[i] != "headers")
                        {
                            i++;
                        }
                        stack_flag = false;
                        TreeNode[] node_temp = treeView1.Nodes.Find(temp.id_of_header, true);
                        node_temp.First().Nodes.Add(temp_2nd.id_of_header, temp_2nd.name_of_header);
                        //continue;

                    }
                    else if (trimed_all[i].StartsWith(":[]}"))
                        if (trimed_all[i].EndsWith("}"))
                        {
                            pop_count = trimed_all[i].Count(x => x == '}') - 1 ;
                            while (pop_count != 1)
                            {
                                //MessageBox.Show("" + pop_count);
                                temp = mystack.Pop();
                                pop_count--;
                            }
                            base_of_document = temp;
                            int kll = base_of_document.headers.Count;
                            for (int l = 0; l < kll; l++)
                            {
                                //MessageBox.Show(base_of_document.headers[l].name_of_header);
                            }
                            break;
                        }
                        else if (trimed_all[i].EndsWith(",{"))
                        {
                            pop_count = trimed_all[i].Count(x => x == '}') - 1;
                            while (pop_count != 0)
                            {
                                //MessageBox.Show("pop count is :" + pop_count);
                                temp = mystack.Pop();
                                pop_count--;
                            }
                            temp_2nd = new header();
                            header_counter++;
                            guide.Add(temp_2nd);
                            temp.add_header(temp_2nd);
                            while (trimed_all[i] != "id_of_header")
                            {
                                i++;
                            }
                            i++;
                            i++;
                            temp_2nd.id_of_header = trimed_all[i];
                            while (trimed_all[i] != "name_of_header")
                            {
                                i++;
                            }
                            
                            i++;
                            i++;
                            temp_2nd.name_of_header = trimed_all[i];
                            while (trimed_all[i] != "text_of_header")
                            {
                                i++;
                            }
                            i++;
                            if (trimed_all[i] == ":")
                            {
                                i++;
                                temp_2nd.text_of_header = trimed_all[i];
                            }
                            while (trimed_all[i] != "headers")
                            {
                                i++;
                            }
                            TreeNode[] node_temp = treeView1.Nodes.Find(temp.id_of_header, true);
                            node_temp.First().Nodes.Add(temp_2nd.id_of_header, temp_2nd.name_of_header);
                        }

                }
            }
            //base_of_document = temp;
            //int kl = base_of_document.headers.Count;
            //for (int i = 0; i < kl; i++)
            //{
            //    //MessageBox.Show(base_of_document.headers[i].id_of_header);
            //}
        }

        
        


        public Main_window()
        {
            InitializeComponent();
            all_data r = new all_data();
            r.callnode_event += new control_2event(r_callnode_event);
        }

        void r_callnode_event(string data)
        {
            throw new NotImplementedException();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Informer_Click(object sender, EventArgs e)
        {

        }

        private void book_title_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {

            create.Enabled = false;

            String a = name_of_book.Text;
            book_title.Text = a;

            //naming the node , taking it from name of the book 

            string temp = name_of_book.Text;
            string header_key = header_counter.ToString() ;
            treeView1.Nodes.Add(header_key , temp);

            //adding context menu to the node 

            treeView1.ContextMenuStrip = this.contextMenuStrip1;

            //creating an object for the new document 
            base_of_document = new header(name_of_book.Text);
            base_of_document.id_of_header = header_key;

            //adding base to the guide 
            guide.Add(base_of_document);

            
            

        }

        private void Neww_Click(object sender, EventArgs e)
        {
            Informer.Visible = true;
            name_of_book.Visible = true;
            create.Visible = true;
        }

        private void name_of_book_TextChanged(object sender, EventArgs e)
        {

        }

        private void newHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            header_name_req a = new header_name_req();
            a.Show();
            a.addnode_event += new control_event(a_addnode_event);
        }

        void a_addnode_event(string data)
        {
            header_counter++;
            string header_key = header_counter.ToString();
            treeView1.SelectedNode.Nodes.Add(header_key , data);


            //searching for the key
            string key = treeView1.SelectedNode.Name;
            header target = null;
            foreach (header a in guide )
            {
                if (a.id_of_header == key)
                {
                    target = a;
                    break;
                }
            }

            //adding this object to the guide and building the header object tree 

            header new_header = new header(data);
            guide.Add(new_header);
            new_header.id_of_header = header_key;
            target.add_header(new_header);

            //this is a test :

            //foreach (header a in guide)
            //{
            //    test.Text += a.name_of_header + " ";
            //}

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //moving the text of the object to the richtext editor ...
            
            string id = treeView1.SelectedNode.Name ;
            foreach (header a in guide)
            {
                if (a.id_of_header == id)
                {
                    object_edit = a;
                    break;
                }
               
            }
            richTextBox1.Text = object_edit.text_of_header;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (header a in guide)
            {
                test.Text += a.name_of_header + " ";
            }
        }

        private void transfer_text_Click(object sender, EventArgs e)
        {
            object_edit.text_of_header = richTextBox1.Text;
            MessageBox.Show(object_edit.text_of_header);

        }

        private void generate_JSON_Click(object sender, EventArgs e)
        {
            string json_object = new JavaScriptSerializer().Serialize(base_of_document);

            MessageBox.Show("JSON File is created");
            string name = base_of_document.name_of_header;

           
            string path = string.Format(@"C:\Users\Reza\Documents\{0}.txt", name) ;
            File.Create(path).Close() ;
            File.WriteAllText(path, json_object);
            File.AppendAllText(@"C:\Users\Reza\Documents\all_documents.txt", name + Environment.NewLine);
            
            

        }
    }
}
