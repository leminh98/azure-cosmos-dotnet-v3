// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

// This is auto-generated code. Modify: HttpExceptionCodeGenerator.tt: 98

namespace Microsoft.Azure.Cosmos.Resource.CosmosExceptions.Http.NotFound
{
    using System;

    internal sealed class ReadSessionNotAvailableException : NotFoundBaseException
    {
        public ReadSessionNotAvailableException(CosmosDiagnosticsContext cosmosDiagnosticsContext)
            : this(cosmosDiagnosticsContext, message: null)
        {
        }

        public ReadSessionNotAvailableException(CosmosDiagnosticsContext cosmosDiagnosticsContext, string message)
            : this(cosmosDiagnosticsContext, message, innerException: null)
        {
        }

        public ReadSessionNotAvailableException(CosmosDiagnosticsContext cosmosDiagnosticsContext, string message, Exception innerException)
            : base(
                subStatusCode: (int)NotFoundSubStatusCode.ReadSessionNotAvailable,
                cosmosDiagnosticsContext: cosmosDiagnosticsContext,
                message: message, 
                innerException: innerException)
        {
        }
    }
}
