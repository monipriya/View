using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetail
{
    public class Detail
    {

        public int collegeCode { get; set; }
        public string collegeName { get; set; }
        public int collegeRank { get; set; }
        public Detail(int collegeId, string name, int rank)
        {
            collegeCode = collegeId;
            collegeName = name;
            collegeRank = rank;
        }
    }
}
