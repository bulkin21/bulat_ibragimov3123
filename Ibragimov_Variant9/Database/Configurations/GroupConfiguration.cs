using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ibragimov_Variant9.Database.Helpers;
using Ibragimov_Variant9.Models;

namespace Ibragimov_Variant9.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        //Название таблицы, которое будет отображаться в БД
        private const string TableName = "Groups";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            //Задаем первичный ключ
            builder
                .HasKey(p => p.GroupId)
                .HasName("pk_cd_group_group_id");

            //Для целочисленного первичного ключа задаем автогенерацию
            builder.Property(p => p.GroupId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.GroupId)
                .HasColumnName("GroupId")
                .HasComment("Идентификатор записи группы");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType(ColumnType.String).HasMaxLength(50)
                .HasComment("Название группы");

            builder.Property(p => p.Course)
                .IsRequired()
                .HasColumnName("Course")
                .HasColumnType(ColumnType.Int)
                .HasComment("Курс обучения группы");

            builder.Property(p => p.SpecialtyId)
                .IsRequired()
                .HasColumnName("SpecialtyId")
                .HasComment("Идентификатор специальности");

            builder.Property(p => p.IsDeleted)
                .IsRequired()
                .HasColumnName("IsDeleted")
                .HasColumnType(ColumnType.Bool)
                .HasDefaultValue(false)
                .HasComment("Признак удаления записи");

            //Связь: у группы одна специальность, у специальности много групп
            builder.ToTable(TableName)
                .HasOne(p => p.Specialty)
                .WithMany()
                .HasForeignKey(p => p.SpecialtyId)
                .HasConstraintName("fk_f_specialty_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.SpecialtyId, $"idx_{TableName}_fk_f_specialty_id");

            //Добавим явную автоподгрузку связанной сущности
            builder.Navigation(p => p.Specialty)
                .AutoInclude();
        }
    }
}
