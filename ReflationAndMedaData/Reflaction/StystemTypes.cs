using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflationAndMedaData.Reflaction
{
    public class StystemTypes
    {
        public void DataTypes()
        {
            Type stringType = typeof(string);
            string name = stringType.Name; // String
            Type baseType = stringType.BaseType; // typeof(Object)
            Assembly assem = stringType.Assembly; // System.Private.CoreLib
            bool isPublic = stringType.IsPublic; // true

            Console.WriteLine(name);
            Console.WriteLine(baseType);
            Console.WriteLine(assem);
            Console.WriteLine(isPublic);
        }

        public void TypeInfo()
        {
            Type stringType = typeof(string);
            string name = stringType.Name;
            Type baseType = stringType.GetTypeInfo().BaseType;
            Assembly assem = stringType.GetTypeInfo().Assembly;
            bool isPublic = stringType.GetTypeInfo().IsPublic;
        }

        public void MakeOfArrayType()
        {
            Type simpleArrayType = typeof(int).MakeArrayType();
            Console.WriteLine(simpleArrayType == typeof(int[])); // True
            Type cubeType = typeof(int).MakeArrayType(3); // cube shaped
            Console.WriteLine(cubeType == typeof(int[,,])); // True

            Type e = typeof(int[]).GetElementType(); // e == typeof (int

            int rank = typeof(int[,,]).GetArrayRank(); // 3

            foreach (Type t in typeof(System.Environment).GetNestedTypes())
                Console.WriteLine(t.FullName);

            foreach (TypeInfo t in typeof(System.Environment).GetTypeInfo().DeclaredNestedTypes)
                Debug.WriteLine(t.FullName);
        }


        public void GetInterfaces()
        {
            foreach(Type iType in typeof(Guid).GetInterfaces())
            {
                Console.WriteLine(iType);
            }
        }

        public void IsAssignable()
        {
            object obj = Guid.NewGuid();
            Type targetType = typeof(IFormattable);

            bool isTrue = obj is IFormattable;
            bool isAlsoTrue = targetType.IsInstanceOfType(obj);

            Type target = typeof(IComparable), source = typeof(string);
            Console.WriteLine(target.IsAssignableFrom(source));
        }
    }
}
