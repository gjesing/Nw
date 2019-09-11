using System;
using System.Collections.Generic;

namespace Nw.Entities
{
    public partial class People
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
