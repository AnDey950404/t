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

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM

            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);//公尺
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);//公里
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);//英吋
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);//英呎
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);//碼
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM; //宣告一個double變數，變數名稱叫douM

            douM = Convert.ToDouble(txtM.Text); //從txtM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douM / 0.01);//公分
            txtKM.Text = string.Format("{0:0.##########}", douM / 1000);//公里
            txtIn.Text = string.Format("{0:0.##########}", douM / 0.0254);//英吋
            txtFt.Text = string.Format("{0:0.##########}", douM / 0.3048);//英呎
            txtYard.Text = string.Format("{0:0.##########}", douM / 0.9144);//碼
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM; //宣告一個double變數，變數名稱叫douKM

            douKM = Convert.ToDouble(txtKM.Text); //從txtKM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douKM / 0.00001);//公分
            txtM.Text = string.Format("{0:0.##########}", douKM / 0.001);//公尺
            txtIn.Text = string.Format("{0:0.##########}", douKM / 0.0000254);//英吋
            txtFt.Text = string.Format("{0:0.##########}", douKM / 0.0003048);//英呎
            txtYard.Text = string.Format("{0:0.##########}", douKM / 0.0009144);//碼
        }
    }
}
