 /*
    Win10ThemeSelect - Changes the default Windows 10 style.
    Copyright(C) 2015  George T. Gougoudis<george_gougoudis@hotmail.com>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.If not, see<http://www.gnu.org/licenses/>.
*/


using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Microsoft.Win32;

namespace Win10ThemeSelect {
    public partial class MainForm :Form {
        [DllImport("user32.dll")]
        private static extern UInt32 ExitWindowsEx(UInt32 operationFlag, UInt32 operationReason);
        #region Win32
        /// <summary>
        /// Find the currently used setting.
        /// </summary>
        /// <returns>1 if light theme used, 0 if Dark theme is used.</returns>
        private int FindCurrent() {
            using(RegistryKey machineKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes", true)) {
                using(RegistryKey personalizeKey = machineKey.CreateSubKey("Personalize")) {
                    if(personalizeKey == null) {
                        return 1;
                    }
                    return (int)personalizeKey.GetValue("AppsUseLightTheme", RegistryValueKind.DWord);
                }
            }
        }

        /// <summary>
        /// Writes registry keys.
        /// </summary>
        /// <param name="Value"></param>
        /// <returns>whether the operation was successful or not.</returns>
        private bool ApplySetting(int Value) {
            bool retValue = true;
            using (RegistryKey machineKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes", true)) {
                using (RegistryKey personalizeKey = machineKey.CreateSubKey("Personalize")) {
                    if (personalizeKey == null) {
                        retValue = false;
                    }
                    personalizeKey.SetValue("AppsUseLightTheme", Value, RegistryValueKind.DWord);
                }
            }

            using (RegistryKey machineKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes", true)) {
                using (RegistryKey personalizeKey = machineKey.CreateSubKey("Personalize")) {
                    if (personalizeKey == null) {
                        retValue = false;
                    }
                    personalizeKey.SetValue("AppsUseLightTheme", Value, RegistryValueKind.DWord);
                }
            }
            return retValue;
        }
        #endregion

        /// <summary>
        /// Prompts the user for a log off.
        /// </summary>
        private void AskForLogOff() {
            DialogResult result =
                MessageBox.Show(this, 
                "Please save your work on other programs." + Environment.NewLine +
                "Log off now?",
                "Log off?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                ExitWindowsEx(0, 0);
            }
        }
        
        /// <summary>
        /// Set the status text.
        /// </summary>
        /// <param name="text"></param>
        private void SetStatus(string text) {
            statusLabel.Text = text;
        }

        public MainForm() {
            InitializeComponent();
            
            //Indexes can be used directly as the key value.
            selectBox.Items.Add("Dark");
            selectBox.Items.Add("Light");
            selectBox.SelectedIndex = FindCurrent();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            if (selectBox.SelectedIndex >= 0) {
               if( ApplySetting(selectBox.SelectedIndex) ) {
                    SetStatus("Changes should be visible now. If not please relog.");
                } else {
                    SetStatus("Operation failed.");
                    MessageBox.Show(this, "Operation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            //Ensure this is windows 10.
            //Manifest needs to provide compatibility, or this code WILL fail.
            OperatingSystem osInfo = Environment.OSVersion;
            if (osInfo.Version.Major != 10) {
                MessageBox.Show(this, "This application only works with Windows10!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            SetStatus("Welcome. Select an option and press apply.");
        }

        private void logoff_button_Click(object sender, EventArgs e) {
            AskForLogOff();
        }

        private void about_button_Click(object sender, EventArgs e) {
            var about = new AboutForm();
            about.Show(this);
        }
    }
}
