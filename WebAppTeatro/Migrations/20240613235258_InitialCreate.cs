using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppTeatro.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
                BEGIN
                    CREATE TABLE [dbo].[Usuarios] (
                        [IdUsuario] int NOT NULL IDENTITY,
                        [Nombre] nvarchar(max) NOT NULL,
                        [Apellidos] nvarchar(max) NOT NULL,
                        [Cedula] int NOT NULL,
                        [Telefono] int NOT NULL,
                        [Correo] nvarchar(max) NOT NULL,
                        [Password] nvarchar(max) NOT NULL,
                        CONSTRAINT [PK_Usuarios] PRIMARY KEY ([IdUsuario])
                    );
                END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
