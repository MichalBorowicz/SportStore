using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SportStore.Domain.Concrete
{
    class Context : DbContext
    {
		public DbSet<Product> Products { get; set; }
    }
}
