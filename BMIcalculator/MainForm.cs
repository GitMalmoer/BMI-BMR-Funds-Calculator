namespace BMIcalculator
{
    public partial class MainForm : Form
    {
        private string name = string.Empty; 
        BMIcalculator bmiCalc = new BMIcalculator();
        SavingCalculator savingCalc = new SavingCalculator();
        BmrCalculator bmrCalc = new BmrCalculator();
       
        public MainForm()
        {      
            InitializeComponent();
            InitializeGUI();
            
        }

        private void InitializeGUI()
        {
            this.Text = "Super Calculator by Marcin Junka";
            lblBMI.Text = String.Empty;
            lblWeightCategory.Text = string.Empty;
            lblNormalBMI.Text = "Normal Weight";
            rbtnMetric.Checked = true;
            lblNormalBMI.Text = ("Normal BMI is between 18.5 and 24.9");
            lblAmountPaid.Text = String.Empty;
            lblFinalBalance.Text = String.Empty;
            lblIntrestEarned.Text = String.Empty;
            lblTotalTax.Text = String.Empty;
            lblNormalWeight.Text = String.Empty;
            rbtnNoActive.Checked = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        #region BMICalculator
        private void UpdateHeightText()
        {
            if(rbtnMetric.Checked == true)
            {
                lblHeight.Text = "Height (Cm)";
                lblWeight.Text = "Weight (Kg)";
                txtInch.Visible = false;
            }
            else
            {
                lblHeight.Text = "Height (Ft)";
                lblWeight.Text = "Weight (lbs)";
                txtInch.Visible = true;
            }
            lblBMI.Text = ("");
            lblWeightCategory.Text = ("");
        }
        

        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
            
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
            {
                CalculatesAndResults();
                string a = bmiCalc.NormalWeightLowLimit().ToString("f2"); // Calculating low limit and putting it in string
                string b = bmiCalc.NormalWeightHighLimit().ToString("f2"); // calculationg high limit
                string sentence = ($"Normal weight should be between {a} and {b}"); // putting both methods in a string
                lblNormalWeight.Text = sentence;
            }
          
        }

        private bool ReadInputBMI()
        {
            ReadName();
            ReadUnit();
            bool weightOK = ReadWeight();
            bool heightOK = ReadHeight();
            

            return weightOK && heightOK;
        }
        
        private void ReadUnit() // this void looks which one is checked
        {
            if(rbtnMetric.Checked)
            {
                bmiCalc.setUnit(UnitTypes.Metric);
            }
            else
            {
                bmiCalc.setUnit(UnitTypes.Imperial);
            }
        }
        
        private void ReadName()
        {
            name = txtName.Text.Trim();
            grpResults.Text = name;                      
        }

        private bool ReadWeight()
        {
            double weight = 0.0;
            bool ok = double.TryParse(txtWeight.Text, out weight);
            if (!ok)
            {
                MessageBox.Show("Invalid weight value , error");
            }
            bmiCalc.setWeight(weight);
            return ok;
        }

        private bool ReadHeight()
        {
            double height = 0.0;
            bool ok = double.TryParse(txtCmFt.Text, out height);
            if (!ok)
            {
                MessageBox.Show("Invalid height value , error");
            }

            double inch = 0.0;

            if (rbtnImperial.Checked)
            {
                ok = ok && double.TryParse(txtInch.Text, out inch);
                if (!ok)
                {
                    MessageBox.Show("Invalid inch value , error");
                }
            }
            // cm -> m ft -> inches
            if(bmiCalc.getUnit() == UnitTypes.Metric)
            {
                height = height / 100; // cm -> m
            }
            else 
            {
                height = height * 12.0 + inch; // ft -> inch
            }

            bmiCalc.setHeight(height);
            return ok;
        }
            private void CalculatesAndResults()
            {
            double bmi = bmiCalc.CalculateBMI();
            lblBMI.Text = bmi.ToString("f2");
            lblWeightCategory.Text = bmiCalc.BmiWeightCategory();
            }

        #endregion

        #region SavingsCalculator
        private bool ReadMonthlyDeposit()
        {
            double monthlyDeposit = 0.0;
            bool ok = double.TryParse((txtMonthlyDeposit.Text).Trim(), out monthlyDeposit);
            if(!ok || monthlyDeposit <= 0)
            {
                MessageBox.Show("Error wrong Monthly deposit value.");
            }
            else
            savingCalc.SetDeposit(monthlyDeposit);
            
            return ok;

        }

        private bool ReadSavingsPeriod()
        {
            int savingsPeriod = 0;
            bool ok = int.TryParse(txtPeriod.Text.Trim(), out savingsPeriod);
            if(!ok || savingsPeriod < 1)
            {
                MessageBox.Show("Error, Wrong Saving Period");
            }
            else
            savingCalc.SetYears(savingsPeriod);
            
            return ok;
        }

        bool ReadIntrestRate()
        {
            double intrestRate; 
            bool ok = double.TryParse(txtIntrestRate.Text.Trim(), out intrestRate);
            
            if(!ok || intrestRate < 0)
            {
                MessageBox.Show("Error, Wrong Intrest Rate");
            }
            else // else is needed otherwise intrestRate will go to calculator
            {
                savingCalc.SetIntrestRate(intrestRate);
            }
            return ok;
            
        }

        bool ReadTax()
        {
            double tax = 0.0;
            bool ok = double.TryParse(txtTax.Text, out tax);
            if(!ok)
            {
                MessageBox.Show("Error, Wrong Tax");
            }
            else
            savingCalc.SetTax(tax);
            return ok;
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            ReadMonthlyDeposit();
            ReadSavingsPeriod();
            ReadIntrestRate();
            ReadTax();

            lblAmountPaid.Text = savingCalc.CalculateAmountPaid().ToString("f2");
            lblFinalBalance.Text = savingCalc.CalculateBalance().ToString("f2");
            lblIntrestEarned.Text = savingCalc.ReturnIntrestEarned().ToString("f2");
            lblTotalTax.Text = savingCalc.ReturnTaxAmount().ToString("f2");
            
        }

        #endregion
        
        #region BMRCalculator
        private void UpdateGenderStatus()
        {
            if(rbtnFemale.Checked)
            {
                bmrCalc.SetGender(Gender.Female);
            }
            else
            {
                bmrCalc.SetGender(Gender.Male);
            }
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGenderStatus();
        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGenderStatus();
        }

        private void ReadAge()
        {
            int age;
            bool ok = int.TryParse(txtAge.Text , out age);

            if(!ok)
            {
                MessageBox.Show("Error Wrong Age");
            }
            else
            {
                bmrCalc.SetAge(age);
            }
        }
        

        private void rbtnNoActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetFactor(1.2);
        }

        private void rbtnLightlyActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetFactor(1.375);
        }

        private void rbtnModeratelyActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetFactor(1.550);
        }

        private void rbtnVeryActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetFactor(1.725);
        }

        private void rbtnExtraActiv_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetFactor(1.9);
        }

        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            ReadInputBMI(); // first we need to read input from ReadWeight() and ReadHeight()
            ReadUnit(); // reading unit
            
            // Then we put values from BMICalculator into instance values in BmrCalculator
            bmrCalc.GetWeightFromBmiClass(bmiCalc); // we do it by using those two methods
            bmrCalc.GetHeightFromBmiClass(bmiCalc);
            bmrCalc.GetUnitFromBmiClass(bmiCalc);

            ReadAge(); // we also need to read age value to calculations

            

            lblBmr.Text = bmrCalc.CalculateBMR().ToString("f2"); // lastly we do calculations 
            lblMaintainWeight.Text = bmrCalc.MaintainWeight().ToString("f2");
            lblLoseOrGain.Text = bmrCalc.LoseOrGainWeight().ToString();
        }
        #endregion
    }
}