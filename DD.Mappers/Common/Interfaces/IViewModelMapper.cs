using DD.Dto.Business;
using DD.ViewModels.Web;

namespace DD.Mappers.Common.Interfaces
{
    public interface IViewModelMapper
    {
        #region PersonRecordDto -> PersonRecordViewModel -> PersonRecordDto

        PersonRecordDto Map(PersonRecordViewModel source);

        PersonRecordViewModel Map(PersonRecordDto source);

        #endregion
    }
}
