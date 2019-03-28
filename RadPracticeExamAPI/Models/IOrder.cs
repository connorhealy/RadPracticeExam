using RadPracticeExam;
using RadPracticeExam.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadPracticeExamAPI.Models
{
    interface IOrder
    {
        OrdersViewModel GetOrdersByUserID(string uid);
        void UpdateOrder(Orders order, string uid);
        void CreateOrder(Orders order, string uid);
    }
}
