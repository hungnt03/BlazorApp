using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Shared.Commons
{
    public static class MapperUtil
    {
        public static To Map<From, To>(From from)
        {
            if (from == null) return default;

            var fromProps = GetProperties(typeof(From));
            var toProps = GetProperties(typeof(To));

            // Props that can be mapped from one to the other
            var propsToCopy = fromProps.Intersect(toProps, new PropertyComparer()).ToList();

            var returnObject = (To)Activator.CreateInstance(typeof(To));

            foreach (var prop in propsToCopy)
            {
                // Copy the values
                var fromValue = prop.GetValue(from, null);
                var convertedValue = Convert.ChangeType(fromValue, prop.PropertyType);
                var propTo = typeof(To).GetProperty(prop.Name);
                propTo.SetValue(returnObject, convertedValue, null);
            }

            return returnObject;
        }

        public static PropertyInfo[] GetProperties(Type objectType)
        {
            var allProps = objectType.GetProperties(
                BindingFlags.Public | BindingFlags.Instance);

            return allProps.Where(p => p.PropertyType.IsPrimitive ||
                p.PropertyType == typeof(string)).ToArray();
        }
    }
    public class PropertyComparer : IEqualityComparer<PropertyInfo>
    {
        public bool Equals(PropertyInfo x, PropertyInfo y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(PropertyInfo obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
