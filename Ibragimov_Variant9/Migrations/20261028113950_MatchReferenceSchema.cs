using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ibragimov_Variant9.Migrations
{
    /// <inheritdoc />
    public partial class MatchReferenceSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "cd_student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "cd_specialty",
                newName: "Specialtys");

            migrationBuilder.RenameTable(
                name: "cd_group",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "cd_grade",
                newName: "Grades");

            migrationBuilder.RenameTable(
                name: "cd_discipline",
                newName: "Disciplines");

            migrationBuilder.RenameColumn(
                name: "f_group_id",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "c_student_lastname",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "c_student_is_deleted",
                table: "Students",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "c_student_firstname",
                table: "Students",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "idx_cd_student_fk_f_group_id",
                table: "Students",
                newName: "idx_Students_fk_f_group_id");

            migrationBuilder.RenameColumn(
                name: "c_specialty_title",
                table: "Specialtys",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "c_specialty_code",
                table: "Specialtys",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "specialty_id",
                table: "Specialtys",
                newName: "SpecialtyId");

            migrationBuilder.RenameColumn(
                name: "f_specialty_id",
                table: "Groups",
                newName: "SpecialtyId");

            migrationBuilder.RenameColumn(
                name: "c_group_name",
                table: "Groups",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "c_group_is_deleted",
                table: "Groups",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "c_group_course",
                table: "Groups",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "Groups",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "idx_cd_group_fk_f_specialty_id",
                table: "Groups",
                newName: "idx_Groups_fk_f_specialty_id");

            migrationBuilder.RenameColumn(
                name: "f_student_id",
                table: "Grades",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "f_discipline_id",
                table: "Grades",
                newName: "DisciplineId");

            migrationBuilder.RenameColumn(
                name: "c_grade_value",
                table: "Grades",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "grade_id",
                table: "Grades",
                newName: "GradeId");

            migrationBuilder.RenameIndex(
                name: "idx_cd_grade_fk_f_student_id",
                table: "Grades",
                newName: "idx_Grades_fk_f_student_id");

            migrationBuilder.RenameIndex(
                name: "idx_cd_grade_fk_f_discipline_id",
                table: "Grades",
                newName: "idx_Grades_fk_f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "c_discipline_name",
                table: "Disciplines",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "c_discipline_is_deleted",
                table: "Disciplines",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "discipline_id",
                table: "Disciplines",
                newName: "DisciplineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Students",
                newName: "cd_student");

            migrationBuilder.RenameTable(
                name: "Specialtys",
                newName: "cd_specialty");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "cd_group");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "cd_grade");

            migrationBuilder.RenameTable(
                name: "Disciplines",
                newName: "cd_discipline");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "cd_student",
                newName: "c_student_lastname");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "cd_student",
                newName: "c_student_is_deleted");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "cd_student",
                newName: "f_group_id");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "cd_student",
                newName: "c_student_firstname");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "cd_student",
                newName: "student_id");

            migrationBuilder.RenameIndex(
                name: "idx_Students_fk_f_group_id",
                table: "cd_student",
                newName: "idx_cd_student_fk_f_group_id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "cd_specialty",
                newName: "c_specialty_title");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "cd_specialty",
                newName: "c_specialty_code");

            migrationBuilder.RenameColumn(
                name: "SpecialtyId",
                table: "cd_specialty",
                newName: "specialty_id");

            migrationBuilder.RenameColumn(
                name: "SpecialtyId",
                table: "cd_group",
                newName: "f_specialty_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "cd_group",
                newName: "c_group_name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "cd_group",
                newName: "c_group_is_deleted");

            migrationBuilder.RenameColumn(
                name: "Course",
                table: "cd_group",
                newName: "c_group_course");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "cd_group",
                newName: "group_id");

            migrationBuilder.RenameIndex(
                name: "idx_Groups_fk_f_specialty_id",
                table: "cd_group",
                newName: "idx_cd_group_fk_f_specialty_id");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "cd_grade",
                newName: "c_grade_value");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "cd_grade",
                newName: "f_student_id");

            migrationBuilder.RenameColumn(
                name: "DisciplineId",
                table: "cd_grade",
                newName: "f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "cd_grade",
                newName: "grade_id");

            migrationBuilder.RenameIndex(
                name: "idx_Grades_fk_f_student_id",
                table: "cd_grade",
                newName: "idx_cd_grade_fk_f_student_id");

            migrationBuilder.RenameIndex(
                name: "idx_Grades_fk_f_discipline_id",
                table: "cd_grade",
                newName: "idx_cd_grade_fk_f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "cd_discipline",
                newName: "c_discipline_name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "cd_discipline",
                newName: "c_discipline_is_deleted");

            migrationBuilder.RenameColumn(
                name: "DisciplineId",
                table: "cd_discipline",
                newName: "discipline_id");
        }
    }
}
