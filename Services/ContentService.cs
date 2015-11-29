using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginProject.Services.Interfaces;
using LoginProject.Models;
using LoginProject.DAL;

namespace LoginProject.Services
{
    public class ContentService: IContentService
    {
        private UserDal _db;
        public ContentService()
        {
            _db = new UserDal();
        }
        public List<Content> GetAllContent()
        {
            
            var contents = _db.Contents.ToList();
            return contents;

        }

        

        public Content GetContentById(int id)
        {

            Content content = _db.Contents.Find(id);
            return content;
        }


        public List<Content> GetPublishedContent()
        {
            var contents = _db.Contents.Where(m => m.Published == true).ToList();
            return contents;
        }
    }
}