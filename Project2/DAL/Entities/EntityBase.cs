using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.DAL.Interfaces;

namespace Project2.DAL.Entities
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
    }
}
