using StudentTrackingSoftware.Model.Entities.Base;

namespace StudentTrackingSoftware.Model.Entities
{
    public  class District:BaseEntityCase
    {
        public string DistrictName { get; set; }
        public long CityID { get; set; }
        public string Description { get; set; }
        public City City { get; set; }
    }
}
