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
            this.primaryMemPicture = new System.Windows.Forms.PictureBox();
            this.addPageLabel = new System.Windows.Forms.Label();
            this.newPageInPrimary = new System.Windows.Forms.CheckBox();
            this.newPageAddr = new System.Windows.Forms.NumericUpDown();
            this.newPageFrame = new System.Windows.Forms.NumericUpDown();
            this.newPageAddrLabel = new System.Windows.Forms.Label();
            this.newPageFrameLabel = new System.Windows.Forms.Label();
            this.addPageButton = new System.Windows.Forms.Button();
            this.addresTranslationLabel = new System.Windows.Forms.Label();
            this.updateSettingsButton = new System.Windows.Forms.Button();
            this.translatePageIndexLabel = new System.Windows.Forms.Label();
            this.translatePageOffsetLabel = new System.Windows.Forms.Label();
            this.translatePageOffset = new System.Windows.Forms.NumericUpDown();
            this.translatePageIndex = new System.Windows.Forms.NumericUpDown();
            this.translateRealAddress = new System.Windows.Forms.NumericUpDown();
            this.translateRealAddressLabel = new System.Windows.Forms.Label();
            this.translateAddressButton = new System.Windows.Forms.Button();
            this.secondaryMemPicture = new System.Windows.Forms.PictureBox();
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.secondaryMemScrollView = new System.Windows.Forms.Panel();
            this.primaryMemScrollView = new System.Windows.Forms.Panel();
            this.controlsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.translatePanel = new System.Windows.Forms.Panel();
            this.addPagePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaryMemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPageAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPageFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translatePageOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translatePageIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateRealAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryMemPicture)).BeginInit();
            this.rootLayout.SuspendLayout();
            this.secondaryMemScrollView.SuspendLayout();
            this.primaryMemScrollView.SuspendLayout();
            this.controlsLayout.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.translatePanel.SuspendLayout();
            this.addPagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageSize
            // 
            this.pageSize.Location = new System.Drawing.Point(144, 33);
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
            this.pageSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // framesCount
            // 
            this.framesCount.Location = new System.Drawing.Point(144, 57);
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
            this.framesCount.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // memorySize
            // 
            this.memorySize.Location = new System.Drawing.Point(144, 81);
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
            this.memorySize.Value = new decimal(new int[] {
            524288,
            0,
            0,
            0});
            // 
            // pageSizeLabel
            // 
            this.pageSizeLabel.AutoSize = true;
            this.pageSizeLabel.Location = new System.Drawing.Point(5, 35);
            this.pageSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pageSizeLabel.Name = "pageSizeLabel";
            this.pageSizeLabel.Size = new System.Drawing.Size(98, 13);
            this.pageSizeLabel.TabIndex = 3;
            this.pageSizeLabel.Text = "Размер страницы";
            // 
            // framesCountLabel
            // 
            this.framesCountLabel.AutoSize = true;
            this.framesCountLabel.Location = new System.Drawing.Point(5, 59);
            this.framesCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.framesCountLabel.Name = "framesCountLabel";
            this.framesCountLabel.Size = new System.Drawing.Size(105, 13);
            this.framesCountLabel.TabIndex = 4;
            this.framesCountLabel.Text = "Количество кадров";
            // 
            // memorySizeLabel
            // 
            this.memorySizeLabel.AutoSize = true;
            this.memorySizeLabel.Location = new System.Drawing.Point(5, 83);
            this.memorySizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memorySizeLabel.Name = "memorySizeLabel";
            this.memorySizeLabel.Size = new System.Drawing.Size(82, 13);
            this.memorySizeLabel.TabIndex = 5;
            this.memorySizeLabel.Text = "Объем памяти";
            // 
            // primaryMemPicture
            // 
            this.primaryMemPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.primaryMemPicture.Location = new System.Drawing.Point(0, 0);
            this.primaryMemPicture.Margin = new System.Windows.Forms.Padding(2);
            this.primaryMemPicture.Name = "primaryMemPicture";
            this.primaryMemPicture.Size = new System.Drawing.Size(261, 392);
            this.primaryMemPicture.TabIndex = 6;
            this.primaryMemPicture.TabStop = false;
            // 
            // addPageLabel
            // 
            this.addPageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPageLabel.Location = new System.Drawing.Point(0, 0);
            this.addPageLabel.Name = "addPageLabel";
            this.addPageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addPageLabel.Size = new System.Drawing.Size(238, 30);
            this.addPageLabel.TabIndex = 7;
            this.addPageLabel.Text = "Добавить страницу";
            this.addPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPageInPrimary
            // 
            this.newPageInPrimary.AutoSize = true;
            this.newPageInPrimary.Location = new System.Drawing.Point(8, 33);
            this.newPageInPrimary.Name = "newPageInPrimary";
            this.newPageInPrimary.Size = new System.Drawing.Size(129, 17);
            this.newPageInPrimary.TabIndex = 8;
            this.newPageInPrimary.Text = "В первичной памяти";
            this.newPageInPrimary.UseVisualStyleBackColor = true;
            // 
            // newPageAddr
            // 
            this.newPageAddr.Location = new System.Drawing.Point(144, 56);
            this.newPageAddr.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.newPageAddr.Name = "newPageAddr";
            this.newPageAddr.Size = new System.Drawing.Size(90, 20);
            this.newPageAddr.TabIndex = 9;
            // 
            // newPageFrame
            // 
            this.newPageFrame.Location = new System.Drawing.Point(144, 80);
            this.newPageFrame.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.newPageFrame.Name = "newPageFrame";
            this.newPageFrame.Size = new System.Drawing.Size(90, 20);
            this.newPageFrame.TabIndex = 10;
            // 
            // newPageAddrLabel
            // 
            this.newPageAddrLabel.AutoSize = true;
            this.newPageAddrLabel.Location = new System.Drawing.Point(5, 58);
            this.newPageAddrLabel.Name = "newPageAddrLabel";
            this.newPageAddrLabel.Size = new System.Drawing.Size(38, 13);
            this.newPageAddrLabel.TabIndex = 11;
            this.newPageAddrLabel.Text = "Адрес";
            // 
            // newPageFrameLabel
            // 
            this.newPageFrameLabel.AutoSize = true;
            this.newPageFrameLabel.Location = new System.Drawing.Point(5, 82);
            this.newPageFrameLabel.Name = "newPageFrameLabel";
            this.newPageFrameLabel.Size = new System.Drawing.Size(74, 13);
            this.newPageFrameLabel.TabIndex = 12;
            this.newPageFrameLabel.Text = "Номер кадра";
            // 
            // addPageButton
            // 
            this.addPageButton.Location = new System.Drawing.Point(5, 106);
            this.addPageButton.Name = "addPageButton";
            this.addPageButton.Size = new System.Drawing.Size(230, 23);
            this.addPageButton.TabIndex = 13;
            this.addPageButton.Text = "Добавить";
            this.addPageButton.UseVisualStyleBackColor = true;
            this.addPageButton.Click += new System.EventHandler(this.AddPage);
            // 
            // addresTranslationLabel
            // 
            this.addresTranslationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addresTranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresTranslationLabel.Location = new System.Drawing.Point(0, 0);
            this.addresTranslationLabel.Name = "addresTranslationLabel";
            this.addresTranslationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addresTranslationLabel.Size = new System.Drawing.Size(238, 30);
            this.addresTranslationLabel.TabIndex = 14;
            this.addresTranslationLabel.Text = "Преобразование адреса";
            this.addresTranslationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateSettingsButton
            // 
            this.updateSettingsButton.Location = new System.Drawing.Point(5, 106);
            this.updateSettingsButton.Name = "updateSettingsButton";
            this.updateSettingsButton.Size = new System.Drawing.Size(230, 23);
            this.updateSettingsButton.TabIndex = 15;
            this.updateSettingsButton.Text = "Установить";
            this.updateSettingsButton.UseVisualStyleBackColor = true;
            this.updateSettingsButton.Click += new System.EventHandler(this.UpdateSettings);
            // 
            // translatePageIndexLabel
            // 
            this.translatePageIndexLabel.AutoSize = true;
            this.translatePageIndexLabel.Location = new System.Drawing.Point(5, 39);
            this.translatePageIndexLabel.Name = "translatePageIndexLabel";
            this.translatePageIndexLabel.Size = new System.Drawing.Size(93, 13);
            this.translatePageIndexLabel.TabIndex = 16;
            this.translatePageIndexLabel.Text = "Номер страницы";
            // 
            // translatePageOffsetLabel
            // 
            this.translatePageOffsetLabel.AutoSize = true;
            this.translatePageOffsetLabel.Location = new System.Drawing.Point(140, 39);
            this.translatePageOffsetLabel.Name = "translatePageOffsetLabel";
            this.translatePageOffsetLabel.Size = new System.Drawing.Size(61, 13);
            this.translatePageOffsetLabel.TabIndex = 17;
            this.translatePageOffsetLabel.Text = "Смещение";
            // 
            // translatePageOffset
            // 
            this.translatePageOffset.Location = new System.Drawing.Point(143, 55);
            this.translatePageOffset.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.translatePageOffset.Name = "translatePageOffset";
            this.translatePageOffset.Size = new System.Drawing.Size(91, 20);
            this.translatePageOffset.TabIndex = 18;
            // 
            // translatePageIndex
            // 
            this.translatePageIndex.Location = new System.Drawing.Point(8, 55);
            this.translatePageIndex.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.translatePageIndex.Name = "translatePageIndex";
            this.translatePageIndex.Size = new System.Drawing.Size(91, 20);
            this.translatePageIndex.TabIndex = 19;
            // 
            // translateRealAddress
            // 
            this.translateRealAddress.Enabled = false;
            this.translateRealAddress.Location = new System.Drawing.Point(8, 94);
            this.translateRealAddress.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.translateRealAddress.Name = "translateRealAddress";
            this.translateRealAddress.Size = new System.Drawing.Size(226, 20);
            this.translateRealAddress.TabIndex = 20;
            // 
            // translateRealAddressLabel
            // 
            this.translateRealAddressLabel.AutoSize = true;
            this.translateRealAddressLabel.Location = new System.Drawing.Point(5, 78);
            this.translateRealAddressLabel.Name = "translateRealAddressLabel";
            this.translateRealAddressLabel.Size = new System.Drawing.Size(91, 13);
            this.translateRealAddressLabel.TabIndex = 21;
            this.translateRealAddressLabel.Text = "Реальный адрес";
            // 
            // translateAddressButton
            // 
            this.translateAddressButton.Location = new System.Drawing.Point(8, 120);
            this.translateAddressButton.Name = "translateAddressButton";
            this.translateAddressButton.Size = new System.Drawing.Size(226, 23);
            this.translateAddressButton.TabIndex = 22;
            this.translateAddressButton.Text = "Преобразовать";
            this.translateAddressButton.UseVisualStyleBackColor = true;
            this.translateAddressButton.Click += new System.EventHandler(this.TranslateAddress);
            // 
            // secondaryMemPicture
            // 
            this.secondaryMemPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondaryMemPicture.Location = new System.Drawing.Point(0, 0);
            this.secondaryMemPicture.Name = "secondaryMemPicture";
            this.secondaryMemPicture.Size = new System.Drawing.Size(261, 392);
            this.secondaryMemPicture.TabIndex = 23;
            this.secondaryMemPicture.TabStop = false;
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 3;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootLayout.Controls.Add(this.secondaryMemScrollView, 2, 0);
            this.rootLayout.Controls.Add(this.primaryMemScrollView, 1, 0);
            this.rootLayout.Controls.Add(this.controlsLayout, 0, 0);
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.RowCount = 1;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Size = new System.Drawing.Size(784, 511);
            this.rootLayout.TabIndex = 24;
            // 
            // secondaryMemScrollView
            // 
            this.secondaryMemScrollView.AutoScroll = true;
            this.secondaryMemScrollView.Controls.Add(this.secondaryMemPicture);
            this.secondaryMemScrollView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondaryMemScrollView.Location = new System.Drawing.Point(520, 3);
            this.secondaryMemScrollView.Name = "secondaryMemScrollView";
            this.secondaryMemScrollView.Size = new System.Drawing.Size(261, 505);
            this.secondaryMemScrollView.TabIndex = 25;
            // 
            // primaryMemScrollView
            // 
            this.primaryMemScrollView.AutoScroll = true;
            this.primaryMemScrollView.Controls.Add(this.primaryMemPicture);
            this.primaryMemScrollView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryMemScrollView.Location = new System.Drawing.Point(253, 3);
            this.primaryMemScrollView.Name = "primaryMemScrollView";
            this.primaryMemScrollView.Size = new System.Drawing.Size(261, 505);
            this.primaryMemScrollView.TabIndex = 25;
            // 
            // controlsLayout
            // 
            this.controlsLayout.ColumnCount = 1;
            this.controlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlsLayout.Controls.Add(this.settingsPanel, 0, 0);
            this.controlsLayout.Controls.Add(this.translatePanel, 0, 2);
            this.controlsLayout.Controls.Add(this.addPagePanel, 0, 1);
            this.controlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsLayout.Location = new System.Drawing.Point(3, 3);
            this.controlsLayout.Name = "controlsLayout";
            this.controlsLayout.RowCount = 3;
            this.controlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.controlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.controlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.controlsLayout.Size = new System.Drawing.Size(244, 505);
            this.controlsLayout.TabIndex = 28;
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoSize = true;
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Controls.Add(this.pageSizeLabel);
            this.settingsPanel.Controls.Add(this.pageSize);
            this.settingsPanel.Controls.Add(this.framesCount);
            this.settingsPanel.Controls.Add(this.memorySize);
            this.settingsPanel.Controls.Add(this.framesCountLabel);
            this.settingsPanel.Controls.Add(this.memorySizeLabel);
            this.settingsPanel.Controls.Add(this.updateSettingsButton);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(3, 3);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(238, 132);
            this.settingsPanel.TabIndex = 25;
            // 
            // settingsLabel
            // 
            this.settingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(238, 30);
            this.settingsLabel.TabIndex = 16;
            this.settingsLabel.Text = "Параметры";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translatePanel
            // 
            this.translatePanel.AutoSize = true;
            this.translatePanel.Controls.Add(this.translateAddressButton);
            this.translatePanel.Controls.Add(this.addresTranslationLabel);
            this.translatePanel.Controls.Add(this.translatePageIndexLabel);
            this.translatePanel.Controls.Add(this.translatePageOffsetLabel);
            this.translatePanel.Controls.Add(this.translatePageOffset);
            this.translatePanel.Controls.Add(this.translatePageIndex);
            this.translatePanel.Controls.Add(this.translateRealAddressLabel);
            this.translatePanel.Controls.Add(this.translateRealAddress);
            this.translatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.translatePanel.Location = new System.Drawing.Point(3, 279);
            this.translatePanel.Name = "translatePanel";
            this.translatePanel.Size = new System.Drawing.Size(238, 146);
            this.translatePanel.TabIndex = 27;
            // 
            // addPagePanel
            // 
            this.addPagePanel.AutoSize = true;
            this.addPagePanel.Controls.Add(this.addPageButton);
            this.addPagePanel.Controls.Add(this.addPageLabel);
            this.addPagePanel.Controls.Add(this.newPageInPrimary);
            this.addPagePanel.Controls.Add(this.newPageAddr);
            this.addPagePanel.Controls.Add(this.newPageFrame);
            this.addPagePanel.Controls.Add(this.newPageAddrLabel);
            this.addPagePanel.Controls.Add(this.newPageFrameLabel);
            this.addPagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPagePanel.Location = new System.Drawing.Point(3, 141);
            this.addPagePanel.Name = "addPagePanel";
            this.addPagePanel.Size = new System.Drawing.Size(238, 132);
            this.addPagePanel.TabIndex = 26;
            // 
            // PagedMemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.rootLayout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "PagedMemoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Динамическое преобразование адреса";
            ((System.ComponentModel.ISupportInitialize)(this.pageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaryMemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPageAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPageFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translatePageOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translatePageIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateRealAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryMemPicture)).EndInit();
            this.rootLayout.ResumeLayout(false);
            this.secondaryMemScrollView.ResumeLayout(false);
            this.primaryMemScrollView.ResumeLayout(false);
            this.controlsLayout.ResumeLayout(false);
            this.controlsLayout.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.translatePanel.ResumeLayout(false);
            this.translatePanel.PerformLayout();
            this.addPagePanel.ResumeLayout(false);
            this.addPagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pageSize;
        private System.Windows.Forms.NumericUpDown framesCount;
        private System.Windows.Forms.NumericUpDown memorySize;
        private System.Windows.Forms.Label pageSizeLabel;
        private System.Windows.Forms.Label framesCountLabel;
        private System.Windows.Forms.Label memorySizeLabel;
        private System.Windows.Forms.PictureBox primaryMemPicture;
        private System.Windows.Forms.Label addPageLabel;
        private System.Windows.Forms.CheckBox newPageInPrimary;
        private System.Windows.Forms.NumericUpDown newPageAddr;
        private System.Windows.Forms.NumericUpDown newPageFrame;
        private System.Windows.Forms.Label newPageAddrLabel;
        private System.Windows.Forms.Label newPageFrameLabel;
        private System.Windows.Forms.Button addPageButton;
        private System.Windows.Forms.Label addresTranslationLabel;
        private System.Windows.Forms.Button updateSettingsButton;
        private System.Windows.Forms.Label translatePageIndexLabel;
        private System.Windows.Forms.Label translatePageOffsetLabel;
        private System.Windows.Forms.NumericUpDown translatePageOffset;
        private System.Windows.Forms.NumericUpDown translatePageIndex;
        private System.Windows.Forms.NumericUpDown translateRealAddress;
        private System.Windows.Forms.Label translateRealAddressLabel;
        private System.Windows.Forms.Button translateAddressButton;
        private System.Windows.Forms.PictureBox secondaryMemPicture;
        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Panel primaryMemScrollView;
        private System.Windows.Forms.TableLayoutPanel controlsLayout;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Panel translatePanel;
        private System.Windows.Forms.Panel addPagePanel;
        private System.Windows.Forms.Panel secondaryMemScrollView;
    }
}