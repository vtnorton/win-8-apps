﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProjectCachoeiro.Web.Data;
using System;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180106181903_Cliente")]
    partial class Cliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Comercial.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CNPJ")
                        .IsRequired();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Descricao")
                        .HasMaxLength(1000);

                    b.Property<string>("EmailContato")
                        .IsRequired();

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int>("IdLogoEmpresa");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(100);

                    b.Property<string>("Site");

                    b.Property<string>("Telefone");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Comercial.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cargo");

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("IdEmpresa");

                    b.Property<int>("IdFotoPerfil");

                    b.Property<string>("Observacao")
                        .HasMaxLength(1000);

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Telefone");

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Comercial.GrupoDeClientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Descricao")
                        .HasMaxLength(1000);

                    b.Property<string>("ListaIdClientes");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("GrupoDeClientes");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Comercial.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("IdProduto");

                    b.Property<string>("Observacao")
                        .HasMaxLength(1000);

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Comercial.Proposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("IdCliente");

                    b.Property<int>("IdContato");

                    b.Property<string>("ListaIdItems");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(1000);

                    b.Property<string>("OpcoesPagamento");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Proposta");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("CPF");

                    b.Property<string>("Cargo");

                    b.Property<int>("CompanyId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsSysAdmin");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nome");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfileImagePath");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Sobrenome");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Empresa.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .HasMaxLength(9);

                    b.Property<string>("CNPJ")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Descricao");

                    b.Property<string>("Email");

                    b.Property<string>("EmailCadastroSistema");

                    b.Property<string>("Endereco")
                        .HasMaxLength(140);

                    b.Property<string>("Estado")
                        .HasMaxLength(2);

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("RazaoSocial")
                        .IsRequired();

                    b.Property<string>("Site");

                    b.Property<string>("Slogan");

                    b.Property<string>("Telefone");

                    b.Property<string>("URLLogo");

                    b.Property<string>("URLLogonImage");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Invite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Email");

                    b.Property<string>("Type");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.Property<bool>("Valido");

                    b.HasKey("Id");

                    b.ToTable("Invite");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Produtos.Espessura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("Expessura");

                    b.Property<string>("Nome");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Espessura");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Produtos.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Descricao")
                        .HasMaxLength(1000);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Produtos.Familia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Observacao")
                        .HasMaxLength(1000);

                    b.Property<int>("Type");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Familia");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Produtos.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Produtos.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Altura");

                    b.Property<string>("CodigoEAN");

                    b.Property<string>("CodigoNCM");

                    b.Property<int>("CompanyId");

                    b.Property<decimal>("Comprimento");

                    b.Property<DateTime>("DataDeEntrada");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(50);

                    b.Property<int>("DisponivelEmEstoque");

                    b.Property<int>("IdEspessura");

                    b.Property<int>("IdFamilia");

                    b.Property<int>("IdImagemPrincipal");

                    b.Property<int>("IdMaterial");

                    b.Property<int>("IdProdutoDerivado");

                    b.Property<int>("IdQualidade");

                    b.Property<int>("IdStatus");

                    b.Property<int>("IdTipo");

                    b.Property<decimal>("Largura");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(1000);

                    b.Property<decimal>("Peso");

                    b.Property<decimal>("PrecoUnitarioVenda");

                    b.Property<bool>("Resinado");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Produtos.Qualidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Qualidade");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Produtos.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("ProjectCachoeiro.Web.Models.Utilitarios.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alt");

                    b.Property<int>("CompanyId");

                    b.Property<string>("CorPredominante");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Legenda");

                    b.Property<string>("Tags");

                    b.Property<string>("URL")
                        .IsRequired();

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserModified");

                    b.HasKey("Id");

                    b.ToTable("Imagem");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProjectCachoeiro.Web.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProjectCachoeiro.Web.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectCachoeiro.Web.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProjectCachoeiro.Web.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
