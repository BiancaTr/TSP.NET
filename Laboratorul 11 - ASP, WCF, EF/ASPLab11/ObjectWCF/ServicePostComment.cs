using PostComment;
using System.Collections.Generic;
using AutoMapper;
using System.ServiceModel;


namespace ObjectWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServicePostComment : IPostComment
    {

        private ServicePost _svcPost;
    
        MapperConfiguration config;
        IMapper iMapper;

        public void Cleanup()
        {
            Cleanup();
        }

        public ServicePostComment()
        {
            _svcPost = new ServicePost();
            config = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Post, PostDTO>();
                cfg.CreateMap<Comment, CommentDTO>();
                cfg.CreateMap<PostDTO, Post>();
                cfg.CreateMap<CommentDTO, Comment>();
            });
            iMapper = config.CreateMapper();
        }
       
 
        public List<PostDTO> GetAllPosts()
        {
            var lp = _svcPost.GetAll();

            List<PostDTO> lpDto = new List<PostDTO>();
            lpDto = iMapper.Map<List<Post>, List<PostDTO>>(lp);
            return lpDto;
            
        }


        public PostDTO GetPostByTitle(string title)
        {
            Post post = _svcPost.GetPostByTitle(title);
            if (post != null)
            {
                PostDTO postDTO = iMapper.Map<Post, PostDTO>(post);
                return postDTO;
            }
            return null;
        }


        public void DeleteComment(CommentDTO comment)
        {
            Comment comm = new Comment();

            comm = iMapper.Map<CommentDTO, Comment>(comment);
            _svcPost.DeleteComment(comm);
        }

       

        public PostDTO GetPostById(int id)
        {
            Post post = _svcPost.GetPostById(id);
            PostDTO postDTO = iMapper.Map<Post, PostDTO>(post);
            return postDTO;
        }



        public PostDTO SubmitPost(PostDTO postDTO)
        {
            Post post = new Post();
            post = iMapper.Map<PostDTO, Post>(postDTO);
            post = _svcPost.SubmitPost(post);
            postDTO = iMapper.Map<Post, PostDTO>(post);
            return postDTO;
        }


        public PostDTO UpdatePost(PostDTO newPost)
        {
            Post post = iMapper.Map<PostDTO, Post>(newPost);
            post = _svcPost.UpdatePost(post);
            PostDTO postDTO = iMapper.Map<Post, PostDTO>(post);
            return postDTO;
        }


        public bool DeletePost(int postId)
        {
            return _svcPost.DeletePost(postId);
        }


        public CommentDTO SubmitComment(int postId, CommentDTO commentDTO)
        {
            Comment comment = iMapper.Map<CommentDTO, Comment>(commentDTO);
            comment = _svcPost.SubmitComment(postId, comment);
            CommentDTO comm = iMapper.Map<Comment, CommentDTO>(comment);
            return comm;
        }


        public CommentDTO UpdateComment(CommentDTO oldCommentDTO,
       CommentDTO newCommentDTO)
        {
            Comment oldComment = iMapper.Map<CommentDTO, Comment>(oldCommentDTO);
            Comment newComment = iMapper.Map<CommentDTO, Comment>(newCommentDTO);
            Comment comment = _svcPost.UpdateComment(oldComment, newComment);
            CommentDTO comm = iMapper.Map<Comment, CommentDTO>(comment);
            return comm;
        }


        public bool DeleteComment(int commentId)
        {
            return _svcPost.DeleteComment(commentId);
        }

        public CommentDTO GetCommentById(int id)
        {
            Comment comment = _svcPost.GetCommentById(id);
            CommentDTO commentDTO = iMapper.Map<Comment, CommentDTO>(comment);
            return commentDTO;
        }


        public CommentDTO SubmitComment(CommentDTO commentDTO)
        {
            Comment comment = iMapper.Map<CommentDTO, Comment>(commentDTO);
            comment = _svcPost.SubmitComment(comment);
            CommentDTO commDTO = iMapper.Map<Comment, CommentDTO>(comment);
            return commDTO;
        }
       
        List<PostDTO> ILoadData.GetAllPostsAndRelatedComments()
        {
            return GetAllPosts();
        }
    }
}
