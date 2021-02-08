﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    class Gamer: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }
    }
}
