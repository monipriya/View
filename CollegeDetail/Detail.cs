namespace CollegeDetail.Entity
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
        public Detail()
        { }
    }
}
