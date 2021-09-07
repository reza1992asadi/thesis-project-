namespace main_project
{
    partial class Form2
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
        private void InitializeComponent()
        {
            this.Add_Header = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Header
            // 
            this.Add_Header.Location = new System.Drawing.Point(66, 65);
            this.Add_Header.Name = "Add_Header";
            this.Add_Header.Size = new System.Drawing.Size(75, 23);
            this.Add_Header.TabIndex = 0;
            this.Add_Header.Text = "button1";
            this.Add_Header.UseVisualStyleBackColor = true;
            this.Add_Header.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 480);
            this.Controls.Add(this.Add_Header);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Header;
    }
}