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
using Amazon.Comprehend;
using Amazon.Comprehend.Model;

namespace Amazon.PowerShell.Cmdlets.COMP
{
    /// <summary>
    /// Inspects text for syntax and the part of speech of words in the document. For more
    /// information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-syntax.html">Syntax</a>
    /// in the Comprehend Developer Guide.
    /// </summary>
    [Cmdlet("Find", "COMPSyntax")]
    [OutputType("Amazon.Comprehend.Model.SyntaxToken")]
    [AWSCmdlet("Calls the Amazon Comprehend DetectSyntax API operation.", Operation = new[] {"DetectSyntax"}, SelectReturnType = typeof(Amazon.Comprehend.Model.DetectSyntaxResponse))]
    [AWSCmdletOutput("Amazon.Comprehend.Model.SyntaxToken or Amazon.Comprehend.Model.DetectSyntaxResponse",
        "This cmdlet returns a collection of Amazon.Comprehend.Model.SyntaxToken objects.",
        "The service call response (type Amazon.Comprehend.Model.DetectSyntaxResponse) can be returned by specifying '-Select *'."
    )]
    public partial class FindCOMPSyntaxCmdlet : AmazonComprehendClientCmdlet, IExecutor
    {
        
        protected override bool IsSensitiveRequest { get; set; } = true;
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter LanguageCode
        /// <summary>
        /// <para>
        /// <para>The language code of the input documents. You can specify any of the following languages
        /// supported by Amazon Comprehend: German ("de"), English ("en"), Spanish ("es"), French
        /// ("fr"), Italian ("it"), or Portuguese ("pt").</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Comprehend.SyntaxLanguageCode")]
        public Amazon.Comprehend.SyntaxLanguageCode LanguageCode { get; set; }
        #endregion
        
        #region Parameter Text
        /// <summary>
        /// <para>
        /// <para>A UTF-8 string. The maximum string size is 5 KB.</para>
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
        public System.String Text { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'SyntaxTokens'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Comprehend.Model.DetectSyntaxResponse).
        /// Specifying the name of a property of type Amazon.Comprehend.Model.DetectSyntaxResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "SyntaxTokens";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Text parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Text' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Text' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Comprehend.Model.DetectSyntaxResponse, FindCOMPSyntaxCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Text;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.LanguageCode = this.LanguageCode;
            #if MODULAR
            if (this.LanguageCode == null && ParameterWasBound(nameof(this.LanguageCode)))
            {
                WriteWarning("You are passing $null as a value for parameter LanguageCode which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Text = this.Text;
            #if MODULAR
            if (this.Text == null && ParameterWasBound(nameof(this.Text)))
            {
                WriteWarning("You are passing $null as a value for parameter Text which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.Comprehend.Model.DetectSyntaxRequest();
            
            if (cmdletContext.LanguageCode != null)
            {
                request.LanguageCode = cmdletContext.LanguageCode;
            }
            if (cmdletContext.Text != null)
            {
                request.Text = cmdletContext.Text;
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
        
        private Amazon.Comprehend.Model.DetectSyntaxResponse CallAWSServiceOperation(IAmazonComprehend client, Amazon.Comprehend.Model.DetectSyntaxRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Comprehend", "DetectSyntax");
            try
            {
                #if DESKTOP
                return client.DetectSyntax(request);
                #elif CORECLR
                return client.DetectSyntaxAsync(request).GetAwaiter().GetResult();
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
            public Amazon.Comprehend.SyntaxLanguageCode LanguageCode { get; set; }
            public System.String Text { get; set; }
            public System.Func<Amazon.Comprehend.Model.DetectSyntaxResponse, FindCOMPSyntaxCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.SyntaxTokens;
        }
        
    }
}
