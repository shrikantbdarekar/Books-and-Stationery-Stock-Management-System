﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinBookStationaryStock19.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Book and Stationary Stock Management System")]
        public string ProjectName {
            get {
                return ((string)(this["ProjectName"]));
            }
            set {
                this["ProjectName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Mr. Mark Zuckerberg\r\nMr. Sundar Pichai\r\nMr. Bill Gates")]
        public string DesignedDvelopedBy {
            get {
                return ((string)(this["DesignedDvelopedBy"]));
            }
            set {
                this["DesignedDvelopedBy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=.\\\\sqlexpress19;Database=BookStationaryStockDB;User Id=sa;Password=sqlexpr" +
            "ess@19;")]
        public string ConnestionStringFull {
            get {
                return ((string)(this["ConnestionStringFull"]));
            }
            set {
                this["ConnestionStringFull"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=.\\\\sqlexpress19;Database=BookStationaryStockDB;Integrated Security=True;")]
        public string ConnestionStringShort {
            get {
                return ((string)(this["ConnestionStringShort"]));
            }
            set {
                this["ConnestionStringShort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ShopId {
            get {
                return ((int)(this["ShopId"]));
            }
            set {
                this["ShopId"] = value;
            }
        }
    }
}
