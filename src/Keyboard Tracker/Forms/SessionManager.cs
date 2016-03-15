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
    public partial class SessionManager : Form {
        public SessionManager() {
		    InitializeComponent();
        }

        public void LoadAllSessions() {
            SessionList.Nodes.Clear();
            foreach(var seshObj in Engine.KeyTracker.KeySessions) {
                var session = seshObj.Value;
                TreeNode sessionNode = new TreeNode(session.ID + " : " + session.Name);
                sessionNode.Tag = session.ID;

                foreach(var key in session.Keys) {
                    TreeNode KeyNode = new TreeNode(((Keys)key.Key).ToString() + " - " + key.Value.Amount);
                    sessionNode.Nodes.Add(KeyNode);
                }

                SessionList.Nodes.Add(sessionNode);
            }
        }

        bool getSelectedSession(ref Engine.KeySession sesh) {
            if (SessionList.Nodes.Count != 0) {
                if (SessionList.SelectedNode != null) {
                    TreeNode tn;
                    if (SessionList.SelectedNode.Parent != null) tn = SessionList.SelectedNode.Parent;
                    else tn = SessionList.SelectedNode;
                    int sessionID = (int)tn.Tag;

                    if (Engine.KeyTracker.KeySessions.Keys.Contains(sessionID)) {
                        sesh = Engine.KeyTracker.KeySessions[sessionID];
                        return true; 
                    }
                }
            } return false;
        }

        private void SwapSessions_Load(object sender, EventArgs e) {
		    LoadAllSessions();
        }

        private void RefreshSessions(object sender, EventArgs e) {
            LoadAllSessions();
        }

        private void ChangeSession(object sender, EventArgs e) {
            Engine.KeySession Session = default(Engine.KeySession);
            if(getSelectedSession(ref Session)) 
                Engine.KeyTracker.SessionID = Session.ID;
        }

        private void onListSelect(object sender, TreeViewEventArgs e) {
            /* Change the session information (ON LEFT) */ {
                Engine.KeySession sesh = default(Engine.KeySession);
                if(getSelectedSession(ref sesh)) {
                    selectedID.Text = "" + sesh.ID;
                    selectedName.Text = "" + sesh.Name;
                } else {
                    selectedID.Text     = "";
                    selectedName.Text   = "";
                }
            }
        }

        private void SaveSessionEdits(object sender, EventArgs e) {
            /* Check if session still exists */ {
                Engine.KeySession sesh = default(Engine.KeySession);
                if (getSelectedSession(ref sesh)) {
                    sesh.Name = textBox1.Text;
                    Engine.KeyTracker.setKeySessionByID(sesh, sesh.ID);
                } else { 
                    MessageBox.Show("Session no longer exists");
                }
                RefreshSessions(null, null);
            }
        }


        private void button5_Click(object sender, EventArgs e) {
            MessageBox.Show("Open?");
            openFileDialog1.DefaultExt = ".ktBinary";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK) {
                // Set file path
                string filePath = openFileDialog1.FileName;


                Engine.Loading.LoadSessions(filePath);
            }
        }

        Save sv;
        private void button6_Click(object sender, EventArgs e) {
            sv = new Save();
            sv.Show();
        }
    }
}
