﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.MessageLists {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    public sealed partial class CreditCardValidationMessageList : global::System.Configuration.ApplicationSettingsBase {
        
        private static CreditCardValidationMessageList defaultInstance = ((CreditCardValidationMessageList)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CreditCardValidationMessageList())));
        
        public static CreditCardValidationMessageList Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Credit cards not found.")]
        public string CreditCardsNotFound {
            get {
                return ((string)(this["CreditCardsNotFound"]));
            }
        }
    }
}