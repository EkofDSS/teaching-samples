using System;
using System.Collections.Generic;

namespace project.ViewModels
{
    public class ActorUpdateDto
    {
        public long ActorId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long CountryId { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}