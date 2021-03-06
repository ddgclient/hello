// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

namespace DDG
{
    /// <summary>
    /// Defines the <see cref="IDieRecoveryFactory" />.
    /// </summary>
    public interface IDieRecoveryFactory
    {
        /// <summary>
        /// Factory method.
        /// </summary>
        /// <param name="name">Configuration name.</param>
        /// <returns>Die Recovery interface.</returns>
        IDieRecovery Get(string name);

        /// <summary>
        /// Gets the global indicating whether the user is allowed to update tracker values.
        /// </summary>
        /// <returns>True if changes are allowed, false otherwise.</returns>
        bool AreTrackerChangesAllowed();

        /// <summary>
        /// Loads the given Json file containing DieRecovery Tracker definitions.
        /// </summary>
        /// <param name="trackerFile">Json file containing DieRecovery Tracker definitions.</param>
        /// <returns>true on success.</returns>
        bool LoadTrackerFile(string trackerFile);

        /// <summary>
        /// Clones tracker definition and data using new tracker name.
        /// </summary>
        /// <param name="existingTrackerName">Existing tracker name.</param>
        /// <param name="newTrackerName">New tracker name.</param>
        void CloneTracker(string existingTrackerName, string newTrackerName);

        /// <summary>
        /// Loads the given Xml file containing DieRecovery Rules definitions.
        /// </summary>
        /// <param name="rulesFile">Xml file containing DieRecovery Rules definitions.</param>
        /// <returns>true on success.</returns>
        bool LoadRulesFile(string rulesFile);
    }
}
