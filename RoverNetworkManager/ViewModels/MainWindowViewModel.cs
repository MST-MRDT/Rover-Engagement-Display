﻿using Caliburn.Micro;
using RoverNetworkManager.Models;

namespace RoverNetworkManager.ViewModels
{
    public class MainWindowViewModel : Screen
    {
        private readonly MainWindowModel _model;

        public RoveCommCustomPacketViewModel RoveCommCustomPacket
        {
            get
            {
                return _model._customPacket;
            }
            set
            {
                _model._customPacket = value;
                NotifyOfPropertyChange(() => RoveCommCustomPacket);
            }
        }

        public NetworkMapViewModel NetworkMap
        {
            get
            {
                return _model._networkMap;
            }
            set
            {
                _model._networkMap = value;
                NotifyOfPropertyChange(() => NetworkMap);
            }
        }

        public MainWindowViewModel()
        {
            base.DisplayName = "Rover Network Manager";
            _model = new MainWindowModel();

            RoveCommCustomPacket = new RoveCommCustomPacketViewModel();
            NetworkMap = new NetworkMapViewModel();
        }
    }
}
