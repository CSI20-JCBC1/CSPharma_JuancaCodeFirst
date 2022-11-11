﻿// <auto-generated />
using System;
using DAL.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(BDPostgreContext))]
    partial class BDPostgreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("DAL.Models.Tdc_cat_estados_devolucion_pedido", b =>
                {
                    b.Property<string>("Cod_estado_devolucion")
                        .HasColumnType("text")
                        .HasColumnName("Cod_estado_devolucion");

                    b.Property<string>("Des_estado_devolucion")
                        .HasColumnType("text")
                        .HasColumnName("Des_estado_devolucion");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Md_date");

                    b.Property<string>("Md_uuid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Md_uuid");

                    b.HasKey("Cod_estado_devolucion");

                    b.ToTable("Tdc_cat_estados_devolucion_pedido", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Models.Tdc_cat_estados_envio_pedido", b =>
                {
                    b.Property<string>("Cod_estado_envio")
                        .HasColumnType("text")
                        .HasColumnName("Cod_estado_envio");

                    b.Property<string>("Des_estado_envio")
                        .HasColumnType("text")
                        .HasColumnName("Des_estado_envio");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Md_date");

                    b.Property<string>("Md_uuid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Md_uuid");

                    b.HasKey("Cod_estado_envio");

                    b.ToTable("Tdc_cat_estados_envio_pedido", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Models.Tdc_cat_estados_pago_pedido", b =>
                {
                    b.Property<string>("Cod_estado_pago")
                        .HasColumnType("text")
                        .HasColumnName("Cod_estado_pago");

                    b.Property<string>("Des_estado_pago")
                        .HasColumnType("text")
                        .HasColumnName("Des_estado_pago");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Md_date");

                    b.Property<string>("Md_uuid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Md_uuid");

                    b.HasKey("Cod_estado_pago");

                    b.ToTable("Tdc_cat_estados_pago_pedido", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Models.Tdc_cat_lineas_distribucion", b =>
                {
                    b.Property<string>("Cod_linea")
                        .HasColumnType("text")
                        .HasColumnName("Cod_linea");

                    b.Property<string>("Cod_barrio")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cod_barrio");

                    b.Property<string>("Cod_municipio")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cod_municipio");

                    b.Property<string>("Cod_provincia")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cod_provincia");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Md_date");

                    b.Property<string>("Md_uuid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Md_uuid");

                    b.HasKey("Cod_linea");

                    b.ToTable("Tdc_cat_lineas_distribucion", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Models.Tdc_tch_estado_pedidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Cod_estado_devolucion")
                        .HasColumnType("text")
                        .HasColumnName("Cod_estado_devolucion");

                    b.Property<string>("Cod_estado_envio")
                        .HasColumnType("text")
                        .HasColumnName("Cod_estado_envio");

                    b.Property<string>("Cod_estado_pago")
                        .HasColumnType("text")
                        .HasColumnName("Cod_estado_pago");

                    b.Property<string>("Cod_linea")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cod_linea");

                    b.Property<string>("Cod_pedido")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cod_pedido");

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Md_date");

                    b.Property<string>("Md_uuid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Md_uuid");

                    b.HasKey("Id");

                    b.HasIndex("Cod_estado_devolucion");

                    b.HasIndex("Cod_estado_envio");

                    b.HasIndex("Cod_estado_pago");

                    b.HasIndex("Cod_linea");

                    b.ToTable("Tdc_tch_estado_pedidos", "dwh_torrecontrol");
                });

            modelBuilder.Entity("DAL.Models.Tdc_tch_estado_pedidos", b =>
                {
                    b.HasOne("DAL.Models.Tdc_cat_estados_devolucion_pedido", "EstadoDevolucion")
                        .WithMany("ListaEstadoPedidos")
                        .HasForeignKey("Cod_estado_devolucion");

                    b.HasOne("DAL.Models.Tdc_cat_estados_envio_pedido", "EstadoEnvio")
                        .WithMany("ListaEstadoPedidos")
                        .HasForeignKey("Cod_estado_envio");

                    b.HasOne("DAL.Models.Tdc_cat_estados_pago_pedido", "EstadoPago")
                        .WithMany("ListaEstadoPedidos")
                        .HasForeignKey("Cod_estado_pago");

                    b.HasOne("DAL.Models.Tdc_cat_lineas_distribucion", "LineaDistribucion")
                        .WithMany("ListaEstadoPedidos")
                        .HasForeignKey("Cod_linea")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoDevolucion");

                    b.Navigation("EstadoEnvio");

                    b.Navigation("EstadoPago");

                    b.Navigation("LineaDistribucion");
                });

            modelBuilder.Entity("DAL.Models.Tdc_cat_estados_devolucion_pedido", b =>
                {
                    b.Navigation("ListaEstadoPedidos");
                });

            modelBuilder.Entity("DAL.Models.Tdc_cat_estados_envio_pedido", b =>
                {
                    b.Navigation("ListaEstadoPedidos");
                });

            modelBuilder.Entity("DAL.Models.Tdc_cat_estados_pago_pedido", b =>
                {
                    b.Navigation("ListaEstadoPedidos");
                });

            modelBuilder.Entity("DAL.Models.Tdc_cat_lineas_distribucion", b =>
                {
                    b.Navigation("ListaEstadoPedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
