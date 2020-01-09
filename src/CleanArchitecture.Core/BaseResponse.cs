// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core
{
    /// <summary>
    /// A base response for all requests.
    /// </summary>
    public class BaseResponse
    {
        private List<string> _errors;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResponse"/> class.
        /// </summary>
        internal BaseResponse()
        {
            this._errors = new List<string>(0);
        }

        /// <summary>
        /// Gets a value indicating whether the response has an error.
        /// </summary>
        public bool HasError
        {
            get
            {
                if (this._errors.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Gets any error messages.
        /// </summary>
        public IReadOnlyCollection<string> Errors => this._errors;

        internal void AddError(string errorMessage)
        {
            if (this._errors == null)
            {
                this._errors = new List<string>(1);
            }

            this._errors.Add(errorMessage);
        }
    }
}
