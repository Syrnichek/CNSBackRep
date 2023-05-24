using CNSBack.Exceptions;
using CNSBack.Interfaces;
using CNSBack.Models;
using Microsoft.EntityFrameworkCore;

namespace CNSBack.Services
{
    public class NewsManageService :INewsManageService
    {
        public List<NewsModel> GetNewsAll()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
 
            var options = optionsBuilder.Options;

            using (ApplicationContext applicationContext = new ApplicationContext(options))
            {
                IEnumerable<NewsModel> newsIEnumerable = applicationContext.news;
                return newsIEnumerable.ToList();
            }
        }

        public void AddNews(string newstitle, string newsimage, DateTime newsdate, string newstext)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
 
            var options = optionsBuilder.Options;

            using (ApplicationContext applicationContext = new ApplicationContext(options))
            {
                if (applicationContext.news.FirstOrDefault(n => n.newstitle == newstitle) != null)
                {
                    throw new UserAlreadyExistsException("User already exists");
                }
                
                NewsModel news = new NewsModel {newstitle = newstitle, newsimage = newsimage, newsdate = newsdate, newstext = newstext};
                applicationContext.news.Add(news);
                applicationContext.SaveChanges();
            }
        }
    }
}