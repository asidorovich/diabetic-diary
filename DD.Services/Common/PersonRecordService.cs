using System.Collections.Generic;
using System.Linq;
using DD.Dto.Business;
using DD.Repositories.Interfaces.UnitOfWork;
using DD.Services.Common.Base;
using DD.Services.Interfaces.Common;

namespace DD.Services.Common
{
    public class PersonRecordService : Service, IPersonRecordService
    {
        #region .ctor

        public PersonRecordService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            
        }

        #endregion

        #region Public Methods

        public IList<PersonRecordDto> GetAllPersonRecords(int personId)
        {
            var entities = UnitOfWork.PersonRecord.GetAll(personId);

            var result=entities.Select(entity => new PersonRecordDto
            {
                PersonId = entity.PersonId, 
                RecordTime = entity.RecordTime, 
                Insulin = entity.Insulin, 
                Carbohydrates = entity.Carbohydrates, 
                BloodGloucoseBgm = entity.BloodGloucoseBgm, 
                BloodGloucoseCgm = entity.BloodGloucoseCgm, 
                BloodGloucoseCgmRaw = entity.BloodGloucoseCgmRaw, 
                Note = entity.Note
            }).ToList();

            return result;
        }

        #endregion
    }
}
