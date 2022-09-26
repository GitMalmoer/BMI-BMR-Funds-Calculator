using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIcalculator
{
     class BMIcalculator
    {
        private double height;
        private double weight;
        private UnitTypes unit;

        public BMIcalculator()
        {
            unit = UnitTypes.Metric;
        }

        #region Setters and getters
        public double getHeight(double height)
        {
            return height;
        }

        public void setHeight(double height)
        {
            if(height >= 0.0)
            this.height = height;
        }

        public double getWeight()
        {
            return weight;
        }

        public void setWeight(double weight)
        {
            if (weight >= 0.0)
                this.weight = weight;
        }

        public UnitTypes getUnit()
        {
            return unit;
        }

        public void setUnit(UnitTypes unit)
        {
            this.unit = unit;
        }
        #endregion
        
        //Calculations
        // Pounds and inches
        // Formula: weight(lb) / [height(in)] 2x703
        // calculate BMI by dividing weight in pounds by height in inches
        // example weight = 150 lbs, height = 5'5" (65")
        // calculation [150 / (65)/2 ]
        // x 703 = 24,96

        public double CalculateBMI()
        {
            // metric values 
            // height must be in m or inches
            double bmiValue = 0.0;
            double factor = 1.0;

            if(unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }

            bmiValue = (factor  * weight / (height*height));
            return bmiValue;
        }

        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;

            if (bmi < 18.5)
                stringout = "Underweight";
            else if (bmi <= 24.9)
                stringout = "Normal weight(Pre-Obesity)";
            else if (bmi <= 29.9)
                stringout = "Overweight";
            else if (bmi <= 34.9)
                stringout = "Overweight (Obesity class I)";
            else if (bmi <= 39.9)
                stringout = "Overweight (Obesity class II)";
            else if (bmi >= 40.0)
                stringout = "Overweight (Obesity class III)";
            return stringout; 
        }

        public double NormalWeightLowLimit()
        {
            double factor = 1.0;
            double weight;
            double weightLow;
            if (unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }
            weight = (this.height * this.height)/factor;
            weightLow = weight * 18.50; //low limit 
            return weightLow;
        }

        public double NormalWeightHighLimit()
        {
            double factor = 1.0;
            double weight;
            double weightHigh;
            if (unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }
            weight = (this.height * this.height) / factor;
            weightHigh = weight * 24.9; // high limit 
            return weightHigh;
        }

    }
}
