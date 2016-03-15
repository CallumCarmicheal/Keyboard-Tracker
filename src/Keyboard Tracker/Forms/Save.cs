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
    public partial class Save : Form {
        public Save() {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e) {
            Engine.Saving.Everything(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e) {
            saveFileDialog1.DefaultExt = ".ktBinary";
            DialogResult dr = saveFileDialog1.ShowDialog();
            
            if(dr == DialogResult.OK) {
                // Set file path
                textBox1.Text = saveFileDialog1.FileName;
            }
        }
    }
}
