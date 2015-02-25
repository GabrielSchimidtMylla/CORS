﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNet.Cors.Core
{
    /// <inheritdoc />
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class EnableCorsAttribute : Attribute, IEnableCorsMetadata
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EnableCorsAttribute"/>.
        /// </summary>
        /// <param name="policyName">The name of the policy to be applied.</param>
        public EnableCorsAttribute(string policyName)
        {
            PolicyName = policyName;
        }


        /// <inheritdoc />
        public string PolicyName { get; set; }
    }
}