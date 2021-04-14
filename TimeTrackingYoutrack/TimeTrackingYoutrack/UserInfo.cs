using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTrackingYoutrack
{
    public class UserInfo
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string RingId { get; set; }
        public string Id { get; set; }
        public bool Banned { get; set; }
        public bool Guest { get; set; }
    }
}
