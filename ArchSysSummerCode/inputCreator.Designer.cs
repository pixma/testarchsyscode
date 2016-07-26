namespace ArchSysSummerCode
{
    partial class inputCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputCreator));
            this.label_instruction = new System.Windows.Forms.Label();
            this.textBox_InputData = new System.Windows.Forms.TextBox();
            this.textBox_inputGenerateYield = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_instruction
            // 
            this.label_instruction.AutoSize = true;
            this.label_instruction.Location = new System.Drawing.Point(13, 13);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(224, 13);
            this.label_instruction.TabIndex = 0;
            this.label_instruction.Text = "Type input below as slope, m and intercept, b.";
            // 
            // textBox_InputData
            // 
            this.textBox_InputData.Location = new System.Drawing.Point(16, 45);
            this.textBox_InputData.Multiline = true;
            this.textBox_InputData.Name = "textBox_InputData";
            this.textBox_InputData.Size = new System.Drawing.Size(90, 237);
            this.textBox_InputData.TabIndex = 1;
            // 
            // textBox_inputGenerateYield
            // 
            this.textBox_inputGenerateYield.Location = new System.Drawing.Point(113, 45);
            this.textBox_inputGenerateYield.Multiline = true;
            this.textBox_inputGenerateYield.Name = "textBox_inputGenerateYield";
            this.textBox_inputGenerateYield.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_inputGenerateYield.Size = new System.Drawing.Size(281, 237);
            this.textBox_inputGenerateYield.TabIndex = 2;
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(319, 8);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 3;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // inputCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 298);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.textBox_inputGenerateYield);
            this.Controls.Add(this.textBox_InputData);
            this.Controls.Add(this.label_instruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inputCreator";
            this.Text = "inputCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_instruction;
        private System.Windows.Forms.TextBox textBox_InputData;
        private System.Windows.Forms.TextBox textBox_inputGenerateYield;
        private System.Windows.Forms.Button button_generate;
    }
}