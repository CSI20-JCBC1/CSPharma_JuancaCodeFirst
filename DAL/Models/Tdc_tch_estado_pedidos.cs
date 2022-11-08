using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Models
{
    [Table("tdc_tch_estado_pedidos", Schema = "dwh_torrecontrol")]
    public class Tdc_tch_estado_pedidos
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
        
        [Column("Cod_estado_envio")]
        [Display(Name = "Cod_estado_envio")]
        public string? Cod_estado_envio { get; set; }
        
        [Column("Cod_estado_pago")]
        [Display(Name = "Cod_estado_pago")]
        public string? Cod_estado_pago { get; set; }
        
        [Column("Cod_estado_devolucion")]
        [Display(Name = "Cod_estado_devolucion")]
        public string? Cod_estado_devolucion { get; set; }
        [Required]
        [Column("Cod_pedido")]
        [Display(Name = "Cod_pedido")]
        public string Cod_pedido { get; set; }
        [Required]
        [Column("Cod_linea")]
        [Display(Name = "Cod_linea")]
        public string Cod_linea { get; set; }


        //-------------------------------------------------------------------------------------------------
       
        [ForeignKey("Cod_linea")]
        public Tdc_cat_lineas_distribucion? LineaDistribucion { get; set; }
        [ForeignKey("Cod_estado_envio")]
        public Tdc_cat_estados_envio_pedido? EstadoEnvio { get; set; }
        [ForeignKey("Cod_estado_pago")]
        public Tdc_cat_estados_pago_pedido? EstadoPago { get; set; }
        [ForeignKey("Cod_estado_devolucion")]
        public Tdc_cat_estados_devolucion_pedido? EstadoDevolucion { get; set; }



    }
}
