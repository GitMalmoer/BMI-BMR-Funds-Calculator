namespace BMIcalculator
{
    public partial class MainForm : Form
    {
        private string name = string.Empty; // instance variable
       
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
        }

        private void UpdateHeightText()
        {
            if(rbtnMetric.Checked == true)
            {
                lblHeight.Text = "Height (Cm)";
                lblWeight.Text = "Weight (Kg)";
            }
            else
            {
                lblHeight.Text = "Height (Ft)";
                lblWeight.Text = "Weight (lbs)";
            }


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
            ReadInputBMI();
        }

        private bool ReadInputBMI()
        {
            ReadName();
            bool weightOK = ReadWeight();
            bool heightOK = ReadHeight();

            return weightOK && heightOK;
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
            return ok;
        }


        
    }
}