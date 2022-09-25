namespace BMIcalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCmFt = new System.Windows.Forms.TextBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Your Name";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(27, 72);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(54, 20);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 2;
            // 
            // txtCmFt
            // 
            this.txtCmFt.Location = new System.Drawing.Point(165, 65);
            this.txtCmFt.Name = "txtCmFt";
            this.txtCmFt.Size = new System.Drawing.Size(51, 27);
            this.txtCmFt.TabIndex = 3;
            // 
            // txtInch
            // 
            this.txtInch.Location = new System.Drawing.Point(236, 65);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(54, 27);
            this.txtInch.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(140, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 29);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Calculate";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnImperial);
            this.groupBox1.Controls.Add(this.rbtnMetric);
            this.groupBox1.Location = new System.Drawing.Point(469, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Location = new System.Drawing.Point(26, 65);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(127, 24);
            this.rbtnImperial.TabIndex = 1;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial(lbs,ft)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(26, 35);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(121, 24);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric(kg,cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblWeightCategory);
            this.grpResults.Controls.Add(this.lblBMI);
            this.grpResults.Controls.Add(this.label2);
            this.grpResults.Controls.Add(this.label1);
            this.grpResults.Location = new System.Drawing.Point(27, 182);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(413, 132);
            this.grpResults.TabIndex = 7;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results ";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCategory.Location = new System.Drawing.Point(223, 77);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(52, 22);
            this.lblWeightCategory.TabIndex = 3;
            this.lblWeightCategory.Text = "label4";
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Location = new System.Drawing.Point(223, 31);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(52, 22);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "WeightCategory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your BMI";
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNormalBMI.Location = new System.Drawing.Point(63, 330);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(337, 25);
            this.lblNormalBMI.TabIndex = 8;
            this.lblNormalBMI.Text = "label3";
            this.lblNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(27, 110);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 20);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(165, 103);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(51, 27);
            this.txtWeight.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblNormalBMI);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtInch);
            this.Controls.Add(this.txtCmFt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblHeight;
        private TextBox txtName;
        private TextBox txtCmFt;
        private TextBox txtInch;
        private Button btnOK;
        private GroupBox groupBox1;
        private RadioButton rbtnImperial;
        private RadioButton rbtnMetric;
        private GroupBox grpResults;
        private Label lblWeightCategory;
        private Label lblBMI;
        private Label label2;
        private Label label1;
        private Label lblNormalBMI;
        private Label lblWeight;
        private TextBox txtWeight;
    }
}