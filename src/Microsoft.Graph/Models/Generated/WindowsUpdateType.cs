// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WindowsUpdateType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WindowsUpdateType
    {
    
        /// <summary>
        /// user Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// all
        /// </summary>
        All = 1,
	
        /// <summary>
        /// business Ready Only
        /// </summary>
        BusinessReadyOnly = 2,
	
        /// <summary>
        /// windows Insider Build Fast
        /// </summary>
        WindowsInsiderBuildFast = 3,
	
        /// <summary>
        /// windows Insider Build Slow
        /// </summary>
        WindowsInsiderBuildSlow = 4,
	
        /// <summary>
        /// windows Insider Build Release
        /// </summary>
        WindowsInsiderBuildRelease = 5,
	
    }
}
