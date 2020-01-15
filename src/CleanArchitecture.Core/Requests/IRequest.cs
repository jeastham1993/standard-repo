// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Requests
{
    /// <summary>
    /// Marker interface to represent a request with a void response.
    /// </summary>
    internal interface IRequest
    {
    }

    /// <summary>
    /// Marker interface to represent a request with a response.
    /// </summary>
    /// <typeparam name="TResponse">Response type.</typeparam>
    internal interface IRequest<out TResponse>
    {
    }
}
