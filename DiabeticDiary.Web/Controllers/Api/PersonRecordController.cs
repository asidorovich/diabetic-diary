using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DD.Dto.Business;

namespace DiabeticDiary.Web.Controllers.Api
{
    public class PersonRecordController : ApiController
    {
        #region Public Methods

        // GET api/<controller>
        public IEnumerable<PersonRecordDto> GetPersonRecordsForDate(int personId, DateTime date)
        {
            return new List<PersonRecordDto>()
            {
                new PersonRecordDto(),
                new PersonRecordDto()
            };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
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