using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        double FirstTexboxValue = 0;
        bool firstclickbtnControl = true;
        string lastclickbtnControl = "";
        string lastclickCalcbtnControl = "";

        public Form1()
        {
            InitializeComponent();
        }

        //for numbers button
        private void button7_Click(object sender, EventArgs e)
        {

            Button senderbtn = sender as Button;
            if (lastclickbtnControl == "+" || lastclickbtnControl == "-" || lastclickbtnControl == "*" || lastclickbtnControl == "/"||lastclickbtnControl == "="||lastclickbtnControl == "C")
                {
                      textBox1.Clear();
                }
            lastclickbtnFindMethod(ref lastclickbtnControl, senderbtn);
            textBox1.Text += senderbtn.Text;
           
        }
        //---for calc's button--------------------
        private void button13_Click(object sender, EventArgs e)
        {
            Button senderbtn = sender as Button;
            if (lastclickCalcbtnControl == "+" || firstclickbtnControl==true)
            {
               calcCollection(senderbtn);
            }
            else if (lastclickCalcbtnControl == "-" || firstclickbtnControl==true)
            {
                calcSubtract(senderbtn);
            }
            else if (lastclickCalcbtnControl == "*" || firstclickbtnControl==true)
            {
                calcMultiplie(senderbtn);
            }
            else if (lastclickCalcbtnControl == "/" || firstclickbtnControl==true)
            {
                calcDivide(senderbtn);
            }
             else if (senderbtn.Text == "=" )
            {
                calcEqual(ref firstclickbtnControl, senderbtn);
            }
            else if(senderbtn.Text == "C" )
            {
               calcDoZero(ref  FirstTexboxValue,ref firstclickbtnControl, senderbtn);
            }
            lastclickCalcbtnFindMethod(ref lastclickCalcbtnControl, senderbtn);
            lastclickbtnFindMethod(ref lastclickbtnControl, senderbtn);
            firstclickbtnControlMethod(ref firstclickbtnControl);
        }
        // for save first TexBox1 Text 
        void SaveTextBox(ref double FirstTexboxValue)
        {
            FirstTexboxValue = double.Parse(textBox1.Text);
        }
        void firstclickbtnControlMethod(ref bool firstclickbtnControl)
        {
            if (lastclickbtnControl!="C" )
                firstclickbtnControl = false;
        }
        void lastclickbtnFindMethod(ref string lastclickbtnControl, Button e)
        {
            lastclickbtnControl = e.Text;
        }
        void lastclickCalcbtnFindMethod(ref string lastclickCalcbtnControl, Button e)
        {
            lastclickCalcbtnControl = e.Text;
        }
//*****************************************************************************************************
        void calcCollection(Button senderbtn)
        {
                 if (firstclickbtnControl )
                 {
                     SaveTextBox(ref FirstTexboxValue);
                     textBox1.Text = senderbtn.Text;
                   
                 }
                 else
                 {
                     textBox1.Text = (FirstTexboxValue + double.Parse(textBox1.Text)).ToString();
                     SaveTextBox(ref FirstTexboxValue);
                 }
        }
        void calcSubtract(Button senderbtn)
        {
                if (firstclickbtnControl )
                {
                    SaveTextBox(ref FirstTexboxValue);
                    textBox1.Text = senderbtn.Text;
                  
                }
                else
                {
                    textBox1.Text = (FirstTexboxValue - double.Parse(textBox1.Text)).ToString();
                    SaveTextBox(ref FirstTexboxValue);
                }
        }
        void calcMultiplie(Button senderbtn)
        {
                if (firstclickbtnControl )
                {
                    SaveTextBox(ref FirstTexboxValue);
                    textBox1.Text = senderbtn.Text;
                  
                }
                else
                {
                    textBox1.Text = (FirstTexboxValue * double.Parse(textBox1.Text)).ToString();
                    SaveTextBox(ref FirstTexboxValue);
                }
        }
        void calcDivide(Button senderbtn)
        {
                if (firstclickbtnControl)
                {
                    SaveTextBox(ref FirstTexboxValue);
                    textBox1.Text = senderbtn.Text;
                  
                }
                else
                {
                    textBox1.Text = (FirstTexboxValue / double.Parse(textBox1.Text)).ToString();
                    SaveTextBox(ref FirstTexboxValue);
                }
        }
        void calcEqual(ref bool firstclickbtnControl, Button senderbtn)
        {
            
            SaveTextBox(ref FirstTexboxValue);
            
        }
        void calcDoZero(ref double FirstTexboxValue, ref bool firstclickbtnControl,  Button senderbtn)
        {
            textBox1.Text =String.Empty;
            FirstTexboxValue=0;
            firstclickbtnControl= true;

        }
     //************************************************************************************************
    }
}
