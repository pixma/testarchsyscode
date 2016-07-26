using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchSysSummerCode
{
    public partial class inputCreator : Form
    {
        public inputCreator()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            string inputData;
            float[] fInputReq;
            float x;
            x = 0.0f;

            if (textBox_InputData.Text.Length == 0)
            {
                MessageBox.Show("Please provide some input.");
                return;
            }

            inputData = textBox_InputData.Text;
            fInputReq = new float[inputData.Trim().Split(',').Length];
            fInputReq = Array.ConvertAll(inputData.Trim().Split(','), float.Parse);

            if (fInputReq.Length % 3 != 0)
            {
                MessageBox.Show("Please enter proper pair x,y coordinates. It seems like a coordinate is missing in input data set.");
                return;
            }

            for (int i = 2; i < fInputReq.Length; i += 3)
            {
                x = 0.0f;
                for (int j = 0; j < fInputReq[i]; j++)
                {
                    textBox_inputGenerateYield.Text += x.ToString() + "," + ((fInputReq[i-2] * x) + fInputReq[i-1]).ToString() + "," ;
                    x++;
                }
            }

        }
    }
}
