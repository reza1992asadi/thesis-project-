namespace main_project
{
    partial class Main_window
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.create = new System.Windows.Forms.Button();
            this.name_of_book = new System.Windows.Forms.TextBox();
            this.Informer = new System.Windows.Forms.Label();
            this.Neww = new System.Windows.Forms.Button();
            this.book_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.test = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.transfer_text = new System.Windows.Forms.Button();
            this.generate_JSON = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(176, 125);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 0;
            this.create.Text = "Create ";
            this.create.UseVisualStyleBackColor = true;
            this.create.Visible = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // name_of_book
            // 
            this.name_of_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_book.Location = new System.Drawing.Point(24, 128);
            this.name_of_book.Name = "name_of_book";
            this.name_of_book.Size = new System.Drawing.Size(137, 20);
            this.name_of_book.TabIndex = 2;
            this.name_of_book.Visible = false;
            this.name_of_book.TextChanged += new System.EventHandler(this.name_of_book_TextChanged);
            // 
            // Informer
            // 
            this.Informer.AutoSize = true;
            this.Informer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informer.Location = new System.Drawing.Point(21, 88);
            this.Informer.Name = "Informer";
            this.Informer.Size = new System.Drawing.Size(215, 13);
            this.Informer.TabIndex = 3;
            this.Informer.Text = "Enter The Name Of Your Document :\r\n";
            this.Informer.Visible = false;
            this.Informer.Click += new System.EventHandler(this.Informer_Click);
            // 
            // Neww
            // 
            this.Neww.Location = new System.Drawing.Point(61, 36);
            this.Neww.Name = "Neww";
            this.Neww.Size = new System.Drawing.Size(137, 35);
            this.Neww.TabIndex = 4;
            this.Neww.Text = "New Document";
            this.Neww.UseVisualStyleBackColor = true;
            this.Neww.Click += new System.EventHandler(this.Neww_Click);
            // 
            // book_title
            // 
            this.book_title.AutoSize = true;
            this.book_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_title.Location = new System.Drawing.Point(3, 9);
            this.book_title.Name = "book_title";
            this.book_title.Size = new System.Drawing.Size(0, 20);
            this.book_title.TabIndex = 0;
            this.book_title.Click += new System.EventHandler(this.book_title_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.book_title);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(268, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 615);
            this.panel1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-2, -2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(419, 615);
            this.treeView1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newHeaderToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 70);
            // 
            // newHeaderToolStripMenuItem
            // 
            this.newHeaderToolStripMenuItem.Name = "newHeaderToolStripMenuItem";
            this.newHeaderToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newHeaderToolStripMenuItem.Text = "New Header";
            this.newHeaderToolStripMenuItem.Click += new System.EventHandler(this.newHeaderToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteToolStripMenuItem.Text = "Delete ";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(839, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(464, 615);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(268, 661);
            this.test.Multiline = true;
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(1037, 68);
            this.test.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transfer_text
            // 
            this.transfer_text.Location = new System.Drawing.Point(735, 77);
            this.transfer_text.Name = "transfer_text";
            this.transfer_text.Size = new System.Drawing.Size(98, 34);
            this.transfer_text.TabIndex = 8;
            this.transfer_text.Text = "confirm";
            this.transfer_text.UseVisualStyleBackColor = true;
            this.transfer_text.Click += new System.EventHandler(this.transfer_text_Click);
            // 
            // generate_JSON
            // 
            this.generate_JSON.Location = new System.Drawing.Point(735, 128);
            this.generate_JSON.Name = "generate_JSON";
            this.generate_JSON.Size = new System.Drawing.Size(98, 34);
            this.generate_JSON.TabIndex = 9;
            this.generate_JSON.Text = "Generate JSON & Save";
            this.generate_JSON.UseVisualStyleBackColor = true;
            this.generate_JSON.Click += new System.EventHandler(this.generate_JSON_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 741);
            this.Controls.Add(this.generate_JSON);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.transfer_text);
            this.Controls.Add(this.Neww);
            this.Controls.Add(this.Informer);
            this.Controls.Add(this.name_of_book);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox name_of_book;
        private System.Windows.Forms.Label Informer;
        private System.Windows.Forms.Button Neww;
        private System.Windows.Forms.Label book_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button transfer_text;
        private System.Windows.Forms.Button generate_JSON;
    }
}