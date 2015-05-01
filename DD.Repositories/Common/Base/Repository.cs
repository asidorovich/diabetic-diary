using System.Collections.Generic;
using System.Data;
using Dapper;
using DD.Data.Interfaces;
using DD.Repositories.Interfaces.Common.Base;
using DD.Repositories.Interfaces.Context;

namespace DD.Repositories.Common.Base
{
    public class Repository<T> : IRepository<T> where T: IEntity, new()
    {
        #region Private Members

        #endregion

        #region Public Properties

        public IDapperContext DbContext { get; private set; }

        public IDbConnection DbConnection { get; private set; }


        #endregion

        #region .ctor

        public Repository(IDapperContext context)
        {
            DbContext = context;
            DbConnection = DbContext.Connection;
        }

        #endregion

        #region Public Methods
        
        public IEnumerable<T> GetAll()
        {
            var entityName = (typeof (T)).Name;

            var query = string.Format("{0}_GetAll", entityName);

            var result = DbConnection.Query<T>(query);

            return result;
        }

        #endregion
    }
}
