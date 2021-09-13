using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPrueba.Modelo;

namespace ApiPrueba.Data
{
    public class ApiPruebaContext : DbContext
    {
        public ApiPruebaContext (DbContextOptions<ApiPruebaContext> options)
            : base(options)
        {
        }

        public DbSet<ApiPrueba.Modelo.Producto> Producto { get; set; }
    }
}
