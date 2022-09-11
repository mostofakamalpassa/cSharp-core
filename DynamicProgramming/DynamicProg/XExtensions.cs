using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynamicProgramming.DynamicProg
{
    static class XExtensions
    {
        public static dynamic DynamicAttributes(this XElement e)
        => new XWrapper(e);
        class XWrapper : DynamicObject
        {
            XElement _element;
            public XWrapper(XElement e) { _element = e; }
            public override bool TryGetMember(GetMemberBinder binder,
            out object result)
            {
                result = _element.Attribute(binder.Name).Value;
                return true;
            }
            public override bool TrySetMember(SetMemberBinder binder,
            object value)
            {
                _element.SetAttributeValue(binder.Name, value);
                return true;
            }
        }
    }
}
