using System.Collections.Generic;
using System.Linq;

namespace PostComment
{
    public class ServicePost
    {
        private ModelPostCommentContainer context;
        public ServicePost()
        {
            context = new ModelPostCommentContainer();
        }

        public List<Post> GetAll()
        {
            List<Post> lp = new List<Post>();
            lp = context.Posts.ToList();
            return lp;
        }

        public void DeleteComment(Comment comm)
        {

            context.Comments.Remove(comm);
            foreach (var post in context.Posts.Where(p => p.Comments.Any(c => c.CommentId == comm.CommentId)).ToList())
            {
                post.Comments.Remove(comm);
            }
            context.SaveChanges();
        }

        public Post GetPostByTitle(string title)
        {
            var post = context.Posts.FirstOrDefault(p => p.Description == title);
            return post;
        }

        public Post GetPostById(int id)
        {
            var post = context.Posts.FirstOrDefault(p => p.PostId == id);
            return post;
        }


        public Post SubmitPost(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
            return post;
        }

        public Post UpdatePost(Post post)
        {
            var toUpdate = context.Posts.FirstOrDefault(p => p.PostId == post.PostId);
            if (toUpdate != null)
            {
                toUpdate.Description = post.Description;
                toUpdate.Domain = post.Domain;
                toUpdate.Comments = post.Comments;
                context.SaveChanges();
            }
            return toUpdate;
        }

        public bool DeletePost(int postId)
        {
            var toDelete = context.Posts.FirstOrDefault(p => p.PostId == postId);
            if (toDelete == null)
            {
                return false;
            }
            else
            {
                foreach (var comm in toDelete.Comments)
                {
                    toDelete.Comments.Remove(comm);
                    context.Comments.Remove(comm);
                }
                context.Posts.Remove(toDelete);
                context.SaveChanges();
                return true;
            }
        }

        public Comment GetCommentById(int id)
        {
            var comm = context.Comments.FirstOrDefault(c => c.CommentId == id);
            return comm;
        }
        public Comment SubmitComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return comment;
        }
        public Comment UpdateComment(Comment oldComment, Comment newComment)
        {
            var oldcomm = context.Comments.FirstOrDefault(c => c.CommentId == oldComment.CommentId);
            if (oldcomm != null)
            {
                oldcomm.Text = newComment.Text;
                oldcomm.Post = newComment.Post;
                oldcomm.PostPostId = oldcomm.PostPostId;
                context.SaveChanges();
            }
            return newComment;
        }

        public bool DeleteComment(int commentId)
        {
            var comm = context.Comments.FirstOrDefault(c => c.CommentId == commentId);
            if (comm == null)
            {
                return false;
            }
            else
            {
                comm.Post.Comments.Remove(comm);
                context.Comments.Remove(comm);
                context.SaveChanges();
                return true;
            }
        }

        public Comment SubmitComment(int postId, Comment comm)
        {
            var post = context.Posts.FirstOrDefault(p => p.PostId == postId);
            if (post != null)
            {
                comm.Post = post;
                post.Comments.Add(comm);
                context.Comments.Add(comm);
                context.SaveChanges();

            }
            return comm;
        }

      

      
    }
}
