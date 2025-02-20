// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Properties supplied to the Create Or Update Event Hub operation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class EventhubProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubPropertiesInternal
    {

        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}.
        /// Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string ArchiveNameFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).ArchiveNameFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).ArchiveNameFormat = value ?? null; }

        /// <summary>Blob container Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string BlobContainer { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).BlobContainer; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).BlobContainer = value ?? null; }

        /// <summary>Backing field for <see cref="CaptureDescription" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescription _captureDescription;

        /// <summary>Properties of capture description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescription CaptureDescription { get => (this._captureDescription = this._captureDescription ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.CaptureDescription()); set => this._captureDescription = value; }

        /// <summary>A value that indicates whether capture description is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public bool? CaptureDescriptionEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).Enabled = value ?? default(bool); }

        /// <summary>
        /// Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated
        /// in New API Version
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EncodingCaptureDescription? CaptureDescriptionEncoding { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).Encoding; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).Encoding = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EncodingCaptureDescription)""); }

        /// <summary>
        /// The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between
        /// 60 to 900 seconds
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public int? CaptureDescriptionIntervalInSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).IntervalInSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).IntervalInSecond = value ?? default(int); }

        /// <summary>
        /// The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between
        /// 10485760 to 524288000 bytes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public int? CaptureDescriptionSizeLimitInByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).SizeLimitInByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).SizeLimitInByte = value ?? default(int); }

        /// <summary>A value that indicates whether to Skip Empty Archives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public bool? CaptureDescriptionSkipEmptyArchive { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).SkipEmptyArchive; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).SkipEmptyArchive = value ?? default(bool); }

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        /// <summary>Exact time the Event Hub was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; }

        /// <summary>The Azure Data Lake Store name for the captured events</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string DataLakeAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DataLakeAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DataLakeAccountName = value ?? null; }

        /// <summary>The destination folder path for the captured events</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string DataLakeFolderPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DataLakeFolderPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DataLakeFolderPath = value ?? null; }

        /// <summary>Subscription Id of Azure Data Lake Store</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string DataLakeSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DataLakeSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DataLakeSubscriptionId = value ?? null; }

        /// <summary>Name for capture destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string DestinationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DestinationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DestinationName = value ?? null; }

        /// <summary>Backing field for <see cref="MessageRetentionInDay" /> property.</summary>
        private long? _messageRetentionInDay;

        /// <summary>
        /// Number of days to retain the events for this Event Hub, value should be 1 to 7 days
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public long? MessageRetentionInDay { get => this._messageRetentionInDay; set => this._messageRetentionInDay = value; }

        /// <summary>Internal Acessors for CaptureDescription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescription Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubPropertiesInternal.CaptureDescription { get => (this._captureDescription = this._captureDescription ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.CaptureDescription()); set { {_captureDescription = value;} } }

        /// <summary>Internal Acessors for CaptureDescriptionDestination</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IDestination Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubPropertiesInternal.CaptureDescriptionDestination { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).Destination; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).Destination = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubPropertiesInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for DestinationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IDestinationProperties Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubPropertiesInternal.DestinationProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DestinationProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).DestinationProperty = value; }

        /// <summary>Internal Acessors for PartitionId</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubPropertiesInternal.PartitionId { get => this._partitionId; set { {_partitionId = value;} } }

        /// <summary>Internal Acessors for RetentionDescription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescription Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubPropertiesInternal.RetentionDescription { get => (this._retentionDescription = this._retentionDescription ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.RetentionDescription()); set { {_retentionDescription = value;} } }

        /// <summary>Internal Acessors for UpdatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEventhubPropertiesInternal.UpdatedAt { get => this._updatedAt; set { {_updatedAt = value;} } }

        /// <summary>Backing field for <see cref="PartitionCount" /> property.</summary>
        private long? _partitionCount;

        /// <summary>
        /// Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public long? PartitionCount { get => this._partitionCount; set => this._partitionCount = value; }

        /// <summary>Backing field for <see cref="PartitionId" /> property.</summary>
        private string[] _partitionId;

        /// <summary>Current number of shards on the Event Hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string[] PartitionId { get => this._partitionId; }

        /// <summary>Backing field for <see cref="RetentionDescription" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescription _retentionDescription;

        /// <summary>Event Hub retention settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescription RetentionDescription { get => (this._retentionDescription = this._retentionDescription ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.RetentionDescription()); set => this._retentionDescription = value; }

        /// <summary>Enumerates the possible values for cleanup policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CleanupPolicyRetentionDescription? RetentionDescriptionCleanupPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescriptionInternal)RetentionDescription).CleanupPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescriptionInternal)RetentionDescription).CleanupPolicy = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CleanupPolicyRetentionDescription)""); }

        /// <summary>
        /// Number of hours to retain the events for this Event Hub. This value is only used when cleanupPolicy is Delete. If cleanupPolicy
        /// is Compaction the returned value of this property is Long.MaxValue
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public long? RetentionDescriptionRetentionTimeInHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescriptionInternal)RetentionDescription).RetentionTimeInHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescriptionInternal)RetentionDescription).RetentionTimeInHour = value ?? default(long); }

        /// <summary>
        /// Number of hours to retain the tombstone markers of a compacted Event Hub. This value is only used when cleanupPolicy is
        /// Compaction. Consumer must complete reading the tombstone marker within this specified amount of time if consumer begins
        /// from starting offset to ensure they get a valid snapshot for the specific key described by the tombstone marker within
        /// the compacted Event Hub
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public int? RetentionDescriptionTombstoneRetentionTimeInHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescriptionInternal)RetentionDescription).TombstoneRetentionTimeInHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescriptionInternal)RetentionDescription).TombstoneRetentionTimeInHour = value ?? default(int); }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EntityStatus? _status;

        /// <summary>Enumerates the possible values for the status of the Event Hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EntityStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Resource id of the storage account to be used to create the blobs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string StorageAccountResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).StorageAccountResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescriptionInternal)CaptureDescription).StorageAccountResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="UpdatedAt" /> property.</summary>
        private global::System.DateTime? _updatedAt;

        /// <summary>The exact time the message was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public global::System.DateTime? UpdatedAt { get => this._updatedAt; }

        /// <summary>Creates an new <see cref="EventhubProperties" /> instance.</summary>
        public EventhubProperties()
        {

        }
    }
    /// Properties supplied to the Create Or Update Event Hub operation.
    public partial interface IEventhubProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}.
        /// Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order",
        SerializedName = @"archiveNameFormat",
        PossibleTypes = new [] { typeof(string) })]
        string ArchiveNameFormat { get; set; }
        /// <summary>Blob container Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Blob container Name",
        SerializedName = @"blobContainer",
        PossibleTypes = new [] { typeof(string) })]
        string BlobContainer { get; set; }
        /// <summary>A value that indicates whether capture description is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value that indicates whether capture description is enabled. ",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CaptureDescriptionEnabled { get; set; }
        /// <summary>
        /// Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated
        /// in New API Version
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version",
        SerializedName = @"encoding",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EncodingCaptureDescription) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EncodingCaptureDescription? CaptureDescriptionEncoding { get; set; }
        /// <summary>
        /// The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between
        /// 60 to 900 seconds
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds",
        SerializedName = @"intervalInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? CaptureDescriptionIntervalInSecond { get; set; }
        /// <summary>
        /// The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between
        /// 10485760 to 524288000 bytes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes",
        SerializedName = @"sizeLimitInBytes",
        PossibleTypes = new [] { typeof(int) })]
        int? CaptureDescriptionSizeLimitInByte { get; set; }
        /// <summary>A value that indicates whether to Skip Empty Archives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value that indicates whether to Skip Empty Archives",
        SerializedName = @"skipEmptyArchives",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CaptureDescriptionSkipEmptyArchive { get; set; }
        /// <summary>Exact time the Event Hub was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Exact time the Event Hub was created.",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }
        /// <summary>The Azure Data Lake Store name for the captured events</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure Data Lake Store name for the captured events",
        SerializedName = @"dataLakeAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string DataLakeAccountName { get; set; }
        /// <summary>The destination folder path for the captured events</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The destination folder path for the captured events",
        SerializedName = @"dataLakeFolderPath",
        PossibleTypes = new [] { typeof(string) })]
        string DataLakeFolderPath { get; set; }
        /// <summary>Subscription Id of Azure Data Lake Store</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription Id of Azure Data Lake Store",
        SerializedName = @"dataLakeSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string DataLakeSubscriptionId { get; set; }
        /// <summary>Name for capture destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name for capture destination",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationName { get; set; }
        /// <summary>
        /// Number of days to retain the events for this Event Hub, value should be 1 to 7 days
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of days to retain the events for this Event Hub, value should be 1 to 7 days",
        SerializedName = @"messageRetentionInDays",
        PossibleTypes = new [] { typeof(long) })]
        long? MessageRetentionInDay { get; set; }
        /// <summary>
        /// Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions.",
        SerializedName = @"partitionCount",
        PossibleTypes = new [] { typeof(long) })]
        long? PartitionCount { get; set; }
        /// <summary>Current number of shards on the Event Hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current number of shards on the Event Hub.",
        SerializedName = @"partitionIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] PartitionId { get;  }
        /// <summary>Enumerates the possible values for cleanup policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enumerates the possible values for cleanup policy",
        SerializedName = @"cleanupPolicy",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CleanupPolicyRetentionDescription) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CleanupPolicyRetentionDescription? RetentionDescriptionCleanupPolicy { get; set; }
        /// <summary>
        /// Number of hours to retain the events for this Event Hub. This value is only used when cleanupPolicy is Delete. If cleanupPolicy
        /// is Compaction the returned value of this property is Long.MaxValue
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of hours to retain the events for this Event Hub. This value is only used when cleanupPolicy is Delete. If cleanupPolicy is Compaction the returned value of this property is Long.MaxValue ",
        SerializedName = @"retentionTimeInHours",
        PossibleTypes = new [] { typeof(long) })]
        long? RetentionDescriptionRetentionTimeInHour { get; set; }
        /// <summary>
        /// Number of hours to retain the tombstone markers of a compacted Event Hub. This value is only used when cleanupPolicy is
        /// Compaction. Consumer must complete reading the tombstone marker within this specified amount of time if consumer begins
        /// from starting offset to ensure they get a valid snapshot for the specific key described by the tombstone marker within
        /// the compacted Event Hub
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of hours to retain the tombstone markers of a compacted Event Hub. This value is only used when cleanupPolicy is Compaction. Consumer must complete reading the tombstone marker within this specified amount of time if consumer begins from starting offset to ensure they get a valid snapshot for the specific key described by the tombstone marker within the compacted Event Hub",
        SerializedName = @"tombstoneRetentionTimeInHours",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionDescriptionTombstoneRetentionTimeInHour { get; set; }
        /// <summary>Enumerates the possible values for the status of the Event Hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enumerates the possible values for the status of the Event Hub.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EntityStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EntityStatus? Status { get; set; }
        /// <summary>Resource id of the storage account to be used to create the blobs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource id of the storage account to be used to create the blobs",
        SerializedName = @"storageAccountResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountResourceId { get; set; }
        /// <summary>The exact time the message was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The exact time the message was updated.",
        SerializedName = @"updatedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpdatedAt { get;  }

    }
    /// Properties supplied to the Create Or Update Event Hub operation.
    internal partial interface IEventhubPropertiesInternal

    {
        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}.
        /// Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        /// </summary>
        string ArchiveNameFormat { get; set; }
        /// <summary>Blob container Name</summary>
        string BlobContainer { get; set; }
        /// <summary>Properties of capture description</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ICaptureDescription CaptureDescription { get; set; }
        /// <summary>
        /// Properties of Destination where capture will be stored. (Storage Account, Blob Names)
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IDestination CaptureDescriptionDestination { get; set; }
        /// <summary>A value that indicates whether capture description is enabled.</summary>
        bool? CaptureDescriptionEnabled { get; set; }
        /// <summary>
        /// Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated
        /// in New API Version
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EncodingCaptureDescription? CaptureDescriptionEncoding { get; set; }
        /// <summary>
        /// The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between
        /// 60 to 900 seconds
        /// </summary>
        int? CaptureDescriptionIntervalInSecond { get; set; }
        /// <summary>
        /// The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between
        /// 10485760 to 524288000 bytes
        /// </summary>
        int? CaptureDescriptionSizeLimitInByte { get; set; }
        /// <summary>A value that indicates whether to Skip Empty Archives</summary>
        bool? CaptureDescriptionSkipEmptyArchive { get; set; }
        /// <summary>Exact time the Event Hub was created.</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>The Azure Data Lake Store name for the captured events</summary>
        string DataLakeAccountName { get; set; }
        /// <summary>The destination folder path for the captured events</summary>
        string DataLakeFolderPath { get; set; }
        /// <summary>Subscription Id of Azure Data Lake Store</summary>
        string DataLakeSubscriptionId { get; set; }
        /// <summary>Name for capture destination</summary>
        string DestinationName { get; set; }
        /// <summary>
        /// Properties describing the storage account, blob container and archive name format for capture destination
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IDestinationProperties DestinationProperty { get; set; }
        /// <summary>
        /// Number of days to retain the events for this Event Hub, value should be 1 to 7 days
        /// </summary>
        long? MessageRetentionInDay { get; set; }
        /// <summary>
        /// Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions.
        /// </summary>
        long? PartitionCount { get; set; }
        /// <summary>Current number of shards on the Event Hub.</summary>
        string[] PartitionId { get; set; }
        /// <summary>Event Hub retention settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IRetentionDescription RetentionDescription { get; set; }
        /// <summary>Enumerates the possible values for cleanup policy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CleanupPolicyRetentionDescription? RetentionDescriptionCleanupPolicy { get; set; }
        /// <summary>
        /// Number of hours to retain the events for this Event Hub. This value is only used when cleanupPolicy is Delete. If cleanupPolicy
        /// is Compaction the returned value of this property is Long.MaxValue
        /// </summary>
        long? RetentionDescriptionRetentionTimeInHour { get; set; }
        /// <summary>
        /// Number of hours to retain the tombstone markers of a compacted Event Hub. This value is only used when cleanupPolicy is
        /// Compaction. Consumer must complete reading the tombstone marker within this specified amount of time if consumer begins
        /// from starting offset to ensure they get a valid snapshot for the specific key described by the tombstone marker within
        /// the compacted Event Hub
        /// </summary>
        int? RetentionDescriptionTombstoneRetentionTimeInHour { get; set; }
        /// <summary>Enumerates the possible values for the status of the Event Hub.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EntityStatus? Status { get; set; }
        /// <summary>Resource id of the storage account to be used to create the blobs</summary>
        string StorageAccountResourceId { get; set; }
        /// <summary>The exact time the message was updated.</summary>
        global::System.DateTime? UpdatedAt { get; set; }

    }
}