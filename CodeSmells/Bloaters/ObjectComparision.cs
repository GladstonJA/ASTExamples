using System.Reflection;

namespace CodeSmelss.Bloaters
{
    public class ObjectComparision
    {
        public ObjectComparision(Type parentType, object? valueOne, object? valueTwo, PropertyInfo property)
        {
            ParentType = parentType;
            ValueOne = valueOne;
            ValueTwo = valueTwo;
            Property = property;
        }

        public Type ParentType { get; set; }

        public object? ValueOne { get; set; }

        public object? ValueTwo { get; set; }

        public PropertyInfo Property { get; set; }
    }
}
