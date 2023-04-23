namespace System.Drawing
{
    public static class GraphicsExtensions
    {
        public static void DrawRectangle(this Graphics gfx, Pen pen, Point pos, Size size)
        {
            gfx.DrawRectangle(pen, pos.X, pos.Y, size.Width, size.Height);
        }

        public static void FillRectangle(this Graphics gfx, Brush brush, Point pos, Size size)
        {
            gfx.FillRectangle(brush, pos.X, pos.Y, size.Width, size.Height);
        }
    }
}
