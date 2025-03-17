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
            double douCM; //宣告一個double變數，變數名稱叫douCM
            {

                strInput = txtCM.Text;

                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtM.Text = string.Format("{0:0.##########}", douOutput / 100);//公尺
                    txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);//公里
                    txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);//英吋
                    txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);//英呎
                    txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);//碼
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                    txtInfo.Text = "請輸入數字";
                    txtCM.Text = "";
                }
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM; //宣告一個double變數，變數名稱叫douM
            {
                strInput = txtM.Text;

                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtCM.Text = string.Format("{0:0.##########}", douOutput / 0.01);//公分
                    txtKM.Text = string.Format("{0:0.##########}", douOutput / 1000);//公里
                    txtIn.Text = string.Format("{0:0.##########}", douOutput / 0.0254);//英吋
                    txtFt.Text = string.Format("{0:0.##########}", douOutput / 0.3048);//英呎
                    txtYard.Text = string.Format("{0:0.##########}", douOutput / 0.9144);//碼
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                    txtInfo.Text = "請輸入數字";
                    txtM.Text = "";
                }
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM; //宣告一個double變數，變數名稱叫douKM
            {
                strInput = txtKM.Text;

                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtCM.Text = string.Format("{0:0.##########}", douOutput / 0.00001);//公分
                    txtM.Text = string.Format("{0:0.##########}", douOutput / 0.001);//公尺
                    txtIn.Text = string.Format("{0:0.##########}", douOutput / 0.0000254);//英吋
                    txtFt.Text = string.Format("{0:0.##########}", douOutput / 0.0003048);//英呎
                    txtYard.Text = string.Format("{0:0.##########}", douOutput / 0.0009144);//碼
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                    txtInfo.Text = "請輸入數字";
                    txtKM.Text = "";
                }
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn; //宣告一個double變數，變數名稱叫douIn
            {
                strInput = txtIn.Text;

                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);//公分
                    txtM.Text = string.Format("{0:0.##########}", douOutput * 0.0254);//公尺
                    txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0000254);//公里
                    txtFt.Text = string.Format("{0:0.##########}", douOutput * 0.0833);//英呎
                    txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.0278);//碼
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                    txtInfo.Text = "請輸入數字";
                    txtIn.Text = "";
                }
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt; //宣告一個double變數，變數名稱叫douFt
            {
                strInput = txtFt.Text;

                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtCM.Text = string.Format("{0:0.##########}", douOutput * 30.48);//公分
                    txtM.Text = string.Format("{0:0.##########}", douOutput * 0.3048);//公尺
                    txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0003048);//公里
                    txtIn.Text = string.Format("{0:0.##########}", douOutput * 12);//英吋
                    txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.3333);//碼
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                    txtInfo.Text = "請輸入數字";
                    txtFt.Text = "";
                }
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard; //宣告一個double變數，變數名稱叫douYard
            {
                strInput = txtYard.Text;

                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtCM.Text = string.Format("{0:0.##########}", douOutput * 91.44);//公分
                    txtM.Text = string.Format("{0:0.##########}", douOutput * 0.9144);//公尺
                    txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0009144);//公里
                    txtIn.Text = string.Format("{0:0.##########}", douOutput * 36);//英吋
                    txtFt.Text = string.Format("{0:0.##########}", douOutput * 3);//英呎
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                    txtInfo.Text = "請輸入數字";
                    txtYard.Text = "";
                }
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
    }
}
