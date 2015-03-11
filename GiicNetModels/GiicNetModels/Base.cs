using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GiicNetModels
{
    public class Base : ICloneable
    {
        public object Clone()
        {
            dynamic item;

            try
            {
                item = Activator.CreateInstance(this.GetType());
                PropertyInfo[] properties = item.GetType().GetProperties();

                properties.ToList().ForEach(o => o.SetValue(item, o.GetValue(this,null),null));
          
            }
            catch (Exception ex)
            {
                throw new Exception("Clone not successly succedded", ex);
            }

            return item;
        }


    }
}
