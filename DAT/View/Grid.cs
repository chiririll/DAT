using System;
using System.Drawing;

namespace DAT.View
{
    public class Grid
    {
        public Point pos;
        public Size cellSize;
        public int cellsInRow;

        public Grid(Point pos, Size cellSize, int cellsInRow)
        {
            this.pos = pos;
            this.cellSize = cellSize;
            this.cellsInRow = cellsInRow;
        }

        public void Draw(Graphics gfx, int cellsCount, Pen color = default)
        {
            var rowsCount = (int)Math.Floor((float)cellsCount / cellsInRow);

            var rectSize = new Size(cellsInRow * cellSize.Width, rowsCount * cellSize.Height);
            var memRect = new Rectangle(pos, rectSize);
            gfx.DrawRectangle(color, memRect);

            for (int i = 1; i < rowsCount; i++)
            {
                var yPos = pos.Y + cellSize.Height * i;
                gfx.DrawLine(color, pos.X, yPos, pos.X + rectSize.Width, yPos);
            }

            for (int i = 1; i < cellsInRow; i++)
            {
                var xPos = pos.X + cellSize.Width * i;
                gfx.DrawLine(color, xPos, pos.Y, xPos, pos.Y + rectSize.Height);
            }

            var inLastRow = cellsCount - rowsCount * cellsInRow;
            if (inLastRow > 0)
            {
                var yMin = pos.Y + rectSize.Height;
                var yMax = yMin + cellSize.Height;
                gfx.DrawLine(color, pos.X, yMax, pos.X + rectSize.Width, yMax);

                for (int i = 0; i <= inLastRow; i++)
                {
                    var xPos = pos.X + cellSize.Width * i;
                    gfx.DrawLine(color, xPos, yMin, xPos, yMax);
                }

                gfx.DrawLine(color, pos.X + rectSize.Width, yMin, pos.X + rectSize.Width, yMax);
            }
        }

        public Point GetCellPosition(int index)
        {
            var y = index / cellsInRow;
            var x = index % cellsInRow;

            return new Point(pos.X + x * cellSize.Width, pos.Y + y * cellSize.Height);
        }
    }
}
