namespace Keyboard_Tracker.Forms {
    partial class Options {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SaveCurrentSessionsBTN = new System.Windows.Forms.Button();
            this.CBAllowKeyHolding = new System.Windows.Forms.CheckBox();
            this.CreateNewSessionBTN = new System.Windows.Forms.Button();
            this.SaveAllSessionsBTN = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(8, 119);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(125, 13);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Clear Total Pressed Keys";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearTotalKeysPressed);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(146, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Session Manager";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SwapToAnotherSession);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(11, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Clear all sessions";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ClearAllSessions);
            // 
            // SaveCurrentSessionsBTN
            // 
            this.SaveCurrentSessionsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCurrentSessionsBTN.Location = new System.Drawing.Point(146, 41);
            this.SaveCurrentSessionsBTN.Name = "SaveCurrentSessionsBTN";
            this.SaveCurrentSessionsBTN.Size = new System.Drawing.Size(133, 23);
            this.SaveCurrentSessionsBTN.TabIndex = 29;
            this.SaveCurrentSessionsBTN.Text = "Save current Session";
            this.SaveCurrentSessionsBTN.UseVisualStyleBackColor = true;
            this.SaveCurrentSessionsBTN.Click += new System.EventHandler(this.SaveCurrentSession);
            // 
            // CBAllowKeyHolding
            // 
            this.CBAllowKeyHolding.AutoSize = true;
            this.CBAllowKeyHolding.Location = new System.Drawing.Point(53, 99);
            this.CBAllowKeyHolding.Name = "CBAllowKeyHolding";
            this.CBAllowKeyHolding.Size = new System.Drawing.Size(186, 17);
            this.CBAllowKeyHolding.TabIndex = 28;
            this.CBAllowKeyHolding.Text = "Allow Key Holding (On Key Down)";
            this.CBAllowKeyHolding.UseVisualStyleBackColor = true;
            this.CBAllowKeyHolding.CheckedChanged += new System.EventHandler(this.CBAllowKeyHolding_CheckedChanged);
            // 
            // CreateNewSessionBTN
            // 
            this.CreateNewSessionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewSessionBTN.Location = new System.Drawing.Point(12, 12);
            this.CreateNewSessionBTN.Name = "CreateNewSessionBTN";
            this.CreateNewSessionBTN.Size = new System.Drawing.Size(267, 23);
            this.CreateNewSessionBTN.TabIndex = 27;
            this.CreateNewSessionBTN.Text = "Create new Session";
            this.CreateNewSessionBTN.UseVisualStyleBackColor = true;
            this.CreateNewSessionBTN.Click += new System.EventHandler(this.CreateNewSession);
            // 
            // SaveAllSessionsBTN
            // 
            this.SaveAllSessionsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAllSessionsBTN.Location = new System.Drawing.Point(11, 41);
            this.SaveAllSessionsBTN.Name = "SaveAllSessionsBTN";
            this.SaveAllSessionsBTN.Size = new System.Drawing.Size(129, 23);
            this.SaveAllSessionsBTN.TabIndex = 25;
            this.SaveAllSessionsBTN.Text = "Save all Sessions";
            this.SaveAllSessionsBTN.UseVisualStyleBackColor = true;
            this.SaveAllSessionsBTN.Click += new System.EventHandler(this.SaveAllSessions);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(148, 119);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Realtime keystroke viewer";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowKeysView);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 140);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SaveCurrentSessionsBTN);
            this.Controls.Add(this.CBAllowKeyHolding);
            this.Controls.Add(this.CreateNewSessionBTN);
            this.Controls.Add(this.SaveAllSessionsBTN);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.Text = "Keyboard Tracker - Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Shown += new System.EventHandler(this.Options_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button SaveCurrentSessionsBTN;
        private System.Windows.Forms.CheckBox CBAllowKeyHolding;
        private System.Windows.Forms.Button CreateNewSessionBTN;
        private System.Windows.Forms.Button SaveAllSessionsBTN;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}