using DataSoldier.UI;
using Domain.Model.Raw;
using Infrastructure;
using Infrastructure.Repository;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataSoldier
{
    public partial class Form1 : MaterialForm
    {

        /// <summary>
        /// https://elaws.e-gov.go.jp/apitop/
        /// https://elaws.e-gov.go.jp/file/houreiapi_shiyosyo.pdf
        /// </summary>
        public Form1()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);



            var rawAPI = new RawDataRepository();

            var rawType = new RawTypeValue(RawType.r1_‘S–@—ß);
            var rawListXMLText = rawAPI.GetRawList(rawType.ToCodeValue());

            var rawListXML = XDocument.Parse(rawListXMLText);
            var rawList = rawListXML.Descendants("LawNameListInfo").ToList().Select(x =>
            {
                return new RawName(x.Element("LawId").Value,
                                   x.Element("LawName").Value,
                                   x.Element("LawNo").Value,
                                   x.Element("PromulgationDate").Value
                                   );
            }).ToList();

            var tableColumnDefinitionArray = RawNameTableDefinition.ColumnNameArray;

            int colIndex = 0;
            foreach (var colDef in tableColumnDefinitionArray)
            {
                this.DisplayDataGridView.Columns.Add(colDef, RawNameTableDefinition.ColumnJPNameArray[colIndex]);
                colIndex++;
            }

            this.DisplayDataGridView.Rows.Add(rawList.Count);

            int index = 0;
            foreach (RawName g in rawList)
            {
                DisplayDataGridView[0, index].Value = g.ID;
                DisplayDataGridView[1, index].Value = g.Name;
                DisplayDataGridView[2, index].Value = g.Number;
                DisplayDataGridView[3, index].Value = g.PromuigationDate;
                index++;
            }



        }

        private void SelectRawButton_Click(object sender, EventArgs e)
        {
            var v = new SelectorView();
            var p = new SelectorPresenter(v);


            try
            {
                v.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Debug.Print(p.SelectResult.SelectedText);
            }
        }
    }

}