using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migracionFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tdc_tch_estado_pedidos_tdc_cat_estados_devolucion_pedido_Co~",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_tdc_tch_estado_pedidos_tdc_cat_estados_envio_pedido_Cod_est~",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_tdc_tch_estado_pedidos_tdc_cat_estados_pago_pedido_Cod_esta~",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_tdc_tch_estado_pedidos_tdc_cat_lineas_distribucion_Cod_linea",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tdc_tch_estado_pedidos",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tdc_cat_lineas_distribucion",
                schema: "dwh_torrecontrol",
                table: "tdc_cat_lineas_distribucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tdc_cat_estados_pago_pedido",
                schema: "dwh_torrecontrol",
                table: "tdc_cat_estados_pago_pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tdc_cat_estados_envio_pedido",
                schema: "dwh_torrecontrol",
                table: "tdc_cat_estados_envio_pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tdc_cat_estados_devolucion_pedido",
                schema: "dwh_torrecontrol",
                table: "tdc_cat_estados_devolucion_pedido");

            migrationBuilder.RenameTable(
                name: "tdc_tch_estado_pedidos",
                schema: "dwh_torrecontrol",
                newName: "Tdc_tch_estado_pedidos",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameTable(
                name: "tdc_cat_lineas_distribucion",
                schema: "dwh_torrecontrol",
                newName: "Tdc_cat_lineas_distribucion",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameTable(
                name: "tdc_cat_estados_pago_pedido",
                schema: "dwh_torrecontrol",
                newName: "Tdc_cat_estados_pago_pedido",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameTable(
                name: "tdc_cat_estados_envio_pedido",
                schema: "dwh_torrecontrol",
                newName: "Tdc_cat_estados_envio_pedido",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameTable(
                name: "tdc_cat_estados_devolucion_pedido",
                schema: "dwh_torrecontrol",
                newName: "Tdc_cat_estados_devolucion_pedido",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameIndex(
                name: "IX_tdc_tch_estado_pedidos_Cod_linea",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                newName: "IX_Tdc_tch_estado_pedidos_Cod_linea");

            migrationBuilder.RenameIndex(
                name: "IX_tdc_tch_estado_pedidos_Cod_estado_pago",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                newName: "IX_Tdc_tch_estado_pedidos_Cod_estado_pago");

            migrationBuilder.RenameIndex(
                name: "IX_tdc_tch_estado_pedidos_Cod_estado_envio",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                newName: "IX_Tdc_tch_estado_pedidos_Cod_estado_envio");

            migrationBuilder.RenameIndex(
                name: "IX_tdc_tch_estado_pedidos_Cod_estado_devolucion",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                newName: "IX_Tdc_tch_estado_pedidos_Cod_estado_devolucion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tdc_tch_estado_pedidos",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tdc_cat_lineas_distribucion",
                schema: "dwh_torrecontrol",
                table: "Tdc_cat_lineas_distribucion",
                column: "Cod_linea");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tdc_cat_estados_pago_pedido",
                schema: "dwh_torrecontrol",
                table: "Tdc_cat_estados_pago_pedido",
                column: "Cod_estado_pago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tdc_cat_estados_envio_pedido",
                schema: "dwh_torrecontrol",
                table: "Tdc_cat_estados_envio_pedido",
                column: "Cod_estado_envio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tdc_cat_estados_devolucion_pedido",
                schema: "dwh_torrecontrol",
                table: "Tdc_cat_estados_devolucion_pedido",
                column: "Cod_estado_devolucion");

            migrationBuilder.AddForeignKey(
                name: "FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_devolucion_pedido_Co~",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                column: "Cod_estado_devolucion",
                principalSchema: "dwh_torrecontrol",
                principalTable: "Tdc_cat_estados_devolucion_pedido",
                principalColumn: "Cod_estado_devolucion");

            migrationBuilder.AddForeignKey(
                name: "FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_envio_pedido_Cod_est~",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                column: "Cod_estado_envio",
                principalSchema: "dwh_torrecontrol",
                principalTable: "Tdc_cat_estados_envio_pedido",
                principalColumn: "Cod_estado_envio");

            migrationBuilder.AddForeignKey(
                name: "FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_pago_pedido_Cod_esta~",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                column: "Cod_estado_pago",
                principalSchema: "dwh_torrecontrol",
                principalTable: "Tdc_cat_estados_pago_pedido",
                principalColumn: "Cod_estado_pago");

            migrationBuilder.AddForeignKey(
                name: "FK_Tdc_tch_estado_pedidos_Tdc_cat_lineas_distribucion_Cod_linea",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos",
                column: "Cod_linea",
                principalSchema: "dwh_torrecontrol",
                principalTable: "Tdc_cat_lineas_distribucion",
                principalColumn: "Cod_linea",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_devolucion_pedido_Co~",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_envio_pedido_Cod_est~",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tdc_tch_estado_pedidos_Tdc_cat_estados_pago_pedido_Cod_esta~",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tdc_tch_estado_pedidos_Tdc_cat_lineas_distribucion_Cod_linea",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tdc_tch_estado_pedidos",
                schema: "dwh_torrecontrol",
                table: "Tdc_tch_estado_pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tdc_cat_lineas_distribucion",
                schema: "dwh_torrecontrol",
                table: "Tdc_cat_lineas_distribucion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tdc_cat_estados_pago_pedido",
                schema: "dwh_torrecontrol",
                table: "Tdc_cat_estados_pago_pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tdc_cat_estados_envio_pedido",
                schema: "dwh_torrecontrol",
                table: "Tdc_cat_estados_envio_pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tdc_cat_estados_devolucion_pedido",
                schema: "dwh_torrecontrol",
                table: "Tdc_cat_estados_devolucion_pedido");

            migrationBuilder.RenameTable(
                name: "Tdc_tch_estado_pedidos",
                schema: "dwh_torrecontrol",
                newName: "tdc_tch_estado_pedidos",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameTable(
                name: "Tdc_cat_lineas_distribucion",
                schema: "dwh_torrecontrol",
                newName: "tdc_cat_lineas_distribucion",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameTable(
                name: "Tdc_cat_estados_pago_pedido",
                schema: "dwh_torrecontrol",
                newName: "tdc_cat_estados_pago_pedido",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameTable(
                name: "Tdc_cat_estados_envio_pedido",
                schema: "dwh_torrecontrol",
                newName: "tdc_cat_estados_envio_pedido",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameTable(
                name: "Tdc_cat_estados_devolucion_pedido",
                schema: "dwh_torrecontrol",
                newName: "tdc_cat_estados_devolucion_pedido",
                newSchema: "dwh_torrecontrol");

            migrationBuilder.RenameIndex(
                name: "IX_Tdc_tch_estado_pedidos_Cod_linea",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                newName: "IX_tdc_tch_estado_pedidos_Cod_linea");

            migrationBuilder.RenameIndex(
                name: "IX_Tdc_tch_estado_pedidos_Cod_estado_pago",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                newName: "IX_tdc_tch_estado_pedidos_Cod_estado_pago");

            migrationBuilder.RenameIndex(
                name: "IX_Tdc_tch_estado_pedidos_Cod_estado_envio",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                newName: "IX_tdc_tch_estado_pedidos_Cod_estado_envio");

            migrationBuilder.RenameIndex(
                name: "IX_Tdc_tch_estado_pedidos_Cod_estado_devolucion",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                newName: "IX_tdc_tch_estado_pedidos_Cod_estado_devolucion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tdc_tch_estado_pedidos",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                column: "Md_uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tdc_cat_lineas_distribucion",
                schema: "dwh_torrecontrol",
                table: "tdc_cat_lineas_distribucion",
                column: "Md_uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tdc_cat_estados_pago_pedido",
                schema: "dwh_torrecontrol",
                table: "tdc_cat_estados_pago_pedido",
                column: "Md_uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tdc_cat_estados_envio_pedido",
                schema: "dwh_torrecontrol",
                table: "tdc_cat_estados_envio_pedido",
                column: "Md_uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tdc_cat_estados_devolucion_pedido",
                schema: "dwh_torrecontrol",
                table: "tdc_cat_estados_devolucion_pedido",
                column: "Md_uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_tdc_tch_estado_pedidos_tdc_cat_estados_devolucion_pedido_Co~",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                column: "Cod_estado_devolucion",
                principalSchema: "dwh_torrecontrol",
                principalTable: "tdc_cat_estados_devolucion_pedido",
                principalColumn: "Md_uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_tdc_tch_estado_pedidos_tdc_cat_estados_envio_pedido_Cod_est~",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                column: "Cod_estado_envio",
                principalSchema: "dwh_torrecontrol",
                principalTable: "tdc_cat_estados_envio_pedido",
                principalColumn: "Md_uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_tdc_tch_estado_pedidos_tdc_cat_estados_pago_pedido_Cod_esta~",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                column: "Cod_estado_pago",
                principalSchema: "dwh_torrecontrol",
                principalTable: "tdc_cat_estados_pago_pedido",
                principalColumn: "Md_uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_tdc_tch_estado_pedidos_tdc_cat_lineas_distribucion_Cod_linea",
                schema: "dwh_torrecontrol",
                table: "tdc_tch_estado_pedidos",
                column: "Cod_linea",
                principalSchema: "dwh_torrecontrol",
                principalTable: "tdc_cat_lineas_distribucion",
                principalColumn: "Md_uuid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
