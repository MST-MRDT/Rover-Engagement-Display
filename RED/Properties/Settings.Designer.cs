﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RED.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultIP {
            get {
                return ((string)(this["DefaultIP"]));
            }
            set {
                this["DefaultIP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11000")]
        public int DefaultPort {
            get {
                return ((int)(this["DefaultPort"]));
            }
            set {
                this["DefaultPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Idle")]
        public string DefaultControlMode {
            get {
                return ((string)(this["DefaultControlMode"]));
            }
            set {
                this["DefaultControlMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool VoiceMute {
            get {
                return ((bool)(this["VoiceMute"]));
            }
            set {
                this["VoiceMute"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool VoiceCommandsMute {
            get {
                return ((bool)(this["VoiceCommandsMute"]));
            }
            set {
                this["VoiceCommandsMute"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ModuleStateSaves.xml")]
        public string ModuleStateSaveFileName {
            get {
                return ((string)(this["ModuleStateSaveFileName"]));
            }
            set {
                this["ModuleStateSaveFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11000")]
        public short ServerListeningPort {
            get {
                return ((short)(this["ServerListeningPort"]));
            }
            set {
                this["ServerListeningPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int DriveSpeedLimit {
            get {
                return ((int)(this["DriveSpeedLimit"]));
            }
            set {
                this["DriveSpeedLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DriveParabolicScaling {
            get {
                return ((bool)(this["DriveParabolicScaling"]));
            }
            set {
                this["DriveParabolicScaling"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("90")]
        public int InputSerialReadSpeed {
            get {
                return ((int)(this["InputSerialReadSpeed"]));
            }
            set {
                this["InputSerialReadSpeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool InputAutoDeadzone {
            get {
                return ((bool)(this["InputAutoDeadzone"]));
            }
            set {
                this["InputAutoDeadzone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int InputManualDeadzone {
            get {
                return ((int)(this["InputManualDeadzone"]));
            }
            set {
                this["InputManualDeadzone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double GPSBaseStationLocationLatitude {
            get {
                return ((double)(this["GPSBaseStationLocationLatitude"]));
            }
            set {
                this["GPSBaseStationLocationLatitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double GPSBaseStationLocationLongitude {
            get {
                return ((double)(this["GPSBaseStationLocationLongitude"]));
            }
            set {
                this["GPSBaseStationLocationLongitude"] = value;
            }
        }
    }
}
