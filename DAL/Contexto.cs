﻿using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Depositos> Deposito { get; set; }
        public DbSet<CuentasBancarias> Cuenta { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
