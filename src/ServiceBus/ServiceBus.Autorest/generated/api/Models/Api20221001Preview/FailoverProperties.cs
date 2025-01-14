// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>
    /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
    /// </summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class FailoverProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesInternal
    {

        /// <summary>
        /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public bool? IsSafeFailover { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesAutoGeneratedInternal)Property).IsSafeFailover; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesAutoGeneratedInternal)Property).IsSafeFailover = value ?? default(bool); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.FailoverPropertiesAutoGenerated()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesAutoGenerated _property;

        /// <summary>
        /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesAutoGenerated Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.FailoverPropertiesAutoGenerated()); set => this._property = value; }

        /// <summary>Creates an new <see cref="FailoverProperties" /> instance.</summary>
        public FailoverProperties()
        {

        }
    }
    /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
    public partial interface IFailoverProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.",
        SerializedName = @"IsSafeFailover",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSafeFailover { get; set; }

    }
    /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
    internal partial interface IFailoverPropertiesInternal

    {
        /// <summary>
        /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
        /// </summary>
        bool? IsSafeFailover { get; set; }
        /// <summary>
        /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesAutoGenerated Property { get; set; }

    }
}