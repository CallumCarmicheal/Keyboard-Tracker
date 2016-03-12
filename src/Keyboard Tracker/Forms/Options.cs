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
    public partial class Options : Form {
        public bool IsShown = false;

        public Options() {
            InitializeComponent();

            CBAllowKeyHolding.Checked = Engine.KeyTracker.AllowSpamming;
        }

        AddNewSession ans;
        private void CreateNewSession(object sender, EventArgs e) {
            // Dont know if i should pause counter while doing this
            // But ill do it this time, disable later if its "Unethical?"
            Engine.KeyTracker.ListenForKeys = false;


            // Show our new session wizard
            ans = new AddNewSession();
            ans.ShowDialog();

            // Resume Key Listening (May end up in new Session if created)
            Engine.KeyTracker.ListenForKeys = true;
        }

        private void SaveAllSessions(object sender, EventArgs e) {
            // TODO: Loop through the sessions and save the file
            // Most likely into JSON so we can read all the stuff later, WAIT URIKA THATS IT
            // Just read the class into a JSON file
            // OKAY MY MINIONS GET WORKING ONTO IT!
            // *Sorry i mean github collaborators

        }

        private void SaveCurrentSession(object sender, EventArgs e) {

        }

        private void ClearAllSessions(object sender, EventArgs e) {
            // Are you sure?
            if (!AreYouSure("Are you sure you want to clear the button presses?"))
                return;

            // Backup what status the logging was on and then Set it to false
            var LoggingStatus = Engine.KeyTracker.ListenForKeys;
            Engine.KeyTracker.ListenForKeys = false;

            // Check if the total presses want to be cleared
            if (AreYouSure("Do you want to clear the GLOBAL total presses while your at it Sir?")) {
                Engine.KeyTracker.TotalKeysPressed = 0;
            }

            // Lock session because the listener uses this first
            lock ((object)Engine.KeyTracker.SessionID) {
                Engine.KeyTracker.TotalSessions = -1;
                Engine.KeyTracker.SessionID = 0;
                Engine.KeyTracker.KeySessions = new Dictionary<int, Engine.KeySession>();
            } // Unlock the sessions, and everything is reset besides the total presses

            // Restore the user preference for logging b4 clearing.
            Engine.KeyTracker.ListenForKeys = LoggingStatus;
        }

        SessionManager swapSessions;
        private void SwapToAnotherSession(object sender, EventArgs e) {
            swapSessions = new SessionManager();
            swapSessions.Show();
        }

        // Markiplier reference (Bah gawd man)
        public bool AreYouSure(string Question, string Title = "BAH GAWD MAN, ARE YOU SURE YOU WANT TO DO THIS?") {
            DialogResult dr = MessageBox.Show(Question, Title, MessageBoxButtons.YesNo);
            return (dr == DialogResult.Yes);
        }

        private void ClearTotalKeysPressed(object sender, LinkLabelLinkClickedEventArgs e) {
            if(AreYouSure("Do you want to clear the GLOBAL total presses while your at it Sir?")) {
                Engine.KeyTracker.TotalKeysPressed = 0;
            }
        }

        View view;
        private void ShowKeysView(object sender, LinkLabelLinkClickedEventArgs e) {
            view = new View();
            view.Show();
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            IsShown = false;
            this.Hide();
        }

        private void Options_Shown(object sender, EventArgs e) {
            IsShown = true;
        }

        private void CBAllowKeyHolding_CheckedChanged(object sender, EventArgs e) {
            Engine.KeyTracker.AllowSpamming = ((CheckBox)sender).Checked;
        }
    }
}
