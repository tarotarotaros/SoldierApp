using System.Windows.Forms;

namespace DataSoldier.UI.Control
{
    internal class CommonDataGrid : DataGridView
    {
        /// <summary>
        /// https://qiita.com/OhiKazuma/items/798b9c0a607edf78381b
        /// </summary>
        public CommonDataGrid()
        {
            base.BackgroundColor = Color.White;

            base.ReadOnly = true;                      //読取専用
            base.AllowUserToDeleteRows = false;        //行削除禁止
            base.AllowUserToAddRows = false;           //行挿入禁止
            base.AllowUserToResizeRows = false;        //行の高さ変更禁止
            base.RowHeadersVisible = false;            //行ヘッダーを非表示にする
            base.MultiSelect = false;                  //セル、行、列が複数選択禁止

            base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            this.ColumnHeadersVisible = false;

            base.EnableHeadersVisualStyles = false;     // Visualスタイルを使用しない
            base.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            base.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("BIZUD Gothic", 9);
            base.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            base.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            base.ColumnHeadersHeight = 30;

        }


        public void AddRow()
        {
            //base.Rows.Add();
            //base[]
        }
    }
}
