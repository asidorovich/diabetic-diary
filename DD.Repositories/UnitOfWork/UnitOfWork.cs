using System;
using DD.Repositories.Common;
using DD.Repositories.Interfaces.Common;
using DD.Repositories.Interfaces.Context;
using DD.Repositories.Interfaces.UnitOfWork;

namespace DD.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region Private Members

        private IPersonRecordRepository _personRecordRepository;

        #endregion

        #region Public Properties

        public IDapperContext Context { get; private set; }

        public IPersonRecordRepository PersonRecord
        {
            get
            {
                if (_personRecordRepository == null)
                {
                    _personRecordRepository = new PersonRecordRepository(Context);
                }
                return _personRecordRepository;
                
            }
        }

        #endregion

        #region .ctor

        public UnitOfWork(IDapperContext context)
        {
            Context = context;
        }

        #endregion

        #region Public Methods

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }

        #endregion
    }
}
