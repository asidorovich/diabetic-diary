using DD.Dto.Business;
using DD.Mappers.Common.Interfaces;
using DD.ViewModels.Web;

namespace DD.Mappers
{
    public partial class Mapper
    {
        #region PersonRecordDto -> PersonRecordViewModel -> PersonRecordDto

        PersonRecordViewModel IViewModelMapper.Map(PersonRecordDto dto)
        {
            var viewModel = new PersonRecordViewModel();

            if (dto != null)
            {
                viewModel.PersonId = dto.PersonId;
                viewModel.RecordTime = dto.RecordTime;
                viewModel.Insulin = dto.Insulin;
                viewModel.Carbohydrates = dto.Carbohydrates;
                viewModel.BloodGloucoseBgm = dto.BloodGloucoseBgm;
                viewModel.BloodGloucoseCgm = dto.BloodGloucoseCgm;
                viewModel.BloodGloucoseCgmRaw = dto.BloodGloucoseCgmRaw;
                viewModel.Note = dto.Note;
            }

            return viewModel;
        }

        public PersonRecordDto Map(PersonRecordViewModel viewModel)
        {
            var dto = new PersonRecordDto();

            if (viewModel != null)
            {
                dto.PersonId = viewModel.PersonId;
                dto.RecordTime = viewModel.RecordTime;
                dto.Insulin = viewModel.Insulin;
                dto.Carbohydrates = viewModel.Carbohydrates;
                dto.BloodGloucoseBgm = viewModel.BloodGloucoseBgm;
                dto.BloodGloucoseCgm = viewModel.BloodGloucoseCgm;
                dto.BloodGloucoseCgmRaw = viewModel.BloodGloucoseCgmRaw;
                dto.Note = viewModel.Note;
            }

            return dto;
        }

        #endregion
    }
}
