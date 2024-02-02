using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ooad_homework.Models;
using ooad_homework.Common.Repositories;
using ooad_homework.Repositories.Interfaces;

namespace ooad_homework.Repositories
{
    public class PhieuPTRepository : RepositoryBase<PhieuPT, int>, IPhieuPTRepository
    {
        public PhieuPTRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}