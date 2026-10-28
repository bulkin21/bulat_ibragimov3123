using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ibragimov_Variant9.Database.Helpers;
using Ibragimov_Variant9.Models;

namespace Ibragimov_Variant9.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        //Название таблицы, которое будет отображаться в БД
        private const string TableName = "Disciplines";

        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            //Задаем первичный ключ
            builder
                .HasKey(p => p.DisciplineId)
                .HasName("pk_cd_discipline_discipline_id");

            //Для целочисленного первичного ключа задаем автогенерацию
            builder.Property(p => p.DisciplineId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.DisciplineId)
                .HasColumnName("DisciplineId")
                .HasComment("Идентификатор записи дисциплины");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType(ColumnType.String).HasMaxLength(200)
                .HasComment("Название дисциплины");

            builder.Property(p => p.IsDeleted)
                .IsRequired()
                .HasColumnName("IsDeleted")
                .HasColumnType(ColumnType.Bool)
                .HasDefaultValue(false)
                .HasComment("Признак удаления записи");

            builder.ToTable(TableName);
        }
    }
}
