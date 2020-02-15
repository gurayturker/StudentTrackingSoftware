using StudentTrackingSoftware.Model.Entities.Base;

namespace StudentTrackingSoftware.Model.Entities
{
    public class School:BaseEntityCase
    {
        public string SchoolName { get; set; }
        public long CityID { get; set; }
        public long DistrictID { get; set; }
        public string Description { get; set; }
        public City City { get; set; }
        public District District { get; set; }
    } 
}
