﻿// Licensed to eXtensoft LLC under one or more agreements.
// eXtensoft LLC licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace XF.Common
{

    public interface IRequestContext : IContext
    {
        string InstanceIdentifier { get; }
        void SetMetric(string scope, string key, object value);
        bool HasError();
    }

}
