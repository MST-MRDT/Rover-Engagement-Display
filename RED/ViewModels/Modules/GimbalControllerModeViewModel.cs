﻿using Caliburn.Micro;
using RED.Interfaces;
using RED.Interfaces.Input;
using RED.Models.Modules;

namespace RED.ViewModels.Modules
{
    public class GimbalControllerModeViewModel : PropertyChangedBase, IControllerMode
    {
        private GimbalModel _model;
        private IDataRouter _router;
        private IDataIdResolver _idResolver;
        private ILogger _log;

        private readonly string[] CommandDataId = { "Camera1Command", "Camera2Command" };
        private readonly string[] PTZDataId = { "PTZ1Speed", "PTZ2Speed" };
        private readonly string[] MenuDataId = { "Camera1Menu", "Camera2Menu" };

        public string Name { get; set; }
        public IInputDevice InputVM { get; set; }

        public int GimbalIndex
        {
            get
            {
                return _model.gimbalIndex;
            }
            set
            {
                _model.gimbalIndex = value;
                NotifyOfPropertyChange(() => GimbalIndex);
            }
        }
        public int SpeedLimit
        {
            get
            {
                return _model.speedLimit;
            }
            set
            {
                _model.speedLimit = value;
                NotifyOfPropertyChange(() => SpeedLimit);
            }
        }

        public GimbalControllerModeViewModel(IInputDevice inputVM, IDataRouter router, IDataIdResolver idResolver, ILogger log, int gimbalIndex)
        {
            _model = new GimbalModel();
            _router = router;
            _idResolver = idResolver;
            _log = log;
            InputVM = inputVM;
            Name = "Gimbal " + (gimbalIndex + 1).ToString();
            SpeedLimit = 1000;
            GimbalIndex = gimbalIndex;
        }

        public void EnterMode()
        {

        }

        public void EvaluateMode()
        {
            short pan, tilt;

            pan = (short)(InputVM.GimbalPan * SpeedLimit);
            tilt = (short)(InputVM.GimbalTilt * SpeedLimit);
            _router.Send(_idResolver.GetId(PTZDataId[GimbalIndex]), ((int)tilt << 16) | (((int)pan) & 0xFFFF));

            if (InputVM.GimbalZoomIn)
                _router.Send(_idResolver.GetId(CommandDataId[GimbalIndex]), (byte)GimbalZoomCommands.ZoomIn);
            else if (InputVM.GimbalZoomOut)
                _router.Send(_idResolver.GetId(CommandDataId[GimbalIndex]), (byte)GimbalZoomCommands.ZoomOut);
            else
                _router.Send(_idResolver.GetId(CommandDataId[GimbalIndex]), (byte)GimbalZoomCommands.Stop);

        }

        public void ExitMode()
        {
            _router.Send(_idResolver.GetId("PTZ1Speed"), (int)0);
        }

        public void ZoomFocusStop()
        {
            _router.Send(_idResolver.GetId(CommandDataId[GimbalIndex]), (byte)GimbalZoomCommands.Stop);
        }
        public void ZoomIn()
        {
            _router.Send(_idResolver.GetId(CommandDataId[GimbalIndex]), (byte)GimbalZoomCommands.ZoomIn);
        }
        public void ZoomOut()
        {
            _router.Send(_idResolver.GetId(CommandDataId[GimbalIndex]), (byte)GimbalZoomCommands.ZoomOut);
        }
        public void FocusNear()
        {
            _router.Send(_idResolver.GetId(CommandDataId[GimbalIndex]), (byte)GimbalZoomCommands.FocusNear);
        }
        public void FocusFar()
        {
            _router.Send(_idResolver.GetId(CommandDataId[GimbalIndex]), (byte)GimbalZoomCommands.FocusFar);
        }

        public void MenuCenter()
        {
            _router.Send(_idResolver.GetId(MenuDataId[GimbalIndex]), (byte)GimbalMenuCommands.Menu);
        }
        public void MenuUp()
        {
            _router.Send(_idResolver.GetId(MenuDataId[GimbalIndex]), (byte)GimbalMenuCommands.MenuUp);
        }
        public void MenuDown()
        {
            _router.Send(_idResolver.GetId(MenuDataId[GimbalIndex]), (byte)GimbalMenuCommands.MenuDown);
        }
        public void MenuLeft()
        {
            _router.Send(_idResolver.GetId(MenuDataId[GimbalIndex]), (byte)GimbalMenuCommands.MenuLeft);
        }
        public void MenuRight()
        {
            _router.Send(_idResolver.GetId(MenuDataId[GimbalIndex]), (byte)GimbalMenuCommands.MenuRight);
        }

        private enum GimbalZoomCommands : byte
        {
            Stop = 0,
            ZoomIn = 1,
            ZoomOut = 2,
            FocusNear = 3,
            FocusFar = 4
        }

        private enum GimbalMenuCommands : byte
        {
            Menu = 0,
            MenuLeft = 1,
            MenuRight = 2,
            MenuUp = 3,
            MenuDown = 4
        }
    }
}