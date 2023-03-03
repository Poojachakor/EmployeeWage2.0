namespace EmpProgram2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....EMP WAGE COMPUTATION....");

            //UC7-Use Class Method and Variables
            //UC8-Multiple companies
            EmpWageBuilders Tata = new EmpWageBuilders("HCL", 30, 16, 60);
            EmpWageBuilders Google = new EmpWageBuilders("TCS", 20, 15, 80);
            EmpWageBuilders Apple = new EmpWageBuilders("BRIDGELAB", 15, 18, 100);

            Tata.EmpWage();
            Console.WriteLine(Tata.ToString());
            Google.EmpWage();
            Console.WriteLine(Apple.ToString());
            Apple.EmpWage();
            Console.WriteLine(Google.ToString());

            Console.ReadLine();
        }
    }
    
}