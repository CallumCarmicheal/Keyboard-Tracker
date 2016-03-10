namespace Keyboard_Tracker {
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyUpdater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // KeysList
            // 
            this.KeysList.BackColor = System.Drawing.SystemColors.Control;
            this.KeysList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.KeysList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeysList.Location = new System.Drawing.Point(0, 0);
            this.KeysList.Name = "KeysList";
            this.KeysList.Size = new System.Drawing.Size(624, 364);
            this.KeysList.TabIndex = 2;
            this.KeysList.UseCompatibleStateImageBehavior = false;
            this.KeysList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pressed Amount";
            this.columnHeader2.Width = 200;
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer KeyUpdater;
    }
}