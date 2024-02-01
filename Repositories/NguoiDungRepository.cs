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
    public class NguoiDungRepository : RepositoryBase<NguoiDung, int>, INguoiDungRepository
    {
        public NguoiDungRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}