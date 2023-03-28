using DAT.Model;
using System.Drawing;

namespace DAT.View
{
    internal class PagedMemoryView
    {
        private PagedMemory memory;
        private Grid vMemGrid;

        private Pen gridPen;
        private Pen pagePen;

        public PagedMemoryView(PagedMemory memory)
        {
            this.memory = memory;

            vMemGrid = new Grid(new Point(0, 0), new Size(40, 40), 8);

            gridPen = Pens.LightGray;
            pagePen = Pens.Red;
        }

        public void Draw(Graphics gfx)
        {
            vMemGrid.Draw(gfx, 30, gridPen);

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
        }
    }
}
