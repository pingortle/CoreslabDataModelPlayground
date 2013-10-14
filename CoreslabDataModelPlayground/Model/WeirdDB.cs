using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.Model
{
    internal sealed class WeirdDB
    {
        WeirdDB()
        {
            Activities = new List<Activity>();
            Customers = new List<Customer>();
            Employees = new List<Employee>();
            Jobs = new List<Job>();
            JobAssignments = new List<JobAssignment>();
            Jobsites = new List<Jobsite>();
            Products = new List<Product>();
            ProductCompositions = new List<ProductComposition>();
            Projects = new List<Project>();
        }

        public IEnumerable<Activity> Activities { get; private set; }
        public IEnumerable<Customer> Customers { get; private set; }
        public IEnumerable<Employee> Employees { get; private set; }
        public IEnumerable<Job> Jobs { get; private set; }
        public IEnumerable<JobAssignment> JobAssignments { get; private set; }
        public IEnumerable<Jobsite> Jobsites { get; private set; }
        public IEnumerable<Product> Products { get; private set; }
        public IEnumerable<ProductComposition> ProductCompositions { get; private set; }
        public IEnumerable<Project> Projects { get; private set; }
    }
}
