﻿using AutoMapper;
using ECommerce.Data;
using ECommerce.Domain;

namespace ECommerce.Schema;

public class MapperProfile : Profile 
{
    public MapperProfile()
    {
        CreateMap<Category, CategoryResponse>();
        CreateMap<CategoryRequest, Category>();

        CreateMap<Product, ProductResponse>();
        CreateMap<ProductRequest, Product>();

        CreateMap<User, UserResponse>();
        CreateMap<UserRequest, User>();

        //CreateMap<Customer, CustomerResponse>();
        //CreateMap<CustomerRequest, Customer>();

        //CreateMap<Account, AccountResponse>();
        //CreateMap<AccountRequest, Account>();

        //CreateMap<Transaction, TransactionResponse>();
        //CreateMap<TransactionView, TransactionViewResponse>();

        //CreateMap<UserLogRequest, UserLog>();
        //CreateMap<UserLog, UserLogResponse>();

        //CreateMap<CurrencyRequest, Currency>();
        //CreateMap<Currency, CurrencyResponse>();

    }


}
