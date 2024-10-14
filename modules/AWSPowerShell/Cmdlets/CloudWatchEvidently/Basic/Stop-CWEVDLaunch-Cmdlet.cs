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
using Amazon.CloudWatchEvidently;
using Amazon.CloudWatchEvidently.Model;

namespace Amazon.PowerShell.Cmdlets.CWEVD
{
    /// <summary>
    /// Stops a launch that is currently running. After you stop a launch, you will not be
    /// able to resume it or restart it. Also, it will not be evaluated as a rule for traffic
    /// allocation, and the traffic that was allocated to the launch will instead be available
    /// to the feature's experiment, if there is one. Otherwise, all traffic will be served
    /// the default variation after the launch is stopped.
    /// </summary>
    [Cmdlet("Stop", "CWEVDLaunch", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.CloudWatchEvidently.Model.StopLaunchResponse")]
    [AWSCmdlet("Calls the Amazon CloudWatch Evidently StopLaunch API operation.", Operation = new[] {"StopLaunch"}, SelectReturnType = typeof(Amazon.CloudWatchEvidently.Model.StopLaunchResponse))]
    [AWSCmdletOutput("Amazon.CloudWatchEvidently.Model.StopLaunchResponse",
        "This cmdlet returns an Amazon.CloudWatchEvidently.Model.StopLaunchResponse object containing multiple properties."
    )]
    public partial class StopCWEVDLaunchCmdlet : AmazonCloudWatchEvidentlyClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter DesiredState
        /// <summary>
        /// <para>
        /// <para>Specify whether to consider the launch as <c>COMPLETED</c> or <c>CANCELLED</c> after
        /// it stops.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.CloudWatchEvidently.LaunchStopDesiredState")]
        public Amazon.CloudWatchEvidently.LaunchStopDesiredState DesiredState { get; set; }
        #endregion
        
        #region Parameter Launch
        /// <summary>
        /// <para>
        /// <para>The name of the launch to stop.</para>
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
        public System.String Launch { get; set; }
        #endregion
        
        #region Parameter Project
        /// <summary>
        /// <para>
        /// <para>The name or ARN of the project that contains the launch that you want to stop.</para>
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
        public System.String Project { get; set; }
        #endregion
        
        #region Parameter Reason
        /// <summary>
        /// <para>
        /// <para>A string that describes why you are stopping the launch.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Reason { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.CloudWatchEvidently.Model.StopLaunchResponse).
        /// Specifying the name of a property of type Amazon.CloudWatchEvidently.Model.StopLaunchResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Launch), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Stop-CWEVDLaunch (StopLaunch)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.CloudWatchEvidently.Model.StopLaunchResponse, StopCWEVDLaunchCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.DesiredState = this.DesiredState;
            context.Launch = this.Launch;
            #if MODULAR
            if (this.Launch == null && ParameterWasBound(nameof(this.Launch)))
            {
                WriteWarning("You are passing $null as a value for parameter Launch which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Project = this.Project;
            #if MODULAR
            if (this.Project == null && ParameterWasBound(nameof(this.Project)))
            {
                WriteWarning("You are passing $null as a value for parameter Project which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Reason = this.Reason;
            
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
            var request = new Amazon.CloudWatchEvidently.Model.StopLaunchRequest();
            
            if (cmdletContext.DesiredState != null)
            {
                request.DesiredState = cmdletContext.DesiredState;
            }
            if (cmdletContext.Launch != null)
            {
                request.Launch = cmdletContext.Launch;
            }
            if (cmdletContext.Project != null)
            {
                request.Project = cmdletContext.Project;
            }
            if (cmdletContext.Reason != null)
            {
                request.Reason = cmdletContext.Reason;
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
        
        private Amazon.CloudWatchEvidently.Model.StopLaunchResponse CallAWSServiceOperation(IAmazonCloudWatchEvidently client, Amazon.CloudWatchEvidently.Model.StopLaunchRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon CloudWatch Evidently", "StopLaunch");
            try
            {
                #if DESKTOP
                return client.StopLaunch(request);
                #elif CORECLR
                return client.StopLaunchAsync(request).GetAwaiter().GetResult();
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
            public Amazon.CloudWatchEvidently.LaunchStopDesiredState DesiredState { get; set; }
            public System.String Launch { get; set; }
            public System.String Project { get; set; }
            public System.String Reason { get; set; }
            public System.Func<Amazon.CloudWatchEvidently.Model.StopLaunchResponse, StopCWEVDLaunchCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
