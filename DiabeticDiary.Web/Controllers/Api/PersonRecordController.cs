using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DD.Mappers.Common.Interfaces;
using DD.Services.Interfaces.Common;
using DD.ViewModels.Web;

namespace DiabeticDiary.Web.Controllers.Api
{
    public class PersonRecordController : ApiController
    {
        private IPersonRecordService _personRecordService;
        private IViewModelMapper _mapper;

        public PersonRecordController(IPersonRecordService personRecordService, IMapper mapper)
        {
            _personRecordService = personRecordService;
            _mapper = mapper;
        }

        #region Public Methods

        // GET api/<controller>
        public IEnumerable<PersonRecordViewModel> GetPersonRecordsForDate(int personId, DateTime date)
        {
            var result = new List<PersonRecordViewModel>();

            var personRecords = _personRecordService.GetAllPersonRecords(personId);

            if (personRecords.Any())
            {
                result.AddRange(personRecords.Select(personRecord => _mapper.Map(personRecord)));
            }

            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]PersonRecordViewModel personRecord)
        {
            var dto = _mapper.Map(personRecord);

            _personRecordService.SavePersonRecord(dto);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        #endregion

        
    }
}