﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Cirrus.Editor
{
    /// <summary>
    /// When used this field will show in inside the node, as well as the properties sidebar.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class SummaryAttribute : Attribute
    {
        public string summary { get; private set; }

        public SummaryAttribute(string summary)
        {
            this.summary = summary;
        }
    }
}
