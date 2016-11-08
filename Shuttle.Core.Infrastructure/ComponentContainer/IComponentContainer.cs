﻿using System;

namespace Shuttle.Core.Infrastructure
{
    public enum Lifestyle
    {
        Singleton = 0,
        Transient = 1,
        Thread = 2
    }

    public interface IComponentContainer
    {
        object Resolve(Type serviceType);
        IComponentContainer Register(Type serviceType, Type implementationType, Lifestyle lifestyle);
        IComponentContainer Register(Type serviceType, object instance);
    }
}