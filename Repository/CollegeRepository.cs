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
            package.Add(new Detail(1, "Kerala", 15000));
            package.Add(new Detail(2, "Goa", 15000));
            package.Add(new Detail(3, "Kashmir", 10000));
        }
        public IEnumerable<Detail> GetCollegeDetails()
        {
            return package;
        }
    }
}
