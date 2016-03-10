using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Tracker.Forms {
    public partial class View : Form {
        public View() {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void View_Shown(object sender, EventArgs e) {
            KeyUpdater.Start();
            this.DoubleBuffered = true;
            KeysList.Sorting = SortOrder.Ascending;
        }

        private void UpdateListbox() {
            KeysList.BeginUpdate(); { 
                KeysList.Items.Clear();

                foreach(var seshObj in Engine.KeyTracker.KeySessions) {
                    var session = seshObj.Value;
                    foreach (var key in session.Keys) {
                        string PressedKey = ((Keys)key.Key).ToString();

                        ListViewItem item = new ListViewItem(session.Name);
                        item.SubItems.Add(session.ID + ""); 
                        item.SubItems.Add(PressedKey + "");
                        item.SubItems.Add(string.Format("{0:n0}", key.Value.Amount));

                        KeysList.Items.Add(item);
                    }
                }

                KeysList.Sort();
            } KeysList.EndUpdate();
        }

        private void KeyUpdater_Tick(object sender, EventArgs e) {
            UpdateListbox();
        }

        
    }

    static class Fixes {
        public static void DoubleBuffering(this Control control, bool enable) {
            var method = typeof(Control).GetMethod("SetStyle", BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            method.Invoke(control, new object[] { ControlStyles.OptimizedDoubleBuffer, enable });
        }
    }
}
