﻿namespace RED.Models
{
    public class StateModel
    {
        internal string _currentControlMode;
        internal string _currentController;
        internal bool _networkHasConnection = false;
        internal bool _controllerIsConnected = false;
        internal bool _serverIsRunning = false;
    }
}
