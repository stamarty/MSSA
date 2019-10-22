using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to use lbs or kgs?");
            string measure = Console.ReadLine();

            if (measure == "lbs")
            {
                Console.WriteLine("What is your height in inches?");
                int height;
                string sHeight = Console.ReadLine();
                if (int.TryParse(sHeight, out height))
                {
                    Console.WriteLine("What is your weight in lbs?");
                    float weight;
                    string sWeight = Console.ReadLine();
                    if (float.TryParse(sWeight, out weight))
                    {
                        LBBMICalculation(height, weight);

                        //TODO Need to add the call for the BMI results here. 
                        if (BMI >= 30)
                        {
                            Console.WriteLine("obese");
                        }

                        else if (BMI > 25)
                        {
                            Console.WriteLine("overweight");
                        }

                        else if (BMI >= 18.5)
                        {
                            Console.WriteLine("normal");
                        }

                        else if (BMI < 18.5)
                        {
                            Console.WriteLine("underweight");
                        }

                        else
                        {
                            InvalidInput("weight");
                        }
                    }
                    else
                    {
                        InvalidInput("height");
                    }
                }
                else
                {
                    InvalidInput("measurement");
                }
            }

            else if (measure == "kgs")
            {
                Console.WriteLine("What is your height in centimeters?");
                float height = 0;
                string sHeight = Console.ReadLine();
                if (float.TryParse(sHeight, out height))
                {
                    Console.WriteLine("What is your weight in kgs?");
                    int weight;
                    string sWeight = Console.ReadLine();
                    if (int.TryParse(sWeight, out weight))
                    {
                        KGBMICalculation(height, weight);

                        if (BMI >= 30)
                        {
                            Console.WriteLine("obese");
                        }

                        else if (BMI > 25)
                        {
                            Console.WriteLine("overweight");
                        }

                        else if (BMI >= 18.5)
                        {
                            Console.WriteLine("normal");
                        }

                        else if (BMI < 18.5)
                        {
                            Console.WriteLine("underweight");
                        }

                        else
                        {
                            Console.WriteLine("I think we messed up somewhere. Try again.");
                        }

                    }
                    else
                    {
                        InvalidInput("weight");
                    }
                }
                else
                {
                    InvalidInput("height");
                }
            }
            else
            {
                InvalidInput("measurement");
            }
        }

        public static void InvalidInput (string section)
        {
            Console.WriteLine($"Something went wrong, please select a valid {section}");
        }

        //TODO Need to return BMI How do I do it? 
        public static float LBBMICalculation (float height, float weight)
        {
            float BMI = (weight * 703) / (height * height);
        }

        //TODO Need to return BMI How do I do it? 
        public static float KGBMICalculation(float height, float weight)
        {
            float BMI = (weight) / ((height / 1000) * (height / 1000));
        }

        //TODO Create a BMI Method to check calculators against and return results....
    }
}
