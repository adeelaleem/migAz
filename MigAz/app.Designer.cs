// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MigAz {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class app : global::System.Configuration.ApplicationSettingsBase {
        
        private static app defaultInstance = ((app)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new app())));
        
        public static app Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowTelemetry {
            get {
                return ((bool)(this["AllowTelemetry"]));
            }
            set {
                this["AllowTelemetry"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<domain>.onmicrosoft.com")]
        public string TenantId {
            get {
                return ((string)(this["TenantId"]));
            }
            set {
                this["TenantId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("v2")]
        public string UniquenessSuffix {
            get {
                return ((string)(this["UniquenessSuffix"]));
            }
            set {
                this["UniquenessSuffix"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1950a258-227b-4e31-a9cf-717495945fc2")]
        public string ClientId {
            get {
                return ((string)(this["ClientId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("urn:ietf:wg:oauth:2.0:oob")]
        public string ReturnURL {
            get {
                return ((string)(this["ReturnURL"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BuildEmpty {
            get {
                return ((bool)(this["BuildEmpty"]));
            }
            set {
                this["BuildEmpty"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowTag {
            get {
                return ((bool)(this["AllowTag"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AzureCloud")]
        public string AzureEnvironment {
            get {
                return ((string)(this["AzureEnvironment"]));
            }
            set {
                this["AzureEnvironment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoSelectDependencies {
            get {
                return ((bool)(this["AutoSelectDependencies"]));
            }
            set {
                this["AutoSelectDependencies"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveSelection {
            get {
                return ((bool)(this["SaveSelection"]));
            }
            set {
                this["SaveSelection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("v2")]
        public string StorageAccountSuffix {
            get {
                return ((string)(this["StorageAccountSuffix"]));
            }
            set {
                this["StorageAccountSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AvailabilitySetSuffix {
            get {
                return ((string)(this["AvailabilitySetSuffix"]));
            }
            set {
                this["AvailabilitySetSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string VirtualMachineSuffix {
            get {
                return ((string)(this["VirtualMachineSuffix"]));
            }
            set {
                this["VirtualMachineSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string NetworkInterfaceCardSuffix {
            get {
                return ((string)(this["NetworkInterfaceCardSuffix"]));
            }
            set {
                this["NetworkInterfaceCardSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ResourceGroupSuffix {
            get {
                return ((string)(this["ResourceGroupSuffix"]));
            }
            set {
                this["ResourceGroupSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string VirtualNetworkSuffix {
            get {
                return ((string)(this["VirtualNetworkSuffix"]));
            }
            set {
                this["VirtualNetworkSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string VirtualNetworkGatewaySuffix {
            get {
                return ((string)(this["VirtualNetworkGatewaySuffix"]));
            }
            set {
                this["VirtualNetworkGatewaySuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string NetworkSecurityGroupSuffix {
            get {
                return ((string)(this["NetworkSecurityGroupSuffix"]));
            }
            set {
                this["NetworkSecurityGroupSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PublicIPSuffix {
            get {
                return ((string)(this["PublicIPSuffix"]));
            }
            set {
                this["PublicIPSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LoadBalancerSuffix {
            get {
                return ((string)(this["LoadBalancerSuffix"]));
            }
            set {
                this["LoadBalancerSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ManagedDisk")]
        public global::MigAz.Core.Interface.ArmDiskType DefaultTargetDiskType {
            get {
                return ((global::MigAz.Core.Interface.ArmDiskType)(this["DefaultTargetDiskType"]));
            }
            set {
                this["DefaultTargetDiskType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3600")]
        public int AccessSASTokenLifetimeSeconds {
            get {
                return ((int)(this["AccessSASTokenLifetimeSeconds"]));
            }
            set {
                this["AccessSASTokenLifetimeSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Always")]
        public global::Microsoft.IdentityModel.Clients.ActiveDirectory.PromptBehavior LoginPromptBehavior {
            get {
                return ((global::Microsoft.IdentityModel.Clients.ActiveDirectory.PromptBehavior)(this["LoginPromptBehavior"]));
            }
            set {
                this["LoginPromptBehavior"] = value;
            }
        }
    }
}

