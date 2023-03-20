using System;
using System.Drawing;
using System.Windows.Forms;

namespace DAT
{
    public partial class MemoryViewForm : Form
    {
        public MemoryViewForm()
        {
            InitializeComponent();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var gfx = e.Graphics;

            var offset = new Point(10, 10);

            var outlineColor = Pens.Black;

            DrawVirtualMemory(gfx, outlineColor, offset, new Size(32, 32), 254, 8);
        }

        private void DrawVirtualMemory(Graphics gfx, Pen color, Point pos, Size cellSize, int cellsCount, int cellsInRow)
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
    }
}
