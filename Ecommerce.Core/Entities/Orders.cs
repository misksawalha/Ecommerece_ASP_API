using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }

        [ForeignKey(nameof(Orders))]
        public int LocalUserId { get; set; }
        
        public LocalUser LocalUser { get; set; }
        public ICollection<Orders> orders { get; set; } = new List<Orders>();
    }
}
