﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace NuGet.Services.Gallery
{
    [Serializable]
    public class ReadOnlyModeException
        : Exception
    {
        public ReadOnlyModeException()
        {}

        public ReadOnlyModeException(string message)
            : base(message)
        {
        }

        public ReadOnlyModeException(string message, Exception exception)
            : base(message, exception)
        {
        }
    }
}