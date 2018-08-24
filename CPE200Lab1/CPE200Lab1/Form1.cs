using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        float num = 0;
        float numSign = 0;
        float percentNum = 0;
        string Operate = "";
        bool operationClick = false;
        bool PercentClick = false;
        bool signClick = false;
        bool clearClick = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
                if (btn.Text == ".") lblDisplay.Text = "0.";
            }
            if (lblDisplay.Text.Length < 8 && btn.Text != "." )
            {
                lblDisplay.Text = lblDisplay.Text + btn.Text;
            }

        }

        private void Operate_Click(object sender, EventArgs e)
        {
            if (operationClick == false)
            {
                Button btn = (Button)sender;
                Operate = btn.Text;
                num = float.Parse(lblDisplay.Text);
                operationClick = true;
                lblDisplay.Text = "0";
                syn.Text = num + " " + Operate;
            }
            else
            {
                if(lblDisplay.Text == "0") //change operator
                {
                    Button btn = (Button)sender;
                    Operate = btn.Text;
                    syn.Text = num + Operate;
                }
                else //unlimited operate
                {
                    float Num = 0;
                    float sum = 0;
                    string Operation = "";
                    Button btn = (Button)sender;
                    Operation = btn.Text;
                    Num = float.Parse(lblDisplay.Text);
                    sum = num + Num;
                    lblDisplay.Text = "0";

                    if (Operation == "+")
                    {
                        Operate = Operation;
                        sum = (sum + float.Parse(lblDisplay.Text));
                        Operation = "";
                    }
                    else if (Operation == "-")
                    {
                        Operate = Operation;
                        sum = (sum - float.Parse(lblDisplay.Text));
                        Operation = "";
                    }
                    else if (Operation == "X")
                    {
                        Operate = Operation;
                        sum = (sum * float.Parse(lblDisplay.Text));
                        Operation = "";
                    }
                    else if (Operation == "÷")
                    {
                        Operate = Operation;
                        sum = (sum / float.Parse(lblDisplay.Text));
                        Operation = "";
                    }
                    num = sum;
                    syn.Text = num + " " + Operate;
                    
                }
            }
        }
        private void Percent_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            percentNum = float.Parse(lblDisplay.Text)/100;
            PercentClick = true;
            lblDisplay.Text = lblDisplay.Text + "%" ;
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            signClick = true;
            numSign = float.Parse(lblDisplay.Text)*-1;
            lblDisplay.Text = numSign.ToString();
        }

        private void Equa_Click(object sender, EventArgs e)
        {
            syn.Text = "";
            if (PercentClick == true)
            {
                    if (Operate == "+")          lblDisplay.Text = (num + num * percentNum).ToString();
                    else if (Operate == "-")     lblDisplay.Text = (num - num * percentNum).ToString();
                    else if (Operate == "X")     lblDisplay.Text = (num * percentNum).ToString();
                    else if (Operate == "÷")     lblDisplay.Text = (num / percentNum).ToString();
            }
            else
            {
                    if (Operate == "+")         lblDisplay.Text = (num + float.Parse(lblDisplay.Text)).ToString();
                    else if (Operate == "-")    lblDisplay.Text = (num - float.Parse(lblDisplay.Text)).ToString();
                    else if (Operate == "X")    lblDisplay.Text = (num * float.Parse(lblDisplay.Text)).ToString();
                    else if (Operate == "÷")    lblDisplay.Text = (num / float.Parse(lblDisplay.Text)).ToString();
            }
            
            operationClick = false;
            PercentClick = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (clearClick == false)
            {
                lblDisplay.Text = "0";
                clearClick = true;
            }
            else
            {
                syn.Text = "";
                operationClick = false;
                PercentClick = false;
                signClick = false;
                clearClick = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int N = lblDisplay.Text.Length;
            int M = N - 1;
            string a = lblDisplay.Text;
            string[] value = new string[9];
            string[] val = new string[9];
            for (int i = 0 ; i < N ; i++ ) val[i] = a.Substring(i, 1);
            for (int j = 0; j < M; j++) value[j] = val[j];
            lblDisplay.Text = String.Join("", value);
            if (lblDisplay.Text.Length == 0) lblDisplay.Text = "0";
        }
    }
}