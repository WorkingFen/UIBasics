namespace WindowsForms
{
    partial class MusicForm
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
            this.components = new System.ComponentModel.Container();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.NoItemLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SongsList = new System.Windows.Forms.ListView();
            this.TitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsContainer = new System.Windows.Forms.ToolStripContainer();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.AddStripButton = new System.Windows.Forms.ToolStripButton();
            this.ModifyStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.StripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Filtr = new System.Windows.Forms.ToolStripLabel();
            this.FiltrComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.StatusStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.ListContextMenu.SuspendLayout();
            this.ToolsContainer.ContentPanel.SuspendLayout();
            this.ToolsContainer.TopToolStripPanel.SuspendLayout();
            this.ToolsContainer.SuspendLayout();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NoItemLabel,
            this.NoLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 428);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "Pasek informacji";
            this.StatusStrip.Visible = false;
            // 
            // NoItemLabel
            // 
            this.NoItemLabel.Name = "NoItemLabel";
            this.NoItemLabel.Size = new System.Drawing.Size(189, 17);
            this.NoItemLabel.Text = "Liczba wyświetlonych elementów: ";
            // 
            // NoLabel
            // 
            this.NoLabel.Name = "NoLabel";
            this.NoLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Pasek menu";
            this.MainMenu.Visible = false;
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(53, 20);
            this.EditMenuItem.Text = "Edycja";
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(105, 22);
            this.AddMenuItem.Text = "Dodaj";
            this.AddMenuItem.Click += new System.EventHandler(this.AddMenuItem_Click);
            // 
            // SongsList
            // 
            this.SongsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleColumn,
            this.AuthorColumn,
            this.DateColumn,
            this.CategoryColumn});
            this.SongsList.ContextMenuStrip = this.ListContextMenu;
            this.SongsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongsList.FullRowSelect = true;
            this.SongsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SongsList.HideSelection = false;
            this.SongsList.Location = new System.Drawing.Point(0, 0);
            this.SongsList.MultiSelect = false;
            this.SongsList.Name = "SongsList";
            this.SongsList.Size = new System.Drawing.Size(800, 425);
            this.SongsList.TabIndex = 2;
            this.SongsList.UseCompatibleStateImageBehavior = false;
            this.SongsList.View = System.Windows.Forms.View.Details;
            // 
            // TitleColumn
            // 
            this.TitleColumn.Text = "Tytuł";
            this.TitleColumn.Width = 260;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.Text = "Autor";
            this.AuthorColumn.Width = 200;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Data nagrania";
            this.DateColumn.Width = 180;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.Text = "Kategoria";
            this.CategoryColumn.Width = 140;
            // 
            // ListContextMenu
            // 
            this.ListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddContextMenuItem,
            this.ModifyContextMenuItem,
            this.DeleteContextMenuItem});
            this.ListContextMenu.Name = "ContextMenu";
            this.ListContextMenu.Size = new System.Drawing.Size(129, 70);
            // 
            // AddContextMenuItem
            // 
            this.AddContextMenuItem.Name = "AddContextMenuItem";
            this.AddContextMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AddContextMenuItem.Text = "Dodaj";
            this.AddContextMenuItem.Click += new System.EventHandler(this.AddContextMenuItem_Click);
            // 
            // ModifyContextMenuItem
            // 
            this.ModifyContextMenuItem.Name = "ModifyContextMenuItem";
            this.ModifyContextMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ModifyContextMenuItem.Text = "Modyfikuj";
            this.ModifyContextMenuItem.Click += new System.EventHandler(this.ModifyContextMenuItem_Click);
            // 
            // DeleteContextMenuItem
            // 
            this.DeleteContextMenuItem.Name = "DeleteContextMenuItem";
            this.DeleteContextMenuItem.Size = new System.Drawing.Size(128, 22);
            this.DeleteContextMenuItem.Text = "Usuń";
            this.DeleteContextMenuItem.Click += new System.EventHandler(this.DeleteContextMenuItem_Click);
            // 
            // ToolsContainer
            // 
            // 
            // ToolsContainer.ContentPanel
            // 
            this.ToolsContainer.ContentPanel.Controls.Add(this.SongsList);
            this.ToolsContainer.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.ToolsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsContainer.Location = new System.Drawing.Point(0, 0);
            this.ToolsContainer.Name = "ToolsContainer";
            this.ToolsContainer.Size = new System.Drawing.Size(800, 450);
            this.ToolsContainer.TabIndex = 3;
            this.ToolsContainer.Text = "ToolsContainer";
            // 
            // ToolsContainer.TopToolStripPanel
            // 
            this.ToolsContainer.TopToolStripPanel.Controls.Add(this.Tools);
            // 
            // Tools
            // 
            this.Tools.Dock = System.Windows.Forms.DockStyle.None;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStripButton,
            this.ModifyStripButton,
            this.DeleteStripButton,
            this.StripSeparator,
            this.Filtr,
            this.FiltrComboBox});
            this.Tools.Location = new System.Drawing.Point(3, 0);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(404, 25);
            this.Tools.TabIndex = 0;
            // 
            // AddStripButton
            // 
            this.AddStripButton.Image = global::WindowsForms.Properties.Resources.Add;
            this.AddStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStripButton.Name = "AddStripButton";
            this.AddStripButton.Size = new System.Drawing.Size(58, 22);
            this.AddStripButton.Text = "Dodaj";
            this.AddStripButton.Click += new System.EventHandler(this.AddStripButton_Click);
            // 
            // ModifyStripButton
            // 
            this.ModifyStripButton.Image = global::WindowsForms.Properties.Resources.Modify;
            this.ModifyStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModifyStripButton.Name = "ModifyStripButton";
            this.ModifyStripButton.Size = new System.Drawing.Size(81, 22);
            this.ModifyStripButton.Text = "Modyfikuj";
            this.ModifyStripButton.Click += new System.EventHandler(this.ModifyStripButton_Click);
            // 
            // DeleteStripButton
            // 
            this.DeleteStripButton.Image = global::WindowsForms.Properties.Resources.Delete;
            this.DeleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteStripButton.Name = "DeleteStripButton";
            this.DeleteStripButton.Size = new System.Drawing.Size(54, 22);
            this.DeleteStripButton.Text = "Usuń";
            this.DeleteStripButton.Click += new System.EventHandler(this.DeleteStripButton_Click);
            // 
            // StripSeparator
            // 
            this.StripSeparator.Name = "StripSeparator";
            this.StripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // Filtr
            // 
            this.Filtr.Margin = new System.Windows.Forms.Padding(0, 1, 6, 2);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(65, 22);
            this.Filtr.Text = "Filtrowanie";
            // 
            // FiltrComboBox
            // 
            this.FiltrComboBox.Items.AddRange(new object[] {
            "(Brak)",
            "Data >= 2000 rok",
            "Data < 2000 rok"});
            this.FiltrComboBox.Name = "FiltrComboBox";
            this.FiltrComboBox.Size = new System.Drawing.Size(120, 25);
            this.FiltrComboBox.Text = "(Brak)";
            this.FiltrComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrComboBox_SelectedIndexChanged);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolsContainer);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MusicForm";
            this.Text = "Music catalog";
            this.Activated += new System.EventHandler(this.MusicForm_Activated);
            this.Deactivate += new System.EventHandler(this.MusicForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicForm_FormClosing);
            this.Load += new System.EventHandler(this.MusicForm_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ListContextMenu.ResumeLayout(false);
            this.ToolsContainer.ContentPanel.ResumeLayout(false);
            this.ToolsContainer.TopToolStripPanel.ResumeLayout(false);
            this.ToolsContainer.TopToolStripPanel.PerformLayout();
            this.ToolsContainer.ResumeLayout(false);
            this.ToolsContainer.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel NoItemLabel;
        private System.Windows.Forms.ToolStripStatusLabel NoLabel;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ListView SongsList;
        private System.Windows.Forms.ColumnHeader TitleColumn;
        private System.Windows.Forms.ColumnHeader AuthorColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader CategoryColumn;
        private System.Windows.Forms.ContextMenuStrip ListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteContextMenuItem;
        private System.Windows.Forms.ToolStripContainer ToolsContainer;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton AddStripButton;
        private System.Windows.Forms.ToolStripButton ModifyStripButton;
        private System.Windows.Forms.ToolStripButton DeleteStripButton;
        private System.Windows.Forms.ToolStripSeparator StripSeparator;
        private System.Windows.Forms.ToolStripLabel Filtr;
        private System.Windows.Forms.ToolStripComboBox FiltrComboBox;
    }
}

