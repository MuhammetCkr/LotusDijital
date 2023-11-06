using LotusDijital.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Concrete.EfCore.Context
{
    public class LotusDijitalDbContext : IdentityDbContext<User>
    {
        public LotusDijitalDbContext(DbContextOptions options) : base(options) { }

    }
}
