using System;

namespace BookShelves.Infra
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class PageAttribute : Attribute { }
}
