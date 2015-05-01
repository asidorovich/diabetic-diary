using DD.Repositories.Interfaces.Common;
using DD.Repositories.Interfaces.Context;

namespace DD.Repositories.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        IDapperContext Context { get; }

        IPersonRecordRepository PersonRecord { get; }
    }
}
