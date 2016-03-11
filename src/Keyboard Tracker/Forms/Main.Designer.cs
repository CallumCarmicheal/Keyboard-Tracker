namespace Keyboard_Tracker.Forms {
    partial class Main {
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
            this.saveKeysDialog = new System.Windows.Forms.SaveFileDialog();
            this.TBCSessionPresses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBCSessionName = new System.Windows.Forms.MaskedTextBox();
            this.ToggleTrackingBTN = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ToggleOptionsForm = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have pressed your Keyboard...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "times in total";
            // 
            // TotalPresses
            // 
            this.TotalPresses.BackColor = System.Drawing.SystemColors.Control;
            this.TotalPresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPresses.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPresses.Location = new System.Drawing.Point(13, 30);
            this.TotalPresses.Name = "TotalPresses";
            this.TotalPresses.ReadOnly = true;
            this.TotalPresses.Size = new System.Drawing.Size(267, 46);
            this.TotalPresses.TabIndex = 2;
            this.TotalPresses.Text = "0";
            this.TotalPresses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeysUpdate
            // 
            this.KeysUpdate.Interval = 1;
            this.KeysUpdate.Tick += new System.EventHandler(this.KeysUpdate_Tick);
            // 
            // TBCSessionPresses
            // 
            this.TBCSessionPresses.BackColor = System.Drawing.SystemColors.Control;
            this.TBCSessionPresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCSessionPresses.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCSessionPresses.Location = new System.Drawing.Point(286, 30);
            this.TBCSessionPresses.Name = "TBCSessionPresses";
            this.TBCSessionPresses.ReadOnly = true;
            this.TBCSessionPresses.Size = new System.Drawing.Size(267, 46);
            this.TBCSessionPresses.TabIndex = 18;
            this.TBCSessionPresses.Text = "0";
            this.TBCSessionPresses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "times in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "You have pressed your Keyboard...";
            // 
            // TBCSessionName
            // 
            this.TBCSessionName.BackColor = System.Drawing.SystemColors.Control;
            this.TBCSessionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCSessionName.Location = new System.Drawing.Point(285, 91);
            this.TBCSessionName.Name = "TBCSessionName";
            this.TBCSessionName.Size = new System.Drawing.Size(268, 13);
            this.TBCSessionName.TabIndex = 19;
            this.TBCSessionName.Text = "Current Session";
            this.TBCSessionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToggleTrackingBTN
            // 
            this.ToggleTrackingBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleTrackingBTN.Location = new System.Drawing.Point(28, 91);
            this.ToggleTrackingBTN.Name = "ToggleTrackingBTN";
            this.ToggleTrackingBTN.Size = new System.Drawing.Size(129, 23);
            this.ToggleTrackingBTN.TabIndex = 34;
            this.ToggleTrackingBTN.Text = "Start tracking Keyboard";
            this.ToggleTrackingBTN.UseVisualStyleBackColor = true;
            this.ToggleTrackingBTN.Click += new System.EventHandler(this.ToggleKeyboardTracking);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(335, 125);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(198, 13);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Im open-source, Click me to goto GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenToGithub);
            // 
            // ToggleOptionsForm
            // 
            this.ToggleOptionsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleOptionsForm.Location = new System.Drawing.Point(163, 91);
            this.ToggleOptionsForm.Name = "ToggleOptionsForm";
            this.ToggleOptionsForm.Size = new System.Drawing.Size(100, 23);
            this.ToggleOptionsForm.TabIndex = 37;
            this.ToggleOptionsForm.Text = "Show options";
            this.ToggleOptionsForm.UseVisualStyleBackColor = true;
            this.ToggleOptionsForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(25, 125);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(190, 13);
            this.linkLabel2.TabIndex = 38;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Created by CallumC (On LiveCoding.tv)";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 147);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.ToggleOptionsForm);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ToggleTrackingBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBCSessionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBCSessionPresses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalPresses);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Keyboard Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalPresses;
        private System.Windows.Forms.Timer KeysUpdate;
        private System.Windows.Forms.SaveFileDialog saveKeysDialog;
        private System.Windows.Forms.TextBox TBCSessionPresses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TBCSessionName;
        private System.Windows.Forms.Button ToggleTrackingBTN;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button ToggleOptionsForm;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

