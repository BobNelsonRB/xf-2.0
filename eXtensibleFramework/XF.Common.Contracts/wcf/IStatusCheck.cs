﻿// Licensed to eXtensoft LLC under one or more agreements.
// eXtensoft LLC licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace XF.Common
{
    using System.ServiceModel;

    [ServiceContract(Namespace = "http://eXtensoft/xf/schemas/2017/09")]
    [ServiceKnownType(typeof(ListItem))]
    [ServiceKnownType(typeof(TypedItem))]
    [ServiceKnownType(typeof(StatusCheck))]
    public interface IStatusCheck
    {
        [OperationContract]
        StatusCheck ExecuteStatusCheck(StatusCheck item);
    }
}
