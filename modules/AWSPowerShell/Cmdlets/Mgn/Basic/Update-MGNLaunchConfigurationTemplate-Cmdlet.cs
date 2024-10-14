/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.Mgn;
using Amazon.Mgn.Model;

namespace Amazon.PowerShell.Cmdlets.MGN
{
    /// <summary>
    /// Updates an existing Launch Configuration Template by ID.
    /// </summary>
    [Cmdlet("Update", "MGNLaunchConfigurationTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse")]
    [AWSCmdlet("Calls the Application Migration Service UpdateLaunchConfigurationTemplate API operation.", Operation = new[] {"UpdateLaunchConfigurationTemplate"}, SelectReturnType = typeof(Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse))]
    [AWSCmdletOutput("Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse",
        "This cmdlet returns an Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse object containing multiple properties."
    )]
    public partial class UpdateMGNLaunchConfigurationTemplateCmdlet : AmazonMgnClientCmdlet, IExecutor
    {
        
        protected override bool IsSensitiveResponse { get; set; } = true;
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter AssociatePublicIpAddress
        /// <summary>
        /// <para>
        /// <para>Associate public Ip address.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AssociatePublicIpAddress { get; set; }
        #endregion
        
        #region Parameter BootMode
        /// <summary>
        /// <para>
        /// <para>Launch configuration template boot mode.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Mgn.BootMode")]
        public Amazon.Mgn.BootMode BootMode { get; set; }
        #endregion
        
        #region Parameter PostLaunchActions_CloudWatchLogGroupName
        /// <summary>
        /// <para>
        /// <para>AWS Systems Manager Command's CloudWatch log group name.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PostLaunchActions_CloudWatchLogGroupName { get; set; }
        #endregion
        
        #region Parameter CopyPrivateIp
        /// <summary>
        /// <para>
        /// <para>Copy private Ip.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? CopyPrivateIp { get; set; }
        #endregion
        
        #region Parameter CopyTag
        /// <summary>
        /// <para>
        /// <para>Copy tags.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CopyTags")]
        public System.Boolean? CopyTag { get; set; }
        #endregion
        
        #region Parameter PostLaunchActions_Deployment
        /// <summary>
        /// <para>
        /// <para>Deployment type in which AWS Systems Manager Documents will be executed.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Mgn.PostLaunchActionsDeploymentType")]
        public Amazon.Mgn.PostLaunchActionsDeploymentType PostLaunchActions_Deployment { get; set; }
        #endregion
        
        #region Parameter EnableMapAutoTagging
        /// <summary>
        /// <para>
        /// <para>Enable map auto tagging.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EnableMapAutoTagging { get; set; }
        #endregion
        
        #region Parameter LargeVolumeConf_Iops
        /// <summary>
        /// <para>
        /// <para>Launch template disk iops configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? LargeVolumeConf_Iops { get; set; }
        #endregion
        
        #region Parameter SmallVolumeConf_Iops
        /// <summary>
        /// <para>
        /// <para>Launch template disk iops configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? SmallVolumeConf_Iops { get; set; }
        #endregion
        
        #region Parameter LaunchConfigurationTemplateID
        /// <summary>
        /// <para>
        /// <para>Launch Configuration Template ID.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String LaunchConfigurationTemplateID { get; set; }
        #endregion
        
        #region Parameter LaunchDisposition
        /// <summary>
        /// <para>
        /// <para>Launch disposition.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Mgn.LaunchDisposition")]
        public Amazon.Mgn.LaunchDisposition LaunchDisposition { get; set; }
        #endregion
        
        #region Parameter MapAutoTaggingMpeID
        /// <summary>
        /// <para>
        /// <para>Launch configuration template map auto tagging MPE ID.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MapAutoTaggingMpeID { get; set; }
        #endregion
        
        #region Parameter Licensing_OsByol
        /// <summary>
        /// <para>
        /// <para>Configure BYOL OS licensing.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? Licensing_OsByol { get; set; }
        #endregion
        
        #region Parameter PostLaunchActions_S3LogBucket
        /// <summary>
        /// <para>
        /// <para>AWS Systems Manager Command's logs S3 log bucket.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PostLaunchActions_S3LogBucket { get; set; }
        #endregion
        
        #region Parameter PostLaunchActions_S3OutputKeyPrefix
        /// <summary>
        /// <para>
        /// <para>AWS Systems Manager Command's logs S3 output key prefix.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PostLaunchActions_S3OutputKeyPrefix { get; set; }
        #endregion
        
        #region Parameter SmallVolumeMaxSize
        /// <summary>
        /// <para>
        /// <para>Small volume maximum size.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? SmallVolumeMaxSize { get; set; }
        #endregion
        
        #region Parameter PostLaunchActions_SsmDocument
        /// <summary>
        /// <para>
        /// <para>AWS Systems Manager Documents.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("PostLaunchActions_SsmDocuments")]
        public Amazon.Mgn.Model.SsmDocument[] PostLaunchActions_SsmDocument { get; set; }
        #endregion
        
        #region Parameter TargetInstanceTypeRightSizingMethod
        /// <summary>
        /// <para>
        /// <para>Target instance type right-sizing method.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Mgn.TargetInstanceTypeRightSizingMethod")]
        public Amazon.Mgn.TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod { get; set; }
        #endregion
        
        #region Parameter LargeVolumeConf_Throughput
        /// <summary>
        /// <para>
        /// <para>Launch template disk throughput configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? LargeVolumeConf_Throughput { get; set; }
        #endregion
        
        #region Parameter SmallVolumeConf_Throughput
        /// <summary>
        /// <para>
        /// <para>Launch template disk throughput configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int64? SmallVolumeConf_Throughput { get; set; }
        #endregion
        
        #region Parameter LargeVolumeConf_VolumeType
        /// <summary>
        /// <para>
        /// <para>Launch template disk volume type configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Mgn.VolumeType")]
        public Amazon.Mgn.VolumeType LargeVolumeConf_VolumeType { get; set; }
        #endregion
        
        #region Parameter SmallVolumeConf_VolumeType
        /// <summary>
        /// <para>
        /// <para>Launch template disk volume type configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Mgn.VolumeType")]
        public Amazon.Mgn.VolumeType SmallVolumeConf_VolumeType { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse).
        /// Specifying the name of a property of type Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the LaunchConfigurationTemplateID parameter.
        /// The -PassThru parameter is deprecated, use -Select '^LaunchConfigurationTemplateID' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^LaunchConfigurationTemplateID' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.PostLaunchActions_CloudWatchLogGroupName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-MGNLaunchConfigurationTemplate (UpdateLaunchConfigurationTemplate)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse, UpdateMGNLaunchConfigurationTemplateCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.LaunchConfigurationTemplateID;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AssociatePublicIpAddress = this.AssociatePublicIpAddress;
            context.BootMode = this.BootMode;
            context.CopyPrivateIp = this.CopyPrivateIp;
            context.CopyTag = this.CopyTag;
            context.EnableMapAutoTagging = this.EnableMapAutoTagging;
            context.LargeVolumeConf_Iops = this.LargeVolumeConf_Iops;
            context.LargeVolumeConf_Throughput = this.LargeVolumeConf_Throughput;
            context.LargeVolumeConf_VolumeType = this.LargeVolumeConf_VolumeType;
            context.LaunchConfigurationTemplateID = this.LaunchConfigurationTemplateID;
            #if MODULAR
            if (this.LaunchConfigurationTemplateID == null && ParameterWasBound(nameof(this.LaunchConfigurationTemplateID)))
            {
                WriteWarning("You are passing $null as a value for parameter LaunchConfigurationTemplateID which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.LaunchDisposition = this.LaunchDisposition;
            context.Licensing_OsByol = this.Licensing_OsByol;
            context.MapAutoTaggingMpeID = this.MapAutoTaggingMpeID;
            context.PostLaunchActions_CloudWatchLogGroupName = this.PostLaunchActions_CloudWatchLogGroupName;
            context.PostLaunchActions_Deployment = this.PostLaunchActions_Deployment;
            context.PostLaunchActions_S3LogBucket = this.PostLaunchActions_S3LogBucket;
            context.PostLaunchActions_S3OutputKeyPrefix = this.PostLaunchActions_S3OutputKeyPrefix;
            if (this.PostLaunchActions_SsmDocument != null)
            {
                context.PostLaunchActions_SsmDocument = new List<Amazon.Mgn.Model.SsmDocument>(this.PostLaunchActions_SsmDocument);
            }
            context.SmallVolumeConf_Iops = this.SmallVolumeConf_Iops;
            context.SmallVolumeConf_Throughput = this.SmallVolumeConf_Throughput;
            context.SmallVolumeConf_VolumeType = this.SmallVolumeConf_VolumeType;
            context.SmallVolumeMaxSize = this.SmallVolumeMaxSize;
            context.TargetInstanceTypeRightSizingMethod = this.TargetInstanceTypeRightSizingMethod;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateRequest();
            
            if (cmdletContext.AssociatePublicIpAddress != null)
            {
                request.AssociatePublicIpAddress = cmdletContext.AssociatePublicIpAddress.Value;
            }
            if (cmdletContext.BootMode != null)
            {
                request.BootMode = cmdletContext.BootMode;
            }
            if (cmdletContext.CopyPrivateIp != null)
            {
                request.CopyPrivateIp = cmdletContext.CopyPrivateIp.Value;
            }
            if (cmdletContext.CopyTag != null)
            {
                request.CopyTags = cmdletContext.CopyTag.Value;
            }
            if (cmdletContext.EnableMapAutoTagging != null)
            {
                request.EnableMapAutoTagging = cmdletContext.EnableMapAutoTagging.Value;
            }
            
             // populate LargeVolumeConf
            var requestLargeVolumeConfIsNull = true;
            request.LargeVolumeConf = new Amazon.Mgn.Model.LaunchTemplateDiskConf();
            System.Int64? requestLargeVolumeConf_largeVolumeConf_Iops = null;
            if (cmdletContext.LargeVolumeConf_Iops != null)
            {
                requestLargeVolumeConf_largeVolumeConf_Iops = cmdletContext.LargeVolumeConf_Iops.Value;
            }
            if (requestLargeVolumeConf_largeVolumeConf_Iops != null)
            {
                request.LargeVolumeConf.Iops = requestLargeVolumeConf_largeVolumeConf_Iops.Value;
                requestLargeVolumeConfIsNull = false;
            }
            System.Int64? requestLargeVolumeConf_largeVolumeConf_Throughput = null;
            if (cmdletContext.LargeVolumeConf_Throughput != null)
            {
                requestLargeVolumeConf_largeVolumeConf_Throughput = cmdletContext.LargeVolumeConf_Throughput.Value;
            }
            if (requestLargeVolumeConf_largeVolumeConf_Throughput != null)
            {
                request.LargeVolumeConf.Throughput = requestLargeVolumeConf_largeVolumeConf_Throughput.Value;
                requestLargeVolumeConfIsNull = false;
            }
            Amazon.Mgn.VolumeType requestLargeVolumeConf_largeVolumeConf_VolumeType = null;
            if (cmdletContext.LargeVolumeConf_VolumeType != null)
            {
                requestLargeVolumeConf_largeVolumeConf_VolumeType = cmdletContext.LargeVolumeConf_VolumeType;
            }
            if (requestLargeVolumeConf_largeVolumeConf_VolumeType != null)
            {
                request.LargeVolumeConf.VolumeType = requestLargeVolumeConf_largeVolumeConf_VolumeType;
                requestLargeVolumeConfIsNull = false;
            }
             // determine if request.LargeVolumeConf should be set to null
            if (requestLargeVolumeConfIsNull)
            {
                request.LargeVolumeConf = null;
            }
            if (cmdletContext.LaunchConfigurationTemplateID != null)
            {
                request.LaunchConfigurationTemplateID = cmdletContext.LaunchConfigurationTemplateID;
            }
            if (cmdletContext.LaunchDisposition != null)
            {
                request.LaunchDisposition = cmdletContext.LaunchDisposition;
            }
            
             // populate Licensing
            var requestLicensingIsNull = true;
            request.Licensing = new Amazon.Mgn.Model.Licensing();
            System.Boolean? requestLicensing_licensing_OsByol = null;
            if (cmdletContext.Licensing_OsByol != null)
            {
                requestLicensing_licensing_OsByol = cmdletContext.Licensing_OsByol.Value;
            }
            if (requestLicensing_licensing_OsByol != null)
            {
                request.Licensing.OsByol = requestLicensing_licensing_OsByol.Value;
                requestLicensingIsNull = false;
            }
             // determine if request.Licensing should be set to null
            if (requestLicensingIsNull)
            {
                request.Licensing = null;
            }
            if (cmdletContext.MapAutoTaggingMpeID != null)
            {
                request.MapAutoTaggingMpeID = cmdletContext.MapAutoTaggingMpeID;
            }
            
             // populate PostLaunchActions
            var requestPostLaunchActionsIsNull = true;
            request.PostLaunchActions = new Amazon.Mgn.Model.PostLaunchActions();
            System.String requestPostLaunchActions_postLaunchActions_CloudWatchLogGroupName = null;
            if (cmdletContext.PostLaunchActions_CloudWatchLogGroupName != null)
            {
                requestPostLaunchActions_postLaunchActions_CloudWatchLogGroupName = cmdletContext.PostLaunchActions_CloudWatchLogGroupName;
            }
            if (requestPostLaunchActions_postLaunchActions_CloudWatchLogGroupName != null)
            {
                request.PostLaunchActions.CloudWatchLogGroupName = requestPostLaunchActions_postLaunchActions_CloudWatchLogGroupName;
                requestPostLaunchActionsIsNull = false;
            }
            Amazon.Mgn.PostLaunchActionsDeploymentType requestPostLaunchActions_postLaunchActions_Deployment = null;
            if (cmdletContext.PostLaunchActions_Deployment != null)
            {
                requestPostLaunchActions_postLaunchActions_Deployment = cmdletContext.PostLaunchActions_Deployment;
            }
            if (requestPostLaunchActions_postLaunchActions_Deployment != null)
            {
                request.PostLaunchActions.Deployment = requestPostLaunchActions_postLaunchActions_Deployment;
                requestPostLaunchActionsIsNull = false;
            }
            System.String requestPostLaunchActions_postLaunchActions_S3LogBucket = null;
            if (cmdletContext.PostLaunchActions_S3LogBucket != null)
            {
                requestPostLaunchActions_postLaunchActions_S3LogBucket = cmdletContext.PostLaunchActions_S3LogBucket;
            }
            if (requestPostLaunchActions_postLaunchActions_S3LogBucket != null)
            {
                request.PostLaunchActions.S3LogBucket = requestPostLaunchActions_postLaunchActions_S3LogBucket;
                requestPostLaunchActionsIsNull = false;
            }
            System.String requestPostLaunchActions_postLaunchActions_S3OutputKeyPrefix = null;
            if (cmdletContext.PostLaunchActions_S3OutputKeyPrefix != null)
            {
                requestPostLaunchActions_postLaunchActions_S3OutputKeyPrefix = cmdletContext.PostLaunchActions_S3OutputKeyPrefix;
            }
            if (requestPostLaunchActions_postLaunchActions_S3OutputKeyPrefix != null)
            {
                request.PostLaunchActions.S3OutputKeyPrefix = requestPostLaunchActions_postLaunchActions_S3OutputKeyPrefix;
                requestPostLaunchActionsIsNull = false;
            }
            List<Amazon.Mgn.Model.SsmDocument> requestPostLaunchActions_postLaunchActions_SsmDocument = null;
            if (cmdletContext.PostLaunchActions_SsmDocument != null)
            {
                requestPostLaunchActions_postLaunchActions_SsmDocument = cmdletContext.PostLaunchActions_SsmDocument;
            }
            if (requestPostLaunchActions_postLaunchActions_SsmDocument != null)
            {
                request.PostLaunchActions.SsmDocuments = requestPostLaunchActions_postLaunchActions_SsmDocument;
                requestPostLaunchActionsIsNull = false;
            }
             // determine if request.PostLaunchActions should be set to null
            if (requestPostLaunchActionsIsNull)
            {
                request.PostLaunchActions = null;
            }
            
             // populate SmallVolumeConf
            var requestSmallVolumeConfIsNull = true;
            request.SmallVolumeConf = new Amazon.Mgn.Model.LaunchTemplateDiskConf();
            System.Int64? requestSmallVolumeConf_smallVolumeConf_Iops = null;
            if (cmdletContext.SmallVolumeConf_Iops != null)
            {
                requestSmallVolumeConf_smallVolumeConf_Iops = cmdletContext.SmallVolumeConf_Iops.Value;
            }
            if (requestSmallVolumeConf_smallVolumeConf_Iops != null)
            {
                request.SmallVolumeConf.Iops = requestSmallVolumeConf_smallVolumeConf_Iops.Value;
                requestSmallVolumeConfIsNull = false;
            }
            System.Int64? requestSmallVolumeConf_smallVolumeConf_Throughput = null;
            if (cmdletContext.SmallVolumeConf_Throughput != null)
            {
                requestSmallVolumeConf_smallVolumeConf_Throughput = cmdletContext.SmallVolumeConf_Throughput.Value;
            }
            if (requestSmallVolumeConf_smallVolumeConf_Throughput != null)
            {
                request.SmallVolumeConf.Throughput = requestSmallVolumeConf_smallVolumeConf_Throughput.Value;
                requestSmallVolumeConfIsNull = false;
            }
            Amazon.Mgn.VolumeType requestSmallVolumeConf_smallVolumeConf_VolumeType = null;
            if (cmdletContext.SmallVolumeConf_VolumeType != null)
            {
                requestSmallVolumeConf_smallVolumeConf_VolumeType = cmdletContext.SmallVolumeConf_VolumeType;
            }
            if (requestSmallVolumeConf_smallVolumeConf_VolumeType != null)
            {
                request.SmallVolumeConf.VolumeType = requestSmallVolumeConf_smallVolumeConf_VolumeType;
                requestSmallVolumeConfIsNull = false;
            }
             // determine if request.SmallVolumeConf should be set to null
            if (requestSmallVolumeConfIsNull)
            {
                request.SmallVolumeConf = null;
            }
            if (cmdletContext.SmallVolumeMaxSize != null)
            {
                request.SmallVolumeMaxSize = cmdletContext.SmallVolumeMaxSize.Value;
            }
            if (cmdletContext.TargetInstanceTypeRightSizingMethod != null)
            {
                request.TargetInstanceTypeRightSizingMethod = cmdletContext.TargetInstanceTypeRightSizingMethod;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse CallAWSServiceOperation(IAmazonMgn client, Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Application Migration Service", "UpdateLaunchConfigurationTemplate");
            try
            {
                #if DESKTOP
                return client.UpdateLaunchConfigurationTemplate(request);
                #elif CORECLR
                return client.UpdateLaunchConfigurationTemplateAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.Boolean? AssociatePublicIpAddress { get; set; }
            public Amazon.Mgn.BootMode BootMode { get; set; }
            public System.Boolean? CopyPrivateIp { get; set; }
            public System.Boolean? CopyTag { get; set; }
            public System.Boolean? EnableMapAutoTagging { get; set; }
            public System.Int64? LargeVolumeConf_Iops { get; set; }
            public System.Int64? LargeVolumeConf_Throughput { get; set; }
            public Amazon.Mgn.VolumeType LargeVolumeConf_VolumeType { get; set; }
            public System.String LaunchConfigurationTemplateID { get; set; }
            public Amazon.Mgn.LaunchDisposition LaunchDisposition { get; set; }
            public System.Boolean? Licensing_OsByol { get; set; }
            public System.String MapAutoTaggingMpeID { get; set; }
            public System.String PostLaunchActions_CloudWatchLogGroupName { get; set; }
            public Amazon.Mgn.PostLaunchActionsDeploymentType PostLaunchActions_Deployment { get; set; }
            public System.String PostLaunchActions_S3LogBucket { get; set; }
            public System.String PostLaunchActions_S3OutputKeyPrefix { get; set; }
            public List<Amazon.Mgn.Model.SsmDocument> PostLaunchActions_SsmDocument { get; set; }
            public System.Int64? SmallVolumeConf_Iops { get; set; }
            public System.Int64? SmallVolumeConf_Throughput { get; set; }
            public Amazon.Mgn.VolumeType SmallVolumeConf_VolumeType { get; set; }
            public System.Int64? SmallVolumeMaxSize { get; set; }
            public Amazon.Mgn.TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod { get; set; }
            public System.Func<Amazon.Mgn.Model.UpdateLaunchConfigurationTemplateResponse, UpdateMGNLaunchConfigurationTemplateCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
