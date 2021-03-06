﻿// Licensed to eXtensoft LLC under one or more agreements.
// eXtensoft LLC licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace XF.Common
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public sealed class Authorization
    {
        public string AppContext { get; set; }

        public Guid ApplicationId { get; set; }

        public List<Permission> Permissions { get; set; }

        [XmlAttribute("id")]
        public Guid SessionId { get; set; }

        [XmlAttribute("identity")]
        public string UserIdentity { get; set; }

        [XmlAttribute("from")]
        public DateTime ValidFrom { get; set; }

        [XmlAttribute("to")]
        public DateTime ValidTo { get; set; }
    }
}
