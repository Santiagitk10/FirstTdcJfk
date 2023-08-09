﻿using FirstTdcJfk.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTdcJfk.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ITdcRepository Tdcs { get; };
    }
}