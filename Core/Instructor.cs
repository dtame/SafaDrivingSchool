﻿using System;

namespace Core
{
    public class Instructor
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
        public Guid Branch { get; set; }
    }
}