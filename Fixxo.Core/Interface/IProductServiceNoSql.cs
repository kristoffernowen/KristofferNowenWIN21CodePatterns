﻿using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;

namespace Fixxo.Core.Interface;

public interface IProductServiceNoSql
{
    public Task<List<IProduct>> GetAsync();
    public Task CreateAsync(Product model);
}