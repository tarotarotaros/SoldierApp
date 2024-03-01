using DataSoldier.UI;
using Domain.Model.Raw;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DataSoldier
{

    public interface ISelectorView
    {
        event EventHandler OKClicked;
        event EventHandler CancelClicked;
        void CloseView();
        string Title { set; }
        Dictionary<string, string> SelectItems { set; }
    }

    public partial class SelectorView : DesignedViewBase, ISelectorView
    {
        public string Title { set => this.Text = value; }
        public Dictionary<string, string> SelectItems
        {
            set
            {
                this.SelectDataGrid.Columns.Add("ID", "ID");
                this.SelectDataGrid.Columns.Add("値", "値");

                foreach (var item in value) 
                {
                    var index = this.SelectDataGrid.Rows.Add();



                    this.SelectDataGrid[0, index].Value = item.Key;
                    this.SelectDataGrid[1, index].Value = item.Value;
                }

            }
        }

        public event EventHandler OKClicked;
        public event EventHandler CancelClicked;

        public SelectorView()
        {
            InitializeComponent();


        }

        public void CloseView()
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelClicked(this, new EventArgs());
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            OKClicked(this, new EventArgs());
        }
    }
}
