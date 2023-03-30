namespace DAT.Forms
{
    partial class PagedMemoryForm
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
            this.pageSize = new System.Windows.Forms.NumericUpDown();
            this.framesCount = new System.Windows.Forms.NumericUpDown();
            this.memorySize = new System.Windows.Forms.NumericUpDown();
            this.pageSizeLabel = new System.Windows.Forms.Label();
            this.framesCountLabel = new System.Windows.Forms.Label();
            this.memorySizeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addPageLabel = new System.Windows.Forms.Label();
            this.newPageInPrimary = new System.Windows.Forms.CheckBox();
            this.newPageAddr = new System.Windows.Forms.NumericUpDown();
            this.newPageFrame = new System.Windows.Forms.NumericUpDown();
            this.newPageAddrLabel = new System.Windows.Forms.Label();
            this.newPageFrameLabel = new System.Windows.Forms.Label();
            this.addPageButton = new System.Windows.Forms.Button();
            this.addresTranslationLabel = new System.Windows.Forms.Label();
            this.updateSettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPageAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPageFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // pageSize
            // 
            this.pageSize.Location = new System.Drawing.Point(124, 21);
            this.pageSize.Margin = new System.Windows.Forms.Padding(2);
            this.pageSize.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.pageSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSize.Name = "pageSize";
            this.pageSize.Size = new System.Drawing.Size(90, 20);
            this.pageSize.TabIndex = 0;
            this.pageSize.Value = PagedMemoryForm.defaultPageSize;
            // 
            // framesCount
            // 
            this.framesCount.Location = new System.Drawing.Point(124, 46);
            this.framesCount.Margin = new System.Windows.Forms.Padding(2);
            this.framesCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.framesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.framesCount.Name = "framesCount";
            this.framesCount.Size = new System.Drawing.Size(90, 20);
            this.framesCount.TabIndex = 1;
            this.framesCount.Value = PagedMemoryForm.defaultFramesCount;
            // 
            // memorySize
            // 
            this.memorySize.Location = new System.Drawing.Point(124, 69);
            this.memorySize.Margin = new System.Windows.Forms.Padding(2);
            this.memorySize.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.memorySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.memorySize.Name = "memorySize";
            this.memorySize.Size = new System.Drawing.Size(90, 20);
            this.memorySize.TabIndex = 2;
            this.memorySize.Value = PagedMemoryForm.defaultMemorySize;
            // 
            // pageSizeLabel
            // 
            this.pageSizeLabel.AutoSize = true;
            this.pageSizeLabel.Location = new System.Drawing.Point(9, 23);
            this.pageSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pageSizeLabel.Name = "pageSizeLabel";
            this.pageSizeLabel.Size = new System.Drawing.Size(98, 13);
            this.pageSizeLabel.TabIndex = 3;
            this.pageSizeLabel.Text = "Размер страницы";
            // 
            // framesCountLabel
            // 
            this.framesCountLabel.AutoSize = true;
            this.framesCountLabel.Location = new System.Drawing.Point(9, 48);
            this.framesCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.framesCountLabel.Name = "framesCountLabel";
            this.framesCountLabel.Size = new System.Drawing.Size(105, 13);
            this.framesCountLabel.TabIndex = 4;
            this.framesCountLabel.Text = "Количество кадров";
            // 
            // memorySizeLabel
            // 
            this.memorySizeLabel.AutoSize = true;
            this.memorySizeLabel.Location = new System.Drawing.Point(9, 71);
            this.memorySizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memorySizeLabel.Name = "memorySizeLabel";
            this.memorySizeLabel.Size = new System.Drawing.Size(82, 13);
            this.memorySizeLabel.TabIndex = 5;
            this.memorySizeLabel.Text = "Объем памяти";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(219, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 346);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawMemory);
            // 
            // addPageLabel
            // 
            this.addPageLabel.AutoSize = true;
            this.addPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPageLabel.Location = new System.Drawing.Point(12, 125);
            this.addPageLabel.Name = "addPageLabel";
            this.addPageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addPageLabel.Size = new System.Drawing.Size(106, 13);
            this.addPageLabel.TabIndex = 7;
            this.addPageLabel.Text = "Добавить страницу";
            // 
            // newPageInPrimary
            // 
            this.newPageInPrimary.AutoSize = true;
            this.newPageInPrimary.Location = new System.Drawing.Point(13, 150);
            this.newPageInPrimary.Name = "newPageInPrimary";
            this.newPageInPrimary.Size = new System.Drawing.Size(129, 17);
            this.newPageInPrimary.TabIndex = 8;
            this.newPageInPrimary.Text = "В первичной памяти";
            this.newPageInPrimary.UseVisualStyleBackColor = true;
            // 
            // newPageAddr
            // 
            this.newPageAddr.Location = new System.Drawing.Point(125, 173);
            this.newPageAddr.Name = "newPageAddr";
            this.newPageAddr.Size = new System.Drawing.Size(90, 20);
            this.newPageAddr.TabIndex = 9;
            // 
            // newPageFrame
            // 
            this.newPageFrame.Location = new System.Drawing.Point(125, 197);
            this.newPageFrame.Name = "newPageFrame";
            this.newPageFrame.Size = new System.Drawing.Size(90, 20);
            this.newPageFrame.TabIndex = 10;
            // 
            // newPageAddrLabel
            // 
            this.newPageAddrLabel.AutoSize = true;
            this.newPageAddrLabel.Location = new System.Drawing.Point(9, 175);
            this.newPageAddrLabel.Name = "newPageAddrLabel";
            this.newPageAddrLabel.Size = new System.Drawing.Size(38, 13);
            this.newPageAddrLabel.TabIndex = 11;
            this.newPageAddrLabel.Text = "Адрес";
            // 
            // newPageFrameLabel
            // 
            this.newPageFrameLabel.AutoSize = true;
            this.newPageFrameLabel.Location = new System.Drawing.Point(10, 199);
            this.newPageFrameLabel.Name = "newPageFrameLabel";
            this.newPageFrameLabel.Size = new System.Drawing.Size(74, 13);
            this.newPageFrameLabel.TabIndex = 12;
            this.newPageFrameLabel.Text = "Номер кадра";
            // 
            // addPageButton
            // 
            this.addPageButton.Location = new System.Drawing.Point(13, 223);
            this.addPageButton.Name = "addPageButton";
            this.addPageButton.Size = new System.Drawing.Size(202, 23);
            this.addPageButton.TabIndex = 13;
            this.addPageButton.Text = "Добавить";
            this.addPageButton.UseVisualStyleBackColor = true;
            this.addPageButton.Click += new System.EventHandler(this.AddPage);
            // 
            // addresTranslationLabel
            // 
            this.addresTranslationLabel.AutoSize = true;
            this.addresTranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresTranslationLabel.Location = new System.Drawing.Point(13, 260);
            this.addresTranslationLabel.Name = "addresTranslationLabel";
            this.addresTranslationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addresTranslationLabel.Size = new System.Drawing.Size(132, 13);
            this.addresTranslationLabel.TabIndex = 14;
            this.addresTranslationLabel.Text = "Преобразование адреса";
            // 
            // updateSettingsButton
            // 
            this.updateSettingsButton.Location = new System.Drawing.Point(13, 94);
            this.updateSettingsButton.Name = "updateSettingsButton";
            this.updateSettingsButton.Size = new System.Drawing.Size(202, 23);
            this.updateSettingsButton.TabIndex = 15;
            this.updateSettingsButton.Text = "Установить";
            this.updateSettingsButton.UseVisualStyleBackColor = true;
            this.updateSettingsButton.Click += new System.EventHandler(this.UpdateSettings);
            // 
            // PagedMemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.updateSettingsButton);
            this.Controls.Add(this.addresTranslationLabel);
            this.Controls.Add(this.addPageButton);
            this.Controls.Add(this.newPageFrameLabel);
            this.Controls.Add(this.newPageAddrLabel);
            this.Controls.Add(this.newPageFrame);
            this.Controls.Add(this.newPageAddr);
            this.Controls.Add(this.newPageInPrimary);
            this.Controls.Add(this.addPageLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.memorySizeLabel);
            this.Controls.Add(this.framesCountLabel);
            this.Controls.Add(this.pageSizeLabel);
            this.Controls.Add(this.memorySize);
            this.Controls.Add(this.framesCount);
            this.Controls.Add(this.pageSize);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PagedMemoryForm";
            this.Text = "PagedMemory";
            ((System.ComponentModel.ISupportInitialize)(this.pageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPageAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPageFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pageSize;
        private System.Windows.Forms.NumericUpDown framesCount;
        private System.Windows.Forms.NumericUpDown memorySize;
        private System.Windows.Forms.Label pageSizeLabel;
        private System.Windows.Forms.Label framesCountLabel;
        private System.Windows.Forms.Label memorySizeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label addPageLabel;
        private System.Windows.Forms.CheckBox newPageInPrimary;
        private System.Windows.Forms.NumericUpDown newPageAddr;
        private System.Windows.Forms.NumericUpDown newPageFrame;
        private System.Windows.Forms.Label newPageAddrLabel;
        private System.Windows.Forms.Label newPageFrameLabel;
        private System.Windows.Forms.Button addPageButton;
        private System.Windows.Forms.Label addresTranslationLabel;
        private System.Windows.Forms.Button updateSettingsButton;
    }
}