using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ooad.Models;
using ooad_homework.Common.Repositories;
using ooad_homework.Repositories.Interfaces;

namespace ooad_homework.Repositories
{
    public class BacSiRepository : RepositoryBase<BacSi, int>, IBacSiRepository
    {
        public BacSiRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}