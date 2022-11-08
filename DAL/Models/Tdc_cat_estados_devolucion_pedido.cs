using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Models
{
    [Table("tdc_cat_estados_devolucion_pedido", Schema = "dwh_torrecontrol")]
    public class Tdc_cat_estados_devolucion_pedido
    {
        [Key]
        [Column("Md_uuid")]
        [Display(Name = "Md_uuid")]
        public string Md_uuid { get; set; }
        [Required]
        [Column("Md_date")]
        [Display(Name = "Md_date")]
        public DateTime Md_date { get; set; }
       
        [Column("Id")]
        [Display(Name = "Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column("Cod_estado_devolucion")]
        [Display(Name = "Cod_estado_devolucion")]
        public string Cod_estado_devolucion { get; set; }

        [Column("Des_estado_devolucion")]
        [Display(Name = "Des_estado_devolucion")]
        public string? Des_estado_devolucion { get; set; }

        //---------------------------------------------------------------------------------------------------------------------------------
        [InverseProperty("EstadoDevolucion")]
        public virtual List<Tdc_tch_estado_pedidos>? ListaEstadoPedidos { get; set; }

    }
}
