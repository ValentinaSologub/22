class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Semenov", "Max");
        employee.CalculateSalaryAndTax(Position.designer, 10);
        employee.PrintSalaryWithTax();
        Console.Write(employee);
    }
}