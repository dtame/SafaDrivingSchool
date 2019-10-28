using System;
using System.Collections.Generic;
using System.Linq;
using static SafaEngine.Core.Ennumarations;

namespace SafaEngine.Core
{
    public class PaiementPlanner
    {
        //public List<Paiement> Paiements { get; set; }
        //private int StudentID { get; set; }
        //private DateTime StartDate { get; set; }
        //private ProgramType ProgramType { get; set; }

        //public PaiementPlanner(int studentID, DateTime startDate, ProgramType programType)
        //{
        //    Paiements = new List<Paiement>();
        //    StudentID = studentID;
        //    StartDate = startDate;
        //    ProgramType = programType;

        //    //set paiement plan
        //    switch (programType)
        //    {
        //        case ProgramType.CUSTOM:
        //            Paiements.Add(new Paiement {
                        
        //            });
        //            break;

        //        case ProgramType.STANDARD:
        //            break;
        //    }            
        //}
        
        ///// <summary>
        ///// Add a panelty fee when a student miss a class
        ///// </summary>
        ///// <param name="studentID"></param>
        ///// <param name="courseTitle"></param>
        //public void AjustFee(int studentID, string courseTitle)
        //{
        //    if (!String.IsNullOrWhiteSpace(courseTitle) && studentID > 0)
        //    {
        //        Paiement paiement = new Paiement
        //        {
        //            Amount = 35
        //            , StudentID = studentID
        //            , TimeStamp = DateTime.Now                    
        //            , Description = $"Ajustment for a missing class : {courseTitle}"
        //        };
        //        paiement.DueDate = GetNextDuePaiementDate();
        //        Paiements.Add(paiement);
        //    }
        //}

        ///// <summary>
        ///// Get the next due date for a student to make a paiement 
        ///// </summary>
        ///// <returns></returns>
        //private DateTime GetNextDuePaiementDate()
        //{            
        //    DateTime result = DateTime.Now;
        //    foreach (var paiement in Paiements.OrderBy(x => x.DueDate))
        //    {                
        //        if(paiement.DueDate >= DateTime.Now)
        //        {
        //            result = paiement.DueDate;
        //            break;
        //        }            
        //    }
        //    return result;
        //}
    }
}
