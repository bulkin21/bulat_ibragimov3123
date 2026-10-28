using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ibragimov_Variant9.Database.Helpers;
using Ibragimov_Variant9.Models;

namespace Ibragimov_Variant9.Database.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        //Название таблицы, которое будет отображаться в БД
        private const string TableName = "Students";

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //Задаем первичный ключ
            builder
                .HasKey(p => p.StudentId)
                .HasName("pk_cd_student_student_id");

            //Для целочисленного первичного ключа задаем автогенерацию (к каждой новой записи будет добавлять +1)
            builder.Property(p => p.StudentId)
                .ValueGeneratedOnAdd();

            //Расписываем как будут называться колонки в БД, а так же их обязательность и тд
            builder.Property(p => p.StudentId)
                .HasColumnName("StudentId")
                .HasComment("Идентификатор записи студента");

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Имя студента");

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Фамилия студента");

            builder.Property(p => p.GroupId)
                .IsRequired()
                .HasColumnName("GroupId")
                .HasComment("Идентификатор группы");

            builder.Property(p => p.IsDeleted)
                .IsRequired()
                .HasColumnName("IsDeleted")
                .HasColumnType(ColumnType.Bool)
                .HasDefaultValue(false)
                .HasComment("Признак удаления записи");

            //Связь: у студента одна группа, у группы много студентов
            builder.ToTable(TableName)
                .HasOne(p => p.Group)
                .WithMany()
                .HasForeignKey(p => p.GroupId)
                .HasConstraintName("fk_f_group_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.GroupId, $"idx_{TableName}_fk_f_group_id");

            //Добавим явную автоподгрузку связанной сущности
            builder.Navigation(p => p.Group)
                .AutoInclude();
        }
    }
}
