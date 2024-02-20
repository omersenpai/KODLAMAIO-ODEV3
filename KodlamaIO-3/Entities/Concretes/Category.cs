using KodlamaIO_3.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO_3.Entities.Concretes
{
    public class Category:IEntities
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
