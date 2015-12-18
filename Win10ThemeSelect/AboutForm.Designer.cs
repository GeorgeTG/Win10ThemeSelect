namespace Win10ThemeSelect {
    partial class AboutForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.github_link = new System.Windows.Forms.LinkLabel();
            this.gnu_link = new System.Windows.Forms.LinkLabel();
            this.close_button = new System.Windows.Forms.Button();
            this.gnu_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gnu_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(391, 217);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // github_link
            // 
            this.github_link.AutoSize = true;
            this.github_link.Location = new System.Drawing.Point(12, 232);
            this.github_link.Name = "github_link";
            this.github_link.Size = new System.Drawing.Size(94, 13);
            this.github_link.TabIndex = 1;
            this.github_link.TabStop = true;
            this.github_link.Text = "Visit me on GitHub";
            this.github_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // gnu_link
            // 
            this.gnu_link.AutoSize = true;
            this.gnu_link.Location = new System.Drawing.Point(245, 232);
            this.gnu_link.Name = "gnu_link";
            this.gnu_link.Size = new System.Drawing.Size(158, 13);
            this.gnu_link.TabIndex = 2;
            this.gnu_link.TabStop = true;
            this.gnu_link.Text = "GNU General Public License v3\r\n";
            this.gnu_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(154, 272);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // gnu_logo
            // 
            this.gnu_logo.Image = ((System.Drawing.Image)(resources.GetObject("gnu_logo.Image")));
            this.gnu_logo.Location = new System.Drawing.Point(304, 248);
            this.gnu_logo.Name = "gnu_logo";
            this.gnu_logo.Size = new System.Drawing.Size(95, 47);
            this.gnu_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gnu_logo.TabIndex = 4;
            this.gnu_logo.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 304);
            this.Controls.Add(this.gnu_logo);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.gnu_link);
            this.Controls.Add(this.github_link);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gnu_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel github_link;
        private System.Windows.Forms.LinkLabel gnu_link;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox gnu_logo;
    }
}