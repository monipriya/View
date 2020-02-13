using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeDetail;
namespace Repository
{
    public class CollegeRepository
    {
        public static List<Detail> package = new List<Detail>();
        static CollegeRepository()
        {
            package.Add(new Detail(4536, "KSR",2));
            package.Add(new Detail(2654, "SAKTHI",6));
            package.Add(new Detail(3856, "SRI ESWAR",7));
        }
        public IEnumerable<Detail> GetCollegeDetails()
        {
            return package;
        }
    }
}
