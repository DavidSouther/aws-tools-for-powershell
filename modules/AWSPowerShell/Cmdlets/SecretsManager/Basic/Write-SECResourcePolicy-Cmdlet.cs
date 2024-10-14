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
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

namespace Amazon.PowerShell.Cmdlets.SEC
{
    /// <summary>
    /// Attaches a resource-based permission policy to a secret. A resource-based policy is
    /// optional. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control for Secrets Manager</a><para>
    /// For information about attaching a policy in the console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_resource-based-policies.html">Attach
    /// a permissions policy to a secret</a>.
    /// </para><para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters because it might be logged. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>.
    /// </para><para><b>Required permissions: </b><c>secretsmanager:PutResourcePolicy</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    [Cmdlet("Write", "SECResourcePolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.SecretsManager.Model.PutResourcePolicyResponse")]
    [AWSCmdlet("Calls the AWS Secrets Manager PutResourcePolicy API operation.", Operation = new[] {"PutResourcePolicy"}, SelectReturnType = typeof(Amazon.SecretsManager.Model.PutResourcePolicyResponse))]
    [AWSCmdletOutput("Amazon.SecretsManager.Model.PutResourcePolicyResponse",
        "This cmdlet returns an Amazon.SecretsManager.Model.PutResourcePolicyResponse object containing multiple properties."
    )]
    public partial class WriteSECResourcePolicyCmdlet : AmazonSecretsManagerClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter BlockPublicPolicy
        /// <summary>
        /// <para>
        /// <para>Specifies whether to block resource-based policies that allow broad access to the
        /// secret, for example those that use a wildcard for the principal. By default, public
        /// policies aren't blocked.</para><important><para>Resource policy validation and the BlockPublicPolicy parameter help protect your resources
        /// by preventing public access from being granted through the resource policies that
        /// are directly attached to your secrets. In addition to using these features, carefully
        /// inspect the following policies to confirm that they do not grant public access:</para><ul><li><para>Identity-based policies attached to associated Amazon Web Services principals (for
        /// example, IAM roles)</para></li><li><para>Resource-based policies attached to associated Amazon Web Services resources (for
        /// example, Key Management Service (KMS) keys)</para></li></ul><para>To review permissions to your secrets, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/determine-acccess_examine-iam-policies.html">Determine
        /// who has permissions to your secrets</a>.</para></important>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? BlockPublicPolicy { get; set; }
        #endregion
        
        #region Parameter ResourcePolicy
        /// <summary>
        /// <para>
        /// <para>A JSON-formatted string for an Amazon Web Services resource-based policy. For example
        /// policies, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_examples.html">Permissions
        /// policy examples</a>.</para>
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
        public System.String ResourcePolicy { get; set; }
        #endregion
        
        #region Parameter SecretId
        /// <summary>
        /// <para>
        /// <para>The ARN or name of the secret to attach the resource-based policy.</para><para>For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
        /// See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot.html#ARN_secretnamehyphen">Finding
        /// a secret from a partial ARN</a>.</para>
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
        public System.String SecretId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SecretsManager.Model.PutResourcePolicyResponse).
        /// Specifying the name of a property of type Amazon.SecretsManager.Model.PutResourcePolicyResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ResourcePolicy parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ResourcePolicy' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ResourcePolicy' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.SecretId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Write-SECResourcePolicy (PutResourcePolicy)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SecretsManager.Model.PutResourcePolicyResponse, WriteSECResourcePolicyCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ResourcePolicy;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.BlockPublicPolicy = this.BlockPublicPolicy;
            context.ResourcePolicy = this.ResourcePolicy;
            #if MODULAR
            if (this.ResourcePolicy == null && ParameterWasBound(nameof(this.ResourcePolicy)))
            {
                WriteWarning("You are passing $null as a value for parameter ResourcePolicy which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SecretId = this.SecretId;
            #if MODULAR
            if (this.SecretId == null && ParameterWasBound(nameof(this.SecretId)))
            {
                WriteWarning("You are passing $null as a value for parameter SecretId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.SecretsManager.Model.PutResourcePolicyRequest();
            
            if (cmdletContext.BlockPublicPolicy != null)
            {
                request.BlockPublicPolicy = cmdletContext.BlockPublicPolicy.Value;
            }
            if (cmdletContext.ResourcePolicy != null)
            {
                request.ResourcePolicy = cmdletContext.ResourcePolicy;
            }
            if (cmdletContext.SecretId != null)
            {
                request.SecretId = cmdletContext.SecretId;
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
        
        private Amazon.SecretsManager.Model.PutResourcePolicyResponse CallAWSServiceOperation(IAmazonSecretsManager client, Amazon.SecretsManager.Model.PutResourcePolicyRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Secrets Manager", "PutResourcePolicy");
            try
            {
                #if DESKTOP
                return client.PutResourcePolicy(request);
                #elif CORECLR
                return client.PutResourcePolicyAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? BlockPublicPolicy { get; set; }
            public System.String ResourcePolicy { get; set; }
            public System.String SecretId { get; set; }
            public System.Func<Amazon.SecretsManager.Model.PutResourcePolicyResponse, WriteSECResourcePolicyCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
