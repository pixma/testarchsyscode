namespace ArchSysSummerCode
{
    partial class Form_BaseWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BaseWindow));
            this.splitContainer_base = new System.Windows.Forms.SplitContainer();
            this.groupBox_ImportFile = new System.Windows.Forms.GroupBox();
            this.button_import = new System.Windows.Forms.Button();
            this.openFileDialog_Import = new System.Windows.Forms.OpenFileDialog();
            this.label_selected_file_to_import = new System.Windows.Forms.Label();
            this.button_process = new System.Windows.Forms.Button();
            this.groupBox_raw_imput = new System.Windows.Forms.GroupBox();
            this.textBox_direct_input = new System.Windows.Forms.TextBox();
            this.button_direct_input_process = new System.Windows.Forms.Button();
            this.progressBar_process = new System.Windows.Forms.ProgressBar();
            this.textBox_verbose_output = new System.Windows.Forms.TextBox();
            this.label_veerbose_title = new System.Windows.Forms.Label();
            this.button_Clean = new System.Windows.Forms.Button();
            this.button_Create_Input = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_base)).BeginInit();
            this.splitContainer_base.Panel1.SuspendLayout();
            this.splitContainer_base.Panel2.SuspendLayout();
            this.splitContainer_base.SuspendLayout();
            this.groupBox_ImportFile.SuspendLayout();
            this.groupBox_raw_imput.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_base
            // 
            this.splitContainer_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_base.IsSplitterFixed = true;
            this.splitContainer_base.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_base.Name = "splitContainer_base";
            // 
            // splitContainer_base.Panel1
            // 
            this.splitContainer_base.Panel1.Controls.Add(this.groupBox_raw_imput);
            this.splitContainer_base.Panel1.Controls.Add(this.groupBox_ImportFile);
            // 
            // splitContainer_base.Panel2
            // 
            this.splitContainer_base.Panel2.Controls.Add(this.button_Clean);
            this.splitContainer_base.Panel2.Controls.Add(this.label_veerbose_title);
            this.splitContainer_base.Panel2.Controls.Add(this.textBox_verbose_output);
            this.splitContainer_base.Panel2.Controls.Add(this.progressBar_process);
            this.splitContainer_base.Size = new System.Drawing.Size(834, 348);
            this.splitContainer_base.SplitterDistance = 278;
            this.splitContainer_base.TabIndex = 0;
            // 
            // groupBox_ImportFile
            // 
            this.groupBox_ImportFile.Controls.Add(this.button_Create_Input);
            this.groupBox_ImportFile.Controls.Add(this.button_process);
            this.groupBox_ImportFile.Controls.Add(this.label_selected_file_to_import);
            this.groupBox_ImportFile.Controls.Add(this.button_import);
            this.groupBox_ImportFile.Location = new System.Drawing.Point(3, 3);
            this.groupBox_ImportFile.Name = "groupBox_ImportFile";
            this.groupBox_ImportFile.Size = new System.Drawing.Size(272, 123);
            this.groupBox_ImportFile.TabIndex = 0;
            this.groupBox_ImportFile.TabStop = false;
            this.groupBox_ImportFile.Text = "Import File";
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(141, 9);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(125, 25);
            this.button_import.TabIndex = 1;
            this.button_import.Text = "Import File";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // openFileDialog_Import
            // 
            this.openFileDialog_Import.FileName = "Import File";
            this.openFileDialog_Import.Title = "Import File";
            // 
            // label_selected_file_to_import
            // 
            this.label_selected_file_to_import.AutoSize = true;
            this.label_selected_file_to_import.Location = new System.Drawing.Point(9, 45);
            this.label_selected_file_to_import.Name = "label_selected_file_to_import";
            this.label_selected_file_to_import.Size = new System.Drawing.Size(68, 13);
            this.label_selected_file_to_import.TabIndex = 2;
            this.label_selected_file_to_import.Text = "Selected File";
            // 
            // button_process
            // 
            this.button_process.Location = new System.Drawing.Point(141, 87);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(125, 30);
            this.button_process.TabIndex = 3;
            this.button_process.Text = "Process";
            this.button_process.UseVisualStyleBackColor = true;
            this.button_process.Click += new System.EventHandler(this.button_process_Click);
            // 
            // groupBox_raw_imput
            // 
            this.groupBox_raw_imput.Controls.Add(this.button_direct_input_process);
            this.groupBox_raw_imput.Controls.Add(this.textBox_direct_input);
            this.groupBox_raw_imput.Location = new System.Drawing.Point(3, 133);
            this.groupBox_raw_imput.Name = "groupBox_raw_imput";
            this.groupBox_raw_imput.Size = new System.Drawing.Size(272, 225);
            this.groupBox_raw_imput.TabIndex = 1;
            this.groupBox_raw_imput.TabStop = false;
            this.groupBox_raw_imput.Text = "Direct Input";
            // 
            // textBox_direct_input
            // 
            this.textBox_direct_input.Location = new System.Drawing.Point(12, 19);
            this.textBox_direct_input.Multiline = true;
            this.textBox_direct_input.Name = "textBox_direct_input";
            this.textBox_direct_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_direct_input.Size = new System.Drawing.Size(254, 154);
            this.textBox_direct_input.TabIndex = 1;
            this.textBox_direct_input.Text = "x1,y1,x2,y2,x3,y3,x4,y4,x5,y5,x6,y6";
            // 
            // button_direct_input_process
            // 
            this.button_direct_input_process.Location = new System.Drawing.Point(141, 179);
            this.button_direct_input_process.Name = "button_direct_input_process";
            this.button_direct_input_process.Size = new System.Drawing.Size(125, 30);
            this.button_direct_input_process.TabIndex = 2;
            this.button_direct_input_process.Text = "Process";
            this.button_direct_input_process.UseVisualStyleBackColor = true;
            this.button_direct_input_process.Click += new System.EventHandler(this.button_direct_input_process_Click);
            // 
            // progressBar_process
            // 
            this.progressBar_process.Enabled = false;
            this.progressBar_process.Location = new System.Drawing.Point(3, 312);
            this.progressBar_process.Name = "progressBar_process";
            this.progressBar_process.Size = new System.Drawing.Size(545, 30);
            this.progressBar_process.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_process.TabIndex = 0;
            // 
            // textBox_verbose_output
            // 
            this.textBox_verbose_output.Location = new System.Drawing.Point(3, 30);
            this.textBox_verbose_output.Multiline = true;
            this.textBox_verbose_output.Name = "textBox_verbose_output";
            this.textBox_verbose_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_verbose_output.Size = new System.Drawing.Size(545, 276);
            this.textBox_verbose_output.TabIndex = 1;
            // 
            // label_veerbose_title
            // 
            this.label_veerbose_title.AutoSize = true;
            this.label_veerbose_title.Location = new System.Drawing.Point(3, 9);
            this.label_veerbose_title.Name = "label_veerbose_title";
            this.label_veerbose_title.Size = new System.Drawing.Size(30, 13);
            this.label_veerbose_title.TabIndex = 2;
            this.label_veerbose_title.Text = "Yield";
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(473, 4);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(75, 23);
            this.button_Clean.TabIndex = 3;
            this.button_Clean.Text = "Clear";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // button_Create_Input
            // 
            this.button_Create_Input.Location = new System.Drawing.Point(7, 87);
            this.button_Create_Input.Name = "button_Create_Input";
            this.button_Create_Input.Size = new System.Drawing.Size(128, 30);
            this.button_Create_Input.TabIndex = 4;
            this.button_Create_Input.Text = "Create Input Set";
            this.button_Create_Input.UseVisualStyleBackColor = true;
            this.button_Create_Input.Click += new System.EventHandler(this.button_Create_Input_Click);
            // 
            // Form_BaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 348);
            this.Controls.Add(this.splitContainer_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_BaseWindow";
            this.Text = "ArchSys SummerCode";
            this.Load += new System.EventHandler(this.Form_BaseWindow_Load);
            this.splitContainer_base.Panel1.ResumeLayout(false);
            this.splitContainer_base.Panel2.ResumeLayout(false);
            this.splitContainer_base.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_base)).EndInit();
            this.splitContainer_base.ResumeLayout(false);
            this.groupBox_ImportFile.ResumeLayout(false);
            this.groupBox_ImportFile.PerformLayout();
            this.groupBox_raw_imput.ResumeLayout(false);
            this.groupBox_raw_imput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_base;
        private System.Windows.Forms.GroupBox groupBox_ImportFile;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.Label label_selected_file_to_import;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Import;
        private System.Windows.Forms.GroupBox groupBox_raw_imput;
        private System.Windows.Forms.Button button_direct_input_process;
        private System.Windows.Forms.TextBox textBox_direct_input;
        private System.Windows.Forms.ProgressBar progressBar_process;
        private System.Windows.Forms.Label label_veerbose_title;
        private System.Windows.Forms.TextBox textBox_verbose_output;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.Button button_Create_Input;
    }
}

