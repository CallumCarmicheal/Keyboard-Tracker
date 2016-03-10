using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Tracker {
    public partial class GUI : Form {
        public GUI() {
            DoubleBuffered = true;
            InitializeComponent();
            KeysUpdate.Start();
        }

        private void ToggleListener(object sender, EventArgs e) {
            Program.ListenForKeys = !Program.ListenForKeys;
            StartListeningBTN.Text = (Program.ListenForKeys ? "Stop" : "Start");
            
        }

        private void KeysUpdate_Tick(object sender, EventArgs e) {
            StartListeningBTN.Text = (Program.ListenForKeys ? "Stop" : "Start");
            TotalPresses.Text = string.Format("{0:n0}", Program.TotalKeysPressed);
        }

        

        private void Reset(object sender, EventArgs e) {
            Program.TotalKeysPressed = 0;
            Program.PressedKeys = new Dictionary<int, int>();
        }

        View view;
        private void ShowKeysView(object sender, LinkLabelLinkClickedEventArgs e) {
            view = new View();
            view.Show();
        }

        private void ToggleAllowSpam(object sender, EventArgs e) {
            Program.AllowSpamming = CBAllowKeyHolding.Checked;
        }
    }
}
