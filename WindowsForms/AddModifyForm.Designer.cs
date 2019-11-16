namespace WindowsForms
{
    partial class AddModifyForm
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
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TitleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AuthorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChangeCategory = new WindowsForms.ChangeCategory();
            this.Table.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Controls.Add(this.AuthorText, 1, 1);
            this.Table.Controls.Add(this.AuthorLabel, 0, 1);
            this.Table.Controls.Add(this.DateLabel, 0, 2);
            this.Table.Controls.Add(this.CategoryLabel, 0, 3);
            this.Table.Controls.Add(this.TitleLabel, 0, 0);
            this.Table.Controls.Add(this.TitleText, 1, 0);
            this.Table.Controls.Add(this.DatePicker, 1, 2);
            this.Table.Controls.Add(this.ChangeCategory, 1, 3);
            this.Table.Location = new System.Drawing.Point(12, 12);
            this.Table.Name = "Table";
            this.Table.RowCount = 4;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table.Size = new System.Drawing.Size(460, 150);
            this.Table.TabIndex = 0;
            // 
            // AuthorText
            // 
            this.AuthorText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorText.CausesValidation = false;
            this.AuthorText.Location = new System.Drawing.Point(94, 39);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(352, 20);
            this.AuthorText.TabIndex = 6;
            this.AuthorText.Validating += new System.ComponentModel.CancelEventHandler(this.AuthorText_Validating);
            this.AuthorText.Validated += new System.EventHandler(this.AuthorText_Validated);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(3, 43);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(32, 13);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Autor";
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(3, 76);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(74, 13);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Data nagrania";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 118);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Kategoria";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(3, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(32, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Tytuł";
            // 
            // TitleText
            // 
            this.TitleText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleText.CausesValidation = false;
            this.TitleText.Location = new System.Drawing.Point(94, 6);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(352, 20);
            this.TitleText.TabIndex = 4;
            this.TitleText.Validating += new System.ComponentModel.CancelEventHandler(this.TitleText_Validating);
            this.TitleText.Validated += new System.EventHandler(this.TitleText_Validated);
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatePicker.CausesValidation = false;
            this.DatePicker.Location = new System.Drawing.Point(94, 72);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(352, 20);
            this.DatePicker.TabIndex = 7;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.ButtonAccept);
            this.ButtonsPanel.Controls.Add(this.ButtonCancel);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 168);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(460, 41);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Location = new System.Drawing.Point(277, 9);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccept.TabIndex = 1;
            this.ButtonAccept.Text = "Zapisz";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(109, 9);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Anuluj";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TitleErrorProvider
            // 
            this.TitleErrorProvider.ContainerControl = this;
            // 
            // AuthorErrorProvider
            // 
            this.AuthorErrorProvider.ContainerControl = this;
            // 
            // ChangeCategory
            // 
            this.ChangeCategory.Category = WindowsForms.Category.Rock;
            this.ChangeCategory.Location = new System.Drawing.Point(83, 102);
            this.ChangeCategory.Name = "ChangeCategory";
            this.ChangeCategory.Size = new System.Drawing.Size(374, 45);
            this.ChangeCategory.TabIndex = 8;
            // 
            // AddModifyForm
            // 
            this.AcceptButton = this.ButtonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(484, 221);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddModifyForm";
            this.Text = "Song";
            this.Load += new System.EventHandler(this.AddModifyForm_Load);
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private ChangeCategory ChangeCategory;
        private System.Windows.Forms.ErrorProvider TitleErrorProvider;
        private System.Windows.Forms.ErrorProvider AuthorErrorProvider;
    }
}