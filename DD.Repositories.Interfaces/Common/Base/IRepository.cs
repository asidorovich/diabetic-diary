using System;
using System.Collections.Generic;
using DD.Data.Interfaces;
using DD.Repositories.Interfaces.Context;

namespace DD.Repositories.Interfaces.Common.Base
{
    public interface IRepository<T> where T : IEntity, new()
    {
        IDapperContext DbContext { get; }

        IEnumerable<T>  GetAll();
    }
}
