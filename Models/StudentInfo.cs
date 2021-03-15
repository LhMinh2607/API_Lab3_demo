using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LeHuynhMinh_5951071059.Models
{
    public class StudentInfo
    {
        [DataMember(Name = "stName")]
        public string stName { get; set; }
        [DataMember(Name = "stId")]
        public string stId { get; set; }
        [DataMember(Name = "stClass")]
        public string stClass { get; set; }
        [DataMember(Name = "stNo")]
        public int stNo { get; set; }
        [DataMember(Name = "stBirthYear")]
        public int stBirthYear { get; set; }
        [DataMember(Name = "RandomNumber")]
        public float RandomNumber { get; set; }
    }
}