using System;
using System.Collections.Generic;

namespace project.ViewModels
{
    public class ActorUpdateDTO
    {
        public long ActorId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CountryCode { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}