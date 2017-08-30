using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void bSolutionHW1_1_Click(object sender, EventArgs e)
        {
            Int64 givenNumber = Convert.ToInt32(Given_Number_1.Text);
            Int64 i = 0;

            while (Math.Pow(2, ++i) < givenNumber) ;

            listBoxHW1_1.Items.Add("2^" + (i - 1) + " = " + Math.Pow(2, i - 1) + " < " + givenNumber);
            listBoxHW1_1.Items.Add("Answer: (" + i + ") 2^" + i + " = " + Math.Pow(2, i) + " > " + givenNumber);
            listBoxHW1_1.Items.Add("2^" + (i + 1) + " = " + Math.Pow(2, i + 1) + " > " + givenNumber);
        }

        private void bSolutionHW1_2_Click(object sender, EventArgs e)
        {
            int givenNumber = Convert.ToInt32(Given_Number_2.Text);

            for (int x = 1; x < Math.Sqrt(givenNumber); ++x)
            {
                for (int y = 1; y < Math.Sqrt(givenNumber); y++)
                {
                    for (int z = 1; z < Math.Sqrt(givenNumber); z++)
                    {
                        if (Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) == givenNumber)
                        {
                            listBoxHW1_2.Items.Add(x + "^2+" + y + "^2+" + z + "^2 = " + givenNumber);
                            x = givenNumber;
                            y = givenNumber;
                            z = givenNumber;
                        }
                    }
                }
            }
        }

        private void bSolutionHW1_3_Click(object sender, EventArgs e)
        {
            int givenNumber = Convert.ToInt32(Given_Number_3.Text);

            for (int a = 1; a < Math.Sqrt(givenNumber); ++a)
                for (int b = 1; b < Math.Sqrt(givenNumber); b++)
                    for (int c = 1; c < Math.Sqrt(givenNumber); c++)
                        if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) && 
                            (a <= b) && (b <= c) && (c <= givenNumber))
                        {
                            listBoxHW1_3.Items.Add(a + "^2+" + b + "^2+" + " = " + c + "^2");
                            listBoxHW1_3.Items.Add(Math.Pow(a, 2) + " + " + Math.Pow(b, 2) + " = " + Math.Pow(c, 2));
                            listBoxHW1_3.Items.Add("------------------------------------------");
                        }
        }
    }
}
