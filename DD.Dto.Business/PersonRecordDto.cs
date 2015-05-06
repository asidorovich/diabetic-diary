using System;

namespace DD.Dto.Business
{
    public class PersonRecordDto
    {
        #region Public Properties

        public int PersonId { get; set; }

        public DateTimeOffset RecordTime { get; set; }

        public decimal? Insulin { get; set; }

        public decimal? Carbohydrates { get; set; }

        public decimal? BloodGloucoseBgm { get; set; }

        public decimal? BloodGloucoseCgm { get; set; }

        public decimal? BloodGloucoseCgmRaw { get; set; }

        public string Note { get; set; }
                
        #endregion
    }
}
