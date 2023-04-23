using DAT.Model.Paged;
using DAT.View;
using System.Drawing;
using System.Windows.Forms;

namespace DAT.Forms
{
    public partial class PageForm : Form
    {
        private readonly string title = "Страница #{0}";
        private readonly Size offset = new Size(20, 20);
        
        private readonly Grid grid;

        private int selectedCell;

        public PageForm()
        {
            InitializeComponent();

            grid = new Grid(pagePicture, new Size(40, 40), 0, this.Font);
        }

        public void SetData(Page page, int pageSize, int selectedCell)
        {
            this.Text = string.Format(title, page.Id);
            this.selectedCell = selectedCell;
            
            grid.SetCellsCount(pageSize);
            this.Width = grid.GetSquareSizeWidth() + offset.Width;
            this.Invalidate();
            grid.RecalculateSize();
            this.Height = pagePicture.Height + offset.Height;
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            grid.Draw(e.Graphics, selectedCell: selectedCell);
        }
    }
}
