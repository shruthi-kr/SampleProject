using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginProject.Models;

namespace LoginProject.Services.Interfaces
{
    interface IContentService
    {
        List<Content> GetAllContent();
        Content GetContentById(int id);
        List<Content> GetPublishedContent();

    }
}
