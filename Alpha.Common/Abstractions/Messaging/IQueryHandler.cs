﻿using MediatR;

namespace Alpha.Common.Abstractions.Messaging
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
       where TQuery : IQuery<TResponse>
    {
    }
}
