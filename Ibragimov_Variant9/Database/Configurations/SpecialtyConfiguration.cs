using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ibragimov_Variant9.Database.Helpers;
using Ibragimov_Variant9.Models;

namespace Ibragimov_Variant9.Database.Configurations
{
    public class SpecialtyConfiguration : IEntityTypeConfiguration<Specialty>
    {
        //Название таблицы, которое будет отображаться в БД
        private const string TableName = "Specialtys";

        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            //Задаем первичный ключ
            builder
                .HasKey(p => p.SpecialtyId)
                .HasName("pk_cd_specialty_specialty_id");

            //Для целочисленного первичного ключа задаем автогенерацию
            builder.Property(p => p.SpecialtyId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.SpecialtyId)
                .HasColumnName("SpecialtyId")
                .HasComment("Идентификатор записи специальности");

            builder.Property(p => p.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType(ColumnType.String).HasMaxLength(200)
                .HasComment("Название специальности");

            builder.Property(p => p.Code)
                .IsRequired()
                .HasColumnName("Code")
                .HasColumnType(ColumnType.String).HasMaxLength(20)
                .HasComment("Код специальности");

            builder.ToTable(TableName);
        }
    }
}
