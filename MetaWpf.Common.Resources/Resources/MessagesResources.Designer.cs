﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetaWpf.Common.Resources.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MessagesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessagesResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MetaWpf.Common.Resources.Resources.MessagesResources", typeof(MessagesResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confermi la Chiusura di MetaWpf?.
        /// </summary>
        public static string CloseApplicationQuestion {
            get {
                return ResourceManager.GetString("CloseApplicationQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eliminazione Definitiva Eventi. Confermi?.
        /// </summary>
        public static string DeleteEvents {
            get {
                return ResourceManager.GetString("DeleteEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eliminazione Definitiva Elemento Selezionato. Confermi?.
        /// </summary>
        public static string DeleteSelectedItem {
            get {
                return ResourceManager.GetString("DeleteSelectedItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nessuna Connessione di Rete Disponibile..
        /// </summary>
        public static string NoConnectionAvailable {
            get {
                return ResourceManager.GetString("NoConnectionAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nessun Elemento Selezionato..
        /// </summary>
        public static string NothingToSaveMessage {
            get {
                return ResourceManager.GetString("NothingToSaveMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aggiornamento Completato..
        /// </summary>
        public static string UpdateComplete {
            get {
                return ResourceManager.GetString("UpdateComplete", resourceCulture);
            }
        }
    }
}
