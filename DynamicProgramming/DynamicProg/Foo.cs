using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.DynamicProg
{
    internal class Foo<T>
    {
        public T Value;
        static T GetFooValue<T>(Foo<T> foo) => foo.Value;
        static object GetFooValue(object foo) => null;
        static string GetGroupKey<TKey, TElement>(IGrouping<TKey, TElement> group) => "Group with key=" + group.Key + ": ";

        static void Write(dynamic obj)
        {
            try { Console.WriteLine(obj.Value); }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException) { }
        }

        static string GetGroupKey(object source) => null;

        public static string ToStringEx(object value)
        {
            if (value == null) return "<null>";
            if (value is string s) return s;
            if (value.GetType().IsPrimitive) return value.ToString();
            StringBuilder sb = new StringBuilder();
            string groupKey = GetGroupKey((dynamic)value); // Dynamic dispatch
            if (groupKey != null) sb.Append(groupKey);
            if (value is IEnumerable)
                foreach (object element in ((IEnumerable)value))
                    sb.Append(ToStringEx(element) + " ");
            if (sb.Length == 0) sb.Append(value.ToString());
            return "\r\n" + sb.ToString();
        }

    }
}
