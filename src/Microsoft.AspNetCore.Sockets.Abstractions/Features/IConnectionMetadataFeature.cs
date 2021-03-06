﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Sockets.Features
{
    public interface IConnectionMetadataFeature
    {
        IDictionary<object, object> Metadata { get; set; }
    }
}
