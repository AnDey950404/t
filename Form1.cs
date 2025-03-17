﻿using System;
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

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn; //宣告一個double變數，變數名稱叫douIn

            douIn = Convert.ToDouble(txtIn.Text); //從txtIn輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);//公分
            txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);//公尺
            txtKM.Text = string.Format("{0:0.##########}", douIn * 0.0000254);//公里
            txtFt.Text = string.Format("{0:0.##########}", douIn * 0.0833);//英呎
            txtYard.Text = string.Format("{0:0.##########}", douIn * 0.0278);//碼
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt; //宣告一個double變數，變數名稱叫douFt

            douFt = Convert.ToDouble(txtFt.Text); //從txtFt輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);//公分
            txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);//公尺
            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0003048);//公里
            txtIn.Text = string.Format("{0:0.##########}", douFt * 12);//英吋
            txtYard.Text = string.Format("{0:0.##########}", douFt * 0.3333);//碼
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard; //宣告一個double變數，變數名稱叫douYard

            douYard = Convert.ToDouble(txtYard.Text); //從txtYard輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);//公分
            txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);//公尺
            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);//公里
            txtIn.Text = string.Format("{0:0.##########}", douYard * 36);//英吋
            txtFt.Text = string.Format("{0:0.##########}", douYard * 3);//英呎
        }
    }
}
