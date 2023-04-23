using DAT.Model.Paged;
using System.Windows.Forms;

namespace DAT.Forms
{
    public partial class PageForm : Form
    {
        private readonly string title = "Страница #{0}";

        public PageForm()
        {
            InitializeComponent();
        }

        public void SetData(Page page, int pageSize)
        {
            this.Text = string.Format(title, page.Id);
        }
    }
}
