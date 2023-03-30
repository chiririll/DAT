using DAT.Model.Paged;
using System.Drawing;

namespace DAT.View
{
    internal class PagedMemoryView
    {
        private PagedMemory memory;
        private Grid vMemGrid;

        private Pen gridPen;
        private Pen pagePen;

        private Font font;

        public PagedMemoryView(PagedMemory memory, Font font)
        {
            this.memory = memory;

            vMemGrid = new Grid(new Point(0, 0), new Size(40, 40), 8);

            gridPen = Pens.LightGray;
            pagePen = Pens.Red;

            this.font = font;
        }

        public void Draw(Graphics gfx)
        {
            vMemGrid.Draw(gfx, memory.FramesCount, gridPen);

            foreach (var page in memory.Primary)
            {
                DrawPage(gfx, page);
            }
        }

        private void DrawPage(Graphics gfx, Page page)
        {
            if (page == null) return;

            var pos = vMemGrid.GetCellPosition(page.Frame);

            gfx.DrawRectangle(pagePen, new Rectangle(pos, vMemGrid.cellSize));
            gfx.DrawString(page.Id.ToString(), font, Brushes.Black, pos);
        }
    }
}
