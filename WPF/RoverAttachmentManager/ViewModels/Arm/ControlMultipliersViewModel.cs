﻿using Caliburn.Micro;
using Core.Interfaces;
using Core.Models;
using Core.RoveProtocol;
using Core.ViewModels.Input;
using RoverAttachmentManager.Configurations.Modules;
using RoverAttachmentManager.Contexts;
using RoverAttachmentManager.Models.Arm;
using RoverAttachmentManager.Models.ArmModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace RoverAttachmentManager.ViewModels.Arm
{
    public class ControlMultipliersViewModel : PropertyChangedBase
    {
        private readonly ControlMultipliersModel _model;

        public int BaseRangeFactor
        {
            get
            {
                return _model.BaseRangeFactor;
            }
            set
            {
                _model.BaseRangeFactor = value;
                NotifyOfPropertyChange(() => BaseRangeFactor);
            }
        }
        public int ElbowRangeFactor
        {
            get
            {
                return _model.ElbowRangeFactor;
            }
            set
            {
                _model.ElbowRangeFactor = value;
                NotifyOfPropertyChange(() => ElbowRangeFactor);
            }
        }
        public int WristRangeFactor
        {
            get
            {
                return _model.WristRangeFactor;
            }
            set
            {
                _model.WristRangeFactor = value;
                NotifyOfPropertyChange(() => WristRangeFactor);
            }
        }
        public int GripperOpenRangeFactor
        {
            get
            {
                return _model.GripperOpenRangeFactor;
            }
            set
            {
                _model.GripperOpenRangeFactor = value;
                NotifyOfPropertyChange(() => GripperOpenRangeFactor);
            }
        }
        public int GripperCloseRangeFactor
        {
            get
            {
                return _model.GripperCloseRangeFactor;
            }
            set
            {
                _model.GripperCloseRangeFactor = value;
                NotifyOfPropertyChange(() => GripperCloseRangeFactor);
            }
        }

        public ControlMultipliersViewModel()
        {
            _model = new ControlMultipliersModel();
        }


    }
}
