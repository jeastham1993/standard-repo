// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Infrastructure
{
    /// <summary>
    /// Encapsulates code for in memory database repository.
    /// </summary>
    public class CustomerDatabaseInMemoryImpl : ICustomerDatabase
    {
        private static List<Customer> customers;

        /// <inheritdoc/>
        public Task StoreAsync(Customer customer)
        {
            if (customers == null)
            {
                customers = new List<Customer>();
            }

            customers.Add(customer);

            return Task.FromResult(string.Empty);
        }
    }
}
