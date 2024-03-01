namespace DataSoldier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DisplayDataGridView = new DataGridView();
            SelectRawButton = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)DisplayDataGridView).BeginInit();
            SuspendLayout();
            // 
            // DisplayDataGridView
            // 
            DisplayDataGridView.AllowUserToAddRows = false;
            DisplayDataGridView.AllowUserToDeleteRows = false;
            DisplayDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DisplayDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            DisplayDataGridView.BackgroundColor = Color.White;
            DisplayDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisplayDataGridView.Dock = DockStyle.Bottom;
            DisplayDataGridView.GridColor = Color.Black;
            DisplayDataGridView.Location = new Point(10, 231);
            DisplayDataGridView.MultiSelect = false;
            DisplayDataGridView.Name = "DisplayDataGridView";
            DisplayDataGridView.ReadOnly = true;
            DisplayDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            DisplayDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DisplayDataGridView.RowTemplate.Height = 25;
            DisplayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DisplayDataGridView.Size = new Size(1410, 604);
            DisplayDataGridView.TabIndex = 2;
            // 
            // SelectRawButton
            // 
            SelectRawButton.AutoSize = true;
            SelectRawButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectRawButton.Depth = 0;
            SelectRawButton.Icon = null;
            SelectRawButton.Location = new Point(50, 134);
            SelectRawButton.Margin = new Padding(4, 6, 4, 6);
            SelectRawButton.MouseState = MaterialSkin.MouseState.HOVER;
            SelectRawButton.Name = "SelectRawButton";
            SelectRawButton.Primary = false;
            SelectRawButton.Size = new Size(51, 36);
            SelectRawButton.TabIndex = 3;
            SelectRawButton.Text = "選択";
            SelectRawButton.UseVisualStyleBackColor = true;
            SelectRawButton.Click += SelectRawButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 845);
            Controls.Add(SelectRawButton);
            Controls.Add(DisplayDataGridView);
            Font = new Font("BIZ UDゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Padding = new Padding(10, 100, 10, 10);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DisplayDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialListView RawNameListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DataGridView DisplayDataGridView;
        private MaterialSkin.Controls.MaterialFlatButton SelectRawButton;
    }
}