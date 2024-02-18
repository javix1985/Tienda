using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;



namespace Tienda.Modelos
{
    public class Modelo_ModelodeProductos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int tipo_prod_id { get; set; }

        public int marca_id { get; set; }
       
        public string? Modelo { get; set; }
    }
}
