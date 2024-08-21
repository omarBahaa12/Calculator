using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            
        }

        clsCalculator Calc1= new clsCalculator();

        
        private void Clear_Lb_Result()
        {
            if (Lb_Result.Text == "0")
            {
                Lb_Result.Text = "";
                return;
            }
            if (Lb_Result.Tag!=null) 
            {
                Lb_Result.Text = "";
                return;
            }
        }

        private void Negative()
        {
            Lb_Result.Text =Convert.ToString(-1*(Convert.ToInt32(Lb_Result.Text)));
            
        }
        
        private string Show_Sign()
        {
           
            string s1 = Calc1.Get_Sign();
            return Lb_Result.Tag+ s1;

        }
        

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Lb_Result.Text = Convert.ToString(Convert.ToInt32(Lb_Result.Text) / 10);
        }

        private void Btn_ClearE_Click(object sender, EventArgs e)
        {
            Lb_Result.Text = "0";
        }

        private void Btn_One_Click(object sender, EventArgs e)
        {
            
            Clear_Lb_Result();
            Lb_Result.Text += "1";
            Lb_Result.Tag =null ;
            
        }

        private void Btn_Two_Click(object sender, EventArgs e)
        {
            
            Clear_Lb_Result();
            Lb_Result.Text += "2";
            Lb_Result.Tag =null;

        }

        private void Btn_Three_Click(object sender, EventArgs e)
        {
            
            Clear_Lb_Result();
            Lb_Result.Text += "3";
            Lb_Result.Tag = null;
            
        }

        private void Btn_Four_Click(object sender, EventArgs e)
        {
            
            Clear_Lb_Result();
            Lb_Result.Text += "4";
            Lb_Result.Tag = null;
            
            
        }

        private void Btn_Five_Click(object sender, EventArgs e)
        {
            
            Clear_Lb_Result();
            Lb_Result.Text += "5";
            Lb_Result.Tag = null;           
            
        }

        private void Btn_Six_Click(object sender, EventArgs e)
        {
            
            Clear_Lb_Result();
            Lb_Result.Text += "6";
            Lb_Result.Tag = null;           
        }

        private void Btn_Seven_Click(object sender, EventArgs e)
        {
            
            Clear_Lb_Result();
            Lb_Result.Text += "7";
            Lb_Result.Text = null;                      
        }

        private void Btn_Eight_Click(object sender, EventArgs e)
        {
            
            Clear_Lb_Result();
            Lb_Result.Text+="8";
            Lb_Result.Tag = null;
           
        }

        private void Btn_Nine_Click(object sender, EventArgs e)
        {
            Clear_Lb_Result();
            Lb_Result.Text+="9";
            Lb_Result.Tag = null;                       
        }

        private void Btn_Zero_Click(object sender, EventArgs e)
        {
            Clear_Lb_Result();
            Lb_Result.Text+="0";
            Lb_Result.Tag = null;                    
        }

        private void Btn_Float_Click(object sender, EventArgs e)
        {
            Clear_Lb_Result();
            Lb_Result.Text+=".";
            Lb_Result.Tag = null;
            
        }

        private void Btn_Nagetive_Click(object sender, EventArgs e)
        {
            Negative();
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            Lb_Result.Tag = Lb_Result.Text;
            Calc1.Num1 = Convert.ToSingle(Lb_Result.Tag);
            Calc1.Operation = clsCalculator.enOreration._Add;
            Lb_Show.Text=Show_Sign();  
  
        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            Lb_Result.Tag = Lb_Result.Text;
            Calc1.Num1 = Convert.ToSingle(Lb_Result.Tag);
            Calc1.Operation = clsCalculator.enOreration._Minus;
            Lb_Show.Text = Show_Sign();          
            
        }

        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            Lb_Result.Tag = Lb_Result.Text;
            Calc1.Num1 = Convert.ToSingle(Lb_Result.Tag);
            Calc1.Operation = clsCalculator.enOreration._Divide;
            Lb_Show.Text = Show_Sign();
            
        }

        private void Btn_Mulity_Click(object sender, EventArgs e)
        {
            Lb_Result.Tag = Lb_Result.Text;
            Calc1.Num1 = Convert.ToSingle(Lb_Result.Tag);
            Calc1.Operation = clsCalculator.enOreration._Multy;
            Lb_Show.Text = Show_Sign();            
            
        }

        private void Get_Result()
        {
            if(Calc1.Operation==clsCalculator.enOreration._Divide||Calc1.Operation==clsCalculator.enOreration.Breakage &&Calc1.Num2==0)
            {
                Lb_Result.Text = "Cannot Divide by Zero";
                return;
            }
            Lb_Show.Text = Calc1.StrResult();
            Lb_Result.Text = Convert.ToString(Calc1.Result());

        }

        private void Btn_Eual_Click(object sender, EventArgs e)
        {
            Calc1.Num2=Convert.ToSingle(Lb_Result.Text);
            Get_Result();

        }

        

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Calc1.Clear();
            Lb_Result.Text = "0";
            Lb_Show.Text = "";
            Lb_Result.Tag = null;
        }

        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            Calc1.Num1 = Convert.ToSingle(Lb_Result.Text);
            Calc1.Num2 = 100;
            Calc1.Operation = clsCalculator.enOreration._Mod;
            Lb_Show.Text=Calc1.Num1 + "%" ;
            Lb_Result.Text = Convert.ToString(Calc1.Result());
        }

        private void Btn_Root_Click(object sender, EventArgs e)
        {
            Calc1.Num1=2;
            Calc1.Num2 = Convert.ToSingle(Lb_Result.Text);
            Calc1.Operation = clsCalculator.enOreration._Sqr;
            Get_Result();
        }

        private void Btn_Pow_Click(object sender, EventArgs e)
        {
            Calc1.Num1=Convert.ToSingle( Lb_Result.Text);
            Calc1.Num2 = 2;
            Calc1.Operation = clsCalculator.enOreration._Pow;
            Get_Result();
        }

        private void Btn_Breakage_Click(object sender, EventArgs e)
        {
            Calc1.Num1 = 1;
            Calc1.Num2 = Convert.ToSingle( Lb_Result.Text);
            Calc1.Operation = clsCalculator.enOreration.Breakage;
            Get_Result();

        }

        
    }
}
