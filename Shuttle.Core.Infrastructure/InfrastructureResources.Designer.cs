﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shuttle.Core.Infrastructure {
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
    public class InfrastructureResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal InfrastructureResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Shuttle.Core.Infrastructure.InfrastructureResources", typeof(InfrastructureResources).Assembly);
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
        ///   Looks up a localized string similar to [GetAssembly] : could not load assembly &apos;{0}&apos; / exception = {1}.
        /// </summary>
        public static string AssemblyLoadException {
            get {
                return ResourceManager.GetString("AssemblyLoadException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration item &apos;{0}&apos; is specified but empty.  Using the specified default &apos;{1}&apos;..
        /// </summary>
        public static string ConfigurationItemEmptyUsingDefault {
            get {
                return ResourceManager.GetString("ConfigurationItemEmptyUsingDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application setting &apos;{0}&apos; is missing or has an empty value..
        /// </summary>
        public static string ConfigurationItemMissing {
            get {
                return ResourceManager.GetString("ConfigurationItemMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to configuration item not specified - using default.
        /// </summary>
        public static string ConfigurationItemMissingUsingDefault {
            get {
                return ResourceManager.GetString("ConfigurationItemMissingUsingDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string with name &apos;{0}&apos; may not be empty..
        /// </summary>
        public static string EmptyStringException {
            get {
                return ResourceManager.GetString("EmptyStringException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entering pipeline stage &apos;{0}&apos;..
        /// </summary>
        public static string EnteringPipelineStage {
            get {
                return ResourceManager.GetString("EnteringPipelineStage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing pipeline &apos;{0}&apos;..
        /// </summary>
        public static string ExecutingPipeline {
            get {
                return ResourceManager.GetString("ExecutingPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First chance exception handled by pipeline: {0}.
        /// </summary>
        public static string FirstChanceExceptionHandledByPipeline {
            get {
                return ResourceManager.GetString("FirstChanceExceptionHandledByPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no argument with name &apos;{0}&apos;..
        /// </summary>
        public static string InvalidArgumentException {
            get {
                return ResourceManager.GetString("InvalidArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception type &apos;{0}&apos; used with Guard possibly does not have a constructor that takes 1 string parameter (message).  Exception reported: {1}.
        /// </summary>
        public static string InvalidGuardExceptionType {
            get {
                return ResourceManager.GetString("InvalidGuardExceptionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value with name &apos;{0}&apos; may not be null..
        /// </summary>
        public static string NullValueException {
            get {
                return ResourceManager.GetString("NullValueException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a section named &apos;{0}&apos; in configuration file &apos;{1}&apos; that is of type &apos;{2}&apos;..
        /// </summary>
        public static string OpenSectionException {
            get {
                return ResourceManager.GetString("OpenSectionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipeline stage &apos;{0}&apos; has no event of type &apos;{1}&apos;..
        /// </summary>
        public static string PipelineStageEventNotRegistered {
            get {
                return ResourceManager.GetString("PipelineStageEventNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no pipeline stage with a name of &apos;{0}&apos;..
        /// </summary>
        public static string PipelineStageNotFound {
            get {
                return ResourceManager.GetString("PipelineStageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread executing] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string ProcessorExecuting {
            get {
                return ResourceManager.GetString("ProcessorExecuting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread active] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string ProcessorThreadActive {
            get {
                return ResourceManager.GetString("ProcessorThreadActive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread starting] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string ProcessorThreadStarting {
            get {
                return ResourceManager.GetString("ProcessorThreadStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread stopped] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string ProcessorThreadStopped {
            get {
                return ResourceManager.GetString("ProcessorThreadStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [processor thread stopping] : managed thread id = {0} / processor type = {1}.
        /// </summary>
        public static string ProcessorThreadStopping {
            get {
                return ResourceManager.GetString("ProcessorThreadStopping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Raising pipeline event &apos;{0}&apos; in stage &apos;{1}&apos; for observer &apos;{2}&apos;..
        /// </summary>
        public static string RaisingPipelineEvent {
            get {
                return ResourceManager.GetString("RaisingPipelineEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to assign a value to &apos;{0}&apos; but it has already been assigned a value..
        /// </summary>
        public static string ReassignmentException {
            get {
                return ResourceManager.GetString("ReassignmentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{0}] : Stream position is not 0 but seek is not permitted..
        /// </summary>
        public static string StreamCannotSeek {
            get {
                return ResourceManager.GetString("StreamCannotSeek", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String duration contains invalid items &apos;{0}&apos;..
        /// </summary>
        public static string StringDurationFormatError {
            get {
                return ResourceManager.GetString("StringDurationFormatError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queue handler configuration requires thread count of at least 1.  The input queue can not be processed..
        /// </summary>
        public static string ThreadCountZeroException {
            get {
                return ResourceManager.GetString("ThreadCountZeroException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thread pool &apos;{0}&apos; has {1} successfully..
        /// </summary>
        public static string ThreadPoolStatusChange {
            get {
                return ResourceManager.GetString("ThreadPoolStatusChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving all typew from from assembly &apos;{0}&apos;..
        /// </summary>
        public static string TraceGetTypesFromAssembly {
            get {
                return ResourceManager.GetString("TraceGetTypesFromAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled exception during event &apos;{0}&apos;: {1}.
        /// </summary>
        public static string UnhandledPipelineException {
            get {
                return ResourceManager.GetString("UnhandledPipelineException", resourceCulture);
            }
        }
    }
}
