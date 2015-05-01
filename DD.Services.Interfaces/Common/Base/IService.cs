using DD.Repositories.Interfaces.UnitOfWork;

namespace DD.Services.Interfaces.Common.Base
{
    public interface IService
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
