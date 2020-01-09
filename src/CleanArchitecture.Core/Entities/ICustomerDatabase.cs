// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Entities
{
    /// <summary>
    /// Encapsulates all persistance of customer records.
    /// </summary>
    public interface ICustomerDatabase
    {
        /// <summary>
        /// Store the customer object in the database.
        /// </summary>
        /// <param name="customer">The <see cref="Customer"/> to be stored.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task StoreAsync(Customer customer);
    }
}
