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

        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
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
        /// Post'a category tanımlar
        /// </summary>
        /// <param name="post"></param>
        /// <param name="category"></param>
        public void AddCategory(Post post, Category category)
        {
            post.PostCategory = category;
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
    }
}
