namespace Composite.Entities
{
    using System.Collections.Generic;

    public class Employee
    {
        private string name;
        private string dept;
        private int salary;
        private List<Employee> subordinates;

        public Employee(string name, string dept, int salary)
        {
            this.name = name;
            this.dept = dept;
            this.salary = salary;
            subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            subordinates.Add(e);
        }
        public void Remove(Employee e)
        {
            subordinates.Remove(e);
        }
        public List<Employee> getSubordinates()
        {
            return subordinates;
        }
        public string toString()
        {
            return ("Employee :[ Name : " + name + ", dept : " + dept + ", salary :" + salary + " ]");
        }
    }
}