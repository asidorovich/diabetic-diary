using System.Collections.Generic;
using System.Linq;
using DD.Data.Entities;
using DD.Dto.Business;
using DD.Mappers.Common.Interfaces;
using DD.Repositories.Interfaces.UnitOfWork;
using DD.Services.Common.Base;
using DD.Services.Interfaces.Common;

namespace DD.Services.Common
{
    public class PersonRecordService : Service, IPersonRecordService
    {
        #region Private Members

        private IMapper _mapper;

        #endregion

        #region .ctor

        public PersonRecordService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork)
        {
            _mapper = mapper;
        }

        #endregion

        #region Public Methods

        public IList<PersonRecordDto> GetAllPersonRecords(int personId)
        {
            var entities = UnitOfWork.PersonRecord.GetAll(personId);

            var result=entities.Select(entity => _mapper.Map(entity)).ToList();

            return result;
        }

        public void SavePersonRecord(PersonRecordDto personRecordDto)
        {
            var personRecord = ((IEntityMapper)_mapper).Map(personRecordDto);

            UnitOfWork.PersonRecord.Save(personRecord);
        }

        #endregion
    }
}
