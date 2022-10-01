using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIcalculator
{
    class BmrCalculator
    {
        private int age;
        private double BMR;
        private Gender Gender; // declaring enum Gender
        private double factor;
        private double weight;
        private double height;
        private UnitTypes unit;

        // Three very important functions to get values from the class BMIcalculator
        // without those program would not work. Without them we would need to make our own getters and setters
        public void GetWeightFromBmiClass(BMIcalculator BMIcalc)
        {
            this.weight = BMIcalc.getWeight();
        }

        public void GetHeightFromBmiClass(BMIcalculator BMIcalc)
        {
            this.height = BMIcalc.getHeight();
        }

        public void GetUnitFromBmiClass(BMIcalculator Bmicalc)
        {
            this.unit = Bmicalc.getUnit();
        }

        
        /* Thanks to 3 functions above we save time and we dont have do those methods
        
        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double GetWeight()
        {
            return weight;
        }
        public double GetHeight()
        {
            return height;
        }
        */

        public void SetGender(Gender Gender)
        {
            this.Gender = Gender;
        }
        public Gender GetGender()
        {
            return this.Gender;
        }

        public double CalculateBMR()
        {
            
            if (Gender == Gender.Female)
            {
                if(unit == UnitTypes.Metric)
                    BMR = (10 * this.weight) + (6.25 * this.height*100) - (5 * age) - 161;
                else
                    BMR = (10 * this.weight*0.454) + (6.25 * this.height * 2.54) - (5 * age) - 161;

            }
            else
            {
                if (unit == UnitTypes.Metric)
                    BMR = (10 * this.weight) + (6.25 * this.height*100) - (5 * age) + 5;
                else
                    BMR = (10 * this.weight*0.454) + (6.25 * this.height * 2.54) - (5 * age) + 5;
            }
            return BMR;
        }

        public void SetFactor(double factor)
        {
            this.factor = factor;
        }

        public double MaintainWeight()
        {
            double maintainWeight = this.BMR * factor;
            return maintainWeight;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string LoseOrGainWeight()
        {
            //To lose 500 gr(0.5 kg) a week = maintainWeightBMRs – 500 
            
            //To lose 1000 gr(1 kg) a week = maintainWeightBMRs –1000 
            
            //To add 500 gr(0.5 kg) a week = maintainWeightBMRs + 500 
            
            //To add 1000 gr(1 kg) a week = maintainWeightBMRs + 1000
            
            string stringout = String.Format($"Calories To lose 500 gr(0.5 kg) a week: {MaintainWeight() - 500:f2} \n " +
                                $"Calories To lose 1000 gr(1 kg) a week: {MaintainWeight() - 1000:f2} \n" +
                                $"Calories To add 500 gr(0.5 kg) a week: {MaintainWeight() + 500:f2}  \n" +
                                $"Calories To add 1000 gr(1 kg) a week: {MaintainWeight() + 1000:f2}");
            return stringout; 
        }

    }
}
