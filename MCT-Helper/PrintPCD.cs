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
    public partial class fPrintPCD : Form
    {
        public string mPCD, mStartAngle, mHoleQty;
        public bool chHalfAngle;

        public fPrintPCD()
        {
            InitializeComponent();
        }

        private void PrintPCD_Load(object sender, EventArgs e)
        {
            string pPCD = null;
            string pNo = null;
            int LoopPCDNumber = 0;

            double RealAngle = 360 / Convert.ToDouble(mHoleQty);
            double RealStartAngle = (chHalfAngle == true ? RealAngle / 2 : Convert.ToDouble(mStartAngle));
            double LengthValue = Convert.ToDouble(mPCD) / 2;

            while (LoopPCDNumber < Convert.ToDouble(mHoleQty))
            {
                double AngleValue = (RealStartAngle + (RealAngle * LoopPCDNumber)) * Math.PI / 180;

                double AxisX = LengthValue * Math.Cos(AngleValue);
                double AxisY = LengthValue * Math.Sin(AngleValue);

                pPCD += "X" + AxisX.ToString("f3") + " Y" + AxisY.ToString("f3") + "\r\n";
                pNo += "N" + (LoopPCDNumber + 1).ToString() + "\r\n";

                LoopPCDNumber++;
            }

            lPCD.Text = "PCD : Ø" + mPCD;
            lHoleQty.Text = "홀 수량 : " + mHoleQty +"ea";
            lStartAngle.Text = "시작 각도 : " + mStartAngle + "°";
            lAngle.Text = "홀간 각도 : " + RealAngle + "°";
            tNo.Text = pNo;
            tPrintData.Text = pPCD;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
