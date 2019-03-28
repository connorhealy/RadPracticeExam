using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadPracticeExam.DTO
{
    public class OrdersViewModel
    {
        public double Total { get; set; }
        public List<Orders> Orders { get; set; }
        public string OrderedBy { get; set; }
    }
}
