using System;
using System.Reflection;

namespace CodeSmelss.Bloaters
{
    public static class ObjectComparerLongParameterListRefactored
    {
        public static Dictionary<Type, PropertyInfo> Compare<T>(T objectOne, T objectTwo) where T : class
        {
            Dictionary<Type, PropertyInfo> differences = [];
            var parentType = objectOne.GetType();

            foreach (PropertyInfo property in parentType.GetProperties())
            {
                object? value1 = property.GetValue(objectOne, null);
                object? value2 = property.GetValue(objectTwo, null);

                ObjectComparision comparision = new(parentType, value1, value2, property);

                if (CompareNullReferences(comparision, differences))
                {
                    continue;
                }

                if (CompareDomainsObjects(comparision, differences))
                {
                    continue;
                }

                if (ComparePrimitiveTypes(comparision, differences))
                {
                    continue;
                }

                Type? nullableType = Nullable.GetUnderlyingType(property.PropertyType);

                if (property.PropertyType.IsArray)
                {
                    CompareObject(comparision, differences);
                }
                else if (property.PropertyType.IsValueType)
                {
                    CompareObject(comparision, differences);
                }
                else if (property.PropertyType.IsAssignableTo(typeof(System.Collections.IEnumerable)))
                {
                    CompareObject(comparision, differences);
                }
                else if (nullableType is not null && nullableType.IsPrimitive)
                {
                    CompareObject(comparision, differences);
                }
                else
                {
                    _ = differences.Concat(Compare(value1!, value2!));
                }
            }

            return differences;
        }

        public static bool CompareDomainsObjects(ObjectComparision comparision,
            Dictionary<Type, PropertyInfo> differences)
        {
            if (comparision.ParentType.IsAssignableTo(typeof(IDominio)))
            {
                CompareObject(comparision, differences);
                return true;
            }
            return false;
        }

        public static bool ComparePrimitiveTypes(ObjectComparision comparision,
            Dictionary<Type, PropertyInfo> differences)
        {
            if (comparision.ParentType == typeof(string))
            {
                if (!(string.IsNullOrEmpty(comparision.ValueOne as string) && string.IsNullOrEmpty(comparision.ValueTwo as string)))
                {
                    CompareObject(comparision, differences);
                }
                return true;
            }
            else if (comparision.ParentType.IsPrimitive)
            {
                CompareObject(comparision, differences);
                return true;
            }
            return false;
        }

        public static bool CompareNullReferences(ObjectComparision comparision,
            Dictionary<Type, PropertyInfo> differences)
        {
            if (comparision.ValueOne is null && comparision.ValueTwo is null)
            {
                return true;
            }
            if (comparision.ValueOne is null)
            {
                differences.Add(comparision.ParentType, comparision.Property);
                return true;
            }
            else if (comparision.ValueTwo is null)
            {
                differences.Add(comparision.ParentType, comparision.Property);
                return true;
            }
            return false;
        }

        private static void CompareObject(ObjectComparision comparision,
            Dictionary<Type, PropertyInfo> differences)
        {
            if (comparision.ValueOne is null && comparision.ValueTwo is null)
            {
                return;
            }

            if (comparision.ValueOne is null || !comparision.ValueOne!.Equals(comparision.ValueTwo))
            {
                differences.Add(comparision.ParentType, comparision.Property);
            }
        }
    }
}
