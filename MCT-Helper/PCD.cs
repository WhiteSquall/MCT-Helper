using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCT_Helper
{
    public partial class fPCD : Form
    {
        public fPCD()
        {
            InitializeComponent();
        }

        private void bCalculating_Click(object sender, EventArgs e)
        {
            if (tPCD.Text == "")
            {
                Console.Beep(500, 200);
                MessageBox.Show("PCD를 입력하세요.");
                return;
            }

            if (Convert.ToDouble(tPCD.Text) < 0)
            {
                Console.Beep(500, 200);
                MessageBox.Show("PCD를 다시 확인하고 입력하세요.");
                return;
            }
            
            if (tHoleQty.Text == "")
            {
                Console.Beep(500, 200);
                MessageBox.Show("홀 수량을 입력하세요.");
                return;
            }

            if (Convert.ToInt16(tHoleQty.Text) < 2)
            {
                Console.Beep(500, 200);
                MessageBox.Show("홀 수량을 다시 확인하고 입력하세요.");
                return;
            }

            if (tStartAngle.Text == "")
            {
                chHalfAngle.Checked = true;
            }

            if (chHalfAngle.Checked == true)
            {
                tStartAngle.Enabled = false;
                tStartAngle.Text = Convert.ToString(360 / Convert.ToDouble(tHoleQty.Text) / 2);
            }
            else
            {
                tStartAngle.Enabled = true;
            }

            fPrintPCD printData = new fPrintPCD();
            printData.Owner = this;

            printData.mPCD = tPCD.Text;
            printData.mStartAngle = tStartAngle.Text;
            printData.mHoleQty = tHoleQty.Text;
            printData.chHalfAngle = chHalfAngle.Checked;

            printData.ShowDialog();
        }

        private void tPCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tPCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == true)
                return;

            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '.')
            {
                int iDot = tPCD.Text.IndexOf('.');

                if (iDot != -1)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (tPCD.Text.Substring(iDot + 1).Length == 3)
                            e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tHoleQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tHoleQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tStartAngle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tStartAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == true)
                return;

            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '.')
            {
                int iDot = tStartAngle.Text.IndexOf('.');

                if (iDot != -1)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (tStartAngle.Text.Substring(iDot + 1).Length == 3)
                            e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void chHalfAngle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void chHalfAngle_CheckedChanged(object sender, EventArgs e)
        {
            tStartAngle.Enabled = (chHalfAngle.Checked == true ? false : true);
        }
    }
}
