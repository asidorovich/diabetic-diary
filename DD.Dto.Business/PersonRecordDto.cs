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

        public string BloodGloucoseCgmFull
        {
            get
            {
                var result = "- (-)";

                if (BloodGloucoseCgm.HasValue && BloodGloucoseCgmRaw.HasValue)
                {
                    result = string.Format("{0:N1} ({1:N1})", BloodGloucoseCgm.Value, BloodGloucoseCgmRaw.Value);
                }
                else if (BloodGloucoseCgm.HasValue &&  !BloodGloucoseCgmRaw.HasValue)
                {
                    result = string.Format("{0:N1} (-)", BloodGloucoseCgm.Value);
                }
                else if (!BloodGloucoseCgm.HasValue && BloodGloucoseCgmRaw.HasValue)
                {
                    result = string.Format("- ({0:N1})", BloodGloucoseCgmRaw.Value);
                }
                return result;
            }
        }

        #endregion
    }
}
