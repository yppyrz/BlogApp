// <auto-generated />
using System;
using BlogApp.Databae;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogApp.Migrations
{
    [DbContext(typeof(BlogAppDbContext))]
    [Migration("20211227123726_fgggdfdgdfg")]
    partial class fgggdfdgdfg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BlogApp.Entities.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BlogApp.Entities.Comment", b =>
                {
                    b.Property<string>("CommentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentPostID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentPublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.HasIndex("PostID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BlogApp.Entities.Post", b =>
                {
                    b.Property<string>("PostID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostAuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCategoryID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostPublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BlogApp.Entities.Tag", b =>
                {
                    b.Property<string>("TagID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<string>("PostTagsTagID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagPostsPostID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostTagsTagID", "TagPostsPostID");

                    b.HasIndex("TagPostsPostID");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("BlogApp.Entities.Comment", b =>
                {
                    b.HasOne("BlogApp.Entities.Post", null)
                        .WithMany("PostComments")
                        .HasForeignKey("PostID");
                });

            modelBuilder.Entity("BlogApp.Entities.Post", b =>
                {
                    b.HasOne("BlogApp.Entities.Category", null)
                        .WithMany("CategoryPosts")
                        .HasForeignKey("CategoryID");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("BlogApp.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("PostTagsTagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogApp.Entities.Post", null)
                        .WithMany()
                        .HasForeignKey("TagPostsPostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogApp.Entities.Category", b =>
                {
                    b.Navigation("CategoryPosts");
                });

            modelBuilder.Entity("BlogApp.Entities.Post", b =>
                {
                    b.Navigation("PostComments");
                });
#pragma warning restore 612, 618
        }
    }
}
