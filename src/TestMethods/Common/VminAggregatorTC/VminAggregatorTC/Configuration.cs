﻿// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// INTEL CONFIDENTIAL
// Copyright (2019) (2022) Intel Corporation
//
// The source code contained or described herein and all documents related to the source code ("Material") are
// owned by Intel Corporation or its suppliers or licensors. Title to the Material remains with Intel Corporation
// or its suppliers and licensors. The Material contains trade secrets and proprietary and confidential
// information of Intel Corporation or its suppliers and licensors. The Material is protected by worldwide copyright
// and trade secret laws and treaty provisions. No part of the Material may be used, copied, reproduced, modified,
// published, uploaded, posted, transmitted, distributed, or disclosed in any way without Intel Corporation's prior express
// written permission.
//
// No license under any patent, copyright, trade secret or other intellectual property right is granted to or
// conferred upon you by disclosure or delivery of the Materials, either expressly, by implication, inducement,
// estoppel or otherwise. Any license under such intellectual property rights must be express and approved by
// Intel in writing.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace VminAggregatorTC
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Defines the <see cref="Configuration" />.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Gets or sets the domain name.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the corner name.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Corner { get; set; }

        /// <summary>
        /// Gets or sets the frequency value. It supports shared storage or uservar names.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public DDG.HdmtExpression Frequency { get; set; }

        /// <summary>
        /// Gets or sets the list of vmin tokens or expressions to use for evaluation.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public List<List<DDG.HdmtExpression>> VminExpressions { get; set; }

        /// <summary>
        /// Gets or sets the output dff token.
        /// </summary>
        [JsonProperty(Required = Required.DisallowNull)]
        public string DffToken { get; set; }
    }
}
