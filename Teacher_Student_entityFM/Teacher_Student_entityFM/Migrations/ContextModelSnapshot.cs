﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teacher_Student_entityFM.DataModels;

#nullable disable

namespace Teacher_Student_entityFM.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Teacher_Student_entityFM.DataModels.Pupil", b =>
                {
                    b.Property<int>("PupilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PupilID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PupilID");

                    b.ToTable("Pupils");
                });

            modelBuilder.Entity("Teacher_Student_entityFM.DataModels.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Teacher_Student_entityFM.DataModels.TeacherPupil", b =>
                {
                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.Property<int>("PupilID")
                        .HasColumnType("int");

                    b.HasKey("TeacherID", "PupilID");

                    b.HasIndex("PupilID");

                    b.ToTable("TeacherPupil");
                });

            modelBuilder.Entity("Teacher_Student_entityFM.DataModels.TeacherPupil", b =>
                {
                    b.HasOne("Teacher_Student_entityFM.DataModels.Pupil", "Pupil")
                        .WithMany("Teachers")
                        .HasForeignKey("PupilID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teacher_Student_entityFM.DataModels.Teacher", "Teacher")
                        .WithMany("Pupils")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pupil");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Teacher_Student_entityFM.DataModels.Pupil", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Teacher_Student_entityFM.DataModels.Teacher", b =>
                {
                    b.Navigation("Pupils");
                });
#pragma warning restore 612, 618
        }
    }
}