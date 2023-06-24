﻿using ECommerce.Base;

namespace ECommerce.Operation;

public interface IBaseService<TEntity,TRequest,TResponse>
{
    ApiResponse<List<TResponse>> GetAll();
    ApiResponse<TResponse> GetById(int id);
    ApiResponse Insert(TRequest request);
    ApiResponse Update(int Id, TRequest request);
    ApiResponse Delete(int Id);
}
