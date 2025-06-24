namespace Planet_Gravity_Enum
{
       
    internal class Planet_Gravity_Enum
    {
        static readonly double[] gravityFactors = new double[]
        {0.38,0.91,1.00,0.38,2.34,1.06,0.92,1.19};



        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight on the earth in kg");
            double weightOnEarth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nyour weight on other planet");
            foreach (Planet planet in Enum.GetValues(typeof(Planet)))
            {
                double weightOnPlanet = weightOnEarth * gravityFactors[(int)planet];
                Console.WriteLine($"{planet}: {weightOnPlanet:F2} kg");
            }
        }
    }
    enum Planet {         
        Mercury, 
        Venus ,
        Earth ,
        Mars ,
        Jupiter ,
        Saturn ,
        Uranus ,
        Neptune
    }
}
