namespace DAT.Forms
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.memTypeLabel = new System.Windows.Forms.Label();
            this.memType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memSizeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Tag = "";
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loadToolStripMenuItem.Text = "&Открыть";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "&Сохранить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Вы&ход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CloseForm);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.helpToolStripMenuItem.Text = "&Справка";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.viewHelpToolStripMenuItem.Text = "&View Help";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.memTypeLabel);
            this.sidebar.Controls.Add(this.memType);
            this.sidebar.Controls.Add(this.memSizeLabel);
            this.sidebar.Controls.Add(this.textBox1);
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 33);
            this.sidebar.MinimumSize = new System.Drawing.Size(200, 300);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(300, 417);
            this.sidebar.TabIndex = 1;
            // 
            // memTypeLabel
            // 
            this.memTypeLabel.AutoSize = true;
            this.memTypeLabel.Location = new System.Drawing.Point(3, 10);
            this.memTypeLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.memTypeLabel.Name = "memTypeLabel";
            this.memTypeLabel.Size = new System.Drawing.Size(168, 20);
            this.memTypeLabel.TabIndex = 0;
            this.memTypeLabel.Text = "Организация памяти";
            // 
            // memType
            // 
            this.memType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memType.FormattingEnabled = true;
            this.memType.Items.AddRange(new object[] {
            "Страничная",
            "Сегментная",
            "Странично-сегментная"});
            this.memType.Location = new System.Drawing.Point(5, 33);
            this.memType.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.memType.MaximumSize = new System.Drawing.Size(300, 0);
            this.memType.MinimumSize = new System.Drawing.Size(150, 0);
            this.memType.Name = "memType";
            this.memType.Size = new System.Drawing.Size(282, 28);
            this.memType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Параметры памяти";
            // 
            // memSizeLabel
            // 
            this.memSizeLabel.AutoSize = true;
            this.memSizeLabel.Location = new System.Drawing.Point(3, 74);
            this.memSizeLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.memSizeLabel.Name = "memSizeLabel";
            this.memSizeLabel.Size = new System.Drawing.Size(121, 20);
            this.memSizeLabel.TabIndex = 3;
            this.memSizeLabel.Text = "Объем памяти";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 26);
            this.textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 146);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Dynamic Address Translation Model";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Label memTypeLabel;
        private System.Windows.Forms.ComboBox memType;
        private System.Windows.Forms.Label memSizeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}