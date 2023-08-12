﻿using NLayer.Core.Concrete;
using NLayer.Core.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface ICustomerRepositories:IGenericrepository<Customer>
    {
        Task<List<Customer>> ListTogether();
    }
}
