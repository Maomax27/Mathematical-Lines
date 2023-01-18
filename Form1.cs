using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematical_Lines___Mauricio
{
    public partial class formLine : Form
    {
        public formLine()
        {
            InitializeComponent();
        }

        private void formLine_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtfunction.Clear(); //clears text box
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //closes app
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {


                txtfunction.Clear(); //clears text box once user calculates once more

                double XA, YA, XB, YB; //gives name to variables

                XA = Convert.ToDouble(txtXA.Text); //converts numbers input by the user into variables
                YA = Convert.ToDouble(txtYA.Text);
                XB = Convert.ToDouble(txtXB.Text);
                YB = Convert.ToDouble(txtYB.Text);

                double slope = (YB - YA) / (XB - XA); //slope calculations
                double length = Math.Sqrt ((XB - XA) * (XB - XA) + (YB - YA) * (YB - YA)); //length calculations
                double midpointx = ((XA + XB) / 2); //midpoint X calculations
                double midpointy = ((YA + YB) / 2); //midpoint Y calculations

               
                txtfunction.Text += "Slope =" + Math.Round(slope,2);
                txtfunction.Text += Environment.NewLine +"Length ="  + Math.Round(length,2);
                txtfunction.Text += Environment.NewLine + "Mid-point =" + "(" + Math.Round(midpointx,2) + "," + Math.Round(midpointy,2) + ")"; //text displayed for the User
            }
            catch
            {

                MessageBox.Show("Please insert numbers only!"); //tells the User to only input numbers 

            }
        }

        private void txtXB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
            
         
