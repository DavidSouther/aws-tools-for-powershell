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
    /// Creates a forecast for each item in the <code>TARGET_TIME_SERIES</code> dataset that
    /// was used to train the predictor. This is known as inference. To retrieve the forecast
    /// for a single item at low latency, use the operation. To export the complete forecast
    /// into your Amazon Simple Storage Service (Amazon S3) bucket, use the <a>CreateForecastExportJob</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// The range of the forecast is determined by the <code>ForecastHorizon</code> value,
    /// which you specify in the <a>CreatePredictor</a> request. When you query a forecast,
    /// you can request a specific date range within the forecast.
    /// </para><para>
    /// To get a list of all your forecasts, use the <a>ListForecasts</a> operation.
    /// </para><note><para>
    /// The forecasts generated by Amazon Forecast are in the same time zone as the dataset
    /// that was used to create the predictor.
    /// </para></note><para>
    /// For more information, see <a>howitworks-forecast</a>.
    /// </para><note><para>
    /// The <code>Status</code> of the forecast must be <code>ACTIVE</code> before you can
    /// query or export the forecast. Use the <a>DescribeForecast</a> operation to get the
    /// status.
    /// </para></note><para>
    /// By default, a forecast includes predictions for every item (<code>item_id</code>)
    /// in the dataset group that was used to train the predictor. However, you can use the
    /// <code>TimeSeriesSelector</code> object to generate a forecast on a subset of time
    /// series. Forecast creation is skipped for any time series that you specify that are
    /// not in the input dataset. The forecast export file will not contain these time series
    /// or their forecasted values.
    /// </para>
    /// </summary>
    [Cmdlet("New", "FRCForecast", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Forecast Service CreateForecast API operation.", Operation = new[] {"CreateForecast"}, SelectReturnType = typeof(Amazon.ForecastService.Model.CreateForecastResponse))]
    [AWSCmdletOutput("System.String or Amazon.ForecastService.Model.CreateForecastResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.ForecastService.Model.CreateForecastResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewFRCForecastCmdlet : AmazonForecastServiceClientCmdlet, IExecutor
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
        
        #region Parameter ForecastName
        /// <summary>
        /// <para>
        /// <para>A name for the forecast.</para>
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
        public System.String ForecastName { get; set; }
        #endregion
        
        #region Parameter ForecastType
        /// <summary>
        /// <para>
        /// <para>The quantiles at which probabilistic forecasts are generated. <b>You can currently
        /// specify up to 5 quantiles per forecast</b>. Accepted values include <code>0.01 to
        /// 0.99</code> (increments of .01 only) and <code>mean</code>. The mean forecast is different
        /// from the median (0.50) when the distribution is not symmetric (for example, Beta and
        /// Negative Binomial). </para><para>The default quantiles are the quantiles you specified during predictor creation. If
        /// you didn't specify quantiles, the default values are <code>["0.1", "0.5", "0.9"]</code>.
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ForecastTypes")]
        public System.String[] ForecastType { get; set; }
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
        /// <para>The Amazon Resource Name (ARN) of an AWS Key Management Service (KMS) key.</para>
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
        
        #region Parameter PredictorArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the predictor to use to generate the forecast.</para>
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
        public System.String PredictorArn { get; set; }
        #endregion
        
        #region Parameter S3Config_RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the AWS Identity and Access Management (IAM) role that Amazon Forecast
        /// can assume to access the Amazon S3 bucket or files. If you provide a value for the
        /// <code>KMSKeyArn</code> key, the role must allow access to the key.</para><para>Passing a role across AWS accounts is not allowed. If you pass a role that isn't in
        /// your account, you get an <code>InvalidInputException</code> error.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TimeSeriesSelector_TimeSeriesIdentifiers_DataSource_S3Config_RoleArn")]
        public System.String S3Config_RoleArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The optional metadata that you apply to the forecast to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.</para><para>The following basic restrictions apply to tags:</para><ul><li><para>Maximum number of tags per resource - 50.</para></li><li><para>For each resource, each tag key must be unique, and each tag key can have only one
        /// value.</para></li><li><para>Maximum key length - 128 Unicode characters in UTF-8.</para></li><li><para>Maximum value length - 256 Unicode characters in UTF-8.</para></li><li><para>If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.</para></li><li><para>Tag keys and values are case sensitive.</para></li><li><para>Do not use <code>aws:</code>, <code>AWS:</code>, or any upper or lowercase combination
        /// of such as a prefix for keys as it is reserved for AWS use. You cannot edit or delete
        /// tag keys with this prefix. Values can have this prefix. If a tag value has <code>aws</code>
        /// as its prefix but the key does not, then Forecast considers it to be a user tag and
        /// will count against the limit of 50 tags. Tags with only the key prefix of <code>aws</code>
        /// do not count against your tags per resource limit.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.ForecastService.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ForecastArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ForecastService.Model.CreateForecastResponse).
        /// Specifying the name of a property of type Amazon.ForecastService.Model.CreateForecastResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ForecastArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the PredictorArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^PredictorArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^PredictorArn' instead. This parameter will be removed in a future version.")]
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
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ForecastName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-FRCForecast (CreateForecast)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ForecastService.Model.CreateForecastResponse, NewFRCForecastCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.PredictorArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ForecastName = this.ForecastName;
            #if MODULAR
            if (this.ForecastName == null && ParameterWasBound(nameof(this.ForecastName)))
            {
                WriteWarning("You are passing $null as a value for parameter ForecastName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.ForecastType != null)
            {
                context.ForecastType = new List<System.String>(this.ForecastType);
            }
            context.PredictorArn = this.PredictorArn;
            #if MODULAR
            if (this.PredictorArn == null && ParameterWasBound(nameof(this.PredictorArn)))
            {
                WriteWarning("You are passing $null as a value for parameter PredictorArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ForecastService.Model.CreateForecastRequest();
            
            if (cmdletContext.ForecastName != null)
            {
                request.ForecastName = cmdletContext.ForecastName;
            }
            if (cmdletContext.ForecastType != null)
            {
                request.ForecastTypes = cmdletContext.ForecastType;
            }
            if (cmdletContext.PredictorArn != null)
            {
                request.PredictorArn = cmdletContext.PredictorArn;
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
        
        private Amazon.ForecastService.Model.CreateForecastResponse CallAWSServiceOperation(IAmazonForecastService client, Amazon.ForecastService.Model.CreateForecastRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Forecast Service", "CreateForecast");
            try
            {
                #if DESKTOP
                return client.CreateForecast(request);
                #elif CORECLR
                return client.CreateForecastAsync(request).GetAwaiter().GetResult();
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
            public System.String ForecastName { get; set; }
            public List<System.String> ForecastType { get; set; }
            public System.String PredictorArn { get; set; }
            public List<Amazon.ForecastService.Model.Tag> Tag { get; set; }
            public System.String S3Config_KMSKeyArn { get; set; }
            public System.String S3Config_Path { get; set; }
            public System.String S3Config_RoleArn { get; set; }
            public System.String TimeSeriesIdentifiers_Format { get; set; }
            public List<Amazon.ForecastService.Model.SchemaAttribute> Schema_Attribute { get; set; }
            public System.Func<Amazon.ForecastService.Model.CreateForecastResponse, NewFRCForecastCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ForecastArn;
        }
        
    }
}
