﻿using PieShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Services
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
