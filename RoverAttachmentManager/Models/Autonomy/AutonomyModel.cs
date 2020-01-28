﻿using Core;
using RoverAttachmentManager.ViewModels;
using System;

using RoverAttachmentManager.ViewModels.Autonomy;

namespace RoverAttachmentManager.Models.Autonomy
{
    internal class AutonomyModel
    {
        internal WaypointManager Manager;
        internal InputManagerViewModel InputManager;
        internal ControlsViewModel Controls;
        internal StateControlViewModel _stateControl;
        internal SentWaypointsViewModel _sentWaypoints;
    }
}
