﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxSimpleHelper.Models
{
    public class OrdersDb
    {

        public static IEnumerable<Order> GetOrders
        {
            get
            {
                List<Order> list = new List<Order>()
                {
                    new Order{ Id=1, Product="WinXp", Quantity=2, Customer="Microsoft"},
                     new Order{ Id=2, Product="Win10", Quantity=20, Customer="Microsoft"},
                      new Order{ Id=3, Product="WinNT", Quantity=200, Customer="Microsoft"},
                       new Order{ Id=4, Product="Iphone", Quantity=3, Customer="Apple"},
                        new Order{ Id=5, Product="IMac", Quantity=24, Customer="Apple"},
                         new Order{ Id=6, Product="IClon", Quantity=234, Customer="Apple"},
                          new Order{ Id=7, Product="IClon", Quantity=2, Customer="Dima"},
                           new Order{ Id=8, Product="MEms", Quantity=56, Customer="Dima"},
                            new Order{ Id=9, Product="Clouds", Quantity=90, Customer="Amazon"},
                           new Order{ Id=10, Product="Servers", Quantity=2, Customer="Amazon"}


                };


                return list;
            }

        }
    }
}