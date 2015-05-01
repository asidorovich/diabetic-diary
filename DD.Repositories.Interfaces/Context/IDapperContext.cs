using System;
using System.Data;

namespace DD.Repositories.Interfaces.Context
{
    public interface IDapperContext : IDisposable
    {
        IDbConnection Connection { get; }
    }
}
