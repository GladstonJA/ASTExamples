using System.Reflection;

namespace CodeSmelss.Bloaters
{
    public static class ObjectComparerLongMethodRefactored
    {
        public static Dictionary<Type, PropertyInfo> Compare<T>(T objectOne, T objectTwo) where T : class
        {
            Dictionary<Type, PropertyInfo> differences = [];
            Type parentType = objectOne.GetType();

            foreach (PropertyInfo property in parentType.GetProperties())
            {
                ComparebjectsProperties(parentType,
                    objectOne,
                    objectTwo,
                    property,
                    differences);
            }

            return differences;
        }

        private static void ComparebjectsProperties(Type parentType,
            object objectOne,
            object objectTwo,
            PropertyInfo property,
            Dictionary<Type, PropertyInfo> differences)
        {
            object? valueOne = property.GetValue(objectOne, null);
            object? valueTwo = property.GetValue(objectTwo, null);

            if (CompareNullReferences(parentType, valueOne, objectTwo, property, differences))
            {
                return;
            }

            if (CompareDomainsObjects(parentType, valueOne!, valueTwo!, property, differences))
            {
                return;
            }

            if (ComparePrimitiveTypes(parentType, valueOne!, valueTwo!, property, differences))
            {
                return;
            }

            _ = differences.Concat(Compare(valueOne!, valueTwo!));
        }

        private static bool CompareDomainsObjects(Type parentType,
            object valueOne,
            object valueTwo
            , PropertyInfo property
            , Dictionary<Type, PropertyInfo> differences)
        {
            if (property.PropertyType.IsAssignableTo(typeof(IDominio)))
            {
                CompareObject(parentType, valueOne, valueTwo, property, differences);
                return true;
            }
            return false;
        }

        private static bool ComparePrimitiveTypes(Type parentType,
            object valueOne,
            object valueTwo,
            PropertyInfo property,
            Dictionary<Type, PropertyInfo> differences)
        {
            if (property.PropertyType == typeof(string))
            {
                if (!(string.IsNullOrEmpty(valueOne as string) && string.IsNullOrEmpty(valueTwo as string)))
                {
                    CompareObject(parentType, valueOne, valueTwo, property, differences);
                }
                return true;
            }
            else if (property.PropertyType.IsPrimitive)
            {
                CompareObject(parentType, valueOne, valueTwo, property, differences);
                return true;
            }
            else if (property.PropertyType.IsValueType)
            {
                CompareObject(parentType, valueOne, valueTwo, property, differences);
                return true;
            }
            else
            {
                Type? nullableType = Nullable.GetUnderlyingType(property.PropertyType);
                if (nullableType is not null && nullableType.IsPrimitive)
                {
                    CompareObject(parentType, valueOne, valueTwo, property, differences);
                    return true;
                }
            }

            return false;
        }

        private static bool CompareCollectionsTypes(Type parentType,
            object valueOne,
            object valueTwo,
            PropertyInfo property,
            Dictionary<Type, PropertyInfo> differences)
        {
            if (property.PropertyType.IsArray)
            {
                CompareObject(parentType, valueOne, valueTwo, property, differences);
                return true;
            }
            else if (property.PropertyType.IsAssignableTo(typeof(System.Collections.IEnumerable)))
            {
                CompareObject(parentType, valueOne, valueTwo, property, differences);
            }
            return false;
        }

        private static bool CompareNullReferences(Type parentType,
            object? valueOne
            , object? valueTwo,
            PropertyInfo property,
            Dictionary<Type, PropertyInfo> differences)
        {
            if (valueOne is null && valueTwo is null)
            {
                return true;
            }
            if (valueOne is null)
            {
                differences.Add(parentType, property);
                return true;
            }
            else if (valueTwo is null)
            {
                differences.Add(parentType, property);
                return true;
            }
            return false;
        }

        private static void CompareObject(Type parentType,
            object? obj1,
            object? obj2,
            PropertyInfo property, Dictionary<Type, PropertyInfo> differences)
        {
            if (obj1 is null && obj2 is null)
            {
                return;
            }

            if (obj1 is null || !obj1!.Equals(obj2))
            {
                differences.Add(parentType, property);
            }
        }
    }
}
