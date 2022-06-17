using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Utilities;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models
{
    public class DashboardViewModel
    {
        public int CategoriesCount { get; set; }
        public int ArticlesCount { get; set; }
        public int CommentsCount { get; set; }
        public int UserCount { get; set; }
        public ArticleListDto Articles { get; set; }
    }
}
