﻿using System;
using JetBrains.Annotations;

namespace Panda.Core
{
    public class ApplicationInitializationContext 
    {
        public IServiceProvider ServiceProvider { get; set; }

        public ApplicationInitializationContext([NotNull] IServiceProvider serviceProvider)
        {
            Check.NotNull(serviceProvider, nameof(serviceProvider));

            ServiceProvider = serviceProvider;
        }
    }
}