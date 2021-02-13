﻿// <auto-generated />
using System;
using FasePractica.WebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FasePractica.WebApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("FasePractica.WebApp.Models.Contacto", b =>
                {
                    b.Property<int>("ContactoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactoId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Documento", b =>
                {
                    b.Property<int>("DocumentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AlmacenadoEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConvenioDocumentoId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirmadoEl")
                        .HasColumnType("datetime2");

                    b.HasKey("DocumentoId");

                    b.HasIndex("ConvenioDocumentoId");

                    b.ToTable("Documentos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Documento");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.Property<string>("Ruc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectorProductivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoEmpresa")
                        .HasColumnType("int");

                    b.HasKey("EmpresaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Nota", b =>
                {
                    b.Property<int>("NotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Aprueba")
                        .HasColumnType("bit");

                    b.Property<float>("Calificacion")
                        .HasColumnType("real");

                    b.Property<int?>("EstudiantePersonaId")
                        .HasColumnType("int");

                    b.Property<int?>("ProyectoId")
                        .HasColumnType("int");

                    b.HasKey("NotaId");

                    b.HasIndex("EstudiantePersonaId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoInstitucional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoPersonal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Proyecto", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int?>("SemestreId")
                        .HasColumnType("int");

                    b.Property<string>("Tecnologia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TutorAcademicoPersonaId")
                        .HasColumnType("int");

                    b.Property<int?>("TutorEmpresarialContactoId")
                        .HasColumnType("int");

                    b.HasKey("ProyectoId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("SemestreId");

                    b.HasIndex("TutorAcademicoPersonaId");

                    b.HasIndex("TutorEmpresarialContactoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Semestre", b =>
                {
                    b.Property<int>("SemestreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SemestreId");

                    b.ToTable("Semestres");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Convenio", b =>
                {
                    b.HasBaseType("FasePractica.WebApp.Models.Documento");

                    b.Property<int?>("ActaDocumentoId")
                        .HasColumnType("int");

                    b.Property<int>("CantidadEstudiantes")
                        .HasColumnType("int");

                    b.Property<int>("ConvenioId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("FechaFinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InformeViabilidadDocumentoId")
                        .HasColumnType("int");

                    b.Property<int?>("MemorandoDocumentoId")
                        .HasColumnType("int");

                    b.HasIndex("ActaDocumentoId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("InformeViabilidadDocumentoId");

                    b.HasIndex("MemorandoDocumentoId");

                    b.HasDiscriminator().HasValue("Convenio");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Estudiante", b =>
                {
                    b.HasBaseType("FasePractica.WebApp.Models.Persona");

                    b.Property<string>("CodigoIgnug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Tutor", b =>
                {
                    b.HasBaseType("FasePractica.WebApp.Models.Persona");

                    b.Property<string>("CodigoIgnug")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tutor_CodigoIgnug");

                    b.Property<int>("TutorId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Tutor");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Contacto", b =>
                {
                    b.HasOne("FasePractica.WebApp.Models.Empresa", null)
                        .WithMany("Contactos")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Documento", b =>
                {
                    b.HasOne("FasePractica.WebApp.Models.Convenio", null)
                        .WithMany("Extension")
                        .HasForeignKey("ConvenioDocumentoId");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Empresa", b =>
                {
                    b.HasOne("FasePractica.WebApp.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Nota", b =>
                {
                    b.HasOne("FasePractica.WebApp.Models.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudiantePersonaId");

                    b.HasOne("FasePractica.WebApp.Models.Proyecto", "Proyecto")
                        .WithMany("Notas")
                        .HasForeignKey("ProyectoId");

                    b.Navigation("Estudiante");

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Proyecto", b =>
                {
                    b.HasOne("FasePractica.WebApp.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");

                    b.HasOne("FasePractica.WebApp.Models.Semestre", "Semestre")
                        .WithMany("Proyectos")
                        .HasForeignKey("SemestreId");

                    b.HasOne("FasePractica.WebApp.Models.Tutor", "TutorAcademico")
                        .WithMany()
                        .HasForeignKey("TutorAcademicoPersonaId");

                    b.HasOne("FasePractica.WebApp.Models.Contacto", "TutorEmpresarial")
                        .WithMany()
                        .HasForeignKey("TutorEmpresarialContactoId");

                    b.Navigation("Empresa");

                    b.Navigation("Semestre");

                    b.Navigation("TutorAcademico");

                    b.Navigation("TutorEmpresarial");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Convenio", b =>
                {
                    b.HasOne("FasePractica.WebApp.Models.Documento", "Acta")
                        .WithMany()
                        .HasForeignKey("ActaDocumentoId");

                    b.HasOne("FasePractica.WebApp.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");

                    b.HasOne("FasePractica.WebApp.Models.Documento", "InformeViabilidad")
                        .WithMany()
                        .HasForeignKey("InformeViabilidadDocumentoId");

                    b.HasOne("FasePractica.WebApp.Models.Documento", "Memorando")
                        .WithMany()
                        .HasForeignKey("MemorandoDocumentoId");

                    b.Navigation("Acta");

                    b.Navigation("Empresa");

                    b.Navigation("InformeViabilidad");

                    b.Navigation("Memorando");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Empresa", b =>
                {
                    b.Navigation("Contactos");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Proyecto", b =>
                {
                    b.Navigation("Notas");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Semestre", b =>
                {
                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("FasePractica.WebApp.Models.Convenio", b =>
                {
                    b.Navigation("Extension");
                });
#pragma warning restore 612, 618
        }
    }
}
