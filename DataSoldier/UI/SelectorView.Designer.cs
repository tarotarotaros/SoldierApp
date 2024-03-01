namespace DataSoldier
{
    partial class SelectorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            OKButton = new MaterialSkin.Controls.MaterialRaisedButton();
            CancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            SelectDataGrid = new UI.Control.CommonDataGrid();
            ((System.ComponentModel.ISupportInitialize)SelectDataGrid).BeginInit();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OKButton.Depth = 0;
            OKButton.Font = new Font("BIZ UDゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OKButton.Icon = null;
            OKButton.Location = new Point(638, 487);
            OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            OKButton.Name = "OKButton";
            OKButton.Primary = true;
            OKButton.Size = new Size(180, 40);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.Depth = 0;
            CancelButton.Font = new Font("BIZ UDゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Icon = null;
            CancelButton.Location = new Point(824, 487);
            CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            CancelButton.Name = "CancelButton";
            CancelButton.Primary = true;
            CancelButton.Size = new Size(180, 40);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "キャンセル";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SelectDataGrid
            // 
            SelectDataGrid.AllowUserToAddRows = false;
            SelectDataGrid.AllowUserToDeleteRows = false;
            SelectDataGrid.AllowUserToResizeRows = false;
            SelectDataGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SelectDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SelectDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelectDataGrid.EnableHeadersVisualStyles = false;
            SelectDataGrid.Location = new Point(12, 74);
            SelectDataGrid.MultiSelect = false;
            SelectDataGrid.Name = "SelectDataGrid";
            SelectDataGrid.ReadOnly = true;
            SelectDataGrid.RowHeadersVisible = false;
            SelectDataGrid.RowTemplate.Height = 25;
            SelectDataGrid.Size = new Size(992, 407);
            SelectDataGrid.TabIndex = 2;
            // 
            // SelectorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 539);
            Controls.Add(SelectDataGrid);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectorView";
            Text = "SelectorViewForm";
            ((System.ComponentModel.ISupportInitialize)SelectDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton OKButton;
        private MaterialSkin.Controls.MaterialRaisedButton CancelButton;
        private UI.Control.CommonDataGrid SelectDataGrid;
    }
}