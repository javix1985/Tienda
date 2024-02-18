using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Tienda.Modelos
{
    public class Articulos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int nro_serie_id { get; set; }
        
        public int marca_id { get; set; }
        
        public int modelo_id { get; set; }

        public int tipo_prod_id { get; set; }

        [StringLength (240)]
        public string? descripcion { get; set; }

        public int stock { get; set; }

        public decimal precio { get; set; }
    }
}
