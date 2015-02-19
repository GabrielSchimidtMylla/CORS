﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Cors;
using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.Http;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Logging.Console;

namespace CORSSample
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            app.UseErrorPage(ErrorPageOptions.ShowAll);

            app.UseCors(CorsOptions.AllowAll);

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Cross origin response");
            });
        }
    }
}