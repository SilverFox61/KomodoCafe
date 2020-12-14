using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Repo
{
    public class ClaimsRepository
    {
        // Class Variables

        List<Claim> _listOfClaims = new List<Claim>();

        // Class Methods
  
        public void AddClaimsToList(Claim claim)
        {
            _listOfClaims.Add(claim);
        }

        public string CreateFormattedNextClaim()
        {
            // Local Variables

            Claim claim;

            string strFormat = "\nNo valid claims exist!";

            if ( _listOfClaims.Count >= 1)
            {
                claim = _listOfClaims[0];

                // Format next claim

                strFormat = "\nClaimID: " + claim.Id +
                            "\nType: " + claim.Type +
                            "\nDescription: " + claim.Description +
                            "\nAmount: " + claim.Amount +
                            "\nDateOfAccident: " + claim.DateOfIncident.ToString("MM/dd/yyyy") +
                            "\nDateOfClaim: " + claim.DateOfClaim.ToString("MM/dd/yyyy") +
                            "\nIsValid: " + claim.IsValid;
            }

            return strFormat;
        }

        public Claim GetNextClaim()
        {
            return _listOfClaims[0];
        }

        public void RemoveNextClaim()
        {
            _listOfClaims.RemoveAt(0);
        }

        //Read
        public List<Claim> ClaimsList() => _listOfClaims;

        public Claim GetClaimsBy(int Id)
        {
            foreach (Claim claim in _listOfClaims)
            {
                if (claim.Id == Id)
                {
                    return claim;
                }
            }

            return null;
        }

        public string DisplayClaims()
        {
            // Local Variables

            string strFormat = "";

            if (_listOfClaims.Count >= 1)
            {
                Console.WriteLine("ClaimID Type Description Amount DateofAccident DateOfClaim isValid");

                foreach (Claim claim in _listOfClaims)
                {
                    strFormat += claim.ToString() + "\n";
                }
            }
            else
                strFormat = "\nNo claims exist!";

            return strFormat;
        }
    }
}