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
            OKButton = new MaterialSkin.Controls.MaterialRaisedButton();
            materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.AutoSize = true;
            OKButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OKButton.Depth = 0;
            OKButton.Icon = null;
            OKButton.Location = new Point(479, 258);
            OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            OKButton.Name = "OKButton";
            OKButton.Primary = true;
            OKButton.Size = new Size(39, 36);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click_1;
            // 
            // materialRaisedButton1
            // 
            materialRaisedButton1.AutoSize = true;
            materialRaisedButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialRaisedButton1.Depth = 0;
            materialRaisedButton1.Icon = null;
            materialRaisedButton1.Location = new Point(583, 258);
            materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRaisedButton1.Name = "materialRaisedButton1";
            materialRaisedButton1.Primary = true;
            materialRaisedButton1.Size = new Size(79, 36);
            materialRaisedButton1.TabIndex = 1;
            materialRaisedButton1.Text = "キャンセル";
            materialRaisedButton1.UseVisualStyleBackColor = true;
            materialRaisedButton1.Click += CancelButton1_Click;
            // 
            // SelectorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialRaisedButton1);
            Controls.Add(OKButton);
            Name = "SelectorView";
            Text = "SelectorViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton OKButton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}