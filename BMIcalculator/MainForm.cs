namespace BMIcalculator
{
    public partial class MainForm : Form
    {
        private string name = string.Empty; // instance variable
        BMIcalculator bmiCalc = new BMIcalculator();
        SavingCalculator savingCalc = new SavingCalculator();
        public MainForm()
        {      
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "Marcin Junka";
            lblBMI.Text = String.Empty;
            lblWeightCategory.Text = string.Empty;
            lblNormalBMI.Text = "Normal Weight";
            rbtnMetric.Checked = true;
            lblNormalBMI.Text = ("Normal BMI is between 18.5 and 24.9");
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

        private bool ReadMonthlyDeposit()
        {
            double monthlyDeposit = 0.0;
            bool ok = double.TryParse((txtMonthlyDeposit.Text).Trim(), out monthlyDeposit);
            if(!ok)
            {
                MessageBox.Show("Error wrong Monthly deposit value.");
            }
            savingCalc.SetDeposit(monthlyDeposit);
            return ok;

        }

        private bool ReadSavingsPeriod()
        {
            int savingsPeriod = 0;
            bool ok = int.TryParse(txtPeriod.Text.Trim(), out savingsPeriod);
            if(!ok && savingsPeriod < 1)
            {
                MessageBox.Show("Error, Wrong Saving Period");
            }
            savingCalc.SetYears(savingsPeriod);
            return ok;
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            ReadMonthlyDeposit();
            ReadSavingsPeriod();
            lblAmountPaid.Text = savingCalc.CalculateAmountPaid().ToString("f2");
            lblFinalBalance.Text = savingCalc.CalculateBalance().ToString("f2");
        }
    }
}