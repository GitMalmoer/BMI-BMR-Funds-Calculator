using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIcalculator
{
     class BMIcalculator
    {
        private static double _weight;
        private static double _height;
        private static UnitTypes _unit;

        public BMIcalculator()
        {
            _unit = UnitTypes.Metric;
        }

        #region Setters and getters
        
        public static double Weight 
        {
            get { return _weight;}
            set 
            {
                if (_weight >= 0.0)
                    _weight = value;
            }
        }

        public static double Height
        {
            get { return _height; }
            set 
            {
                if (_height >= 0.0)
                    _height = value;
            }
        }

        public static UnitTypes getUnit()
        {
            return _unit;
        }

        public static void setUnit(UnitTypes unit)
        {
            _unit = unit;
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

            if(_unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }

            bmiValue = factor  * (_weight / (_height*_height));
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
            if (_unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }
            weight = (_height * _height)/factor;
            weightLow = weight * 18.50; //low limit 
            return weightLow;
        }

        public double NormalWeightHighLimit() // normal weight is between {NormalWeightLowLimit()} and {NormalWeightHighLimit}
        {
            double factor = 1.0;
            double weight;
            double weightHigh;
            if (_unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }
            weight = (_height * _height) / factor;
            weightHigh = weight * 24.9; // high limit 
            return weightHigh;
        }

    }
}
