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
using Amazon.WorkSpacesWeb;
using Amazon.WorkSpacesWeb.Model;

namespace Amazon.PowerShell.Cmdlets.WSW
{
    /// <summary>
    /// Updates the user access logging settings.
    /// </summary>
    [Cmdlet("Update", "WSWUserAccessLoggingSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.WorkSpacesWeb.Model.UserAccessLoggingSettings")]
    [AWSCmdlet("Calls the Amazon WorkSpaces Web UpdateUserAccessLoggingSettings API operation.", Operation = new[] {"UpdateUserAccessLoggingSettings"}, SelectReturnType = typeof(Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsResponse))]
    [AWSCmdletOutput("Amazon.WorkSpacesWeb.Model.UserAccessLoggingSettings or Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsResponse",
        "This cmdlet returns an Amazon.WorkSpacesWeb.Model.UserAccessLoggingSettings object.",
        "The service call response (type Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsResponse) can be returned by specifying '-Select *'."
    )]
    public partial class UpdateWSWUserAccessLoggingSettingCmdlet : AmazonWorkSpacesWebClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter KinesisStreamArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the Kinesis stream.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String KinesisStreamArn { get; set; }
        #endregion
        
        #region Parameter UserAccessLoggingSettingsArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the user access logging settings.</para>
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
        public System.String UserAccessLoggingSettingsArn { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, subsequent retries
        /// with the same client token return the result from the original successful request.
        /// </para><para>If you do not specify a client token, one is automatically generated by the Amazon
        /// Web Services SDK.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'UserAccessLoggingSettings'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsResponse).
        /// Specifying the name of a property of type Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "UserAccessLoggingSettings";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the UserAccessLoggingSettingsArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^UserAccessLoggingSettingsArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^UserAccessLoggingSettingsArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.UserAccessLoggingSettingsArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-WSWUserAccessLoggingSetting (UpdateUserAccessLoggingSettings)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsResponse, UpdateWSWUserAccessLoggingSettingCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.UserAccessLoggingSettingsArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientToken = this.ClientToken;
            context.KinesisStreamArn = this.KinesisStreamArn;
            context.UserAccessLoggingSettingsArn = this.UserAccessLoggingSettingsArn;
            #if MODULAR
            if (this.UserAccessLoggingSettingsArn == null && ParameterWasBound(nameof(this.UserAccessLoggingSettingsArn)))
            {
                WriteWarning("You are passing $null as a value for parameter UserAccessLoggingSettingsArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.KinesisStreamArn != null)
            {
                request.KinesisStreamArn = cmdletContext.KinesisStreamArn;
            }
            if (cmdletContext.UserAccessLoggingSettingsArn != null)
            {
                request.UserAccessLoggingSettingsArn = cmdletContext.UserAccessLoggingSettingsArn;
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
        
        private Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsResponse CallAWSServiceOperation(IAmazonWorkSpacesWeb client, Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon WorkSpaces Web", "UpdateUserAccessLoggingSettings");
            try
            {
                #if DESKTOP
                return client.UpdateUserAccessLoggingSettings(request);
                #elif CORECLR
                return client.UpdateUserAccessLoggingSettingsAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientToken { get; set; }
            public System.String KinesisStreamArn { get; set; }
            public System.String UserAccessLoggingSettingsArn { get; set; }
            public System.Func<Amazon.WorkSpacesWeb.Model.UpdateUserAccessLoggingSettingsResponse, UpdateWSWUserAccessLoggingSettingCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.UserAccessLoggingSettings;
        }
        
    }
}
