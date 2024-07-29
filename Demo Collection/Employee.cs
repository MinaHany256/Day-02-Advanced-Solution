using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Collection
{
    class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Name?.CompareTo(y?.Name) ?? (y is null? 0 :-1) ;
        }
    }

    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            
        }

        public Employee(int Id, string? Name, decimal Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name}, Salary: {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;

            return this.Salary.CompareTo(other.Salary);
        }
    }
}
