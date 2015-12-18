using System;
using System.Windows.Forms;

namespace Win10ThemeSelect {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void AboutForm_Load(object sender, EventArgs e) {
            github_link.Links.Add(0, github_link.Text.Length, "https://github.com/GeorgeTG");
            gnu_link.Links.Add(0, gnu_link.Text.Length, "http://www.gnu.org/licenses/gpl-3.0.en.html");
            close_button.Focus();
        }

        private void close_button_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
