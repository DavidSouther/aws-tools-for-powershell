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
using Amazon.MigrationHubConfig;
using Amazon.MigrationHubConfig.Model;

namespace Amazon.PowerShell.Cmdlets.MHC
{
    /// <summary>
    /// This API permits filtering on the <c>ControlId</c> and <c>HomeRegion</c> fields.<br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "MHCHomeRegionControl")]
    [OutputType("Amazon.MigrationHubConfig.Model.HomeRegionControl")]
    [AWSCmdlet("Calls the AWS Migration Hub Config DescribeHomeRegionControls API operation.", Operation = new[] {"DescribeHomeRegionControls"}, SelectReturnType = typeof(Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsResponse))]
    [AWSCmdletOutput("Amazon.MigrationHubConfig.Model.HomeRegionControl or Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsResponse",
        "This cmdlet returns a collection of Amazon.MigrationHubConfig.Model.HomeRegionControl objects.",
        "The service call response (type Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsResponse) can be returned by specifying '-Select *'."
    )]
    public partial class GetMHCHomeRegionControlCmdlet : AmazonMigrationHubConfigClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter ControlId
        /// <summary>
        /// <para>
        /// <para>The <c>ControlID</c> is a unique identifier string of your <c>HomeRegionControl</c>
        /// object.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ControlId { get; set; }
        #endregion
        
        #region Parameter HomeRegion
        /// <summary>
        /// <para>
        /// <para>The name of the home region you'd like to view.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String HomeRegion { get; set; }
        #endregion
        
        #region Parameter Target_Id
        /// <summary>
        /// <para>
        /// <para>The <c>TargetID</c> is a 12-character identifier of the <c>ACCOUNT</c> for which the
        /// control was created. (This must be the current account.) </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Target_Id { get; set; }
        #endregion
        
        #region Parameter Target_Type
        /// <summary>
        /// <para>
        /// <para>The target type is always an <c>ACCOUNT</c>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.MigrationHubConfig.TargetType")]
        public Amazon.MigrationHubConfig.TargetType Target_Type { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of filtering results to display per page. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>If a <c>NextToken</c> was returned by a previous call, more results are available.
        /// To retrieve the next page of results, make the call again using the returned token
        /// in <c>NextToken</c>.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> This parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>'NextToken' is only returned by the cmdlet when '-Select *' is specified. In order to manually control output pagination, set '-NextToken' to null for the first call then set the 'NextToken' using the same property output from the previous call for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'HomeRegionControls'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsResponse).
        /// Specifying the name of a property of type Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "HomeRegionControls";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the HomeRegion parameter.
        /// The -PassThru parameter is deprecated, use -Select '^HomeRegion' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^HomeRegion' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter NoAutoIteration
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
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
                context.Select = CreateSelectDelegate<Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsResponse, GetMHCHomeRegionControlCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.HomeRegion;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ControlId = this.ControlId;
            context.HomeRegion = this.HomeRegion;
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            context.Target_Id = this.Target_Id;
            context.Target_Type = this.Target_Type;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            
            // create request and set iteration invariants
            var request = new Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsRequest();
            
            if (cmdletContext.ControlId != null)
            {
                request.ControlId = cmdletContext.ControlId;
            }
            if (cmdletContext.HomeRegion != null)
            {
                request.HomeRegion = cmdletContext.HomeRegion;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            
             // populate Target
            var requestTargetIsNull = true;
            request.Target = new Amazon.MigrationHubConfig.Model.Target();
            System.String requestTarget_target_Id = null;
            if (cmdletContext.Target_Id != null)
            {
                requestTarget_target_Id = cmdletContext.Target_Id;
            }
            if (requestTarget_target_Id != null)
            {
                request.Target.Id = requestTarget_target_Id;
                requestTargetIsNull = false;
            }
            Amazon.MigrationHubConfig.TargetType requestTarget_target_Type = null;
            if (cmdletContext.Target_Type != null)
            {
                requestTarget_target_Type = cmdletContext.Target_Type;
            }
            if (requestTarget_target_Type != null)
            {
                request.Target.Type = requestTarget_target_Type;
                requestTargetIsNull = false;
            }
             // determine if request.Target should be set to null
            if (requestTargetIsNull)
            {
                request.Target = null;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.NextToken;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    
                    _nextToken = response.NextToken;
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                ProcessOutput(output);
                
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken));
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsResponse CallAWSServiceOperation(IAmazonMigrationHubConfig client, Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Migration Hub Config", "DescribeHomeRegionControls");
            try
            {
                #if DESKTOP
                return client.DescribeHomeRegionControls(request);
                #elif CORECLR
                return client.DescribeHomeRegionControlsAsync(request).GetAwaiter().GetResult();
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
            public System.String ControlId { get; set; }
            public System.String HomeRegion { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.String Target_Id { get; set; }
            public Amazon.MigrationHubConfig.TargetType Target_Type { get; set; }
            public System.Func<Amazon.MigrationHubConfig.Model.DescribeHomeRegionControlsResponse, GetMHCHomeRegionControlCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.HomeRegionControls;
        }
        
    }
}
