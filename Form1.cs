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

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            //將douCM的數值除以100，也就是從公分轉換成公尺
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM; //宣告一個double變數，變數名稱叫douCM

            douM = Convert.ToDouble(txtM.Text); //從txtM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douM / 0.01);
            //將douCM的數值除以100，也就是從公分轉換成公尺
        }
    }
}
