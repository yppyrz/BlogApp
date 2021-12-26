using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApp.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_PostCategoryCategoryID",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostCategoryCategoryID",
                table: "Posts",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_PostCategoryCategoryID",
                table: "Posts",
                newName: "IX_Posts_CategoryID");

            migrationBuilder.AddColumn<string>(
                name: "PostCategoryID",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCategoryName",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryID",
                table: "Posts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostCategoryID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostCategoryName",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Posts",
                newName: "PostCategoryCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CategoryID",
                table: "Posts",
                newName: "IX_Posts_PostCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_PostCategoryCategoryID",
                table: "Posts",
                column: "PostCategoryCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
