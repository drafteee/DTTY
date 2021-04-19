using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTrackingYoutrack
{
    public class HttpAttribute : Attribute
    {
        public string Name;
        public HttpAttribute(string name)
        {
            Name = name;
        }
    }
    public class GetAttribute : HttpAttribute
    {
        public GetAttribute(string name) : base(name)
        {
            
            Name = name;
        }
    }

    public class PostAttribute : HttpAttribute
    {
        public PostAttribute(string name) : base(name)
        {
            Name = name;
        }
    }
}
