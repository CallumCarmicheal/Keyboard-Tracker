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
    public partial class SwapSessions : Form {
        public SwapSessions() {
		    InitializeComponent();
        }

        public void LoadAllSessions() {
            treeView1.Nodes.Clear();
            foreach(var seshObj in Engine.KeyTracker.KeySessions) {
                var session = seshObj.Value;
                TreeNode sessionNode = new TreeNode(session.ID + " : " + session.Name);
                sessionNode.Tag = session.ID;

                foreach(var key in session.Keys) {
                    TreeNode KeyNode = new TreeNode(((Keys)key.Key).ToString() + " - " + key.Value.Amount);
                    sessionNode.Nodes.Add(KeyNode);
                }

                treeView1.Nodes.Add(sessionNode);
            }
        }

        private void SwapSessions_Load(object sender, EventArgs e) {
		    LoadAllSessions();
        }

        private void button1_Click(object sender, EventArgs e) {
            LoadAllSessions();
        }

        private void button2_Click(object sender, EventArgs e) {
            if(treeView1.Nodes.Count != 0) {
                if(treeView1.SelectedNode != null) {
                    TreeNode tn;

                    if (treeView1.SelectedNode.Parent != null)
                        tn = treeView1.SelectedNode.Parent;
                    else
                        tn = treeView1.SelectedNode;

                    int sessionID = (int)tn.Tag;
                    Engine.KeyTracker.SessionID = sessionID;
                }
            }
        }
    }
}
