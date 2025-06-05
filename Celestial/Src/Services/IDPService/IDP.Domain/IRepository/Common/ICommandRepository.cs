﻿namespace IDP.Domain.IRepository.Common
{
    public interface ICommandRepository<in T> where T : class
    {
        Task<bool> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
