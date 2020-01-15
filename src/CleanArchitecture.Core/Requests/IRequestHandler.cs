// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System.Threading.Tasks;

namespace CleanArchitecture.Core.Requests
{
    /// <summary>
    /// Defines a handler for a request.
    /// </summary>
    /// <typeparam name="TRequest">The type of request being handled.</typeparam>
    /// <typeparam name="TResponse">The type of response from the handler.</typeparam>
    internal interface IRequestHandler<in TRequest, out TResponse>
        where TRequest : IRequest<TResponse>
    {
        /// <summary>
        /// Handles a request.
        /// </summary>
        /// <param name="message">The request message.</param>
        /// <returns>Response from the request.</returns>
        TResponse Handle(TRequest message);
    }

    /// <summary>
    /// Defines a handler for a request without a return value.
    /// </summary>
    /// <typeparam name="TRequest">The type of request being handled.</typeparam>
    internal interface IRequestHandler<in TRequest>
        where TRequest : IRequest
    {
        /// <summary>
        /// Handles a request.
        /// </summary>
        /// <param name="message">The request message.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task Handle(TRequest message);
    }
}
