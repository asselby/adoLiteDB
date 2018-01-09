using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingQueryForLiteDB
{
   public abstract class DTO:EntityDto
    {
        #region Methods
        public override string ToString()
        {
            return GetDetailedTypeInfo();
        }
        #endregion
        #region Constructors
        public DTO(string firstName, string lastName, string email,
            string password, string passwordConfirmation) :base(firstName, lastName, email, password)
        {

        }

        public DTO()
        {

        }
        #endregion

    }
}
