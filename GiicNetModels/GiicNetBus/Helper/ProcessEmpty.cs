using System;
using System.Reflection;

namespace GiicNetBus
{
    public static class Helper
    {
        public static T ProcessEmpty<T>( this T obj) 
        {
            //Serialze the entity object and return its string represenatation
            var type = typeof (T);
       
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
               
                try
                {
                    string tipoP = property.PropertyType.ToString();
                    switch (tipoP)
                    {
                        case "System.String":
                        case "System.Nullable`1[System.String]":
                            if (property.GetValue(obj).ToString() == "") property.SetValue(obj, null);
                            break;
                        case "System.DateTime":
                        case "System.Nullable`1[System.DateTime]":
                            if (property.GetValue(obj).ToString().Contains("0001")) 
                                property.SetValue(obj, null);
                            break;
                        case "System.Short":
                        case "System.Nullable`1[System.Short]":
                            break;
                        case "System.Decimal":
                        case "System.Nullable`1[System.Decimal]":
                            if (Convert.ToDecimal(property.GetValue(obj)) == 0) property.SetValue(obj, null);
                            break;
                        case "System.Int":
                        case "System.Nullable`1[System.Int16]":
                        case "System.Nullable`1[System.Int32]":
                        case "System.Nullable`1[System.Int64]":
                            if ((int)(property.GetValue(obj)) == 0) property.SetValue(obj, null);
                            break;
                        case "System.Bool":
                        case "System.Nullable`1[System.Bool]":
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { }
            }
            return obj;

           
        }
    }


}