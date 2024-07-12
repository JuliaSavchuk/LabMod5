using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMod5
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        // Перевантаження оператора +
        public static Employee operator +(Employee e, decimal amount)
        {
            return new Employee(e.Name, e.Age, e.Salary + amount);
        }

        // Перевантаження оператора -
        public static Employee operator -(Employee e, decimal amount)
        {
            return new Employee(e.Name, e.Age, e.Salary - amount);
        }

        // Перевантаження оператора ==
        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.Salary == e2.Salary;
        }

        // Перевантаження оператора !=
        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.Salary != e2.Salary;
        }

        // Перевантаження оператора <
        public static bool operator <(Employee e1, Employee e2)
        {
            return e1.Salary < e2.Salary;
        }

        // Перевантаження оператора >
        public static bool operator >(Employee e1, Employee e2)
        {
            return e1.Salary > e2.Salary;
        }

        // Перевантаження Equals
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee e = (Employee)obj;
                return this.Salary == e.Salary;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }

        // Перевизначення методу ToString для зручного відображення
        public override string ToString()
        {
            return $"{Name}, Age: {Age}, Salary: {Salary:C}";
        }
    }
}
