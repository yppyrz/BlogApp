using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApp.Migrations
{
    public partial class sdgsdghsdgs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_CommentPostPostID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommentPostPostID",
                table: "Comments",
                newName: "PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CommentPostPostID",
                table: "Comments",
                newName: "IX_Comments_PostID");

            migrationBuilder.AddColumn<string>(
                name: "CommentPostID",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostID",
                table: "Comments",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentPostID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Comments",
                newName: "CommentPostPostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostID",
                table: "Comments",
                newName: "IX_Comments_CommentPostPostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_CommentPostPostID",
                table: "Comments",
                column: "CommentPostPostID",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
