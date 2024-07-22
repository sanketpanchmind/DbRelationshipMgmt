using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbRelationshipMgmt.Migrations
{
    /// <inheritdoc />
    public partial class iformfileadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Subjectphoto",
                table: "SubjectTopics",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subjectphoto",
                table: "SubjectTopics");
        }
    }
}
