using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.Entity;

namespace bd
{

    public static class API
    {
        public static void AddPost(Post post)
        {
            Model1Container ctx = new Model1Container();
            ctx.Posts.Add(post);
            ctx.SaveChanges();
        }
        public static Post UpdatePost(Post newPost)
        {
            Model1Container ctx = new Model1Container();
            Post oldPost = ctx.Posts.Find(newPost.PostId);
            if (oldPost == null) // nu exista in bd
            {
                return null;
            }
            oldPost.Description = newPost.Description;
            oldPost.Domain = newPost.Domain;
            oldPost.Date = newPost.Date;
            ctx.SaveChanges();
            return oldPost;
        }
        public static int DeletePost(int id)
        {
            Model1Container ctx = new Model1Container();
            return ctx.Database.ExecuteSqlCommand("Delete From Post where postid =@p0", id);

        }

        public static Post GetPostById(int id)
        {
            Model1Container ctx = new Model1Container();
            var items = from p in ctx.Posts where (p.PostId == id) select p;
            if (items != null)
                return items.Include(c => c.Comments).SingleOrDefault();
            return null; // trebuie verificat in apelant
        }

        public static List<Post> GetAllPosts()
        {
            Model1Container ctx = new Model1Container();
            return ctx.Posts.Include("Comments").ToList<Post>();
        }

        public static void AddComment(Comment comment)
        {
            Model1Container ctx = new Model1Container();
            ctx.Comments.Add(comment);
            ctx.SaveChanges();
        }

        public static Comment UpdateComment(Comment newComment)
        {
            Model1Container ctx = new Model1Container();
            Comment oldComment = ctx.Comments.Find(newComment.CommentId);
            if (newComment.Text != null)
                oldComment.Text = newComment.Text;

            if ((oldComment.PostPostId != newComment.PostPostId) && (newComment.PostPostId != 0))
            {
                oldComment.PostPostId = newComment.PostPostId;
            }
            ctx.SaveChanges();
            return oldComment;
        }
        public static Comment GetCommentById(int id)
        {
            Model1Container ctx = new Model1Container();
            return ctx.Comments.Where(e => e.CommentId == id).FirstOrDefault();
        }
    }
}