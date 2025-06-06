﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.WebAPIv3.Data;

namespace SmartSchool.WebAPIv3.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20230522104215_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("SmartSchool.WebAPIv3.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                         {
                            Id = 7,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },                 
                        new
                        {
                            Id = 8,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        }
                         {
                            Id = 9,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        }  
                    );
                });

            modelBuilder.Entity("SmartSchool.WebAPIv3.Models.AlunoDiciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DiciplinaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DiciplinaId");

                    b.HasIndex("DiciplinaId");

                    b.ToTable("AlunoDiciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DiciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 1,
                            DiciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 1,
                            DiciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 2,
                            DiciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 2,
                            DiciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 2,
                            DiciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 3,
                            DiciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 3,
                            DiciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 3,
                            DiciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 4,
                            DiciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 4,
                            DiciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 4,
                            DiciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 5,
                            DiciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 5,
                            DiciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 6,
                            DiciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 6,
                            DiciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 6,
                            DiciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 6,
                            DiciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DiciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 7,
                            DiciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 7,
                            DiciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 7,
                            DiciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DiciplinaId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPIv3.Models.Diciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Diciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPIv3.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Lauro"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ronaldo"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Rodrigo"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Alexandre"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPIv3.Models.AlunoDiciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPIv3.Models.Aluno", "Aluno")
                        .WithMany("AlunoDiciplina")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPIv3.Models.Diciplina", "Diciplinas")
                        .WithMany("AlunoDiciplina")
                        .HasForeignKey("DiciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.WebAPIv3.Models.Diciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPIv3.Models.Professor", "Professor")
                        .WithMany("Diciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
