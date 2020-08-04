﻿using System;
using System.Linq;
using System.Linq.Expressions;
using Keltek.Core.Interfaces;
using Keltek.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Keltek.Infrastructure.Repository
{
  public class RepositoryBase<T> : IRepositoryBase<T> where T : class
  {
    protected RepositoryContext RepositoryContext { get; set; }

    public RepositoryBase(RepositoryContext repositoryContext)
    {
      RepositoryContext = repositoryContext;
    }

    public IQueryable<T> FindAll()
    {
      return RepositoryContext.Set<T>().AsNoTracking();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
      return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
    }

    public void Create(T entity)
    {
      RepositoryContext.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
      RepositoryContext.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
      RepositoryContext.Set<T>().Remove(entity);
    }
  }
}