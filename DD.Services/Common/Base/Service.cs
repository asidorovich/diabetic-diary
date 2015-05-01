using DD.Repositories.Interfaces.UnitOfWork;
using DD.Services.Interfaces.Common.Base;

namespace DD.Services.Common.Base
{
    public class Service : IService
    {
        #region Public Properties

        public IUnitOfWork UnitOfWork { get; private set; }

        #endregion

        #region .ctor

        public Service(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        #endregion
    }
}
