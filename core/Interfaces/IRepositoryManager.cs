﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta.Core.Interfaces
{
  public  interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IOrderRepository Order { get;  }

        Task SaveAsync();
    }

}
