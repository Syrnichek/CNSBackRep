using CNSBack.Models;

namespace CNSBack.Interfaces
{
    public interface INewsManageService
    {
        public List<NewsModel> GetNewsAll();

        public void AddNews(string newstitle, string newsimage, DateTime newsdate, string newstext);
    }
}