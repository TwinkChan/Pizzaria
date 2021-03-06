using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaria
{
    public partial class FormOrder : Form
    {
        double cost = 0;
        double discount = 0;
        double result;
        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за заказ!", "Заказ", MessageBoxButtons.OK);
            Close();
        }

        #region food
        private void checkBoxPiperoni_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPiperoni.Checked == true)
            {
                cost = cost + 324;
            }
            else
            {
                cost = cost - 324;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxMargarita_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMargarita.Checked == true)
            {
                cost = cost + 199;
            }
            else
            {
                cost = cost - 199;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxKorbanara_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKorbanara.Checked == true)
            {
                cost = cost + 379;
            }
            else
            {
                cost = cost - 379;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBox4cheese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4cheese.Checked == true)
            {
                cost = cost + 418;
            }
            else
            {
                cost = cost - 418;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxSicilia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSicilia.Checked == true)
            {
                cost = cost + 249;
            }
            else
            {
                cost = cost - 249;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }
        #endregion
        
        #region drink
        private void checkBoxCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSicilia.Checked == true)
            {
                cost = cost + 119;
            }
            else
            {
                cost = cost - 119;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSicilia.Checked == true)
            {
                cost = cost + 115;
            }
            else
            {
                cost = cost - 115;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxFanta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSicilia.Checked == true)
            {
                cost = cost + 119;
            }
            else
            {
                cost = cost - 119;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSicilia.Checked == true)
            {
                cost = cost + 99;
            }
            else
            {
                cost = cost - 99;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }
        #endregion

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            discount = 0 + Convert.ToDouble(textBoxDiscount.Text);
            result = discount / 100.0;
            result = cost * result;
            result = cost - result;
            textBoxSummDiscount.Text = Convert.ToString(result);
        }

        #region Special

        private void checkBoxSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpecial.Checked == true)
            {
                cost = cost + 748;
            }
            else
            {
                cost = cost - 748;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxSpecial2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpecial2.Checked == true)
            {
                cost = cost + 520;
            }
            else
            {
                cost = cost - 520;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxSpecial3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSicilia.Checked == true)
            {
                cost = cost + 510;
            }
            else
            {
                cost = cost - 510;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }

        private void checkBoxSpecial4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSicilia.Checked == true)
            {
                cost = cost + 179;
            }
            else
            {
                cost = cost - 179;
            }
            textBoxSumm.Text = Convert.ToString(cost);
        }
        #endregion
    }
}
