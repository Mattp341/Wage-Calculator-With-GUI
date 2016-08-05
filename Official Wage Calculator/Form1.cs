using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Official_Wage_Calculator
{
    public partial class Form1 : Form
    { 
        double monHours;        double monOT;
        double tuesHours;       double tuesOT;
        double wedHours;        double wedOT;
        double thursHours;      double thursOT;
        double friHours;        double friOT;
        double satHours;        double satOT;
        double sunHours;        double sunOT;
        double wage;            double wageOT;
        double totalHours;      double totalOTHours;
        double totalGenProfit;  double totalOTProfit;

        double totalProfit;
        
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void btn_OneWeek_Click(object sender, EventArgs e)
        {
            //set variable values for each box
            monHours = Convert.ToDouble(txt_MonHours.Text);
            tuesHours = Convert.ToDouble(txt_TuesHours.Text);
            wedHours = Convert.ToDouble(txt_WedHours.Text);
            thursHours = Convert.ToDouble(txt_ThursHours.Text);
            friHours = Convert.ToDouble(txt_FriHours.Text);
            satHours = Convert.ToDouble(txt_SatHours.Text);
            sunHours = Convert.ToDouble(txt_SunHours.Text);
            //wage is calculated for after taxes
            wage = Convert.ToDouble(txt_Wage.Text) * 0.825;
            wageOT = (wage / 2) + wage;
            //check for overtime each day
            //monday
            if (monHours > 8)
            {
                monOT = monHours - 8;
                monHours = 8;
            }
            //tuesday
            if (tuesHours > 8)
            {
                tuesOT = tuesHours - 8;
                tuesHours = 8;
            }
            //wednesday
            if (wedHours > 8)
            {
                wedOT = wedHours - 8;
                wedHours = 8;
            }
            //thursday
            if (thursHours > 8)
            {
                thursOT = thursHours - 8;
                thursHours = 8;
            }
            //friday
            if (friHours > 8)
            {
                friOT = friHours - 8;
                friHours = 8;
            }
            //saturday
            if (satHours > 8)
            {
                satOT = satHours - 8;
                satHours = 8;
            }
            //sunday
            if (sunHours > 8)
            {
                sunOT = sunHours - 8;
                sunHours = 8;
            }
            //get hour count (general hours)
            totalHours = monHours + tuesHours + wedHours + thursHours + friHours + satHours + sunHours;
            //multiply each days hour count by the wage (general hours)
            totalGenProfit = (monHours * wage) + (tuesHours * wage) + (wedHours * wage) + (thursHours * wage) + (friHours * wage) + (satHours * wage) + (sunHours * wage);
           
            //calculate total overtime hours (ot hours)
            totalOTHours = monOT + tuesOT + wedOT + thursOT + friOT + satOT + sunOT;
            //multiply each days hour count by the wage (ot hours)
            totalOTProfit = (monOT * wageOT) + (tuesOT * wageOT) + (wedOT * wageOT) + (thursOT * wageOT) + (friOT * wageOT) + (satOT * wageOT) + (sunOT * wageOT);

            //add the two money amounts 
            totalProfit = totalGenProfit + totalOTProfit;
            //Show the results
            MessageBox.Show(@"Your total hour count is: " + totalHours +
                            "\nYour total overtime hour count is: " + totalOTHours +
                            "\nYour total money made is: " + totalProfit);
            

        }

        

        //all of the following code just makes the text boxes only take in numbers
        /*******************************************************************************/
        //Monday Hours 
        private void txt_MonHours_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Tuesday Hours
        private void txt_TuesHours_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Wednesday Hours
        private void txt_WedHours_TextChanged(object sender, EventArgs e)
        {
           
        }
        //Thursday Hours
        private void txt_ThursHours_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Friday Hours
        private void txt_FriHours_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Saturday Hours
        private void txt_SatHours_TextChanged(object sender, EventArgs e)
        {
           
        }
        //Sunday Hours
        private void txt_SunHours_TextChanged(object sender, EventArgs e)
        {
           
        }
        //Wage Box (Before Tax)
        private void txt_Wage_TextChanged(object sender, EventArgs e)
        {
            
        }
        //this switches to form 2
        


        /*********************************************************************************/
    }
}
