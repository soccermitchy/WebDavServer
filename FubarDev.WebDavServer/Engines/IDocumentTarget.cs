﻿using System;
using System.Threading;
using System.Threading.Tasks;

using JetBrains.Annotations;

namespace FubarDev.WebDavServer.Engines
{
    public interface IDocumentTarget<TCollection, TDocument, TMissing> : IExistingTarget
        where TMissing : IMissingTarget<TCollection, TDocument, TMissing>
        where TDocument : IDocumentTarget<TCollection, TDocument, TMissing>
        where TCollection : ICollectionTarget<TCollection, TDocument, TMissing>
    {
        [NotNull, ItemNotNull]
        Task<TMissing> DeleteAsync(CancellationToken cancellationToken);
    }
}
