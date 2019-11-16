namespace WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainFormMenu = new System.Windows.Forms.MenuStrip();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowStatus = new System.Windows.Forms.StatusStrip();
            this.MainFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenu
            // 
            this.MainFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMenuItem});
            this.MainFormMenu.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenu.Name = "MainFormMenu";
            this.MainFormMenu.Size = new System.Drawing.Size(1065, 24);
            this.MainFormMenu.TabIndex = 0;
            this.MainFormMenu.Text = "Pasek menu";
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewViewMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ViewMenuItem.Text = "Widok";
            // 
            // NewViewMenuItem
            // 
            this.NewViewMenuItem.Name = "NewViewMenuItem";
            this.NewViewMenuItem.Size = new System.Drawing.Size(137, 22);
            this.NewViewMenuItem.Text = "Dodaj nowy";
            this.NewViewMenuItem.Click += new System.EventHandler(this.NewViewMenuItem_Click);
            // 
            // MainWindowStatus
            // 
            this.MainWindowStatus.Location = new System.Drawing.Point(0, 593);
            this.MainWindowStatus.Name = "MainWindowStatus";
            this.MainWindowStatus.Size = new System.Drawing.Size(1065, 22);
            this.MainWindowStatus.TabIndex = 2;
            this.MainWindowStatus.Text = "MainWindowStatus";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 615);
            this.Controls.Add(this.MainWindowStatus);
            this.Controls.Add(this.MainFormMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainFormMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormMenu.ResumeLayout(false);
            this.MainFormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewViewMenuItem;
        public System.Windows.Forms.StatusStrip MainWindowStatus;
    }
}