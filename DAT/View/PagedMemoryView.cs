using DAT.Model.Paged;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DAT.View
{
    internal class PagedMemoryView
    {
        private PagedMemory memory;

        private PictureBox primaryContainer;
        private PictureBox secondaryContainer;

        private Grid primaryGrid;
        private Grid secondaryGrid;

        public PagedMemoryView(PagedMemory memory, PictureBox primaryContainer, PictureBox secondaryContainer, Font font)
        {
            this.memory = memory;
            
            this.primaryContainer = primaryContainer;
            this.secondaryContainer = secondaryContainer;

            primaryGrid = new Grid(primaryContainer, new Size(40, 40), memory.FramesCount, font);
            secondaryGrid = new Grid(secondaryContainer, new Size(15, 20), memory.MemorySize, font);

            memory.MemoryUpdated += MemoryUpdateHandler;
            memory.SettingsUpdated += MemorySettingsUpdateHandler;

            primaryContainer.Paint += DrawPrimary;
            primaryContainer.Resize += ResizePrimary;
            secondaryContainer.Paint += DrawSecondary;
            secondaryContainer.Resize += ResizeSecondary;
        }

        ~PagedMemoryView()
        {
            memory.MemoryUpdated -= MemoryUpdateHandler;
            memory.SettingsUpdated -= MemorySettingsUpdateHandler;

            primaryContainer.Paint -= DrawPrimary;
            secondaryContainer.Paint -= DrawSecondary;
        }

        public void DrawPrimary(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(primaryContainer.BackColor);
            primaryGrid.Draw(e.Graphics, framePages: memory.Primary);
        }

        public void DrawSecondary(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(secondaryContainer.BackColor);
            secondaryGrid.Draw(e.Graphics, memoryPages: memory.Secondary, pageSize: memory.PageSize);
        }

        private void MemorySettingsUpdateHandler()
        {
            primaryGrid.SetCellsCount(memory.FramesCount);
            secondaryGrid.SetCellsCount(memory.MemorySize);
        }

        private void MemoryUpdateHandler()
        {
            primaryContainer.Invalidate();
            secondaryContainer.Invalidate();
        }

        #region Resize
        private void ResizeSecondary(object sender, EventArgs e)
        {
            secondaryGrid.RecalculateSize();
            secondaryContainer.Invalidate();
        }

        private void ResizePrimary(object sender, EventArgs e)
        {
            primaryGrid.RecalculateSize();
            primaryContainer.Invalidate();
        }
        #endregion Resize
    }
}
