﻿// Licensed to eXtensoft LLC under one or more agreements.
// eXtensoft LLC licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace XF.Common
{
    using System;
    using System.Configuration;
    using XF.Common;

    public sealed class AppSettingsStrategyResolver : IStrategyResolver
    {
        string IStrategyResolver.Resolve(params string[] args)
        {
            string resolution = String.Empty;
            if (args != null)
            {
                if (args.Length == 1)
                {
                    string appkey = args[0];
                    resolution = ConfigurationProvider.AppSettings[appkey];
                }
                else if (args.Length == 2)
                {
                    string appkey = string.Format("{0}.{1}", args[0], args[1]).Trim(new char[]{'.'});
                    resolution = ConfigurationProvider.AppSettings[appkey];
                }
                else if (args.Length == 3)
                {
                    string appkey = string.Format("{0}.{1}.{2}", args[0], args[1].Trim(new char[] { '.' }), args[2]);
                    resolution = ConfigurationProvider.AppSettings[appkey];
                }
            }

            return resolution;
        }
    }
}
