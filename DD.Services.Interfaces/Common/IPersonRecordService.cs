using System;
using System.Collections.Generic;
using DD.Dto.Business;

namespace DD.Services.Interfaces.Common
{
    public interface IPersonRecordService
    {
        IList<PersonRecordDto> GetAllPersonRecords(int personId);
    }
}
