
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

public partial class sql8751184Context : DbContext
{
    public sql8751184Context(DbContextOptions<sql8751184Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Day> Days { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<Office> Offices { get; set; }

    public virtual DbSet<Semester> Semesters { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TypeAssign> TypeAssigns { get; set; }

    public virtual DbSet<TypeOffice> TypeOffices { get; set; }

    public virtual DbSet<Week> Weeks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<Day>(entity =>
        {
            entity.HasKey(e => e.DayId).HasName("PRIMARY");

            entity.ToTable("Day");

            entity.HasIndex(e => e.WeekId, "Day_ibfk_1");

            entity.Property(e => e.DayId)
                .HasColumnType("int(11)")
                .HasColumnName("DayID");
            entity.Property(e => e.DayName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.WeekId)
                .HasColumnType("int(11)")
                .HasColumnName("WeekID");

            entity.HasOne(d => d.Week).WithMany(p => p.Days)
                .HasForeignKey(d => d.WeekId)
                .HasConstraintName("Day_ibfk_1");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity.Property(e => e.GroupId)
                .HasColumnType("int(11)")
                .HasColumnName("GroupID");
            entity.Property(e => e.GroupName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Lesson>(entity =>
        {
            entity.HasKey(e => e.LessonId).HasName("PRIMARY");

            entity.HasIndex(e => e.DayId, "DayID");

            entity.HasIndex(e => e.GroupId, "GroupID");

            entity.HasIndex(e => e.OfficeId, "OfficeID");

            entity.HasIndex(e => e.SubjectId, "SubjectID");

            entity.Property(e => e.LessonId)
                .HasColumnType("int(11)")
                .HasColumnName("LessonID");
            entity.Property(e => e.DayId)
                .HasColumnType("int(11)")
                .HasColumnName("DayID");
            entity.Property(e => e.GroupId)
                .HasColumnType("int(11)")
                .HasColumnName("GroupID");
            entity.Property(e => e.LessonsType).HasMaxLength(50);
            entity.Property(e => e.OfficeId)
                .HasColumnType("int(11)")
                .HasColumnName("OfficeID");
            entity.Property(e => e.SubjectId)
                .HasColumnType("int(11)")
                .HasColumnName("SubjectID");

            entity.HasOne(d => d.Day).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Lessons_ibfk_4");

            entity.HasOne(d => d.Group).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Lessons_ibfk_1");

            entity.HasOne(d => d.Office).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Lessons_ibfk_2");

            entity.HasOne(d => d.Subject).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Lessons_ibfk_3");
        });

        modelBuilder.Entity<Office>(entity =>
        {
            entity.HasKey(e => e.OfficeId).HasName("PRIMARY");

            entity.Property(e => e.OfficeId)
                .HasColumnType("int(11)")
                .HasColumnName("OfficeID");
            entity.Property(e => e.NumberSeats).HasColumnType("int(11)");
            entity.Property(e => e.OfficeTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("OfficeTypeID");
        });

        modelBuilder.Entity<Semester>(entity =>
        {
            entity.HasKey(e => e.SemesterId).HasName("PRIMARY");

            entity.HasIndex(e => e.SemesterId, "SemesterID_UNIQUE").IsUnique();

            entity.Property(e => e.SemesterId)
                .HasColumnType("int(11)")
                .HasColumnName("SemesterID");
            entity.Property(e => e.SemesterNumber).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PRIMARY");

            entity.Property(e => e.SubjectId)
                .HasColumnType("int(11)")
                .HasColumnName("SubjectID");
            entity.Property(e => e.HoursPerConsult).HasColumnType("int(11)");
            entity.Property(e => e.HoursPerExam).HasColumnType("int(11)");
            entity.Property(e => e.HoursPerLaborat).HasColumnType("int(11)");
            entity.Property(e => e.HoursPerLecture).HasColumnType("int(11)");
            entity.Property(e => e.HoursPerPractic).HasColumnType("int(11)");
            entity.Property(e => e.SubjectName)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PRIMARY");

            entity.Property(e => e.TeacherId)
                .HasColumnType("int(11)")
                .HasColumnName("TeacherID");
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);

            entity.HasMany(d => d.Subjects).WithMany(p => p.Teachers)
                .UsingEntity<Dictionary<string, object>>(
                    "TeacherSubject",
                    r => r.HasOne<Subject>().WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("TeacherSubjects_ibfk_2"),
                    l => l.HasOne<Teacher>().WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("TeacherSubjects_ibfk_1"),
                    j =>
                    {
                        j.HasKey("TeacherId", "SubjectId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("TeacherSubjects");
                        j.HasIndex(new[] { "SubjectId" }, "SubjectID");
                        j.IndexerProperty<int>("TeacherId")
                            .HasColumnType("int(11)")
                            .HasColumnName("TeacherID");
                        j.IndexerProperty<int>("SubjectId")
                            .HasColumnType("int(11)")
                            .HasColumnName("SubjectID");
                    });
        });

        modelBuilder.Entity<TypeAssign>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PRIMARY");

            entity.ToTable("TypeAssign");

            entity.HasIndex(e => e.OfficeId, "OfficeID");

            entity.HasIndex(e => e.OfficeTypeId, "OfficeTypeID");

            entity.Property(e => e.AssignmentId)
                .HasColumnType("int(11)")
                .HasColumnName("AssignmentID");
            entity.Property(e => e.OfficeId)
                .HasColumnType("int(11)")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OfficeTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("OfficeTypeID");

            entity.HasOne(d => d.Office).WithMany(p => p.TypeAssigns)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TypeAssign_ibfk_1");

            entity.HasOne(d => d.OfficeType).WithMany(p => p.TypeAssigns)
                .HasForeignKey(d => d.OfficeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TypeAssign_ibfk_2");
        });

        modelBuilder.Entity<TypeOffice>(entity =>
        {
            entity.HasKey(e => e.OfficeTypeId).HasName("PRIMARY");

            entity.Property(e => e.OfficeTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("OfficeTypeID");
            entity.Property(e => e.OfficeType)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Week>(entity =>
        {
            entity.HasKey(e => e.WeekId).HasName("PRIMARY");

            entity.HasIndex(e => e.SemesterId, "SemesterID");

            entity.Property(e => e.WeekId)
                .HasColumnType("int(11)")
                .HasColumnName("WeekID");
            entity.Property(e => e.SemesterId)
                .HasColumnType("int(11)")
                .HasColumnName("SemesterID");
            entity.Property(e => e.WeekNumber).HasColumnType("int(11)");

            entity.HasOne(d => d.Semester).WithMany(p => p.Weeks)
                .HasForeignKey(d => d.SemesterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Weeks_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}