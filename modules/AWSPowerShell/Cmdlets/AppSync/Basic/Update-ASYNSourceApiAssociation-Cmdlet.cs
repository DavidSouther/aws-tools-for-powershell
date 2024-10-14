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
using Amazon.AppSync;
using Amazon.AppSync.Model;

namespace Amazon.PowerShell.Cmdlets.ASYN
{
    /// <summary>
    /// Updates some of the configuration choices of a particular source API association.
    /// </summary>
    [Cmdlet("Update", "ASYNSourceApiAssociation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.AppSync.Model.SourceApiAssociation")]
    [AWSCmdlet("Calls the AWS AppSync UpdateSourceApiAssociation API operation.", Operation = new[] {"UpdateSourceApiAssociation"}, SelectReturnType = typeof(Amazon.AppSync.Model.UpdateSourceApiAssociationResponse))]
    [AWSCmdletOutput("Amazon.AppSync.Model.SourceApiAssociation or Amazon.AppSync.Model.UpdateSourceApiAssociationResponse",
        "This cmdlet returns an Amazon.AppSync.Model.SourceApiAssociation object.",
        "The service call response (type Amazon.AppSync.Model.UpdateSourceApiAssociationResponse) can be returned by specifying '-Select *'."
    )]
    public partial class UpdateASYNSourceApiAssociationCmdlet : AmazonAppSyncClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter AssociationId
        /// <summary>
        /// <para>
        /// <para>The ID generated by the AppSync service for the source API association.</para>
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
        public System.String AssociationId { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>The description field.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter MergedApiIdentifier
        /// <summary>
        /// <para>
        /// <para>The identifier of the AppSync Merged API. This is generated by the AppSync service.
        /// In most cases, Merged APIs (especially in your account) only require the API ID value
        /// or ARN of the merged API. However, Merged APIs in other accounts (cross-account use
        /// cases) strictly require the full resource ARN of the merged API.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String MergedApiIdentifier { get; set; }
        #endregion
        
        #region Parameter SourceApiAssociationConfig_MergeType
        /// <summary>
        /// <para>
        /// <para>The property that indicates which merging option is enabled in the source API association.</para><para>Valid merge types are <c>MANUAL_MERGE</c> (default) and <c>AUTO_MERGE</c>. Manual
        /// merges are the default behavior and require the user to trigger any changes from the
        /// source APIs to the merged API manually. Auto merges subscribe the merged API to the
        /// changes performed on the source APIs so that any change in the source APIs are also
        /// made to the merged API. Auto merges use <c>MergedApiExecutionRoleArn</c> to perform
        /// merge operations.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.AppSync.MergeType")]
        public Amazon.AppSync.MergeType SourceApiAssociationConfig_MergeType { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'SourceApiAssociation'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AppSync.Model.UpdateSourceApiAssociationResponse).
        /// Specifying the name of a property of type Amazon.AppSync.Model.UpdateSourceApiAssociationResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "SourceApiAssociation";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AssociationId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AssociationId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AssociationId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AssociationId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-ASYNSourceApiAssociation (UpdateSourceApiAssociation)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AppSync.Model.UpdateSourceApiAssociationResponse, UpdateASYNSourceApiAssociationCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AssociationId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AssociationId = this.AssociationId;
            #if MODULAR
            if (this.AssociationId == null && ParameterWasBound(nameof(this.AssociationId)))
            {
                WriteWarning("You are passing $null as a value for parameter AssociationId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Description = this.Description;
            context.MergedApiIdentifier = this.MergedApiIdentifier;
            #if MODULAR
            if (this.MergedApiIdentifier == null && ParameterWasBound(nameof(this.MergedApiIdentifier)))
            {
                WriteWarning("You are passing $null as a value for parameter MergedApiIdentifier which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SourceApiAssociationConfig_MergeType = this.SourceApiAssociationConfig_MergeType;
            
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
            var request = new Amazon.AppSync.Model.UpdateSourceApiAssociationRequest();
            
            if (cmdletContext.AssociationId != null)
            {
                request.AssociationId = cmdletContext.AssociationId;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.MergedApiIdentifier != null)
            {
                request.MergedApiIdentifier = cmdletContext.MergedApiIdentifier;
            }
            
             // populate SourceApiAssociationConfig
            var requestSourceApiAssociationConfigIsNull = true;
            request.SourceApiAssociationConfig = new Amazon.AppSync.Model.SourceApiAssociationConfig();
            Amazon.AppSync.MergeType requestSourceApiAssociationConfig_sourceApiAssociationConfig_MergeType = null;
            if (cmdletContext.SourceApiAssociationConfig_MergeType != null)
            {
                requestSourceApiAssociationConfig_sourceApiAssociationConfig_MergeType = cmdletContext.SourceApiAssociationConfig_MergeType;
            }
            if (requestSourceApiAssociationConfig_sourceApiAssociationConfig_MergeType != null)
            {
                request.SourceApiAssociationConfig.MergeType = requestSourceApiAssociationConfig_sourceApiAssociationConfig_MergeType;
                requestSourceApiAssociationConfigIsNull = false;
            }
             // determine if request.SourceApiAssociationConfig should be set to null
            if (requestSourceApiAssociationConfigIsNull)
            {
                request.SourceApiAssociationConfig = null;
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
        
        private Amazon.AppSync.Model.UpdateSourceApiAssociationResponse CallAWSServiceOperation(IAmazonAppSync client, Amazon.AppSync.Model.UpdateSourceApiAssociationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS AppSync", "UpdateSourceApiAssociation");
            try
            {
                #if DESKTOP
                return client.UpdateSourceApiAssociation(request);
                #elif CORECLR
                return client.UpdateSourceApiAssociationAsync(request).GetAwaiter().GetResult();
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
            public System.String AssociationId { get; set; }
            public System.String Description { get; set; }
            public System.String MergedApiIdentifier { get; set; }
            public Amazon.AppSync.MergeType SourceApiAssociationConfig_MergeType { get; set; }
            public System.Func<Amazon.AppSync.Model.UpdateSourceApiAssociationResponse, UpdateASYNSourceApiAssociationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.SourceApiAssociation;
        }
        
    }
}
