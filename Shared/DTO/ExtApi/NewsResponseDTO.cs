using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrKlinik.Shared.DTO.ExtApi
{
    public class NewsResponseDTO
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<ArticleDTO> Results { get; set; }
    }
}
