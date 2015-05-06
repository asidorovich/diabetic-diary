using DD.Data.Entities;
using DD.Dto.Business;

namespace DD.Mappers.Common.Interfaces
{
    public interface IEntityMapper
    {
        #region PersonRecord -> PersonRecordDto -> PersonRecord

        PersonRecord Map(PersonRecordDto source);

        PersonRecordDto Map(PersonRecord source);

        #endregion
    }
}
