﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapFrameX.Configuration.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public int MovingAverageWindowSize {
            get {
                return ((int)(this["MovingAverageWindowSize"]));
            }
            set {
                this["MovingAverageWindowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2.5")]
        public double StutteringFactor {
            get {
                return ((double)(this["StutteringFactor"]));
            }
            set {
                this["StutteringFactor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyDocuments\\OCAT\\Captures")]
        public string ObservedDirectory {
            get {
                return ((string)(this["ObservedDirectory"]));
            }
            set {
                this["ObservedDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("High")]
        public string ChartQualityLevel {
            get {
                return ((string)(this["ChartQualityLevel"]));
            }
            set {
                this["ChartQualityLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FpsValuesRoundingDigits {
            get {
                return ((int)(this["FpsValuesRoundingDigits"]));
            }
            set {
                this["FpsValuesRoundingDigits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CapFrameX; SearchUI; ShellExperienceHost; steamwebhelper")]
        public string RecordDataGridIgnoreList {
            get {
                return ((string)(this["RecordDataGridIgnoreList"]));
            }
            set {
                this["RecordDataGridIgnoreList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowLowParameter {
            get {
                return ((bool)(this["ShowLowParameter"]));
            }
            set {
                this["ShowLowParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyDocuments\\OCAT\\Screenshots")]
        public string ScreenshotDirectory {
            get {
                return ((string)(this["ScreenshotDirectory"]));
            }
            set {
                this["ScreenshotDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordMaxStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordMaxStatisticParameter"]));
            }
            set {
                this["UseSingleRecordMaxStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP99QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP99QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP99QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP95QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP95QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP95QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP5QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP5QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP5QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP1QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP1QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP1QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP0Dot1QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP0Dot1QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP0Dot1QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP1LowAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP1LowAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP1LowAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP0Dot1LowAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP0Dot1LowAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP0Dot1LowAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordMinStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordMinStatisticParameter"]));
            }
            set {
                this["UseSingleRecordMinStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordAdaptiveSTDStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordAdaptiveSTDStatisticParameter"]));
            }
            set {
                this["UseSingleRecordAdaptiveSTDStatisticParameter"] = value;
            }
        }
    }
}