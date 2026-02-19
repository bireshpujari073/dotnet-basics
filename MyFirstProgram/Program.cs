
namespace Polymorphysm
{
    public class Employee
    {
        public string firstname = "hello";
        public string lastname = " world";
        public void Print()
        {
            Console.WriteLine(firstname + " " + lastname);
        }
    }
    public class PermenantEmployee : Employee
    {
        public void Print()
        {
            Console.WriteLine(firstname + " " + lastname + " permenant");
        }
    }

    //public class ParttimeEmployee : Employee
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine(firstname + " " + lastname + " parttime");
    //    }
    //}

    //public class TemporaryEmployee : Employee
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine(firstname + " " + lastname + " temporary");
    //    }
    //}


    class Program
    {
        static void Main()
        {
            Employee[] employees = new Employee[2];
            employees[0] = new Employee();
            employees[1] = new PermenantEmployee();
            //employees[2] = new TemporaryEmployee();
            //employees[3] = new ParttimeEmployee();

            foreach (var employee in employees)
            {
                employee.Print();
            }

            var permanentEmployee = new PermenantEmployee();
            permanentEmployee.Print();
        }
    }

    public class Calculator
    {
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        public static double Add(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            return secondNumber + thirdNumber + fourthNumber + firstNumber;
        }

        public static int Add(params int[] numbers)
        {
            return numbers.Length;
        }
    }
}
