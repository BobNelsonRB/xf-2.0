﻿// Licensed to eXtensoft LLC under one or more agreements.
// eXtensoft LLC licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace XF.Quality
{
    using System.Collections.Generic;
    using XF.Common;

    public class ProcessItem
    {
        public string Context { get; set; }
        public ProcessSettings Settings { get; set; }

        public bool IsExecuteAssert { get; set; }

        #region Parameters (List<ProcessParameter>)

        private List<ProcessParameter> _Parameters = new List<ProcessParameter>();

        /// <summary>
        /// Gets or sets the List<ProcessParameter> value for Parameters
        /// </summary>
        /// <value> The List<ProcessParameter> value.</value>

        public List<ProcessParameter> Parameters
        {
            get { return _Parameters; }
            set
            {
                if (_Parameters != value)
                {
                    _Parameters = value;
                }
            }
        }


        #region Results (PropertyCollection)

        private PropertyCollection _Results = new PropertyCollection();

        /// <summary>
        /// Gets or sets the PropertyCollection value for Results
        /// </summary>
        /// <value> The PropertyCollection value.</value>

        public PropertyCollection Results
        {
            get { return _Results; }
            set
            {
                if (_Results != value)
                {
                    _Results = value;
                }
            }
        }

        #endregion


        #endregion

    }
}
