using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataContexts
{
    public class BDPostgreContext : DbContext
    {
        public BDPostgreContext(DbContextOptions<BDPostgreContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Tdc_tch_estado_pedidos> SetEstadoPedidos { get; set; }
        public DbSet<Tdc_cat_lineas_distribucion> SetLineasDistribucion { get; set; }
        public DbSet<Tdc_cat_estados_envio_pedido> SetEstadosEnvioPedido { get; set; }
        public DbSet<Tdc_cat_estados_pago_pedido> SetEstadosPagoPedido { get; set; }
        public DbSet<Tdc_cat_estados_devolucion_pedido> SetEstadosDevolucionPedido { get; set; }

    }
}
