using System;
using System.Collections.Generic;

namespace Komodo_Claims_Repo
{
    public class ClaimsRepository
    {
        // Class Variables

        List<Claims> _listOfClaims = new List<Claims>();

        // Class Methods

        public void AddClaimsToList(Claims claim)
        {
            _listOfClaims.Add(claim);
        }

        public string CreateFormattedNextClaim()
        {
            // Local Variable

            Claims claim;

            string stringFormat = "\n No valid claims exist.";

            if (_listOfClaims.Count >= 1)
            {
                claim = _listOfClaims[0];

                // Format next claim

                stringFormat = "\nClaimID: " + claim.Id +
                            "\nType: " + claim.Type +
                            "\nDescription: " + claim.Description +
                            "\nAmount: " + claim.Amount +
                            "\nDateOfAccident: " + claim.DateOfIncident.ToString("MM/dd/yyyy") +
                            "\nDateOfClaim: " + claim.DateOfClaim.ToString("MM/dd/yyyy") +
                            "\nIsValid: " + claim.IsValid;
            }

            return stringFormat;
        }

        public Claims GetNextClaim()
        {
            return _listOfClaims[0];
        }

        public void RemoveNextClaim()
        {
            _listOfClaims.RemoveAt(0);
        }

        //Read
        public List<Claims> ClaimsList() => _listOfClaims;

        public Claims GetClaimsBy(int Id)
        {
            foreach (Claims claim in _listOfClaims)
            {
                if (claim.Id == Id)
                {
                    return claim;
                }
            }

            return null;
        }

        public void DisplayClaims()
        {

            if (_listOfClaims.Count >= 1)
            {
                Console.WriteLine("ClaimID Type Description Amount DateofAccident DateOfClaim isValid");

                foreach (Claims claim in _listOfClaims)
                {
                    Console.WriteLine($"{claim.Id}\n" +
                        $"{claim.Type}\n" +
                        $"{claim.Description}\n" +
                        $"{claim.Amount}\n" +
                        $"{claim.DateOfIncident}\n" +
                        $"{claim.DateOfClaim}\n" +
                        $"{claim.IsValid}\n");
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }
            else
                Console.WriteLine("No claims exist.");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}