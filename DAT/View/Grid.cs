using DAT.Model.Paged;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DAT.View
{
    public class Grid
    {
        private const int bottomOffset = 5;

        private Font font;
        private Pen framePen;
        private Pen gridPen;
        private Brush pageBrush;
        
        private PictureBox container;
        private Point offset;

        private Size cellSize;

        public Grid(
            PictureBox container,
            Size cellSize,
            int cellsCount,
            Font font,
            Pen gridPen = null,
            Pen framePen = null,
            Brush pageBrush = null)
        {
            this.CellsCount = cellsCount;

            this.container = container;
            this.offset = new Point(0, 0);
            this.cellSize = cellSize;

            this.font = font;
            this.framePen = framePen ?? Palette.FramePen;
            this.gridPen = gridPen ?? Palette.GridPen;
            this.pageBrush = pageBrush ?? Palette.PageBrush;
        }

        public int CellsCount { get; private set; }
        public int CellsInRow { get; private set; }
        public int RowsCount { get; private set; }

        public void SetCellsCount(int cellsCount)
        {
            this.CellsCount = cellsCount;

            container.Invalidate();
        }

        public void RecalculateSize()
        {
            CellsInRow = (container.Size.Width - offset.X) / cellSize.Width;
            RowsCount = (int)Math.Floor((float)CellsCount / CellsInRow);

            var actualRows = RowsCount + (CellsCount % CellsInRow > 0 ? 1 : 0);
            var actualHeight = 2 * offset.Y + actualRows * cellSize.Height + bottomOffset;
            container.Height = actualHeight;
        }

        public Point GetCellPosition(int index)
        {
            var y = index / CellsInRow;
            var x = index % CellsInRow;

            return new Point(offset.X + x * cellSize.Width, offset.Y + y * cellSize.Height);
        }

        public int GetCellIndex(Point pos)
        {
            var xi = (pos.X - offset.X) / cellSize.Width;
            var yi = (pos.Y - offset.Y) / cellSize.Height;
            var idx = CellsInRow * yi + xi;

            if (xi >= CellsInRow || yi > RowsCount || idx >= CellsCount)
                return -1;

            return idx;
        }

        public void Draw(Graphics gfx, IEnumerable<Page> framePages = null, IEnumerable<Page> memoryPages = null, int pageSize = default)
        {
            RecalculateSize();
            
            DrawGrid(gfx);

            if (framePages != null) DrawPagesInFrames(gfx, framePages);
            if (memoryPages != null) DrawPagesInMemory(gfx, memoryPages, pageSize);
        }

        private void DrawGrid(Graphics gfx)
        {
            var rectSize = new Size(CellsInRow * cellSize.Width, RowsCount * cellSize.Height);
            var memRect = new Rectangle(offset, rectSize);

            gfx.DrawRectangle(gridPen, memRect);

            for (int i = 1; i < RowsCount; i++)
            {
                var yPos = offset.Y + cellSize.Height * i;
                gfx.DrawLine(gridPen, offset.X, yPos, offset.X + rectSize.Width, yPos);
            }

            for (int i = 1; i < CellsInRow; i++)
            {
                var xPos = offset.X + cellSize.Width * i;
                gfx.DrawLine(gridPen, xPos, offset.Y, xPos, offset.Y + rectSize.Height);
            }

            var inLastRow = CellsCount - RowsCount * CellsInRow;
            if (inLastRow > 0)
            {
                var yMin = offset.Y + rectSize.Height;
                var yMax = yMin + cellSize.Height;
                gfx.DrawLine(gridPen, offset.X, yMax, offset.X + rectSize.Width, yMax);

                for (int i = 0; i <= inLastRow; i++)
                {
                    var xPos = offset.X + cellSize.Width * i;
                    gfx.DrawLine(gridPen, xPos, yMin, xPos, yMax);
                }

                gfx.DrawLine(gridPen, offset.X + rectSize.Width, yMin, offset.X + rectSize.Width, yMax);
            }
        }

        private void DrawPagesInFrames(Graphics gfx, IEnumerable<Page> pages)
        {
            foreach (var page in pages)
            {
                if (page == null || !page.InPrimary) continue;

                var pos = GetCellPosition(page.Frame);
                gfx.DrawRectangle(framePen, pos, cellSize);
                gfx.DrawString(page.Id.ToString(), font, Brushes.Black, pos);
            }
        }

        private void DrawPagesInMemory(Graphics gfx, IEnumerable<Page> pages, int pageSize)
        {
            foreach (var page in pages)
            {
                if (page == null || page.InPrimary) continue;

                for (int i = page.Address; i < page.Address + pageSize; i++)
                {
                    gfx.FillRectangle(pageBrush, GetCellPosition(i), cellSize);
                }
                gfx.DrawString(page.Id.ToString(), font, Brushes.White, GetCellPosition(page.Address));
            }
        }
    }
}
