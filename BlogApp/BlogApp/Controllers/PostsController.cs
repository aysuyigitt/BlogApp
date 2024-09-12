using BlogApp.Models;
using DataEntitesLayer;
using DataEntitesLayer.Abstract;
using EntitiesLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostRepository _postRepository;

        private readonly ITagRepository _tagRepository;

        private readonly ICommentRepository _commentRepository;

        public PostsController(IPostRepository postRepository, ITagRepository tagRepository, ICommentRepository commentRepository)
        {
           _postRepository = postRepository;    
            _tagRepository = tagRepository;
            _commentRepository = commentRepository;
        }

        public IActionResult Index()
        {
           
            return View(
                new PostViewModel
                {
                    Posts = _postRepository.Posts.ToList(),
                    Tags = _tagRepository.Tags.ToList(),
                    Comments = _commentRepository.Comments.ToList(),    
                }
                );
    }
        public async Task<IActionResult> Details(string url)
        {
            return View(await _postRepository.Posts.Include(x=>x.Comments).ThenInclude(x=>x.User).FirstOrDefaultAsync(p => p.Url == url));
        }

        public IActionResult AddComment(int PostId,string Text,string Url)
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var avatar = User.FindFirstValue(ClaimTypes.UserData);
            var entity = new Comment
            {
                PostId = PostId,
                Text = Text,
                PublishedOn = DateTime.Now,
                UserId = int.Parse(UserId ?? ""), 
            };
            _commentRepository.createComment(entity);

            return Redirect("/posts/details/" + Url);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(PostCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                _postRepository.CreatePost(new Post {
                    Title = model.Title,
                    Content = model.Content,
                    Url = model.Url,
                    UserId = int.Parse(userId ?? ""),
                    PublishedOn = DateTime.Now,
                    Image = "1.png",
                    IsActive = false
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> List()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "");
            var role = User.FindFirstValue(ClaimTypes.Role);

            var posts = _postRepository.Posts;
            if (string.IsNullOrEmpty(role))
            {
                posts = posts.Where(i => i.UserId == userId);
            }
            return View(await posts.ToListAsync());
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var post = _postRepository.Posts.FirstOrDefault(i => i.PostId == id);
            if (post == null)
            {
                return NotFound();
            }
            return View(new PostCreateViewModel
            {
                PostId = post.PostId,
                Title = post.Title,
                Content = post.Content,
                Url = post.Url
            });
        }
        [HttpPost]
        [Authorize]

        public IActionResult Edit(PostCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entityUpdate = new Post
                {
                    PostId = model.PostId,
                    Title = model.Title,
                    Description = model.Description,
                    Content = model.Content,
                    Url = model.Url
                };
                _postRepository.EditPost(entityUpdate);
                return RedirectToAction("List");
                }
            return View(model);
            }

        }

    }

    