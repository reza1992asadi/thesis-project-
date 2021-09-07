namespace main_project
{
    partial class header_name_req
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
            this.label1 = new System.Windows.Forms.Label();
            this.header_textbox = new System.Windows.Forms.TextBox();
            this.confirm_header = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter The Header\'s Name :\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // header_textbox
            // 
            this.header_textbox.Location = new System.Drawing.Point(68, 53);
            this.header_textbox.Name = "header_textbox";
            this.header_textbox.Size = new System.Drawing.Size(151, 20);
            this.header_textbox.TabIndex = 2;
            this.header_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_textbox.TextChanged += new System.EventHandler(this.header_textbox_TextChanged);
            // 
            // confirm_header
            // 
            this.confirm_header.Location = new System.Drawing.Point(107, 93);
            this.confirm_header.Name = "confirm_header";
            this.confirm_header.Size = new System.Drawing.Size(75, 23);
            this.confirm_header.TabIndex = 3;
            this.confirm_header.Text = "OK";
            this.confirm_header.UseVisualStyleBackColor = true;
            this.confirm_header.Click += new System.EventHandler(this.confirm_header_Click);
            // 
            // header_name_req
            // 
            this.AcceptButton = this.confirm_header;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 128);
            this.Controls.Add(this.confirm_header);
            this.Controls.Add(this.header_textbox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "header_name_req";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.header_name_req_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox header_textbox;
        private System.Windows.Forms.Button confirm_header;
    }
}