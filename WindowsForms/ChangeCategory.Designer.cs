namespace WindowsForms
{
    partial class ChangeCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.CategoryPicture = new System.Windows.Forms.PictureBox();
            this.CategoryTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryTable
            // 
            this.CategoryTable.ColumnCount = 2;
            this.CategoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.CategoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.CategoryTable.Controls.Add(this.CategoryText, 0, 0);
            this.CategoryTable.Controls.Add(this.CategoryPicture, 1, 0);
            this.CategoryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryTable.Location = new System.Drawing.Point(0, 0);
            this.CategoryTable.Name = "CategoryTable";
            this.CategoryTable.RowCount = 1;
            this.CategoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CategoryTable.Size = new System.Drawing.Size(347, 51);
            this.CategoryTable.TabIndex = 6;
            // 
            // CategoryText
            // 
            this.CategoryText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryText.Enabled = false;
            this.CategoryText.Location = new System.Drawing.Point(3, 15);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(184, 20);
            this.CategoryText.TabIndex = 5;
            // 
            // CategoryPicture
            // 
            this.CategoryPicture.Location = new System.Drawing.Point(193, 3);
            this.CategoryPicture.Name = "CategoryPicture";
            this.CategoryPicture.Size = new System.Drawing.Size(151, 45);
            this.CategoryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CategoryPicture.TabIndex = 0;
            this.CategoryPicture.TabStop = false;
            this.CategoryPicture.Click += new System.EventHandler(this.CategoryPicture_Click);
            // 
            // ChangeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoryTable);
            this.Name = "ChangeCategory";
            this.Size = new System.Drawing.Size(347, 51);
            this.CategoryTable.ResumeLayout(false);
            this.CategoryTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel CategoryTable;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.PictureBox CategoryPicture;
    }
}
