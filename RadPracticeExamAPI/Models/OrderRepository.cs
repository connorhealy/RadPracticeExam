using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using RadPracticeExam;
using RadPracticeExam.DTO;

namespace RadPracticeExamAPI.Models
{
    public class OrderRepository : IOrder, IUser 
    {
        BusinessDbContext BusinessDB = new BusinessDbContext();
        ApplicationDbContext AppDB = new ApplicationDbContext();
        public string Id => throw new NotImplementedException();

        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CreateOrder(Orders order, string uid)
        {
          // to do
        }

    

        public ApplicationUser getUserByID(string id)
        {
            return AppDB.Users.Find(id);
        }

        public void UpdateOrder(Orders order, string uid)
        {
        //    BusinessDB.Orders.AddOrUpdate()
        }

        public OrdersViewModel GetOrdersByUserID(string uid)
        {
            ApplicationUser user = getUserByID(uid);
            if (user != null)
            {
                var UsersOrders = BusinessDB.Orders.Where(o => o.OrderedBy == uid).ToList();
                return new OrdersViewModel
                {
                    OrderedBy = user.Id,
                    Orders = UsersOrders
                };
            }
            return null;
        }
    }
}