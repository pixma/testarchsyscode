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
    public partial class Form_BaseWindow : Form
    {

        private float[,] f_input;
        public Form_BaseWindow()
        {
            InitializeComponent();
        }

        private void Form_BaseWindow_Load(object sender, EventArgs e)
        {

            // Init Procedure Code goes here
            progressBar_process.Enabled = false;
            // end of Init Code
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            openFileDialog_Import.Multiselect = false;

            DialogResult userOpenDialogBoxResponse = openFileDialog_Import.ShowDialog();

            if (userOpenDialogBoxResponse == DialogResult.OK)
            {
                if (openFileDialog_Import.FileName.Length == 0)
                {
                    MessageBox.Show("Please Select your input file.");
                    return;
                }
                label_selected_file_to_import.Text = openFileDialog_Import.FileName;
            }
        }

        private void button_direct_input_process_Click(object sender, EventArgs e)
        {
            process_archsys_summercode(true, null);
        }

        private void process_archsys_summercode(bool input_type, string sFile)
        {
            string s_file_content;
            int nElementCount = 0;
            float[] fTempInput;
            int x = 0, i;

            if (input_type == true)
            {
                if (textBox_direct_input.Text.Length == 0)
                {
                    MessageBox.Show("No input data set provided. Please provide at least 3 points.");
                    return;
                }
                s_file_content = textBox_direct_input.Text;
                nElementCount =  s_file_content.Trim().Split(',').Length;
                fTempInput = new float[nElementCount];
                fTempInput = Array.ConvertAll(s_file_content.Trim().Split(','), float.Parse);

                if (nElementCount % 2 != 0)
                {
                    MessageBox.Show("Please enter proper pair x,y coordinates. It seems like a coordinate is missing in input data set.");
                    return;
                }

                f_input = new float[ nElementCount / 2, 2];
                x = 0;
                for (i = 0; i < nElementCount - 1; i += 2)
                {
                    f_input[x, 0] = fTempInput[i];
                    f_input[x, 1] = fTempInput[i + 1];                    
                    x++;
                }
                progressBar_process.Enabled = true;
                progressBar_process.Value = 99;

                textBox_verbose_output.Text += "Total Point Count: " + (nElementCount / 2).ToString() + Environment.NewLine;
                archsys_summer_code_func(f_input, nElementCount/2);
            }
            else
            {
                
                s_file_content = System.IO.File.ReadAllText(sFile);
                nElementCount = s_file_content.Trim().Split(',').Length;
                fTempInput = Array.ConvertAll(s_file_content.Trim().Split(','), float.Parse);

                if (nElementCount % 2 != 0)
                {
                    MessageBox.Show("Please enter proper pair x,y coordinates. It seems like a coordinate is missing in input data set.");
                    return;
                }

                f_input = new float[nElementCount / 2, 2];
                x = 0;
                for (i = 0; i < nElementCount; i += 2)
                {
                    f_input[x, 0] = fTempInput[i];
                    f_input[x, 1] = fTempInput[i + 1];
                    x++;
                }

                progressBar_process.Enabled = true;
                progressBar_process.Value = 99;

                textBox_verbose_output.Text += "Total Point Count: " + (nElementCount / 2).ToString() + Environment.NewLine;
                archsys_summer_code_func(f_input, nElementCount/2);
            }
        }

        protected void archsys_summer_code_func(float[,] dataset, int nPoints)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            float[] fslope = new float[nPoints];
            float[,] side_dataset = new float[nPoints, 2];
            int nSideCount = 0;
            int nGlobalPivot = 0;
            int nHighOccur = 0;
            float hHighOccurKey = 0.0f;
            float fIntercept = 0.0f;
            bool isProcessDone = false;


            while (!isProcessDone)
            {
                //hit loops
                for (int i = 1; i < nPoints; i++)
                {
                    fslope[i] = (dataset[i, 1] - dataset[nGlobalPivot, 1]) / (dataset[i, 0] - dataset[nGlobalPivot, 0]);
                }

                var nOccur = fslope.GroupBy(v => v);
                foreach (var item in nOccur)
                {
                    if (nHighOccur < item.Count())
                    {
                        nHighOccur = item.Count();
                        hHighOccurKey = item.Key;
                    }
                }

                if (nHighOccur >= 2)
                {
                    // Found a line now.
                    // y = mx + b | m = slope; b = intercept of the line to x-y axis.
                    textBox_verbose_output.Text += "m = " + hHighOccurKey.ToString();
                    fIntercept = dataset[Array.IndexOf(fslope, hHighOccurKey), 1] - (hHighOccurKey * dataset[Array.IndexOf(fslope, hHighOccurKey), 0]);
                    textBox_verbose_output.Text += "; b = " + fIntercept.ToString() + Environment.NewLine;
                    //

                    //
                    // re construct the array now.
                    nSideCount = 0;
                    textBox_verbose_output.Text += "(" + dataset[0, 0].ToString() + "," + dataset[0, 1].ToString() + ")";
                    for (int i = 1; i < nPoints; i++)
                    {
                        if (fslope[i] == hHighOccurKey)
                        {
                            // match,
                            textBox_verbose_output.Text += "(" + dataset[i, 0].ToString() + "," + dataset[i, 1].ToString() + ")";
                            continue;
                        }
                        side_dataset[nSideCount, 0] = dataset[i, 0];
                        side_dataset[nSideCount, 1] = dataset[i, 1];
                        nSideCount++;
                    }
                    Array.Copy(side_dataset, dataset, nPoints * 2);
                    nPoints = nSideCount;// reset point to processs.
                    nHighOccur = 0;
                    Array.Clear(fslope, 0, fslope.Length);
                    Array.Resize(ref fslope, nPoints);

                    textBox_verbose_output.Text += Environment.NewLine;

                }
                else if( nHighOccur < 2 && nPoints < 3)
                {
                    // Its totally done
                    textBox_verbose_output.Text += Environment.NewLine + "Done!";
                    isProcessDone = true;
                }
                else if (nHighOccur < 2)
                {
                    // Its totally done
                    textBox_verbose_output.Text += Environment.NewLine + "Done!";
                    isProcessDone = true;
                }
            }
            watch.Stop();
            
            textBox_verbose_output.Text += Environment.NewLine; 
            
            var elapsedMs = watch.ElapsedMilliseconds;
            textBox_verbose_output.Text += "Time Elasped : " + elapsedMs.ToString() + "ms.";
            progressBar_process.Value = 100;
            
            textBox_verbose_output.Text += Environment.NewLine; 
            textBox_verbose_output.Text += Environment.NewLine; 
        }

        private void button_process_Click(object sender, EventArgs e)
        {
            process_archsys_summercode(false, label_selected_file_to_import.Text);
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox_verbose_output.Text = "";
        }

        private void button_Create_Input_Click(object sender, EventArgs e)
        {
            inputCreator inpWindow = new inputCreator();
            inpWindow.ShowDialog();
        }
    }
}
