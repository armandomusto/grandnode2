﻿using Grand.Domain.Customers;
using Grand.Domain.Stores;
using Grand.Web.Models.Customer;
using MediatR;

namespace Grand.Web.Commands.Models.Customers
{
    public class SubAccountEditCommand : IRequest<(bool success, string error)>
    {
        public Customer CurrentCustomer { get; set; }
        public Store Store { get; set; }
        public SubAccountModel Model { get; set; }
    }
}
