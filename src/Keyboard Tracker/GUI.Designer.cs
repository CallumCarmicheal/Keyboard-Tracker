namespace Keyboard_Tracker {
    partial class GUI {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalPresses = new System.Windows.Forms.TextBox();
            this.KeysUpdate = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.StartListeningBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CBAllowKeyHolding = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have pressed your Keyboard...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "times";
            // 
            // TotalPresses
            // 
            this.TotalPresses.BackColor = System.Drawing.SystemColors.Control;
            this.TotalPresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPresses.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPresses.Location = new System.Drawing.Point(13, 30);
            this.TotalPresses.Name = "TotalPresses";
            this.TotalPresses.ReadOnly = true;
            this.TotalPresses.Size = new System.Drawing.Size(409, 46);
            this.TotalPresses.TabIndex = 2;
            this.TotalPresses.Text = "0";
            this.TotalPresses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeysUpdate
            // 
            this.KeysUpdate.Interval = 1;
            this.KeysUpdate.Tick += new System.EventHandler(this.KeysUpdate_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 113);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View keystrokes in Detail";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowKeysView);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(375, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StartListeningBTN
            // 
            this.StartListeningBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartListeningBTN.Location = new System.Drawing.Point(259, 103);
            this.StartListeningBTN.Name = "StartListeningBTN";
            this.StartListeningBTN.Size = new System.Drawing.Size(54, 23);
            this.StartListeningBTN.TabIndex = 5;
            this.StartListeningBTN.Text = "Start";
            this.StartListeningBTN.UseVisualStyleBackColor = true;
            this.StartListeningBTN.Click += new System.EventHandler(this.ToggleListener);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(319, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Reset);
            // 
            // CBAllowKeyHolding
            // 
            this.CBAllowKeyHolding.AutoSize = true;
            this.CBAllowKeyHolding.Location = new System.Drawing.Point(144, 107);
            this.CBAllowKeyHolding.Name = "CBAllowKeyHolding";
            this.CBAllowKeyHolding.Size = new System.Drawing.Size(111, 17);
            this.CBAllowKeyHolding.TabIndex = 15;
            this.CBAllowKeyHolding.Text = "Allow Key Holding";
            this.CBAllowKeyHolding.UseVisualStyleBackColor = true;
            this.CBAllowKeyHolding.CheckedChanged += new System.EventHandler(this.ToggleAllowSpam);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 137);
            this.Controls.Add(this.CBAllowKeyHolding);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StartListeningBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TotalPresses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUI";
            this.Text = "Dont even ask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalPresses;
        private System.Windows.Forms.Timer KeysUpdate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StartListeningBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CBAllowKeyHolding;
    }
}

