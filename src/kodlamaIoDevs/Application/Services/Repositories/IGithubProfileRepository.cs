﻿using Core.Persistence.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public interface IGithubPrfoileRepository : IAsyncRepository<GithubProfile>, IRepository<GithubProfile>
    {
    }
}
