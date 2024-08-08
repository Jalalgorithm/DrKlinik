using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrKlinik.Shared.DTO.Diagnose
{
    public class HeartDiseaseDTO
    {
        public int Age { get; set; }
        public string Sex { get; set; }
        public string ChestPainType { get; set; }
        public int RestingBP { get; set; }
        public int Cholesterol { get; set; }
        public int FastingBS { get; set; }
        public string RestingECG { get; set; }
        public int MaxHR { get; set; }
        public string ExerciseAngina { get; set; }
        public int OldPeak { get; set; }
        public string ST_Slope { get; set; }
        



    }
}
