namespace DAT.Forms
{
    partial class PageForm
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
            this.pagePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pagePicture
            // 
            this.pagePicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pagePicture.Location = new System.Drawing.Point(0, 0);
            this.pagePicture.Name = "pagePicture";
            this.pagePicture.Size = new System.Drawing.Size(800, 450);
            this.pagePicture.TabIndex = 0;
            this.pagePicture.TabStop = false;
            this.pagePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            // 
            // PageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pagePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PageForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pagePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pagePicture;
    }
}