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
using Amazon.ForecastService;
using Amazon.ForecastService.Model;

namespace Amazon.PowerShell.Cmdlets.FRC
{
    /// <summary>
    /// What-if analysis is a scenario modeling technique where you make a hypothetical change
    /// to a time series and compare the forecasts generated by these changes against the
    /// baseline, unchanged time series. It is important to remember that the purpose of a
    /// what-if analysis is to understand how a forecast can change given different modifications
    /// to the baseline time series.
    /// 
    ///  
    /// <para>
    /// For example, imagine you are a clothing retailer who is considering an end of season
    /// sale to clear space for new styles. After creating a baseline forecast, you can use
    /// a what-if analysis to investigate how different sales tactics might affect your goals.
    /// </para><para>
    /// You could create a scenario where everything is given a 25% markdown, and another
    /// where everything is given a fixed dollar markdown. You could create a scenario where
    /// the sale lasts for one week and another where the sale lasts for one month. With a
    /// what-if analysis, you can compare many different scenarios against each other.
    /// </para><para>
    /// Note that a what-if analysis is meant to display what the forecasting model has learned
    /// and how it will behave in the scenarios that you are evaluating. Do not blindly use
    /// the results of the what-if analysis to make business decisions. For instance, forecasts
    /// might not be accurate for novel scenarios where there is no reference available to
    /// determine whether a forecast is good.
    /// </para><para>
    /// The <a>TimeSeriesSelector</a> object defines the items that you want in the what-if
    /// analysis.
    /// </para>
    /// </summary>
    [Cmdlet("New", "FRCWhatIfAnalysis", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Forecast Service CreateWhatIfAnalysis API operation.", Operation = new[] {"CreateWhatIfAnalysis"}, SelectReturnType = typeof(Amazon.ForecastService.Model.CreateWhatIfAnalysisResponse))]
    [AWSCmdletOutput("System.String or Amazon.ForecastService.Model.CreateWhatIfAnalysisResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.ForecastService.Model.CreateWhatIfAnalysisResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewFRCWhatIfAnalysisCmdlet : AmazonForecastServiceClientCmdlet, IExecutor
    {
        
        #region Parameter Schema_Attribute
        /// <summary>
        /// <para>
        /// <para>An array of attributes specifying the name and type of each field in a dataset.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TimeSeriesSelector_TimeSeriesIdentifiers_Schema_Attributes")]
        public Amazon.ForecastService.Model.SchemaAttribute[] Schema_Attribute { get; set; }
        #endregion
        
        #region Parameter ForecastArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the baseline forecast.</para>
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
        public System.String ForecastArn { get; set; }
        #endregion
        
        #region Parameter TimeSeriesIdentifiers_Format
        /// <summary>
        /// <para>
        /// <para>The format of the data, either CSV or PARQUET.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TimeSeriesSelector_TimeSeriesIdentifiers_Format")]
        public System.String TimeSeriesIdentifiers_Format { get; set; }
        #endregion
        
        #region Parameter S3Config_KMSKeyArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of an Key Management Service (KMS) key.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TimeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_KMSKeyArn")]
        public System.String S3Config_KMSKeyArn { get; set; }
        #endregion
        
        #region Parameter S3Config_Path
        /// <summary>
        /// <para>
        /// <para>The path to an Amazon Simple Storage Service (Amazon S3) bucket or file(s) in an Amazon
        /// S3 bucket.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TimeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_Path")]
        public System.String S3Config_Path { get; set; }
        #endregion
        
        #region Parameter S3Config_RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the Identity and Access Management (IAM) role that Amazon Forecast can
        /// assume to access the Amazon S3 bucket or files. If you provide a value for the <code>KMSKeyArn</code>
        /// key, the role must allow access to the key.</para><para>Passing a role across Amazon Web Services accounts is not allowed. If you pass a role
        /// that isn't in your account, you get an <code>InvalidInputException</code> error.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TimeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_RoleArn")]
        public System.String S3Config_RoleArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>A list of <a href="https://docs.aws.amazon.com/forecast/latest/dg/tagging-forecast-resources.html">tags</a>
        /// to apply to the what if forecast.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.ForecastService.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter WhatIfAnalysisName
        /// <summary>
        /// <para>
        /// <para>The name of the what-if analysis. Each name must be unique.</para>
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
        public System.String WhatIfAnalysisName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'WhatIfAnalysisArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ForecastService.Model.CreateWhatIfAnalysisResponse).
        /// Specifying the name of a property of type Amazon.ForecastService.Model.CreateWhatIfAnalysisResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "WhatIfAnalysisArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the WhatIfAnalysisName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^WhatIfAnalysisName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^WhatIfAnalysisName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.WhatIfAnalysisName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-FRCWhatIfAnalysis (CreateWhatIfAnalysis)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ForecastService.Model.CreateWhatIfAnalysisResponse, NewFRCWhatIfAnalysisCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.WhatIfAnalysisName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ForecastArn = this.ForecastArn;
            #if MODULAR
            if (this.ForecastArn == null && ParameterWasBound(nameof(this.ForecastArn)))
            {
                WriteWarning("You are passing $null as a value for parameter ForecastArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.ForecastService.Model.Tag>(this.Tag);
            }
            context.S3Config_KMSKeyArn = this.S3Config_KMSKeyArn;
            context.S3Config_Path = this.S3Config_Path;
            context.S3Config_RoleArn = this.S3Config_RoleArn;
            context.TimeSeriesIdentifiers_Format = this.TimeSeriesIdentifiers_Format;
            if (this.Schema_Attribute != null)
            {
                context.Schema_Attribute = new List<Amazon.ForecastService.Model.SchemaAttribute>(this.Schema_Attribute);
            }
            context.WhatIfAnalysisName = this.WhatIfAnalysisName;
            #if MODULAR
            if (this.WhatIfAnalysisName == null && ParameterWasBound(nameof(this.WhatIfAnalysisName)))
            {
                WriteWarning("You are passing $null as a value for parameter WhatIfAnalysisName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ForecastService.Model.CreateWhatIfAnalysisRequest();
            
            if (cmdletContext.ForecastArn != null)
            {
                request.ForecastArn = cmdletContext.ForecastArn;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            
             // populate TimeSeriesSelector
            var requestTimeSeriesSelectorIsNull = true;
            request.TimeSeriesSelector = new Amazon.ForecastService.Model.TimeSeriesSelector();
            Amazon.ForecastService.Model.TimeSeriesIdentifiers requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers = null;
            
             // populate TimeSeriesIdentifiers
            var requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiersIsNull = true;
            requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers = new Amazon.ForecastService.Model.TimeSeriesIdentifiers();
            System.String requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesIdentifiers_Format = null;
            if (cmdletContext.TimeSeriesIdentifiers_Format != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesIdentifiers_Format = cmdletContext.TimeSeriesIdentifiers_Format;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesIdentifiers_Format != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers.Format = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesIdentifiers_Format;
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiersIsNull = false;
            }
            Amazon.ForecastService.Model.DataSource requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource = null;
            
             // populate DataSource
            var requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSourceIsNull = true;
            requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource = new Amazon.ForecastService.Model.DataSource();
            Amazon.ForecastService.Model.S3Config requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config = null;
            
             // populate S3Config
            var requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3ConfigIsNull = true;
            requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config = new Amazon.ForecastService.Model.S3Config();
            System.String requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_KMSKeyArn = null;
            if (cmdletContext.S3Config_KMSKeyArn != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_KMSKeyArn = cmdletContext.S3Config_KMSKeyArn;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_KMSKeyArn != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config.KMSKeyArn = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_KMSKeyArn;
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3ConfigIsNull = false;
            }
            System.String requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_Path = null;
            if (cmdletContext.S3Config_Path != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_Path = cmdletContext.S3Config_Path;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_Path != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config.Path = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_Path;
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3ConfigIsNull = false;
            }
            System.String requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_RoleArn = null;
            if (cmdletContext.S3Config_RoleArn != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_RoleArn = cmdletContext.S3Config_RoleArn;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_RoleArn != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config.RoleArn = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_s3Config_RoleArn;
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3ConfigIsNull = false;
            }
             // determine if requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config should be set to null
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3ConfigIsNull)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config = null;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource.S3Config = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_timeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config;
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSourceIsNull = false;
            }
             // determine if requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource should be set to null
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSourceIsNull)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource = null;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers.DataSource = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_DataSource;
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiersIsNull = false;
            }
            Amazon.ForecastService.Model.Schema requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema = null;
            
             // populate Schema
            var requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_SchemaIsNull = true;
            requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema = new Amazon.ForecastService.Model.Schema();
            List<Amazon.ForecastService.Model.SchemaAttribute> requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema_schema_Attribute = null;
            if (cmdletContext.Schema_Attribute != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema_schema_Attribute = cmdletContext.Schema_Attribute;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema_schema_Attribute != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema.Attributes = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema_schema_Attribute;
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_SchemaIsNull = false;
            }
             // determine if requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema should be set to null
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_SchemaIsNull)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema = null;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema != null)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers.Schema = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers_timeSeriesSelector_TimeSeriesIdentifiers_Schema;
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiersIsNull = false;
            }
             // determine if requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers should be set to null
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiersIsNull)
            {
                requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers = null;
            }
            if (requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers != null)
            {
                request.TimeSeriesSelector.TimeSeriesIdentifiers = requestTimeSeriesSelector_timeSeriesSelector_TimeSeriesIdentifiers;
                requestTimeSeriesSelectorIsNull = false;
            }
             // determine if request.TimeSeriesSelector should be set to null
            if (requestTimeSeriesSelectorIsNull)
            {
                request.TimeSeriesSelector = null;
            }
            if (cmdletContext.WhatIfAnalysisName != null)
            {
                request.WhatIfAnalysisName = cmdletContext.WhatIfAnalysisName;
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
        
        private Amazon.ForecastService.Model.CreateWhatIfAnalysisResponse CallAWSServiceOperation(IAmazonForecastService client, Amazon.ForecastService.Model.CreateWhatIfAnalysisRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Forecast Service", "CreateWhatIfAnalysis");
            try
            {
                #if DESKTOP
                return client.CreateWhatIfAnalysis(request);
                #elif CORECLR
                return client.CreateWhatIfAnalysisAsync(request).GetAwaiter().GetResult();
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
            public System.String ForecastArn { get; set; }
            public List<Amazon.ForecastService.Model.Tag> Tag { get; set; }
            public System.String S3Config_KMSKeyArn { get; set; }
            public System.String S3Config_Path { get; set; }
            public System.String S3Config_RoleArn { get; set; }
            public System.String TimeSeriesIdentifiers_Format { get; set; }
            public List<Amazon.ForecastService.Model.SchemaAttribute> Schema_Attribute { get; set; }
            public System.String WhatIfAnalysisName { get; set; }
            public System.Func<Amazon.ForecastService.Model.CreateWhatIfAnalysisResponse, NewFRCWhatIfAnalysisCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.WhatIfAnalysisArn;
        }
        
    }
}
