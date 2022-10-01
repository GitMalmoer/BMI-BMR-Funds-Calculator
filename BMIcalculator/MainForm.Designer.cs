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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIntrestRate = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSavings = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblIntrestEarned = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNormalWeight = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCalculateBMR = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblBmr = new System.Windows.Forms.Label();
            this.rbtnExtraActiv = new System.Windows.Forms.RadioButton();
            this.rbtnVeryActive = new System.Windows.Forms.RadioButton();
            this.rbtnModeratelyActive = new System.Windows.Forms.RadioButton();
            this.rbtnLightlyActive = new System.Windows.Forms.RadioButton();
            this.rbtnNoActive = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblMaintainWeight = new System.Windows.Forms.Label();
            this.lblLoseOrGain = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(319, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 125);
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
            this.grpResults.Size = new System.Drawing.Size(455, 147);
            this.grpResults.TabIndex = 7;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results ";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCategory.Location = new System.Drawing.Point(222, 89);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(169, 22);
            this.lblWeightCategory.TabIndex = 3;
            this.lblWeightCategory.Text = "label4";
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Location = new System.Drawing.Point(223, 31);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(169, 22);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
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
            this.lblNormalBMI.Location = new System.Drawing.Point(25, 362);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(455, 25);
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
            this.txtWeight.Size = new System.Drawing.Size(125, 27);
            this.txtWeight.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTax);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIntrestRate);
            this.groupBox2.Controls.Add(this.txtPeriod);
            this.groupBox2.Controls.Add(this.txtMonthlyDeposit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(509, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 189);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saving Plan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "fees in %";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(183, 142);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(125, 27);
            this.txtTax.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Growth (or Intrest) in % ";
            // 
            // txtIntrestRate
            // 
            this.txtIntrestRate.Location = new System.Drawing.Point(184, 109);
            this.txtIntrestRate.Name = "txtIntrestRate";
            this.txtIntrestRate.Size = new System.Drawing.Size(125, 27);
            this.txtIntrestRate.TabIndex = 4;
            this.txtIntrestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(184, 76);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(124, 27);
            this.txtPeriod.TabIndex = 3;
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonthlyDeposit
            // 
            this.txtMonthlyDeposit.Location = new System.Drawing.Point(184, 39);
            this.txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            this.txtMonthlyDeposit.Size = new System.Drawing.Size(124, 27);
            this.txtMonthlyDeposit.TabIndex = 2;
            this.txtMonthlyDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Period (years)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monthly Deposit";
            // 
            // btnSavings
            // 
            this.btnSavings.Location = new System.Drawing.Point(607, 221);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(166, 29);
            this.btnSavings.TabIndex = 12;
            this.btnSavings.Text = "Calculate Saving";
            this.btnSavings.UseVisualStyleBackColor = true;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblTotalTax);
            this.groupBox3.Controls.Add(this.lblIntrestEarned);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblAmountPaid);
            this.groupBox3.Controls.Add(this.lblFinalBalance);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(519, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 175);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Future Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Total Fees";
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalTax.Location = new System.Drawing.Point(158, 141);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(60, 22);
            this.lblTotalTax.TabIndex = 6;
            this.lblTotalTax.Text = "label10";
            // 
            // lblIntrestEarned
            // 
            this.lblIntrestEarned.AutoSize = true;
            this.lblIntrestEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntrestEarned.Location = new System.Drawing.Point(158, 72);
            this.lblIntrestEarned.Name = "lblIntrestEarned";
            this.lblIntrestEarned.Size = new System.Drawing.Size(60, 22);
            this.lblIntrestEarned.TabIndex = 5;
            this.lblIntrestEarned.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Amount Earned";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountPaid.Location = new System.Drawing.Point(158, 37);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(52, 22);
            this.lblAmountPaid.TabIndex = 3;
            this.lblAmountPaid.Text = "label8";
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.AutoSize = true;
            this.lblFinalBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinalBalance.Location = new System.Drawing.Point(158, 108);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(52, 22);
            this.lblFinalBalance.TabIndex = 2;
            this.lblFinalBalance.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Final Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount Paid";
            // 
            // lblNormalWeight
            // 
            this.lblNormalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNormalWeight.Location = new System.Drawing.Point(27, 412);
            this.lblNormalWeight.Name = "lblNormalWeight";
            this.lblNormalWeight.Size = new System.Drawing.Size(455, 22);
            this.lblNormalWeight.TabIndex = 14;
            this.lblNormalWeight.Text = "label 4";
            this.lblNormalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCalculateBMR);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.txtAge);
            this.groupBox4.Controls.Add(this.lblAge);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(27, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(863, 403);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BMR calculator";
            // 
            // btnCalculateBMR
            // 
            this.btnCalculateBMR.Location = new System.Drawing.Point(630, 359);
            this.btnCalculateBMR.Name = "btnCalculateBMR";
            this.btnCalculateBMR.Size = new System.Drawing.Size(212, 29);
            this.btnCalculateBMR.TabIndex = 4;
            this.btnCalculateBMR.Text = "Calculate BMR";
            this.btnCalculateBMR.UseVisualStyleBackColor = true;
            this.btnCalculateBMR.Click += new System.EventHandler(this.btnCalculateBMR_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblLoseOrGain);
            this.groupBox6.Controls.Add(this.lblMaintainWeight);
            this.groupBox6.Controls.Add(this.lblBmr);
            this.groupBox6.Controls.Add(this.rbtnExtraActiv);
            this.groupBox6.Controls.Add(this.rbtnVeryActive);
            this.groupBox6.Controls.Add(this.rbtnModeratelyActive);
            this.groupBox6.Controls.Add(this.rbtnLightlyActive);
            this.groupBox6.Controls.Add(this.rbtnNoActive);
            this.groupBox6.Location = new System.Drawing.Point(177, 55);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(652, 276);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Weekly Activity Level";
            // 
            // lblBmr
            // 
            this.lblBmr.AutoSize = true;
            this.lblBmr.Location = new System.Drawing.Point(289, 24);
            this.lblBmr.Name = "lblBmr";
            this.lblBmr.Size = new System.Drawing.Size(58, 20);
            this.lblBmr.TabIndex = 5;
            this.lblBmr.Text = "label10";
            // 
            // rbtnExtraActiv
            // 
            this.rbtnExtraActiv.AutoSize = true;
            this.rbtnExtraActiv.Location = new System.Drawing.Point(11, 160);
            this.rbtnExtraActiv.Name = "rbtnExtraActiv";
            this.rbtnExtraActiv.Size = new System.Drawing.Size(262, 24);
            this.rbtnExtraActiv.TabIndex = 4;
            this.rbtnExtraActiv.TabStop = true;
            this.rbtnExtraActiv.Text = "Extra Activ (hard excercise or work)";
            this.rbtnExtraActiv.UseVisualStyleBackColor = true;
            this.rbtnExtraActiv.CheckedChanged += new System.EventHandler(this.rbtnExtraActiv_CheckedChanged);
            // 
            // rbtnVeryActive
            // 
            this.rbtnVeryActive.AutoSize = true;
            this.rbtnVeryActive.Location = new System.Drawing.Point(11, 130);
            this.rbtnVeryActive.Name = "rbtnVeryActive";
            this.rbtnVeryActive.Size = new System.Drawing.Size(199, 24);
            this.rbtnVeryActive.TabIndex = 3;
            this.rbtnVeryActive.TabStop = true;
            this.rbtnVeryActive.Text = "Very Active (6 to 7 times) ";
            this.rbtnVeryActive.UseVisualStyleBackColor = true;
            this.rbtnVeryActive.CheckedChanged += new System.EventHandler(this.rbtnVeryActive_CheckedChanged);
            // 
            // rbtnModeratelyActive
            // 
            this.rbtnModeratelyActive.AutoSize = true;
            this.rbtnModeratelyActive.Location = new System.Drawing.Point(11, 99);
            this.rbtnModeratelyActive.Name = "rbtnModeratelyActive";
            this.rbtnModeratelyActive.Size = new System.Drawing.Size(243, 24);
            this.rbtnModeratelyActive.TabIndex = 2;
            this.rbtnModeratelyActive.TabStop = true;
            this.rbtnModeratelyActive.Text = "Moderately Active (3 to 5 times)";
            this.rbtnModeratelyActive.UseVisualStyleBackColor = true;
            this.rbtnModeratelyActive.CheckedChanged += new System.EventHandler(this.rbtnModeratelyActive_CheckedChanged);
            // 
            // rbtnLightlyActive
            // 
            this.rbtnLightlyActive.AutoSize = true;
            this.rbtnLightlyActive.Location = new System.Drawing.Point(11, 69);
            this.rbtnLightlyActive.Name = "rbtnLightlyActive";
            this.rbtnLightlyActive.Size = new System.Drawing.Size(171, 24);
            this.rbtnLightlyActive.TabIndex = 1;
            this.rbtnLightlyActive.TabStop = true;
            this.rbtnLightlyActive.Text = "Lightly Active (1 to 3)";
            this.rbtnLightlyActive.UseVisualStyleBackColor = true;
            this.rbtnLightlyActive.CheckedChanged += new System.EventHandler(this.rbtnLightlyActive_CheckedChanged);
            // 
            // rbtnNoActive
            // 
            this.rbtnNoActive.AutoSize = true;
            this.rbtnNoActive.Location = new System.Drawing.Point(11, 33);
            this.rbtnNoActive.Name = "rbtnNoActive";
            this.rbtnNoActive.Size = new System.Drawing.Size(243, 24);
            this.rbtnNoActive.TabIndex = 0;
            this.rbtnNoActive.TabStop = true;
            this.rbtnNoActive.Text = "Sedentary (little or no excercise)";
            this.rbtnNoActive.UseVisualStyleBackColor = true;
            this.rbtnNoActive.CheckedChanged += new System.EventHandler(this.rbtnNoActive_CheckedChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(98, 182);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 27);
            this.txtAge.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(31, 185);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtnMale);
            this.groupBox5.Controls.Add(this.rbtnFemale);
            this.groupBox5.Location = new System.Drawing.Point(17, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(131, 125);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(14, 63);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(63, 24);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(14, 33);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(78, 24);
            this.rbtnFemale.TabIndex = 0;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
            // 
            // lblMaintainWeight
            // 
            this.lblMaintainWeight.AutoSize = true;
            this.lblMaintainWeight.Location = new System.Drawing.Point(289, 69);
            this.lblMaintainWeight.Name = "lblMaintainWeight";
            this.lblMaintainWeight.Size = new System.Drawing.Size(58, 20);
            this.lblMaintainWeight.TabIndex = 6;
            this.lblMaintainWeight.Text = "label10";
            // 
            // lblLoseOrGain
            // 
            this.lblLoseOrGain.AutoSize = true;
            this.lblLoseOrGain.Location = new System.Drawing.Point(289, 112);
            this.lblLoseOrGain.Name = "lblLoseOrGain";
            this.lblLoseOrGain.Size = new System.Drawing.Size(58, 20);
            this.lblLoseOrGain.TabIndex = 7;
            this.lblLoseOrGain.Text = "label10";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 898);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblNormalWeight);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSavings);
            this.Controls.Add(this.groupBox2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private GroupBox groupBox2;
        private TextBox txtPeriod;
        private TextBox txtMonthlyDeposit;
        private Label label4;
        private Label label3;
        private Button btnSavings;
        private GroupBox groupBox3;
        private Label lblAmountPaid;
        private Label lblFinalBalance;
        private Label label6;
        private Label label5;
        private Label lblNormalWeight;
        private Label label7;
        private TextBox txtIntrestRate;
        private Label label8;
        private TextBox txtTax;
        private Label lblIntrestEarned;
        private Label label9;
        private Label label11;
        private Label lblTotalTax;
        private GroupBox groupBox4;
        private Button btnCalculateBMR;
        private GroupBox groupBox6;
        private RadioButton rbtnExtraActiv;
        private RadioButton rbtnVeryActive;
        private RadioButton rbtnModeratelyActive;
        private RadioButton rbtnLightlyActive;
        private RadioButton rbtnNoActive;
        private TextBox txtAge;
        private Label lblAge;
        private GroupBox groupBox5;
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private Label lblBmr;
        private Label lblLoseOrGain;
        private Label lblMaintainWeight;
    }
}