using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIcalculator
{
    class BmrCalculator
    {
        private int _age;
        private double _BMR;
        private Gender _Gender; // declaring enum Gender
        private double _factor;
        private double _weight;
        private double _height;
        private UnitTypes unit;

        public double Weight
        {
            set { _weight = value;}
        }

        public double Height
        {
            set { _height = value;}
        }
        public UnitTypes Unit
        {
            set { unit = value;}
        }

        public Gender Gender
        {
            set { _Gender = value; }
        }

        public double Factor
        {
            set { _factor = value;}
        }

        public int Age
        {
            set {_age = value;}
        }

        public double CalculateBMR()
        {
            
            if (_Gender == Gender.Female)
            {
                if(unit == UnitTypes.Metric)
                    _BMR = (10 * _weight) + (6.25 * _height*100) - (5 * _age) - 161;
                else
                    _BMR = (10 * _weight*0.454) + (6.25 * _height * 2.54) - (5 * _age) - 161;

            }
            else
            {
                if (unit == UnitTypes.Metric)
                    _BMR = (10 * _weight) + (6.25 * _height*100) - (5 * _age) + 5;
                else
                    _BMR = (10 * _weight*0.454) + (6.25 * _height * 2.54) - (5 * _age) + 5;
            }
            return _BMR;
        }

        public double CalculationToMaintainWeight()
        {
            double maintainWeight = _BMR * _factor;
            return maintainWeight;
        }

        public string LoseOrGainWeight(int number)
        {
            //To lose 500 gr(0.5 kg) a week = maintainWeightBMRs – 500 
            //To lose 1000 gr(1 kg) a week = maintainWeightBMRs –1000 
            //To add 500 gr(0.5 kg) a week = maintainWeightBMRs + 500 
            //To add 1000 gr(1 kg) a week = maintainWeightBMRs + 1000
            string weight1;
            string weight2;
            string weight3;
            string weight4;
            
            if(number < 0 && number > 4)
            {
                MessageBox.Show("Error wrong number");
                
            }

            switch(number)
            {
                case 1:
                    weight1 = String.Format($"Calories to lose 500g a week: {CalculationToMaintainWeight() - 500:f2}");
                    return weight1;
                    break;
                case 2:
                    weight2 = String.Format(($"Calories to lose 1kg a week: {CalculationToMaintainWeight() - 1000:f2}"));
                    return weight2;
                case 3:
                    weight3 = String.Format(($"Calories to gain 500g a week: {CalculationToMaintainWeight() + 500:f2}"));
                    return weight3;
                case 4:
                    weight4 = String.Format(($"Calories to gain 1kg a wekk: {CalculationToMaintainWeight() + 1000:f2}"));
                    return weight4;
            }
            return null;
            
        }

    }
}
