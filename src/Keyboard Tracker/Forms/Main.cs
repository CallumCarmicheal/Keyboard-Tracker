using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Tracker.Forms {
    public partial class Main : Form {
        Options frmOptions;

        public Main() {
            frmOptions = new Options();

            DoubleBuffered = true;
            InitializeComponent();
            KeysUpdate.Start();
        }

        private void ToggleListener(object sender, EventArgs e) {
            Engine.KeyTracker.ListenForKeys = !Engine.KeyTracker.ListenForKeys;
        }

        private void KeysUpdate_Tick(object sender, EventArgs e) {
            ToggleTrackingBTN.Text = (Engine.KeyTracker.ListenForKeys ? "Stop tracking keyboard." : "Start tracking keyboard.");
            ToggleOptionsForm.Text = (frmOptions.IsShown ? "Hide options" : "Show Options");
            ToggleOptionsForm.Enabled = !frmOptions.IsShown;


            int totalPressed = Engine.KeyTracker.TotalKeysPressed;
            TotalPresses.Text = string.Format("{0:n0}", totalPressed);

            if(Engine.KeyTracker.KeySessions.Keys.Contains(Engine.KeyTracker.SessionID)) {
                totalPressed = Engine.KeyTracker.KeySessions[Engine.KeyTracker.SessionID].TotalPressed;
                TBCSessionName.Text = Engine.KeyTracker.KeySessions[Engine.KeyTracker.SessionID].Name;
            } else {
                totalPressed = 0;
                TBCSessionName.Text = "NO SESSIONS CREATED YET";
            }

            TBCSessionPresses.Text = string.Format("{0:n0}", totalPressed);
        }

        private void Main_Load(object sender, EventArgs e) {
            // Look pretty
        }

        private void ToggleKeyboardTracking(object sender, EventArgs e) {
            Engine.KeyTracker.ListenForKeys = !Engine.KeyTracker.ListenForKeys;

            ((Button)sender).Text 
                = (Engine.KeyTracker.ListenForKeys ? "Stop tracking keyboard." : "Start tracking keyboard.");
        }

        private void button2_Click(object sender, EventArgs e) {
            /*if (frmOptions.IsShown)
                frmOptions.Show();
            else
                frmOptions.Hide();*/

            if (frmOptions.IsShown)
                return;

            frmOptions = new Options();
            frmOptions.Show();
        }

        private void OpenToGithub(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/CallumCarmicheal/Keyboard-Tracker");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://callumcarmicheal.com");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            Engine.KeyTracker.ListenForKeys = false;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e) {
            Environment.Exit(0);
        }
    }
}
