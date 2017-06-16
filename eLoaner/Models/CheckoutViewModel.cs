using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eLoaner.Models
{
    public class CheckoutViewModel
    {
        public List<Customer> Customers { get; set; }
        public List <Asset> Assets { get; set; }
        public Checkout Checkout { get; set; }

        public List <Checkout> CheckOuts { get; set; }


    }
}