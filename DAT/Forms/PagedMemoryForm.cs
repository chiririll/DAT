using System.Windows.Forms;
using DAT.View;
using DAT.Model.Paged;

namespace DAT.Forms
{
    public partial class PagedMemoryForm : Form
    {
        private PagedMemory memory;
        private PagedMemoryView memView;

        public PagedMemoryForm()
        {
            InitializeComponent();

            memory = new PagedMemory((int)pageSize.Value, (int)framesCount.Value, (int)memorySize.Value);
            memView = new PagedMemoryView(memory, primaryMemPicture, secondaryMemPicture, this.Font);
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

            primaryMemPicture.Invalidate();
        }

        private void UpdateSettings(object sender, System.EventArgs e)
        {
            memory.UpdateSettings((int)pageSize.Value, (int)framesCount.Value, (int)memorySize.Value);
        }

        private void TranslateAddress(object sender, System.EventArgs e)
        {
            try
            {
                translateRealAddress.Value = memory.TranslateAddress((int)translatePageIndex.Value, (int)translatePageOffset.Value);
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            primaryMemPicture.Invalidate();
        }
    }
}
