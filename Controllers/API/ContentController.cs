using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoginProject.Services.Interfaces;
using LoginProject.Services;
using LoginProject.Models;
using System.Collections.Generic;

namespace LoginProject.Areas.API.Controllers
{
    [RoutePrefix("api/content")]
    public class ContentController : ApiController
    {
        private IContentService _contentService;
        public ContentController()
        {
            _contentService = new ContentService();
        }

        // GET api/<controller>
        [Route("")]
        public IEnumerable<Content> Get()
        {
            return _contentService.GetAllContent();
        }

       
        [Route("stat")]
        public List<KeyValuePair<string, int>> GetByConteType()
        {
            var contents = _contentService.GetPublishedContent();
            var results = from p in contents
                          group p by p.ContentType into g
                          select  new KeyValuePair<string, int>(g.Key, g.Count());


            return results.ToList();
            //return list;
        }
        // GET api/content/{string}
        [Route("{ContentType}")]
        public IEnumerable<Content> Get(string ContentType)
        {
            var contents = _contentService.GetPublishedContent();
           return contents.Where(m => m.ContentType.ToUpperInvariant() == ContentType.ToUpperInvariant()).ToList();
           
        }

        // POST api/<controller>
        [Route("")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [Route("{id:int}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [Route("{id:int}")]
        public void Delete(int id)
        {
        }
    }
}