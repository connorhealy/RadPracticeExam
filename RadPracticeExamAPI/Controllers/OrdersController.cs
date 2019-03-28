using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RadPracticeExam;
using RadPracticeExam.DTO;
using RadPracticeExamAPI.Models;

namespace RadPracticeExamAPI.Controllers
{
    [Authorize(Roles = "Manager")]
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        private BusinessDbContext db = new BusinessDbContext();
   

        public OrderRepository OrdersRepo;

        public OrdersController(OrderRepository repo)
        {
            this.OrdersRepo = repo;
        }
        public OrdersController()
        {
            OrdersRepo  = new OrderRepository();
        }


        [Route("GetOrdersByUserID/{uid}")]
        private OrdersViewModel GetOrdersByUserID(string uid)
        {
            return OrdersRepo.GetOrdersByUserID(uid);
        }
        [Route("UpdateOrder")]
        private void UpdateOrder(Orders order, string uid)
        {
            OrdersRepo.UpdateOrder(order, uid);
        }
        [Route("CreateOrder")]
        void CreateOrder(Orders order, string uid)
        {
            OrdersRepo.CreateOrder(order, uid);
        }
    }
}