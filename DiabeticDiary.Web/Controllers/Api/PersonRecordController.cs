using System;
using System.Collections.Generic;
using System.Web.Http;
using DD.Dto.Business;
using DD.Services.Interfaces.Common;

namespace DiabeticDiary.Web.Controllers.Api
{
    public class PersonRecordController : ApiController
    {
        private IPersonRecordService _personRecordService;

        public PersonRecordController(IPersonRecordService personRecordService)
        {
            _personRecordService = personRecordService;
        }

        #region Public Methods

        // GET api/<controller>
        public IEnumerable<PersonRecordDto> GetPersonRecordsForDate(int personId, DateTime date)
        {
            var result = _personRecordService.GetAllPersonRecords(personId);

            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]PersonRecordDto personRecord)
        {
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