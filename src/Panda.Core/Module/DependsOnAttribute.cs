﻿using System;
using JetBrains.Annotations;

namespace Panda.Core.Module
{
    /// <summary>
    /// Used to define dependencies of a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DependsOnAttribute : Attribute
    {
        [NotNull]
        public Type[] DependedTypes { get; }

        public DependsOnAttribute(params Type[] dependedTypes)
        {
            DependedTypes = dependedTypes ?? new Type[0];
        }

        public virtual Type[] GetDependedTypes()
        {
            return DependedTypes;
        }
    }
}