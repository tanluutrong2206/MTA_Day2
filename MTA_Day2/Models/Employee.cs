namespace MTA_Day2.Models
{
    public class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Sales { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Employee: {{Name: {Name}, Age: {Age}, Sales: {Sales}, Salary: {Salary}}}";
        }
    }
}
