using System;

namespace MethodsAndParameters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] fees = new double[5];
            double[] finalFees = new double[5];

                        Process_Fees(fees);

            
            finalFees = Calculate_Discount(fees);

            
            Console.WriteLine("The fees with discount are as:");
            for (int i = 0; i < finalFees.Length; i++)
            {
                Console.WriteLine("Student {0} : {1}", i + 1, finalFees[i]);
            }
        }

        // Accept fees (no while loop, use for + i--)
        public static void Process_Fees(double[] fees)
        {
            for (int i = 0; i < fees.Length; i++)
            {
                Console.Write("Enter fees for Student {0} : ", i + 1);
                string input = Console.ReadLine();

                double fee;
                if (double.TryParse(input, out fee))
                {
                    if (fee >= 5000 && fee <= 10000)
                    {
                        fees[i] = fee;
                    }
                    else
                    {
                        Console.WriteLine(" Fees must be in the range 5000 to 10000");
                        i--; 
                    }
                }
                else
                {
                    Console.WriteLine( "Please enter a valid number.");
                    i--; 
                }
            }
        }

        
        public static double[] Calculate_Discount(double[] fees)
        {
            double[] discountedFees = new double[fees.Length];

            for (int i = 0; i < fees.Length; i++)
            {
                if (fees[i] > 7000)
                {
                    discountedFees[i] = fees[i] - (fees[i] * 0.05);
                }
                else
                {
                    discountedFees[i] = fees[i];
                }
            }

            return discountedFees;
        }
    }
}
