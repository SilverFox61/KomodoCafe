using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Repoxx
{
    public class Claim
    {
        // Class methods
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Decimal Amount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public Boolean IsValid { get; }

        public override string ToString()
        {
            return string.Format( "{0} {1} {2} {3} {4} {5} {6}", 
                                  Id, Type, Description, Amount,
                                  DateOfIncident, DateOfClaim, IsValid);
        }

        // Constructors -- set the initial state

        public Claim(int id, string type, string description,
                        Decimal amount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            Id = id;
            Type = type;
            Description = description;
            Amount = amount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;

            // Claim only valid if claim filed within 30 days of incident

            if ((DateOfClaim - DateOfIncident).TotalDays <= 30)
                IsValid = true;
            else
                IsValid = false;
        }
    }
}
