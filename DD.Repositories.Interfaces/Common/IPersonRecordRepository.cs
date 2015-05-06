using System.Collections.Generic;
using DD.Data.Entities;
namespace DD.Repositories.Interfaces.Common
{
    public interface IPersonRecordRepository
    {
        IEnumerable<PersonRecord> GetAll(int personId);

        void Save(PersonRecord personRecord);
    }
}
