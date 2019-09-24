using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class StudentContext
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Program Program { get; set; }
        public List<Paiement> Paiements { get; set; }
    }
}
