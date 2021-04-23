using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevaP1.Data
{
    public class RevaP1DbContext: DbContext
    {
        public RevaP1DbContext(DbContextOptions<RevaP1DbContext> options): base(options)
        {

        }

        //create dbsets for all your classes below

    }
}
