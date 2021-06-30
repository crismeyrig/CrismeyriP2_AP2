using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrismeyriP2_AP2.Models
{
    public class CobrosDetalle
    {
            [Key]
            public int Id { get; set; }
            public int CobroId { get; set; }
            public virtual Cobros Cobro { get; set; }
            public int VentaId { get; set; }
            public virtual Ventas Venta { get; set; }
            public double Cobrado { get; set; }

        }
    }
}
