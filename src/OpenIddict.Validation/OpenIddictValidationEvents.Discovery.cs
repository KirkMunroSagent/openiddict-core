﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/openiddict/openiddict-core for more information concerning
 * the license and the contributors participating to this project.
 */

using Microsoft.IdentityModel.Tokens;

namespace OpenIddict.Validation;

public static partial class OpenIddictValidationEvents
{
    /// <summary>
    /// Represents an event called for each request to the configuration endpoint
    /// to give the user code a chance to add parameters to the configuration request.
    /// </summary>
    public sealed class PrepareConfigurationRequestContext : BaseExternalContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="PrepareConfigurationRequestContext"/> class.
        /// </summary>
        public PrepareConfigurationRequestContext(OpenIddictValidationTransaction transaction)
            : base(transaction)
        {
        }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public OpenIddictRequest Request
        {
            get => Transaction.Request!;
            set => Transaction.Request = value;
        }
    }

    /// <summary>
    /// Represents an event called for each request to the configuration endpoint
    /// to send the configuration request to the remote authorization server.
    /// </summary>
    public sealed class ApplyConfigurationRequestContext : BaseExternalContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ApplyConfigurationRequestContext"/> class.
        /// </summary>
        public ApplyConfigurationRequestContext(OpenIddictValidationTransaction transaction)
            : base(transaction)
        {
        }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public OpenIddictRequest Request
        {
            get => Transaction.Request!;
            set => Transaction.Request = value;
        }
    }

    /// <summary>
    /// Represents an event called for each configuration response
    /// to extract the response parameters from the server response.
    /// </summary>
    public sealed class ExtractConfigurationResponseContext : BaseExternalContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ExtractConfigurationResponseContext"/> class.
        /// </summary>
        public ExtractConfigurationResponseContext(OpenIddictValidationTransaction transaction)
            : base(transaction)
        {
        }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public OpenIddictRequest Request
        {
            get => Transaction.Request!;
            set => Transaction.Request = value;
        }

        /// <summary>
        /// Gets or sets the response, or <see langword="null"/> if it wasn't extracted yet.
        /// </summary>
        public OpenIddictResponse? Response
        {
            get => Transaction.Response;
            set => Transaction.Response = value;
        }
    }

    /// <summary>
    /// Represents an event called for each configuration response.
    /// </summary>
    public sealed class HandleConfigurationResponseContext : BaseExternalContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="HandleConfigurationResponseContext"/> class.
        /// </summary>
        public HandleConfigurationResponseContext(OpenIddictValidationTransaction transaction)
            : base(transaction)
            => Configuration = new();

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public OpenIddictRequest Request
        {
            get => Transaction.Request!;
            set => Transaction.Request = value;
        }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public OpenIddictResponse Response
        {
            get => Transaction.Response!;
            set => Transaction.Response = value;
        }
    }

    /// <summary>
    /// Represents an event called for each request to the JSON Web Key Set endpoint
    /// to give the user code a chance to add parameters to the JSON Web Key Set request.
    /// </summary>
    public sealed class PrepareJsonWebKeySetRequestContext : BaseExternalContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="PrepareJsonWebKeySetRequestContext"/> class.
        /// </summary>
        public PrepareJsonWebKeySetRequestContext(OpenIddictValidationTransaction transaction)
            : base(transaction)
        {
        }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public OpenIddictRequest Request
        {
            get => Transaction.Request!;
            set => Transaction.Request = value;
        }
    }

    /// <summary>
    /// Represents an event called for each request to the JSON Web Key Set endpoint
    /// to send the JSON Web Key Set request to the remote authorization server.
    /// </summary>
    public sealed class ApplyJsonWebKeySetRequestContext : BaseExternalContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ApplyJsonWebKeySetRequestContext"/> class.
        /// </summary>
        public ApplyJsonWebKeySetRequestContext(OpenIddictValidationTransaction transaction)
            : base(transaction)
        {
        }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public OpenIddictRequest Request
        {
            get => Transaction.Request!;
            set => Transaction.Request = value;
        }
    }

    /// <summary>
    /// Represents an event called for each JSON Web Key Set response
    /// to extract the response parameters from the server response.
    /// </summary>
    public sealed class ExtractJsonWebKeySetResponseContext : BaseExternalContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ExtractJsonWebKeySetResponseContext"/> class.
        /// </summary>
        public ExtractJsonWebKeySetResponseContext(OpenIddictValidationTransaction transaction)
            : base(transaction)
        {
        }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public OpenIddictRequest Request
        {
            get => Transaction.Request!;
            set => Transaction.Request = value;
        }

        /// <summary>
        /// Gets or sets the response, or <see langword="null"/> if it wasn't extracted yet.
        /// </summary>
        public OpenIddictResponse? Response
        {
            get => Transaction.Response;
            set => Transaction.Response = value;
        }
    }

    /// <summary>
    /// Represents an event called for each JSON Web Key Set response.
    /// </summary>
    public sealed class HandleJsonWebKeySetResponseContext : BaseExternalContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="HandleJsonWebKeySetResponseContext"/> class.
        /// </summary>
        public HandleJsonWebKeySetResponseContext(OpenIddictValidationTransaction transaction)
            : base(transaction)
        {
        }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public OpenIddictRequest Request
        {
            get => Transaction.Request!;
            set => Transaction.Request = value;
        }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public OpenIddictResponse Response
        {
            get => Transaction.Response!;
            set => Transaction.Response = value;
        }

        /// <summary>
        /// Gets the security keys.
        /// </summary>
        public JsonWebKeySet SecurityKeys { get; } = new JsonWebKeySet();
    }
}
