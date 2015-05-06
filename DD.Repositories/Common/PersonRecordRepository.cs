using System.Collections.Generic;
using System.Data;
using Dapper;
using DD.Data.Entities;
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

        public void Save(PersonRecord personRecord)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@personId", personRecord.PersonId);
            parameters.Add("@recordTime", personRecord.RecordTime);
            parameters.Add("@insulin", personRecord.Insulin);
            parameters.Add("@carbohydrates", personRecord.Carbohydrates);
            parameters.Add("@bloodGloucoseBgm", personRecord.BloodGloucoseBgm);
            parameters.Add("@bloodGloucoseCgm", personRecord.BloodGloucoseCgm);
            parameters.Add("@bloodGloucoseCgmRaw", personRecord.BloodGloucoseCgmRaw);
            parameters.Add("@note", personRecord.Note);

            DbConnection.Query<PersonRecord>("PersonRecord_Insert",
                    parameters,
                    commandType: CommandType.StoredProcedure);

        }

        #endregion
    }
}
