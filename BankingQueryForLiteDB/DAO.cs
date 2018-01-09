using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace BankingQueryForLiteDB
{
    public class DAO : IDAO<DTO>
    {
        public void Create(DTO record)
        {
            using (var db= new LiteDatabase(@"MyDB.db"))
            {
                var col = db.GetCollection<DTO>("BankClients");
                
            }
           
        }

        public DTO Read(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<DTO> Read()
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public string Update(DTO record)
        {
            throw new NotImplementedException();
        }
    }
}
