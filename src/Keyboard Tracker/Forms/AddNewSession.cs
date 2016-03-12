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
    public partial class AddNewSession : Form {
        public AddNewSession() {
            InitializeComponent();

            DialogResult = DialogResult.Cancel;
        }

        private bool SettingsAreValid() {
            if (string.IsNullOrWhiteSpace(NewSessionName.Text))
                return false;

            return true;
        }

        private void CreateSession(object sender, EventArgs e) {
            // Check if the user inputted data is valid
            if(!SettingsAreValid()) {
                MessageBox.Show("The data inputted is not valid, please look over the data or cancel the new session");
                return;
            }

            // Set our next session name
            Engine.KeyTracker.NextSessionName = NewSessionName.Text;

            // Ignore session scope for now, until added atleast

            // Set our session id to the Next available one
            Engine.KeyTracker.SessionID = Engine.KeyTracker.TotalSessions + 1;
            
            DialogResult = DialogResult.OK;
        }
    }
}
