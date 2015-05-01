using System.Collections.Generic;
using System.Data;
using Dapper;
using DD.Data.Entities;
using DD.Dto.Business;
using DD.Repositories.Common.Base;
using DD.Repositories.Interfaces.Common;
using DD.Repositories.Interfaces.Context;

namespace DD.Repositories.Common
{
    public class PersonRecordRepository : Repository<PersonRecord>, IPersonRecordRepository
    {

        #region .ctor

        public PersonRecordRepository(IDapperContext context)
            :base(context)
        {
            
        }

        #endregion

        #region Public Methods

        public IEnumerable<PersonRecord> GetAll(int personId)
        {
            var entities = DbConnection.Query<PersonRecord>("PersonRecord_GetAll", 
                                new { PersonId = personId}, 
                                commandType: CommandType.StoredProcedure);

            return entities;
        }

        #endregion
    }
}
