using CNSBack.Exceptions;
using CNSBack.Interfaces;
using CNSBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNSBack.Controllers
{
    public class NewsManageController :Controller
    {
        private readonly INewsManageService _newsManageService;
        
        public NewsManageController(INewsManageService newsManageService)
        {
            _newsManageService = newsManageService;
        }
        
        [HttpGet]
        [Route("api/newsManage/GetNewsAll")]
        public List<NewsModel> GetNewsAll()
        {
            return _newsManageService.GetNewsAll();
        }
        
        [HttpGet]
        [Route("api/newsManage/AddNews")]
        public IActionResult AddNews(string newstitle, string newsimage, DateTime newsdate, string newstext)
        {
            try
            {
                _newsManageService.AddNews(newstitle, newsimage, newsdate, newstext);
                return Ok();
            }
            catch (NewsAlreadyExistsException ex)
            {
                return StatusCode(420, "Новость с таким текстом уже существует");
            }
        }
    }
}