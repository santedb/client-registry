﻿/**
 * Copyright 2012-2013 Mohawk College of Applied Arts and Technology
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: fyfej
 * Date: 26-7-2012
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MARC.HI.EHRS.CR.Core.ComponentModel
{
    /// <summary>
    /// Confidence type
    /// </summary>
    [XmlType("MatchAlgorithm", Namespace = "urn:marc-hi:svc:componentModel")]
    public enum MatchAlgorithm
    {
        /// <summary>
        /// Not specified
        /// </summary>
        Unspecified = 0,
        /// <summary>
        /// Names must exactly match one another
        /// </summary>
        Exact = 0x1,
        /// <summary>
        /// Match based on "Sounds Like"
        /// </summary>
        Soundex = 0x2,
        /// <summary>
        /// Match on variants
        /// </summary>
        Variant = 0x4,
        /// <summary>
        /// Default match
        /// </summary>
        Default = Exact | Soundex
    }
}
