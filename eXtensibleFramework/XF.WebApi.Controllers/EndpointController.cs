﻿// Licensed to eXtensoft LLC under one or more agreements.
// eXtensoft LLC licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace XF.WebApi
{
    using System;
    using System.ComponentModel.Composition;
    using System.Web.Http;

    [InheritedExport(typeof(IEndpointController))]
    public abstract class EndpointController : ApiController, IEndpointController
    {

        public abstract string Description { get; }

        public abstract Guid Id { get; }

        public abstract string Name { get; }

        public virtual int Version { get; }

        public abstract string WhitelistPattern { get; }

        public abstract string RouteTablePattern { get; }

        public virtual void RegisterApiRoute(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                    name: ((IEndpointController)this).EndpointName,
                    routeTemplate: ((IEndpointController)this).EndpointRouteTablePattern,
                    defaults: new { controller = ControllerName }
                );
        }

        string IEndpointController.EndpointDescription
        {
            get
            {
                return Description;
            }
        }

        Guid IEndpointController.EndpointId
        {
            get
            {
                return Id;
            }
        }

        string IEndpointController.EndpointName
        {
            get
            {
                return Name;
            }
        }

        int IEndpointController.EndpointVersion
        {
            get
            {
                return Version;
            }
        }

        string IEndpointController.EndpointWhitelistPattern
        {
            get
            {
                return WhitelistPattern;
            }
        }

        string IEndpointController.EndpointRouteTablePattern
        {
            get
            {
                return RouteTablePattern;
            }
        }

        void IEndpointController.RegisterApiRoute(HttpConfiguration config)
        {
            if (config != null)
            {
                RegisterApiRoute(config);
            }            
        }

        protected string ControllerName
        {
            get
            {
                string output = string.Empty;
                string typename = this.GetType().Name;
                if (!String.IsNullOrWhiteSpace(typename) && typename.Contains("Controller"))
                {
                    int len = typename.IndexOf("Controller");
                    output = typename.Substring(0,len);
                }
                return output;
            }
        }
    }
}
