using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project2.DAL.Interfaces;
using Project2.DAL.Entities;

namespace Project2.DAL.Repository
{
    public class CollectionRepo : GenericRepo<Collections>, ICollection
    {
        public CollectionRepo(DBContext dbContext) : base(dbContext) { }

    }
}
