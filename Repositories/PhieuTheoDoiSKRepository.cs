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
    public class PhieuTheoDoiSKRepository : RepositoryBase<PhieuTheoDoiSK, int>, IPhieuTheoDoiSKepository
    {
        public PhieuTheoDoiSKRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}