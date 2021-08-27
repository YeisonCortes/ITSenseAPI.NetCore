﻿using ITSenseAPI.NetCore.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITSenseAPI.NetCore
{
    public class ITSenseContext: DbContext
    {
        public ITSenseContext(DbContextOptions<ITSenseContext> options) : base(options)
        {

        }

        public DbSet<Movimientos> Movimientos { get; set; }

        public DbSet<mdInventario> Inventario { get; set; }
    }
}