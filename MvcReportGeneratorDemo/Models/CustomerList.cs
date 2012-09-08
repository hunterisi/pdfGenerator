using System.Collections.Generic;

namespace MvcReportGeneratorDemo.Models
{
    public class CustomerList : List<Customer>
    {
        public string ImageUrl { get; set; }
    }
}