﻿using System.Collections.Generic;

namespace Dropcraft.Common.Package
{
    /// <summary>
    /// PackageConfiguration is an individual package's configuration
    /// </summary>
    public interface IPackageConfiguration
    {
        /// <summary>
        /// Package ID
        /// </summary>
        PackageId Id { get; }

        /// <summary>
        /// Indicates whether the package is enabled in the current configuration 
        /// </summary>
        bool IsPackageEnabled { get; }

        /// <summary>
        /// Returns the package's metadata
        /// </summary>
        /// <returns>Metadata</returns>
        PackageMetadataInfo GetPackageMetadata();

        /// <summary>
        /// Returns the package's activation mode to use during the runtime
        /// </summary>
        /// <returns>Activation mode</returns>
        EntityActivationMode GetPackageActivationMode();

        /// <summary>
        /// Returns a list of the package startup event handlers
        /// </summary>
        /// <returns>Event handlers</returns>
        IEnumerable<PackageStartupHandlerInfo> GetPackageStartupHandlers();

        /// <summary>
        /// Returns a list of the runtime events handlers
        /// </summary>
        /// <returns>Event handlers</returns>
        IEnumerable<RuntimeEventsHandlerInfo> GetRuntimeEventHandlers();

        /// <summary>
        /// Returns a list of the extensions implemented in the package
        /// </summary>
        /// <returns></returns>
        IEnumerable<ExtensionInfo> GetExtensions();

        /// <summary>
        /// Returns a list of the extensibility points exposed by the package
        /// </summary>
        /// <returns></returns>
        IEnumerable<ExtensibilityPointInfo> GetExtensibilityPoints();

        /// <summary>
        /// Returns a list the deployment events handlers. Not used at the moment.
        /// </summary>
        /// <returns>Event handlers</returns>
        IEnumerable<DeploymentEventsHandlerInfo> GetPackageDeploymentHandlers();

        /// <summary>
        /// Returns custom configuration for the package
        /// </summary>
        /// <returns>Custom configuration</returns>
        ICustomConfiguration GetCustomConfiguration();

        /// <summary>
        /// Converts configuration into JSON
        /// </summary>
        /// <returns>JSON representation of the package configuration</returns>
        string AsJson();
    }
}