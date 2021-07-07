
namespace LogoStore
{
    partial class LogoItemOrderForm
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
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.grpBoxItemType = new System.Windows.Forms.GroupBox();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbMug = new System.Windows.Forms.RadioButton();
            this.rbUsb = new System.Windows.Forms.RadioButton();
            this.txbOrderNum = new System.Windows.Forms.TextBox();
            this.txbNumItems = new System.Windows.Forms.TextBox();
            this.lblTextEngrave = new System.Windows.Forms.Label();
            this.txbEngraveText = new System.Windows.Forms.TextBox();
            this.cbxLogo = new System.Windows.Forms.CheckBox();
            this.lblNumColors = new System.Windows.Forms.Label();
            this.txbNumColors = new System.Windows.Forms.TextBox();
            this.txbResults = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(45, 27);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(73, 13);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "Order Number";
            // 
            // lblNumItems
            // 
            this.lblNumItems.AutoSize = true;
            this.lblNumItems.Location = new System.Drawing.Point(45, 53);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(84, 13);
            this.lblNumItems.TabIndex = 1;
            this.lblNumItems.Text = "Number of Items";
            // 
            // grpBoxItemType
            // 
            this.grpBoxItemType.Controls.Add(this.rbPen);
            this.grpBoxItemType.Controls.Add(this.rbMug);
            this.grpBoxItemType.Controls.Add(this.rbUsb);
            this.grpBoxItemType.Location = new System.Drawing.Point(149, 76);
            this.grpBoxItemType.Name = "grpBoxItemType";
            this.grpBoxItemType.Size = new System.Drawing.Size(230, 100);
            this.grpBoxItemType.TabIndex = 2;
            this.grpBoxItemType.TabStop = false;
            this.grpBoxItemType.Text = "Item Type";
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(21, 65);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(44, 17);
            this.rbPen.TabIndex = 2;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // rbMug
            // 
            this.rbMug.AutoSize = true;
            this.rbMug.Location = new System.Drawing.Point(21, 42);
            this.rbMug.Name = "rbMug";
            this.rbMug.Size = new System.Drawing.Size(46, 17);
            this.rbMug.TabIndex = 1;
            this.rbMug.TabStop = true;
            this.rbMug.Text = "Mug";
            this.rbMug.UseVisualStyleBackColor = true;
            // 
            // rbUsb
            // 
            this.rbUsb.AutoSize = true;
            this.rbUsb.Location = new System.Drawing.Point(21, 19);
            this.rbUsb.Name = "rbUsb";
            this.rbUsb.Size = new System.Drawing.Size(47, 17);
            this.rbUsb.TabIndex = 0;
            this.rbUsb.TabStop = true;
            this.rbUsb.Text = "USB";
            this.rbUsb.UseVisualStyleBackColor = true;
            // 
            // txbOrderNum
            // 
            this.txbOrderNum.Location = new System.Drawing.Point(149, 24);
            this.txbOrderNum.Name = "txbOrderNum";
            this.txbOrderNum.Size = new System.Drawing.Size(230, 20);
            this.txbOrderNum.TabIndex = 3;
            this.txbOrderNum.TextChanged += new System.EventHandler(this.txbOrderNum_TextChanged);
            // 
            // txbNumItems
            // 
            this.txbNumItems.Location = new System.Drawing.Point(149, 50);
            this.txbNumItems.Name = "txbNumItems";
            this.txbNumItems.Size = new System.Drawing.Size(230, 20);
            this.txbNumItems.TabIndex = 4;
            this.txbNumItems.TextChanged += new System.EventHandler(this.txbNumItems_TextChanged);
            // 
            // lblTextEngrave
            // 
            this.lblTextEngrave.AutoSize = true;
            this.lblTextEngrave.Location = new System.Drawing.Point(45, 201);
            this.lblTextEngrave.Name = "lblTextEngrave";
            this.lblTextEngrave.Size = new System.Drawing.Size(110, 13);
            this.lblTextEngrave.TabIndex = 5;
            this.lblTextEngrave.Text = "Text to engrave/print:";
            // 
            // txbEngraveText
            // 
            this.txbEngraveText.Location = new System.Drawing.Point(48, 217);
            this.txbEngraveText.Multiline = true;
            this.txbEngraveText.Name = "txbEngraveText";
            this.txbEngraveText.Size = new System.Drawing.Size(331, 35);
            this.txbEngraveText.TabIndex = 6;
            // 
            // cbxLogo
            // 
            this.cbxLogo.AutoSize = true;
            this.cbxLogo.Location = new System.Drawing.Point(48, 273);
            this.cbxLogo.Name = "cbxLogo";
            this.cbxLogo.Size = new System.Drawing.Size(56, 17);
            this.cbxLogo.TabIndex = 7;
            this.cbxLogo.Text = "Logo?";
            this.cbxLogo.UseVisualStyleBackColor = true;
            this.cbxLogo.CheckedChanged += new System.EventHandler(this.cbxLogo_CheckedChanged);
            // 
            // lblNumColors
            // 
            this.lblNumColors.AutoSize = true;
            this.lblNumColors.Location = new System.Drawing.Point(123, 274);
            this.lblNumColors.Name = "lblNumColors";
            this.lblNumColors.Size = new System.Drawing.Size(88, 13);
            this.lblNumColors.TabIndex = 8;
            this.lblNumColors.Text = "Number of Colors";
            // 
            // txbNumColors
            // 
            this.txbNumColors.Location = new System.Drawing.Point(235, 271);
            this.txbNumColors.Name = "txbNumColors";
            this.txbNumColors.Size = new System.Drawing.Size(48, 20);
            this.txbNumColors.TabIndex = 9;
            this.txbNumColors.Visible = false;
            this.txbNumColors.TextChanged += new System.EventHandler(this.txbNumColors_TextChanged);
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(48, 363);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.ReadOnly = true;
            this.txbResults.Size = new System.Drawing.Size(331, 69);
            this.txbResults.TabIndex = 10;
            this.txbResults.TextChanged += new System.EventHandler(this.txbResults_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(93, 305);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 39);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(235, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LogoItemOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 444);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbResults);
            this.Controls.Add(this.txbNumColors);
            this.Controls.Add(this.lblNumColors);
            this.Controls.Add(this.cbxLogo);
            this.Controls.Add(this.txbEngraveText);
            this.Controls.Add(this.lblTextEngrave);
            this.Controls.Add(this.txbNumItems);
            this.Controls.Add(this.txbOrderNum);
            this.Controls.Add(this.grpBoxItemType);
            this.Controls.Add(this.lblNumItems);
            this.Controls.Add(this.lblOrderNum);
            this.Name = "LogoItemOrderForm";
            this.Text = "Logo Item Order Form";
            this.Load += new System.EventHandler(this.LogoItemOrderForm_Load);
            this.grpBoxItemType.ResumeLayout(false);
            this.grpBoxItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.GroupBox grpBoxItemType;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbMug;
        private System.Windows.Forms.RadioButton rbUsb;
        private System.Windows.Forms.TextBox txbOrderNum;
        private System.Windows.Forms.TextBox txbNumItems;
        private System.Windows.Forms.Label lblTextEngrave;
        private System.Windows.Forms.TextBox txbEngraveText;
        private System.Windows.Forms.CheckBox cbxLogo;
        private System.Windows.Forms.Label lblNumColors;
        private System.Windows.Forms.TextBox txbNumColors;
        private System.Windows.Forms.TextBox txbResults;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}