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
    public partial class Form1 : DesignedViewBase
    {

        /// <summary>
        /// https://elaws.e-gov.go.jp/apitop/
        /// https://elaws.e-gov.go.jp/file/houreiapi_shiyosyo.pdf
        /// </summary>
        public Form1()
        {
            InitializeComponent();


            var rawAPI = new RawDataRepository();

            var rawType = new RawTypeValue(@RawType.r1_全法令);
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
            var rawAPI = new RawDataRepository();

            var rawType = new RawTypeValue(@RawType.r1_全法令);
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

            var selectDict = rawList.ToDictionary(x => x.ID, x => x.Name);

            var v = new SelectorView();
            var p = new SelectorPresenter(v, "法律選択", selectDict);


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