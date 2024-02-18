using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Tienda.Modelos
{
    public class Modelo_Abm_Marca
    {
        //crear modelo llamado marca, que contenga un campo id que sea clave primaria y autoincremental y un campo marca que sea varchar de 50

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
       
        [StringLength (50)]
        public string? Marca { get; set; }

    }
}
