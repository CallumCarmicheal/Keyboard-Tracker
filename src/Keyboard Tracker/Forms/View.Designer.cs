﻿namespace Keyboard_Tracker.Forms {
    partial class View {
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
            this.KeysList = new System.Windows.Forms.ListView();
            this.header_Session = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header_Keys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header_SID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyUpdater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // KeysList
            // 
            this.KeysList.BackColor = System.Drawing.SystemColors.Control;
            this.KeysList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header_Session,
            this.header_Keys,
            this.header_Amount,
            this.header_SID});
            this.KeysList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeysList.Location = new System.Drawing.Point(0, 0);
            this.KeysList.Name = "KeysList";
            this.KeysList.Size = new System.Drawing.Size(624, 364);
            this.KeysList.TabIndex = 2;
            this.KeysList.UseCompatibleStateImageBehavior = false;
            this.KeysList.View = System.Windows.Forms.View.Details;
            // 
            // header_Session
            // 
            this.header_Session.DisplayIndex = 1;
            this.header_Session.Text = "Session ID";
            this.header_Session.Width = 73;
            // 
            // header_Keys
            // 
            this.header_Keys.DisplayIndex = 2;
            this.header_Keys.Text = "Key";
            this.header_Keys.Width = 144;
            // 
            // header_Amount
            // 
            this.header_Amount.DisplayIndex = 3;
            this.header_Amount.Text = "Pressed Amount";
            this.header_Amount.Width = 278;
            // 
            // header_SID
            // 
            this.header_SID.DisplayIndex = 0;
            this.header_SID.Text = "Name";
            this.header_SID.Width = 125;
            // 
            // KeyUpdater
            // 
            this.KeyUpdater.Tick += new System.EventHandler(this.KeyUpdater_Tick);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 364);
            this.Controls.Add(this.KeysList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "View";
            this.Text = "View keystrokes";
            this.Shown += new System.EventHandler(this.View_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView KeysList;
        private System.Windows.Forms.ColumnHeader header_Keys;
        private System.Windows.Forms.ColumnHeader header_Amount;
        private System.Windows.Forms.Timer KeyUpdater;
        private System.Windows.Forms.ColumnHeader header_Session;
        private System.Windows.Forms.ColumnHeader header_SID;
    }
}