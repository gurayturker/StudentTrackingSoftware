using StudentTrackingSoftware.Model.Entities.Base;

namespace StudentTrackingSoftware.Model.Entities
{
    public  class City:BaseEntityCase
    {
        public string CityName { get; set; }
        public string Description { get; set; }
    }
}
