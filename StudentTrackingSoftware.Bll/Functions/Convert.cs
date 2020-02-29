using StudentTrackingSoftware.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTrackingSoftware.Bll.Functions
{
    public static class Convert
    {
        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null) return default(TTarget);
            var target = Activator.CreateInstance<TTarget>();
            var sourceProp = source.GetType().GetProperties();
            var targetProp = typeof(TTarget).GetProperties();
            foreach (var sourceproperty  in sourceProp)
            {
                var value = sourceproperty.GetValue(source);
                var targetproperty = targetProp.FirstOrDefault(x => x.Name == sourceproperty.Name);
                if (targetproperty != null)
                    targetproperty.SetValue(target, ReferenceEquals(value, "") ? null : value);
            }
            return target;
        }
    }
}
