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
using Amazon.Amplify;
using Amazon.Amplify.Model;

namespace Amazon.PowerShell.Cmdlets.AMP
{
    /// <summary>
    /// Updates a webhook.
    /// </summary>
    [Cmdlet("Update", "AMPWebhook", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Amplify.Model.Webhook")]
    [AWSCmdlet("Calls the AWS Amplify UpdateWebhook API operation.", Operation = new[] {"UpdateWebhook"}, SelectReturnType = typeof(Amazon.Amplify.Model.UpdateWebhookResponse))]
    [AWSCmdletOutput("Amazon.Amplify.Model.Webhook or Amazon.Amplify.Model.UpdateWebhookResponse",
        "This cmdlet returns an Amazon.Amplify.Model.Webhook object.",
        "The service call response (type Amazon.Amplify.Model.UpdateWebhookResponse) can be returned by specifying '-Select *'."
    )]
    public partial class UpdateAMPWebhookCmdlet : AmazonAmplifyClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter BranchName
        /// <summary>
        /// <para>
        /// <para>The name for a branch that is part of an Amplify app. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String BranchName { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>The description for a webhook. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter WebhookId
        /// <summary>
        /// <para>
        /// <para>The unique ID for a webhook. </para>
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
        public System.String WebhookId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Webhook'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Amplify.Model.UpdateWebhookResponse).
        /// Specifying the name of a property of type Amazon.Amplify.Model.UpdateWebhookResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Webhook";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the WebhookId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^WebhookId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^WebhookId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.WebhookId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-AMPWebhook (UpdateWebhook)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Amplify.Model.UpdateWebhookResponse, UpdateAMPWebhookCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.WebhookId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.BranchName = this.BranchName;
            context.Description = this.Description;
            context.WebhookId = this.WebhookId;
            #if MODULAR
            if (this.WebhookId == null && ParameterWasBound(nameof(this.WebhookId)))
            {
                WriteWarning("You are passing $null as a value for parameter WebhookId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.Amplify.Model.UpdateWebhookRequest();
            
            if (cmdletContext.BranchName != null)
            {
                request.BranchName = cmdletContext.BranchName;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.WebhookId != null)
            {
                request.WebhookId = cmdletContext.WebhookId;
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
        
        private Amazon.Amplify.Model.UpdateWebhookResponse CallAWSServiceOperation(IAmazonAmplify client, Amazon.Amplify.Model.UpdateWebhookRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Amplify", "UpdateWebhook");
            try
            {
                #if DESKTOP
                return client.UpdateWebhook(request);
                #elif CORECLR
                return client.UpdateWebhookAsync(request).GetAwaiter().GetResult();
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
            public System.String BranchName { get; set; }
            public System.String Description { get; set; }
            public System.String WebhookId { get; set; }
            public System.Func<Amazon.Amplify.Model.UpdateWebhookResponse, UpdateAMPWebhookCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Webhook;
        }
        
    }
}
