using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoStore
{
    public partial class LogoItemOrderForm : Form
    {
        public LogoItemOrderForm()
        {
            InitializeComponent();
        }

        private void LogoItemOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Action <Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }

        private void cbxLogo_CheckedChanged(object sender, EventArgs e)
        {
            txbNumColors.Visible = cbxLogo.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Get item type from user
            string itemType = "mug";
            if (rbUsb.Checked)
            {
                itemType = rbUsb.Text;
            }
            else if (rbMug.Checked)
            {
                itemType = rbMug.Text;
            }
            else if (rbPen.Checked)
            {
                itemType = rbPen.Text;
            }

            //Instantiate an Order
            LogoOrderItem order = new LogoOrderItem(Convert.ToInt32(txbOrderNum.Text),
                                     Convert.ToInt32(txbNumItems.Text),
                                     itemType,
                                     cbxLogo.Checked,
                                     Convert.ToInt32(txbNumColors.Text),
                                     txbEngraveText.Text);

            //Checks if logo checkbox is checked
            int count = 0;
            if (cbxLogo.Checked)
            {
                count++;
            }
            string[] colorNum = new string[count];

            int index = 0;
            if (cbxLogo.Checked)
            {
                colorNum[index] = cbxLogo.Text;
            }

            //Set new arrays into object
            order.

            //Display output
            string summary =
                "Order Number: " + order.ItemID +
                "\nNumber of Items: " + order.numItems +
                "\nItem Type: " + order.itemType +
                "\nHas Logo: " + order.hasLogo +
                "\nNumber of Colors: " + order.numColors;
            foreach (string result in results)
            {
                summary += "\n" + order;
            }
            txbResults.Text = summary;
        }

        private void txbOrderNum_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(txbOrderNum.Text);
        }

        private void txbNumItems_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(txbNumItems.Text);
        }

        private void txbNumColors_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(txbNumColors.Text);
        }

        private void txbResults_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
