using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Repo
{
    public class Claims
    {
        // Class methods
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        //public override string ToString()
        //{
        //    return string.Format( "{0} {1} {2} {3} {4} {5} {6}", 
        //                          Id, Type, Description, Amount,
        //                          DateOfIncident.ToString("MM/dd/yyyy"), 
        //                          DateOfClaim.ToString("MM/dd/yyyy"), IsValid);
        //}

        // Constructors -- set the initial state

        public Claims() { }

        public Claims(int id, string type, string description,
                        decimal amount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            Id = id;
            Type = type;
            Description = description;
            Amount = amount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = (dateOfClaim - dateOfIncident).TotalDays <= 30;
            // Claim only valid if claim filed within 30 days of incident
        }
    }
}
