namespace BMI_Calculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.weightlabel = new System.Windows.Forms.Label();
            this.heightlabel = new System.Windows.Forms.Label();
            this.TextboxforWeight = new System.Windows.Forms.TextBox();
            this.textboxForHeight = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxforBMI = new System.Windows.Forms.TextBox();
            this.BMILabel = new System.Windows.Forms.Label();
            this.CalculateBMIbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightlabel
            // 
            this.weightlabel.AutoSize = true;
            this.weightlabel.Location = new System.Drawing.Point(40, 91);
            this.weightlabel.Name = "weightlabel";
            this.weightlabel.Size = new System.Drawing.Size(86, 20);
            this.weightlabel.TabIndex = 0;
            this.weightlabel.Text = "Weight(kg)";
            this.weightlabel.Click += new System.EventHandler(this.weightlabel_Click);
            // 
            // heightlabel
            // 
            this.heightlabel.AutoSize = true;
            this.heightlabel.Location = new System.Drawing.Point(40, 171);
            this.heightlabel.Name = "heightlabel";
            this.heightlabel.Size = new System.Drawing.Size(84, 20);
            this.heightlabel.TabIndex = 1;
            this.heightlabel.Text = "height(cm)";
            this.heightlabel.Click += new System.EventHandler(this.heightlabel_Click);
            // 
            // TextboxforWeight
            // 
            this.TextboxforWeight.Location = new System.Drawing.Point(181, 88);
            this.TextboxforWeight.Name = "TextboxforWeight";
            this.TextboxforWeight.Size = new System.Drawing.Size(220, 26);
            this.TextboxforWeight.TabIndex = 2;
            this.TextboxforWeight.TextChanged += new System.EventHandler(this.TextboxforWeight_TextChanged);
            // 
            // textboxForHeight
            // 
            this.textboxForHeight.Location = new System.Drawing.Point(181, 165);
            this.textboxForHeight.Name = "textboxForHeight";
            this.textboxForHeight.Size = new System.Drawing.Size(220, 26);
            this.textboxForHeight.TabIndex = 3;
            this.textboxForHeight.TextChanged += new System.EventHandler(this.textboxForHeight_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxforBMI
            // 
            this.textBoxforBMI.Location = new System.Drawing.Point(181, 244);
            this.textBoxforBMI.Name = "textBoxforBMI";
            this.textBoxforBMI.Size = new System.Drawing.Size(220, 26);
            this.textBoxforBMI.TabIndex = 5;
            this.textBoxforBMI.TextChanged += new System.EventHandler(this.textBoxforBMI_TextChanged);
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Location = new System.Drawing.Point(40, 250);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(113, 20);
            this.BMILabel.TabIndex = 6;
            this.BMILabel.Text = "CalculatedBMI";
            this.BMILabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // CalculateBMIbutton
            // 
            this.CalculateBMIbutton.Location = new System.Drawing.Point(168, 336);
            this.CalculateBMIbutton.Name = "CalculateBMIbutton";
            this.CalculateBMIbutton.Size = new System.Drawing.Size(233, 37);
            this.CalculateBMIbutton.TabIndex = 7;
            this.CalculateBMIbutton.Text = "CalculateBMI";
            this.CalculateBMIbutton.UseVisualStyleBackColor = true;
            this.CalculateBMIbutton.Click += new System.EventHandler(this.CalculateBMIbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateBMIbutton);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.textBoxforBMI);
            this.Controls.Add(this.textboxForHeight);
            this.Controls.Add(this.TextboxforWeight);
            this.Controls.Add(this.heightlabel);
            this.Controls.Add(this.weightlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightlabel;
        private System.Windows.Forms.Label heightlabel;
        private System.Windows.Forms.TextBox TextboxforWeight;
        private System.Windows.Forms.TextBox textboxForHeight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxforBMI;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Button CalculateBMIbutton;
    }
}

