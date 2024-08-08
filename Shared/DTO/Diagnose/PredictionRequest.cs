using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrKlinik.Shared.DTO.Diagnose
{
    public class PredictionRequest
    {
        public float Accuracy { get; set; }
        public int Prediction { get; set; }
    }
}
