﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer   //cambio lilin
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string eMail { get; set; }

        public int phoneNumber { get; set; }

        List<Order_Confirmation> order_Confirmations { get; set; }
    }
}
