﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Resources.Domain.Entities {
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
    public class TaskType {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TaskType() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Core.Resources.Domain.Entities.TaskType", typeof(TaskType).Assembly);
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
        ///   Looks up a localized string similar to Difficulty.
        /// </summary>
        public static string Difficulty {
            get {
                return ResourceManager.GetString("Difficulty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Experience.
        /// </summary>
        public static string Exp {
            get {
                return ResourceManager.GetString("Exp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Amount of completions.
        /// </summary>
        public static string Goal {
            get {
                return ResourceManager.GetString("Goal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Money.
        /// </summary>
        public static string Money {
            get {
                return ResourceManager.GetString("Money", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Money and experience boost.
        /// </summary>
        public static string MoneyAndExpBoost {
            get {
                return ResourceManager.GetString("MoneyAndExpBoost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Limit of a rewards price.
        /// </summary>
        public static string RewardPriceLimit {
            get {
                return ResourceManager.GetString("RewardPriceLimit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to time to complete.
        /// </summary>
        public static string TimeToComplete {
            get {
                return ResourceManager.GetString("TimeToComplete", resourceCulture);
            }
        }
    }
}
