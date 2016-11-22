﻿using Caliburn.Micro;
using RED.Interfaces.Input;

namespace RED.ViewModels.Settings.Input
{
    public class InputSettingsViewModel : PropertyChangedBase
    {
        private SettingsManagerViewModel _settings;
        private IInputDevice _vm;

        public int SerialReadSpeed
        {
            get
            {
                return _vm.SerialReadSpeed;
            }
            set
            {
                _vm.SerialReadSpeed = value;
                _settings.CurrentSettings.InputSerialReadSpeed = value;
                NotifyOfPropertyChange(() => SerialReadSpeed);
            }
        }
        public bool AutoDeadzone
        {
            get
            {
                return _vm.AutoDeadzone;
            }
            set
            {
                _vm.AutoDeadzone = value;
                _settings.CurrentSettings.InputAutoDeadzone = value;
                NotifyOfPropertyChange(() => AutoDeadzone);
            }
        }
        public int ManualDeadzone
        {
            get
            {
                return _vm.ManualDeadzone;
            }
            set
            {
                _vm.ManualDeadzone = value;
                _settings.CurrentSettings.InputManualDeadzone = value;
                NotifyOfPropertyChange(() => ManualDeadzone);
            }
        }

        public InputSettingsViewModel(SettingsManagerViewModel settings, IInputDevice vm)
        {
            _settings = settings;
            _vm = vm;

            _vm.SerialReadSpeed = _settings.CurrentSettings.InputSerialReadSpeed;
            _vm.AutoDeadzone = _settings.CurrentSettings.InputAutoDeadzone;
            _vm.ManualDeadzone = _settings.CurrentSettings.InputManualDeadzone;
        }
    }
}