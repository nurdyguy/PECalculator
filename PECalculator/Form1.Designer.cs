namespace PECalculator
{
    partial class calculatorForm
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
            this.problemNumberLabel = new System.Windows.Forms.Label();
            this.problemNumberInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.inputValuesGroup = new System.Windows.Forms.GroupBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.zInput = new System.Windows.Forms.TextBox();
            this.resultsGroup = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.inputValuesGroup.SuspendLayout();
            this.resultsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // problemNumberLabel
            // 
            this.problemNumberLabel.AutoSize = true;
            this.problemNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemNumberLabel.ForeColor = System.Drawing.Color.White;
            this.problemNumberLabel.Location = new System.Drawing.Point(25, 25);
            this.problemNumberLabel.Name = "problemNumberLabel";
            this.problemNumberLabel.Size = new System.Drawing.Size(231, 31);
            this.problemNumberLabel.TabIndex = 0;
            this.problemNumberLabel.Text = "Problem Number";
            // 
            // problemNumberInput
            // 
            this.problemNumberInput.BackColor = System.Drawing.Color.SlateGray;
            this.problemNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemNumberInput.ForeColor = System.Drawing.Color.White;
            this.problemNumberInput.Location = new System.Drawing.Point(175, 70);
            this.problemNumberInput.Name = "problemNumberInput";
            this.problemNumberInput.Size = new System.Drawing.Size(75, 31);
            this.problemNumberInput.TabIndex = 1;
            this.problemNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.problemNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.problemNumberInput_KeyPress);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.SlateGray;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(40, 314);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 40);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "CALCULATE!";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // inputValuesGroup
            // 
            this.inputValuesGroup.Controls.Add(this.xLabel);
            this.inputValuesGroup.Controls.Add(this.yLabel);
            this.inputValuesGroup.Controls.Add(this.zLabel);
            this.inputValuesGroup.Controls.Add(this.xInput);
            this.inputValuesGroup.Controls.Add(this.yInput);
            this.inputValuesGroup.Controls.Add(this.zInput);
            this.inputValuesGroup.Controls.Add(this.calculateButton);
            this.inputValuesGroup.ForeColor = System.Drawing.Color.White;
            this.inputValuesGroup.Location = new System.Drawing.Point(25, 115);
            this.inputValuesGroup.Name = "inputValuesGroup";
            this.inputValuesGroup.Size = new System.Drawing.Size(230, 360);
            this.inputValuesGroup.TabIndex = 3;
            this.inputValuesGroup.TabStop = false;
            this.inputValuesGroup.Text = "INPUT VALUES";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.ForeColor = System.Drawing.Color.White;
            this.xLabel.Location = new System.Drawing.Point(6, 52);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(31, 24);
            this.xLabel.TabIndex = 9;
            this.xLabel.Text = "X:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yLabel.ForeColor = System.Drawing.Color.White;
            this.yLabel.Location = new System.Drawing.Point(8, 123);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(29, 24);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "Y:";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zLabel.ForeColor = System.Drawing.Color.White;
            this.zLabel.Location = new System.Drawing.Point(8, 197);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(29, 24);
            this.zLabel.TabIndex = 10;
            this.zLabel.Text = "Z:";
            // 
            // xInput
            // 
            this.xInput.BackColor = System.Drawing.Color.SlateGray;
            this.xInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xInput.ForeColor = System.Drawing.Color.White;
            this.xInput.Location = new System.Drawing.Point(40, 48);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(184, 31);
            this.xInput.TabIndex = 2;
            this.xInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yInput
            // 
            this.yInput.BackColor = System.Drawing.Color.SlateGray;
            this.yInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yInput.ForeColor = System.Drawing.Color.White;
            this.yInput.Location = new System.Drawing.Point(40, 119);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(184, 31);
            this.yInput.TabIndex = 3;
            this.yInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zInput
            // 
            this.zInput.BackColor = System.Drawing.Color.SlateGray;
            this.zInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zInput.ForeColor = System.Drawing.Color.White;
            this.zInput.Location = new System.Drawing.Point(40, 193);
            this.zInput.Name = "zInput";
            this.zInput.Size = new System.Drawing.Size(184, 31);
            this.zInput.TabIndex = 4;
            this.zInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultsGroup
            // 
            this.resultsGroup.Controls.Add(this.errorLabel);
            this.resultsGroup.ForeColor = System.Drawing.Color.White;
            this.resultsGroup.Location = new System.Drawing.Point(300, 25);
            this.resultsGroup.Name = "resultsGroup";
            this.resultsGroup.Size = new System.Drawing.Size(575, 450);
            this.resultsGroup.TabIndex = 4;
            this.resultsGroup.TabStop = false;
            this.resultsGroup.Text = "RESULTS";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(6, 16);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 31);
            this.errorLabel.TabIndex = 0;
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.resultsGroup);
            this.Controls.Add(this.inputValuesGroup);
            this.Controls.Add(this.problemNumberInput);
            this.Controls.Add(this.problemNumberLabel);
            this.Name = "calculatorForm";
            this.RightToLeftLayout = true;
            this.Text = "PE Calculator";
            this.inputValuesGroup.ResumeLayout(false);
            this.inputValuesGroup.PerformLayout();
            this.resultsGroup.ResumeLayout(false);
            this.resultsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label problemNumberLabel;
        private System.Windows.Forms.TextBox problemNumberInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox inputValuesGroup;
        private System.Windows.Forms.GroupBox resultsGroup;
        private System.Windows.Forms.TextBox zInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

