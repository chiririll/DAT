using System.Windows.Forms;
using DAT.View;
using DAT.Model;
using System.Drawing;

namespace DAT.Forms
{
    public partial class PagedMemoryForm : Form
    {
        private PagedMemory memory;
        private PagedMemoryView memView;

        public PagedMemoryForm()
        {
            memory = new PagedMemory();
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
    }
}
