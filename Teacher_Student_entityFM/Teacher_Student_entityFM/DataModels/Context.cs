using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student_entityFM.DataModels
{
    public class Context : DbContext
    {
       public DbSet<Pupil> Pupils { get; set; }

       public DbSet<Teacher> Teachers { get; set; }

        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NOT7569\SQLEXPRESS;Databse=EFSchoolDemo;Trusred_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeacherPupil>()
                .HasKey(tichst => new { tichst.TeacherID, tichst.PupilID});
            builder.Entity<TeacherPupil>()
                .HasOne(tichst => tichst.Teacher)
                .WithMany(tichst => tichst.Pupils)
                .HasForeignKey(tichst => tichst.TeacherID);
            builder.Entity<TeacherPupil>()
                .HasOne(tichst => tichst.Pupil)
                .WithMany(tichst => tichst.Teachers)
                .HasForeignKey(tichst => tichst.PupilID);
        }

    }
}
