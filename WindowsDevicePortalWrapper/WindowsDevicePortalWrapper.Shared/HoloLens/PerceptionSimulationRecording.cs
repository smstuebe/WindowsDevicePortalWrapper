﻿//----------------------------------------------------------------------------------------------
// <copyright file="PerceptionSimulationRecording.cs" company="Microsoft Corporation">
//     Licensed under the MIT License. See LICENSE.TXT in the project root license information.
// </copyright>
//----------------------------------------------------------------------------------------------

using System.Threading.Tasks;

namespace Microsoft.Tools.WindowsDevicePortal
{
    /// <content>
    /// Wrappers for Perception Simulation Recording methods
    /// </content>
    public partial class DevicePortal
    {
        /// <summary>
        /// API for getting a Holographic Perception Simulation recording status.
        /// </summary>
        private static readonly string HolographicSimulationRecordingStatusApi = "api/holographic/simulation/recording/status";

        /// <summary>
        /// API for starting a Holographic Perception Simulation recording.
        /// </summary>
        private static readonly string StartHolographicSimulationRecordingApi = "api/holographic/simulation/recording/start";

        /// <summary>
        /// API for stopping a Holographic Perception Simulation recording.
        /// </summary>
        private static readonly string StopHolographicSimulationRecordingApi = "api/holographic/simulation/recording/stop";

        public async Task<bool> IsHolographicSimulationRecording()
        {
            // TODO: implement the datacontract and return the "recording" value
            return false;
        }
    }
}