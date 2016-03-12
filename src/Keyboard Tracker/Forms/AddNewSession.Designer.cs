namespace Keyboard_Tracker.Forms {
    partial class AddNewSession {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewSessionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewSessionScope = new System.Windows.Forms.ComboBox();
            this.MainHelpPopup = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The word on the street is that you want to create a new session, Right?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Well my friend, you have come to the right place...    Ill help you out with that" +
    ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "All you have to do is fill in the information below.";
            // 
            // NewSessionName
            // 
            this.NewSessionName.Location = new System.Drawing.Point(108, 61);
            this.NewSessionName.Name = "NewSessionName";
            this.NewSessionName.Size = new System.Drawing.Size(250, 20);
            this.NewSessionName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 64);
            this.label4.Name = "label4";
            this.MainHelpPopup.SetShowHelp(this.label4, true);
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Session Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.MainHelpPopup.SetHelpString(this.label5, "States if the keys will be read globally or just from a single program");
            this.label5.Location = new System.Drawing.Point(21, 90);
            this.label5.Name = "label5";
            this.MainHelpPopup.SetShowHelp(this.label5, true);
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Session Scope: ";
            this.label5.Visible = false;
            // 
            // NewSessionScope
            // 
            this.NewSessionScope.FormattingEnabled = true;
            this.MainHelpPopup.SetHelpString(this.NewSessionScope, "States if the keys will be read globally or just from a single program");
            this.NewSessionScope.Items.AddRange(new object[] {
            "Read keys from Every Application",
            "-----------------------------------"});
            this.NewSessionScope.Location = new System.Drawing.Point(108, 87);
            this.NewSessionScope.Name = "NewSessionScope";
            this.MainHelpPopup.SetShowHelp(this.NewSessionScope, true);
            this.NewSessionScope.Size = new System.Drawing.Size(250, 21);
            this.NewSessionScope.TabIndex = 1;
            this.NewSessionScope.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create the session, My fine Sir!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateSession);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sir, i changed my mind.";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddNewSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewSessionScope);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewSessionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewSession";
            this.Text = "So...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewSessionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HelpProvider MainHelpPopup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NewSessionScope;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}