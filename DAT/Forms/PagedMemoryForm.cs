﻿using System.Windows.Forms;
using DAT.View;
using DAT.Model.Paged;
using System.Drawing;

namespace DAT.Forms
{
    public partial class PagedMemoryForm : Form
    {
        private const int defaultPageSize = 32;
        private const int defaultFramesCount = 64;
        private const int defaultMemorySize = 512 * 1024;

        private PagedMemory memory;
        private PagedMemoryView memView;

        public PagedMemoryForm()
        {
            memory = new PagedMemory(defaultPageSize, defaultFramesCount, defaultMemorySize);
            memView = new PagedMemoryView(memory);

            InitializeComponent();
        }

        private void DrawMemory(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            memView.Draw(e.Graphics);
        }

        private void AddPage(object sender, System.EventArgs e)
        {
            var page = new Page(newPageInPrimary.Checked, (int)newPageAddr.Value, (int)newPageFrame.Value);

            try
            {
                memory.AddPage(page);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            pictureBox1.Invalidate();
        }

        private void UpdateSettings(object sender, System.EventArgs e)
        {
            memory = new PagedMemory((int)pageSize.Value, (int)framesCount.Value, (int)memorySize.Value);
            memView = new PagedMemoryView(memory);

            pictureBox1.Invalidate();
        }
    }
}
