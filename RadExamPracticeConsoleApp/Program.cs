using RadPracticeExam;
using RadPracticeExam.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIClient;

namespace RadExamPracticeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientAuthentication.baseWebAddress = "http://localhost:2327/";
            if (ClientAuthentication.login("bowles.lionie@itsligo.ie", "LBowles$1"))
            {
                Console.WriteLine("Successful login Token acquired {0} user status is {1}", ClientAuthentication.AuthToken, ClientAuthentication.AuthStatus.ToString());
                try
                {
                    OrdersViewModel orders = ClientAuthentication.getItem<OrdersViewModel>("api/Orders/GetOrdersByUserID/" + "0ad55e42-0b7e-4ee4-af6b-ddd527fa0144" );
                  foreach (Orders item in orders.Orders)
                    {
                        Console.WriteLine("OrderDate {0}", item.OrderDate);
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error {0} --> {1}", ex.Message, ex.InnerException.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
