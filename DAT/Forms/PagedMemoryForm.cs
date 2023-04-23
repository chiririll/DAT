using System.Windows.Forms;
using DAT.View;
using DAT.Model.Paged;
using System.Linq;

namespace DAT.Forms
{
    public partial class PagedMemoryForm : Form
    {
        private PagedMemory memory;
        private PagedMemoryView memView;

        private PageForm pageForm;

        public PagedMemoryForm()
        {
            InitializeComponent();

            memory = new PagedMemory((int)pageSize.Value, (int)framesCount.Value, (int)memorySize.Value);
            memView = new PagedMemoryView(memory, primaryMemPicture, secondaryMemPicture, this.Font);

            pageForm = new PageForm();
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

                primaryMemPicture.Invalidate();
                
                if (pageForm.IsDisposed)
                    pageForm = new PageForm();

                pageForm.SetData(memory.Primary.ElementAt((int)translatePageIndex.Value), memory.PageSize, (int)translatePageOffset.Value);
                pageForm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            primaryMemPicture.Invalidate();
        }
    }
}
