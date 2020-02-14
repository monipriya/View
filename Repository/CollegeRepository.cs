using System.Collections.Generic;
using CollegeDetail.Entity;
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
        public void AddPackage(Detail packageDetails)
        {
            package.Add(packageDetails);
        }
        public Detail GetPackageById(int packageId)
        {
            return package.Find(id => id.collegeCode == packageId);
        }
        public void DeletePackage(int packageId)
        {
            Detail pack = GetPackageById(packageId);
            if (pack != null)
                package.Remove(pack);
        }
        public void UpdatePackage(Detail pack)
        {
            //PackageDetails packages = package.Find(id => id.PackageId == pack.PackageId);
            Detail packages = GetPackageById(pack.collegeCode);
            packages.collegeName = pack.collegeName;
            packages.collegeRank = pack.collegeRank;
        }
    }
}
