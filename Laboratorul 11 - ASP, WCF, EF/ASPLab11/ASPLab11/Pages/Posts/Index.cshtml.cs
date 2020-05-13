using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;

namespace ASPLab11.Pages.Posts
{
    public class IndexModel : PageModel
    {
        public List<PostDTO> Posts { get; set; }
        public IndexModel()
        {
            Posts = new List<PostDTO>();
        }
        public async Task OnGetAsync()
        {
            PostCommentClient pcc = new PostCommentClient();
            var posts = await pcc.GetAllPostsAsync();
            foreach (var item in posts)
            {
           
                PostDTO pd = new PostDTO();
                pd.Description = item.Description;
                pd.PostId = item.PostId;
                pd.Domain = item.Domain;
         
                foreach (var cc in item.Comments)
                {
                    CommentDTO cdto = new CommentDTO();
                    cdto.PostPostId = cc.PostPostId;
                    cdto.Text = cc.Text;
                    pd.Comments.Add(cdto);
                }
                Posts.Add(pd);
            }

        }

    }
}