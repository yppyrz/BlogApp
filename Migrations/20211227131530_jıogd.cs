using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApp.Migrations
{
    public partial class jıogd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_CommentPostIDPostID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryID",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Posts_TagPostsPostID",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameColumn(
                name: "CommentPostIDPostID",
                table: "Comments",
                newName: "PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CommentPostIDPostID",
                table: "Comments",
                newName: "IX_Comments_PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CategoryID",
                table: "Post",
                newName: "IX_Post_CategoryID");

            migrationBuilder.AddColumn<string>(
                name: "CommentPostID",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "PostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Post_PostID",
                table: "Comments",
                column: "PostID",
                principalTable: "Post",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Categories_CategoryID",
                table: "Post",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Post_TagPostsPostID",
                table: "PostTag",
                column: "TagPostsPostID",
                principalTable: "Post",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Post_PostID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Categories_CategoryID",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Post_TagPostsPostID",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "CommentPostID",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Comments",
                newName: "CommentPostIDPostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostID",
                table: "Comments",
                newName: "IX_Comments_CommentPostIDPostID");

            migrationBuilder.RenameIndex(
                name: "IX_Post_CategoryID",
                table: "Posts",
                newName: "IX_Posts_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "PostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_CommentPostIDPostID",
                table: "Comments",
                column: "CommentPostIDPostID",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryID",
                table: "Posts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Posts_TagPostsPostID",
                table: "PostTag",
                column: "TagPostsPostID",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
