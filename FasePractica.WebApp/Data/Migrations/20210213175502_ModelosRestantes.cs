using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FasePractica.WebApp.Data.Migrations
{
    public partial class ModelosRestantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Empresas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SectorProductivo",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoEmpresa",
                table: "Empresas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Contactos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Contactos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    DocumentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmadoEl = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlmacenadoEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    ConvenioDocumentoId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConvenioId = table.Column<int>(type: "int", nullable: true),
                    FechaFinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpresaId = table.Column<int>(type: "int", nullable: true),
                    InformeViabilidadDocumentoId = table.Column<int>(type: "int", nullable: true),
                    MemorandoDocumentoId = table.Column<int>(type: "int", nullable: true),
                    ActaDocumentoId = table.Column<int>(type: "int", nullable: true),
                    CantidadEstudiantes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.DocumentoId);
                    table.ForeignKey(
                        name: "FK_Documentos_Documentos_ActaDocumentoId",
                        column: x => x.ActaDocumentoId,
                        principalTable: "Documentos",
                        principalColumn: "DocumentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_Documentos_ConvenioDocumentoId",
                        column: x => x.ConvenioDocumentoId,
                        principalTable: "Documentos",
                        principalColumn: "DocumentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_Documentos_InformeViabilidadDocumentoId",
                        column: x => x.InformeViabilidadDocumentoId,
                        principalTable: "Documentos",
                        principalColumn: "DocumentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_Documentos_MemorandoDocumentoId",
                        column: x => x.MemorandoDocumentoId,
                        principalTable: "Documentos",
                        principalColumn: "DocumentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoInstitucional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoPersonal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstudianteId = table.Column<int>(type: "int", nullable: true),
                    CodigoIgnug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TutorId = table.Column<int>(type: "int", nullable: true),
                    Tutor_CodigoIgnug = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Semestres",
                columns: table => new
                {
                    SemestreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semestres", x => x.SemestreId);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: true),
                    SemestreId = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tecnologia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TutorAcademicoPersonaId = table.Column<int>(type: "int", nullable: true),
                    TutorEmpresarialContactoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.ProyectoId);
                    table.ForeignKey(
                        name: "FK_Proyectos_Contactos_TutorEmpresarialContactoId",
                        column: x => x.TutorEmpresarialContactoId,
                        principalTable: "Contactos",
                        principalColumn: "ContactoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proyectos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proyectos_Personas_TutorAcademicoPersonaId",
                        column: x => x.TutorAcademicoPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proyectos_Semestres_SemestreId",
                        column: x => x.SemestreId,
                        principalTable: "Semestres",
                        principalColumn: "SemestreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    NotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudiantePersonaId = table.Column<int>(type: "int", nullable: true),
                    ProyectoId = table.Column<int>(type: "int", nullable: true),
                    Calificacion = table.Column<float>(type: "real", nullable: false),
                    Aprueba = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.NotaId);
                    table.ForeignKey(
                        name: "FK_Notas_Personas_EstudiantePersonaId",
                        column: x => x.EstudiantePersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_PersonaId",
                table: "Empresas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_ActaDocumentoId",
                table: "Documentos",
                column: "ActaDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_ConvenioDocumentoId",
                table: "Documentos",
                column: "ConvenioDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_EmpresaId",
                table: "Documentos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_InformeViabilidadDocumentoId",
                table: "Documentos",
                column: "InformeViabilidadDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_MemorandoDocumentoId",
                table: "Documentos",
                column: "MemorandoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_EstudiantePersonaId",
                table: "Notas",
                column: "EstudiantePersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_ProyectoId",
                table: "Notas",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_EmpresaId",
                table: "Proyectos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_SemestreId",
                table: "Proyectos",
                column: "SemestreId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_TutorAcademicoPersonaId",
                table: "Proyectos",
                column: "TutorAcademicoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_TutorEmpresarialContactoId",
                table: "Proyectos",
                column: "TutorEmpresarialContactoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresas_Personas_PersonaId",
                table: "Empresas",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_Personas_PersonaId",
                table: "Empresas");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Semestres");

            migrationBuilder.DropIndex(
                name: "IX_Empresas_PersonaId",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "SectorProductivo",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "TipoEmpresa",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Contactos");
        }
    }
}
