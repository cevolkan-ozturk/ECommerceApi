﻿using ECommerce.Base;

namespace ECommerce.Schema;

public class CategoryResponse : BaseResponse
{
    public string Name { get; set; }
    public int Order { get; set; }
}
