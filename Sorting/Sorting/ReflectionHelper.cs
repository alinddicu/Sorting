namespace Sorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class ReflectionHelper
    {
        public static IEnumerable<T> GetEnumerableOfType<T>(this Assembly a, params object[] constructorArgs)
            where T : class
        {
            var objects = new List<T>();
            foreach (Type type in
                a.GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }

            return objects;
        }
    }
}
