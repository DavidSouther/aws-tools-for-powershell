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
using Amazon.EC2;
using Amazon.EC2.Model;

namespace Amazon.PowerShell.Cmdlets.EC2
{
    /// <summary>
    /// Starts analyzing the specified Network Access Scope.
    /// </summary>
    [Cmdlet("Start", "EC2NetworkInsightsAccessScopeAnalysis", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.EC2.Model.NetworkInsightsAccessScopeAnalysis")]
    [AWSCmdlet("Calls the Amazon Elastic Compute Cloud (EC2) StartNetworkInsightsAccessScopeAnalysis API operation.", Operation = new[] {"StartNetworkInsightsAccessScopeAnalysis"}, SelectReturnType = typeof(Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisResponse))]
    [AWSCmdletOutput("Amazon.EC2.Model.NetworkInsightsAccessScopeAnalysis or Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisResponse",
        "This cmdlet returns an Amazon.EC2.Model.NetworkInsightsAccessScopeAnalysis object.",
        "The service call response (type Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisResponse) can be returned by specifying '-Select *'."
    )]
    public partial class StartEC2NetworkInsightsAccessScopeAnalysisCmdlet : AmazonEC2ClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter NetworkInsightsAccessScopeId
        /// <summary>
        /// <para>
        /// <para>The ID of the Network Access Scope.</para>
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
        public System.String NetworkInsightsAccessScopeId { get; set; }
        #endregion
        
        #region Parameter TagSpecification
        /// <summary>
        /// <para>
        /// <para>The tags to apply.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TagSpecifications")]
        public Amazon.EC2.Model.TagSpecification[] TagSpecification { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'NetworkInsightsAccessScopeAnalysis'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisResponse).
        /// Specifying the name of a property of type Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "NetworkInsightsAccessScopeAnalysis";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the NetworkInsightsAccessScopeId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^NetworkInsightsAccessScopeId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^NetworkInsightsAccessScopeId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.NetworkInsightsAccessScopeId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Start-EC2NetworkInsightsAccessScopeAnalysis (StartNetworkInsightsAccessScopeAnalysis)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisResponse, StartEC2NetworkInsightsAccessScopeAnalysisCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.NetworkInsightsAccessScopeId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientToken = this.ClientToken;
            context.NetworkInsightsAccessScopeId = this.NetworkInsightsAccessScopeId;
            #if MODULAR
            if (this.NetworkInsightsAccessScopeId == null && ParameterWasBound(nameof(this.NetworkInsightsAccessScopeId)))
            {
                WriteWarning("You are passing $null as a value for parameter NetworkInsightsAccessScopeId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.TagSpecification != null)
            {
                context.TagSpecification = new List<Amazon.EC2.Model.TagSpecification>(this.TagSpecification);
            }
            
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
            var request = new Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.NetworkInsightsAccessScopeId != null)
            {
                request.NetworkInsightsAccessScopeId = cmdletContext.NetworkInsightsAccessScopeId;
            }
            if (cmdletContext.TagSpecification != null)
            {
                request.TagSpecifications = cmdletContext.TagSpecification;
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
        
        private Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisResponse CallAWSServiceOperation(IAmazonEC2 client, Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Elastic Compute Cloud (EC2)", "StartNetworkInsightsAccessScopeAnalysis");
            try
            {
                #if DESKTOP
                return client.StartNetworkInsightsAccessScopeAnalysis(request);
                #elif CORECLR
                return client.StartNetworkInsightsAccessScopeAnalysisAsync(request).GetAwaiter().GetResult();
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
            public System.String NetworkInsightsAccessScopeId { get; set; }
            public List<Amazon.EC2.Model.TagSpecification> TagSpecification { get; set; }
            public System.Func<Amazon.EC2.Model.StartNetworkInsightsAccessScopeAnalysisResponse, StartEC2NetworkInsightsAccessScopeAnalysisCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.NetworkInsightsAccessScopeAnalysis;
        }
        
    }
}
