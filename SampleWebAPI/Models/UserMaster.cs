using System;
using System.Collections.Generic;

namespace SampleWebAPI.Models
{
    public partial class UserMaster
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRoles { get; set; }
        public string UserEmailId { get; set; }
    }
}
