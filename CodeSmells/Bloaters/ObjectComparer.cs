using System.Reflection;

namespace CodeSmelss.Bloaters
{
    public static class ObjectComparer
    {
        public static Dictionary<Type, PropertyInfo> Compare<T>(T objectOne,
            T objectTwo) where T : class
        {
            Dictionary<Type, PropertyInfo> differences = [];
            var parentType = objectOne.GetType();

            void CompareObject(object? objOne, object? objTwo, PropertyInfo property)
            {
                if (objOne is null && objTwo is null)
                {
                    return;
                }

                if (objOne is null || !objOne!.Equals(objTwo))
                {
                    differences.Add(parentType, property);
                }
            }

            foreach (PropertyInfo property in parentType.GetProperties())
            {
                object? value1 = property.GetValue(objectOne, null);
                object? value2 = property.GetValue(objectTwo, null);

                if (property.PropertyType.IsAssignableTo(typeof(IDominio)))
                {
                    CompareObject(value1, value2, property);
                }
                else if (property.PropertyType == typeof(string))
                {
                    if (!(string.IsNullOrEmpty(value1 as string) && string.IsNullOrEmpty(value2 as string)))
                    {
                        CompareObject(value1, value2, property);
                    }
                }
                else if (property.PropertyType.IsPrimitive)
                {
                    CompareObject(value1, value2, property);
                }
                else
                {
                    if (value1 is null && value2 is null)
                    {
                        continue;
                    }

                    if (value1 is null)
                    {
                        differences.Add(parentType, property);
                    }
                    else if (value2 is null)
                    {
                        differences.Add(parentType, property);
                    }
                    else
                    {
                        Type? nullableType = Nullable.GetUnderlyingType(property.PropertyType);

                        if (property.PropertyType.IsArray)
                        {
                            CompareObject(value1, value2, property);
                        }
                        else if (property.PropertyType.IsValueType)
                        {
                            CompareObject(value1, value2, property);
                        }
                        else if (property.PropertyType.IsAssignableTo(typeof(System.Collections.IEnumerable)))
                        {
                            CompareObject(value1, value2, property);
                        }
                        else if (nullableType is not null && nullableType.IsPrimitive)
                        {
                            CompareObject(value1, value2, property);
                        }
                        else
                        {
                            _ = differences.Concat(Compare(value1!, value2!));
                        }
                    }
                }
            }

            return differences;
        }
    }
}
