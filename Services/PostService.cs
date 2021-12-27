using BlogApp.Entities;
using BlogApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Services
{
    public class PostService
    {
        PostRepository _postRepository;
        CommentRepository _commentRepository;
        TagRepository _tagRepository;
        RelationRepository _relationRepository;


        public PostService(PostRepository postRepository,CommentRepository commentRepository,TagRepository tagRepository,RelationRepository relationRepository)
        {
            _postRepository = postRepository;
            _commentRepository = commentRepository;
            _tagRepository=tagRepository;
            _relationRepository = relationRepository;

        }

        /// <summary>
        /// Post oluşturur
        /// </summary>
        /// <param name="post"></param>
        public void CreatePost(Post post)
        {
            //Lojikler yazılacak
            post.PostPublishDate = DateTime.Now;
            _postRepository.AddPost(post);
        }

        /// <summary>
        /// Post'a tag ekler
        /// </summary>
        /// <param name="post"></param>
        /// <param name="tag"></param>
        public void AddTag(Post post, Tag tag)
        {
            post.PostTags.Add(tag);
            _postRepository.UpdatePost(post);
        }


        /// <summary>
        /// Post'a comment ekler
        /// </summary>
        /// <param name="post"></param>
        /// <param name="comment"></param>
        public void AddComment(Post post, Comment comment)
        {
            post.PostComments.Add(comment);
            _postRepository.UpdatePost(post);
        }

        /// <summary>
        /// Post'un comment listesini getirir
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public List<Comment> GetAllComment(Post post)
        {
            return post.PostComments;
        }

        /// <summary>
        /// Post'un tag listesini getirir
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public List<Tag> GetAllTag(Post post)
        {
            return post.PostTags;
        }

        /// <summary>
        /// PublishDate'e göre postları sıralı listeler
        /// </summary>
        /// <returns></returns>
        public List<Post> OrderingPost()
        {
            return _postRepository.GetAllPost().OrderByDescending(x => x.PostPublishDate).ToList();
        }



        public List<Comment> GetComment(string id)
        {
            var x = _commentRepository.GetAllComment();
            x = x.Where(x => x.CommentPostID == id).ToList();
            return x;
        }

        public List<Tag> GetTag(string id)
        {
            var x = _relationRepository.GetAll();
            var y = new List<Tag>();

            foreach (var item in x)
            {
                if (item.PostID == id)
                {
                    var z = _tagRepository.FindTag(item.TagID);
                    y.Add(z);
                }
            }

            return y;
        }
    }
}
