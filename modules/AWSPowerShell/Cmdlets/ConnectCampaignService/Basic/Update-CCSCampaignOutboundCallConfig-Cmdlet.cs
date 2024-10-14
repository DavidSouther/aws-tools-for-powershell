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
using Amazon.ConnectCampaignService;
using Amazon.ConnectCampaignService.Model;

namespace Amazon.PowerShell.Cmdlets.CCS
{
    /// <summary>
    /// Updates the outbound call config of a campaign. This API is idempotent.
    /// </summary>
    [Cmdlet("Update", "CCSCampaignOutboundCallConfig", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the Amazon Connect Campaign Service UpdateCampaignOutboundCallConfig API operation.", Operation = new[] {"UpdateCampaignOutboundCallConfig"}, SelectReturnType = typeof(Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigResponse))]
    [AWSCmdletOutput("None or Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigResponse) be returned by specifying '-Select *'."
    )]
    public partial class UpdateCCSCampaignOutboundCallConfigCmdlet : AmazonConnectCampaignServiceClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter AnswerMachineDetectionConfig_AwaitAnswerMachinePrompt
        /// <summary>
        /// <para>
        /// <para>Enable or disable await answer machine prompt</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AnswerMachineDetectionConfig_AwaitAnswerMachinePrompt { get; set; }
        #endregion
        
        #region Parameter ConnectContactFlowId
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ConnectContactFlowId { get; set; }
        #endregion
        
        #region Parameter ConnectSourcePhoneNumber
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ConnectSourcePhoneNumber { get; set; }
        #endregion
        
        #region Parameter AnswerMachineDetectionConfig_EnableAnswerMachineDetection
        /// <summary>
        /// <para>
        /// <para>Enable or disable answering machine detection</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AnswerMachineDetectionConfig_EnableAnswerMachineDetection { get; set; }
        #endregion
        
        #region Parameter Id
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
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
        public System.String Id { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Id parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Id), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-CCSCampaignOutboundCallConfig (UpdateCampaignOutboundCallConfig)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigResponse, UpdateCCSCampaignOutboundCallConfigCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Id;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AnswerMachineDetectionConfig_AwaitAnswerMachinePrompt = this.AnswerMachineDetectionConfig_AwaitAnswerMachinePrompt;
            context.AnswerMachineDetectionConfig_EnableAnswerMachineDetection = this.AnswerMachineDetectionConfig_EnableAnswerMachineDetection;
            context.ConnectContactFlowId = this.ConnectContactFlowId;
            context.ConnectSourcePhoneNumber = this.ConnectSourcePhoneNumber;
            context.Id = this.Id;
            #if MODULAR
            if (this.Id == null && ParameterWasBound(nameof(this.Id)))
            {
                WriteWarning("You are passing $null as a value for parameter Id which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigRequest();
            
            
             // populate AnswerMachineDetectionConfig
            var requestAnswerMachineDetectionConfigIsNull = true;
            request.AnswerMachineDetectionConfig = new Amazon.ConnectCampaignService.Model.AnswerMachineDetectionConfig();
            System.Boolean? requestAnswerMachineDetectionConfig_answerMachineDetectionConfig_AwaitAnswerMachinePrompt = null;
            if (cmdletContext.AnswerMachineDetectionConfig_AwaitAnswerMachinePrompt != null)
            {
                requestAnswerMachineDetectionConfig_answerMachineDetectionConfig_AwaitAnswerMachinePrompt = cmdletContext.AnswerMachineDetectionConfig_AwaitAnswerMachinePrompt.Value;
            }
            if (requestAnswerMachineDetectionConfig_answerMachineDetectionConfig_AwaitAnswerMachinePrompt != null)
            {
                request.AnswerMachineDetectionConfig.AwaitAnswerMachinePrompt = requestAnswerMachineDetectionConfig_answerMachineDetectionConfig_AwaitAnswerMachinePrompt.Value;
                requestAnswerMachineDetectionConfigIsNull = false;
            }
            System.Boolean? requestAnswerMachineDetectionConfig_answerMachineDetectionConfig_EnableAnswerMachineDetection = null;
            if (cmdletContext.AnswerMachineDetectionConfig_EnableAnswerMachineDetection != null)
            {
                requestAnswerMachineDetectionConfig_answerMachineDetectionConfig_EnableAnswerMachineDetection = cmdletContext.AnswerMachineDetectionConfig_EnableAnswerMachineDetection.Value;
            }
            if (requestAnswerMachineDetectionConfig_answerMachineDetectionConfig_EnableAnswerMachineDetection != null)
            {
                request.AnswerMachineDetectionConfig.EnableAnswerMachineDetection = requestAnswerMachineDetectionConfig_answerMachineDetectionConfig_EnableAnswerMachineDetection.Value;
                requestAnswerMachineDetectionConfigIsNull = false;
            }
             // determine if request.AnswerMachineDetectionConfig should be set to null
            if (requestAnswerMachineDetectionConfigIsNull)
            {
                request.AnswerMachineDetectionConfig = null;
            }
            if (cmdletContext.ConnectContactFlowId != null)
            {
                request.ConnectContactFlowId = cmdletContext.ConnectContactFlowId;
            }
            if (cmdletContext.ConnectSourcePhoneNumber != null)
            {
                request.ConnectSourcePhoneNumber = cmdletContext.ConnectSourcePhoneNumber;
            }
            if (cmdletContext.Id != null)
            {
                request.Id = cmdletContext.Id;
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
        
        private Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigResponse CallAWSServiceOperation(IAmazonConnectCampaignService client, Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Connect Campaign Service", "UpdateCampaignOutboundCallConfig");
            try
            {
                #if DESKTOP
                return client.UpdateCampaignOutboundCallConfig(request);
                #elif CORECLR
                return client.UpdateCampaignOutboundCallConfigAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? AnswerMachineDetectionConfig_AwaitAnswerMachinePrompt { get; set; }
            public System.Boolean? AnswerMachineDetectionConfig_EnableAnswerMachineDetection { get; set; }
            public System.String ConnectContactFlowId { get; set; }
            public System.String ConnectSourcePhoneNumber { get; set; }
            public System.String Id { get; set; }
            public System.Func<Amazon.ConnectCampaignService.Model.UpdateCampaignOutboundCallConfigResponse, UpdateCCSCampaignOutboundCallConfigCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
