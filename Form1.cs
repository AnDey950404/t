using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
            
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;

            if(double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 100);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 10000);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 2.54);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 30.48);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }

        private void caculateAnswer(int 變數1, double 變數2)
        {
            if (變數1 != 0)
                txtCM.Text = string.Format("{0:0.##########}", 變數2);
            if (變數1 != 1)
                txtM.Text = string.Format("{0:0.##########}", 變數2 / 100);
            if (變數1 != 2)
                txtKM.Text = string.Format("{0:0.##########}", 變數2 / 100000);
            if (變數1 != 3)
                txtIn.Text = string.Format("{0:0.##########}", 變數2 / 2.54);
            if (變數1 != 4)
                txtFt.Text = string.Format("{0:0.##########}", 變數2 / 30.48);
            if (變數1 != 5)
                txtYard.Text = string.Format("{0:0.##########}", 變數2 / 91.44);
        }
    }
}
