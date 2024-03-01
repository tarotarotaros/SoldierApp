using MaterialSkin;
using MaterialSkin.Controls;

namespace DataSoldier
{

    public interface ISelectorView
    {
        event EventHandler OKClicked;
        event EventHandler CancelClicked;
        void CloseView();
    }

    public partial class SelectorView : MaterialForm, ISelectorView
    {
        public event EventHandler OKClicked;
        public event EventHandler CancelClicked;

        public SelectorView()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        public void CloseView()
        {
            this.Close();
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            CancelClicked(this, new EventArgs());
        }

        private void OKButton_Click_1(object sender, EventArgs e)
        {
            OKClicked(this, new EventArgs());
        }
    }
}
