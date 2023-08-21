using Entitiy.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.Concrete
{
    public class Category : IEntity
    {
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
