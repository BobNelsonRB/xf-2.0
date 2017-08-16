﻿// Licensed to eXtensoft LLC under one or more agreements.
// eXtensoft LLC licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace XF.Common
{
    using MongoDB.Driver;

    public class MongoUpdate
    {
        public IMongoQuery Query { get; set; }
        public IMongoUpdate Update { get; set; }
    }
}
