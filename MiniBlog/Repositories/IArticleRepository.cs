using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiniBlog.Model;

namespace MiniBlog.Repositories
{
    public interface IArticleRepository
    {
        public Task<List<Article>> GetArticles();
        public Task<Article> CreateArticle(Article article);
        public Task<long> Delete(string name);
        public Task<Article> GetById(Guid id);
        //public Task<Article> GetById(string id);
    }
}
