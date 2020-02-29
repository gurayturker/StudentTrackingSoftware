using StudentTrackingSoftware.Model.Entities.Base.Interfaces;

namespace StudentTrackingSoftware.Model.Entities.Base
{
    public  class BaseEntity:IBaseEntity
   {
        public long Id { get; set; }
        public string Code { get; set; }
    }
}
