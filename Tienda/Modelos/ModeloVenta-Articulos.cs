using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace Tienda.Modelos
{
    public class ModeloVenta_Articulos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Marca_Id { get; set; }
        public int Modelo_Id { get; set; }

        public int Articulo_Id { get; set; }

        public int cantidad { get; set; }

        public decimal precio { get; set; }

        public decimal total { get; set; }
    }
}
