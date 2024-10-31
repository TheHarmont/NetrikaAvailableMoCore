using Microsoft.EntityFrameworkCore;
using NAMO.Application.Interfaces.Repositories;
using NAMO.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Persistence.Repositories;

public class GenericRepository<T>(ApplicationDBContext db) 
    : IGenericRepository<T> where T : class
{
    public IQueryable<T> Entities => db.Set<T>();

}
