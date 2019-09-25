using System;
using System.Collections.Generic;
using System.Linq;
using static SafaEngine.Ennumarations;

namespace SafaEngine.Core
{
    public class PaiementProfile
    {
        public List<Paiement> Paiements { get; set; }
        private int StudentID { get; set; }
        private DateTime StartDate { get; set; }
        private ProgramType ProgramType { get; set; }

        public PaiementProfile(int studentID, DateTime startDate, ProgramType programType)
        {
            Paiements = new List<Paiement>();
            StudentID = studentID;
            StartDate = startDate;
            ProgramType = programType;

            //TODO : load all paiements from db for this student
        }

        /// <summary>
        /// Add a panelty fee when a student miss a class
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="courseTitle"></param>
        public void AjustFee(int studentID, string courseTitle)
        {
            if (!String.IsNullOrWhiteSpace(courseTitle) && studentID > 0)
            {
                Paiement paiement = new Paiement
                {
                    Amount = 35
                    , StudentID = studentID
                    , TimeStamp = DateTime.Now                    
                    , Description = $"Ajustment for a missing class : {courseTitle}"
                };
                paiement.DueDate = GetNextDuePaiementDate();
                Paiements.Add(paiement);
            }
        }

        /// <summary>
        /// Get the next due date for a student to make a paiement 
        /// </summary>
        /// <returns></returns>
        private DateTime GetNextDuePaiementDate()
        {            
            DateTime result = DateTime.Now;
            foreach (var paiement in Paiements.OrderBy(x => x.DueDate))
            {                
                if(paiement.DueDate >= DateTime.Now)
                {
                    result = paiement.DueDate;
                    break;
                }            
            }
            return result;
        }
    }
}
