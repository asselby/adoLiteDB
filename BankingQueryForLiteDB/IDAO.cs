using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingQueryForLiteDB
{
        public interface IDAO<T>
       where T : class
        {
            void Create(T record);
            string Update(T record);
            void Remove(string id);
            T Read(string id);
            ICollection<T> Read();
        }    
}
