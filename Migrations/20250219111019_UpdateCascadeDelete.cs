using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moment3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCascadeDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorModelId",
                table: "Books");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorModelId",
                table: "Books",
                column: "AuthorModelId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorModelId",
                table: "Books");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorModelId",
                table: "Books",
                column: "AuthorModelId",
                principalTable: "Authors",
                principalColumn: "Id");
        }
    }
}
