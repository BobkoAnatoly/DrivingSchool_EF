﻿// <auto-generated />
using System;
using DrivingSchool.Database;
using DrivingSchool.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrivingSchool.Migrations
{
    [DbContext(typeof(ApplicationDataBaseContext))]
    [Migration("20220724183609_addSRResulTable")]
    partial class addSRResulTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.DrivingCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("DrivingCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "А"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "B"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "C"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "CE"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "D"
                        });
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<DateTime>("LessonDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Lessons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Lesson");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Service");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Дополнительное занятие по вождению на категорию \"А\" 15 рублей",
                            Price = 0m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Дополнительное занятие по управлению автомобилем категории \"В\" 35 руб",
                            Price = 0m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Дополнительное занятие по управлению автомобилем категории \"С\" 40 руб",
                            Price = 0m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Дополнительное занятие по управлению составом транспортных средств категории \"СЕ\" 40 руб",
                            Price = 0m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Дополнительное занятие по управлению автобусом (категория «D») 40 руб",
                            Price = 0m
                        });
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.SpResultModels.SpStudyStream", b =>
                {
                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.ToTable("SpStudyStreams");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.StudyStream", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DrivingCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DrivingCategoryId");

                    b.ToTable("StudyStreams");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("LessonStudent", b =>
                {
                    b.Property<int>("LessonsId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("LessonsId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("LessonStudent");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.DrivingLesson", b =>
                {
                    b.HasBaseType("DrivingSchool.Model.DatabaseModels.Lesson");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasIndex("VehicleId");

                    b.HasDiscriminator().HasValue("DrivingLesson");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.PaidService", b =>
                {
                    b.HasBaseType("DrivingSchool.Model.DatabaseModels.Service");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasIndex("StudentId");

                    b.HasDiscriminator().HasValue("PaidService");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Student", b =>
                {
                    b.HasBaseType("DrivingSchool.Model.DatabaseModels.Person");

                    b.Property<int>("StudyStreamId")
                        .HasColumnType("int");

                    b.HasIndex("StudyStreamId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Teacher", b =>
                {
                    b.HasBaseType("DrivingSchool.Model.DatabaseModels.Person");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Lesson", b =>
                {
                    b.HasOne("DrivingSchool.Model.DatabaseModels.Teacher", "Teacher")
                        .WithMany("Lessons")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.StudyStream", b =>
                {
                    b.HasOne("DrivingSchool.Model.DatabaseModels.DrivingCategory", "DrivingCategory")
                        .WithMany("StudyStreams")
                        .HasForeignKey("DrivingCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DrivingCategory");
                });

            modelBuilder.Entity("LessonStudent", b =>
                {
                    b.HasOne("DrivingSchool.Model.DatabaseModels.Lesson", null)
                        .WithMany()
                        .HasForeignKey("LessonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrivingSchool.Model.DatabaseModels.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.DrivingLesson", b =>
                {
                    b.HasOne("DrivingSchool.Model.DatabaseModels.Vehicle", "Vehicle")
                        .WithMany("DrivingLessons")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.PaidService", b =>
                {
                    b.HasOne("DrivingSchool.Model.DatabaseModels.Student", "Student")
                        .WithMany("PaidServices")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Student", b =>
                {
                    b.HasOne("DrivingSchool.Model.DatabaseModels.Person", null)
                        .WithOne()
                        .HasForeignKey("DrivingSchool.Model.DatabaseModels.Student", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("DrivingSchool.Model.DatabaseModels.StudyStream", "StudyStream")
                        .WithMany("Students")
                        .HasForeignKey("StudyStreamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudyStream");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Teacher", b =>
                {
                    b.HasOne("DrivingSchool.Model.DatabaseModels.Person", null)
                        .WithOne()
                        .HasForeignKey("DrivingSchool.Model.DatabaseModels.Teacher", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.DrivingCategory", b =>
                {
                    b.Navigation("StudyStreams");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.StudyStream", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Vehicle", b =>
                {
                    b.Navigation("DrivingLessons");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Student", b =>
                {
                    b.Navigation("PaidServices");
                });

            modelBuilder.Entity("DrivingSchool.Model.DatabaseModels.Teacher", b =>
                {
                    b.Navigation("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}
