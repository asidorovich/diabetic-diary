using DD.Data.Entities;
using DD.Dto.Business;
using DD.Mappers.Common.Interfaces;

namespace DD.Mappers
{
    public partial class Mapper
    {
        #region PersonRecord -> PersonRecordDto -> PersonRecord

        PersonRecord IEntityMapper.Map(PersonRecordDto dto)
        {
            var entity = new PersonRecord();

            if (dto != null)
            {
                entity.PersonId = dto.PersonId;
                entity.RecordTime = dto.RecordTime;
                entity.Insulin = dto.Insulin;
                entity.Carbohydrates = dto.Carbohydrates;
                entity.BloodGloucoseBgm = dto.BloodGloucoseBgm;
                entity.BloodGloucoseCgm = dto.BloodGloucoseCgm;
                entity.BloodGloucoseCgmRaw = dto.BloodGloucoseCgmRaw;
                entity.Note = dto.Note;
            }

            return entity;
        }

        public PersonRecordDto Map(PersonRecord entity)
        {
            var dto = new PersonRecordDto();

            if (entity != null)
            {
                dto.PersonId = entity.PersonId;
                dto.RecordTime = entity.RecordTime;

                dto.Insulin = entity.Insulin;
                dto.Carbohydrates = entity.Carbohydrates;
                dto.BloodGloucoseBgm = entity.BloodGloucoseBgm;
                dto.BloodGloucoseCgm = entity.BloodGloucoseCgm;
                dto.BloodGloucoseCgmRaw = entity.BloodGloucoseCgmRaw;
                dto.Note = entity.Note;
            }

            return dto;
        }

        #endregion
    }
}
