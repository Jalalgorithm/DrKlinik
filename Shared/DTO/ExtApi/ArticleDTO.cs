using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrKlinik.Shared.DTO.ExtApi
{
    public class ArticleDTO
    {
        public string ArticleId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string PubDate { get; set; }
        public string Image_url { get; set; }

        public string Source_name { get; set; }
    }
}
