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
using Amazon.IVSRealTime;
using Amazon.IVSRealTime.Model;

namespace Amazon.PowerShell.Cmdlets.IVSRT
{
    /// <summary>
    /// Creates an EncoderConfiguration object.
    /// </summary>
    [Cmdlet("New", "IVSRTEncoderConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.IVSRealTime.Model.EncoderConfiguration")]
    [AWSCmdlet("Calls the Amazon Interactive Video Service RealTime CreateEncoderConfiguration API operation.", Operation = new[] {"CreateEncoderConfiguration"}, SelectReturnType = typeof(Amazon.IVSRealTime.Model.CreateEncoderConfigurationResponse))]
    [AWSCmdletOutput("Amazon.IVSRealTime.Model.EncoderConfiguration or Amazon.IVSRealTime.Model.CreateEncoderConfigurationResponse",
        "This cmdlet returns an Amazon.IVSRealTime.Model.EncoderConfiguration object.",
        "The service call response (type Amazon.IVSRealTime.Model.CreateEncoderConfigurationResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewIVSRTEncoderConfigurationCmdlet : AmazonIVSRealTimeClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter Video_Bitrate
        /// <summary>
        /// <para>
        /// <para>Bitrate for generated output, in bps. Default: 2500000.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Video_Bitrate { get; set; }
        #endregion
        
        #region Parameter Video_Framerate
        /// <summary>
        /// <para>
        /// <para>Video frame rate, in fps. Default: 30.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Single? Video_Framerate { get; set; }
        #endregion
        
        #region Parameter Video_Height
        /// <summary>
        /// <para>
        /// <para>Video-resolution height. Note that the maximum value is determined by <code>width</code>
        /// times <code>height</code>, such that the maximum total pixels is 2073600 (1920x1080
        /// or 1080x1920). Default: 720.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Video_Height { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>Optional name to identify the resource.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Tags attached to the resource. Array of maps, each of the form <code>string:string
        /// (key:value)</code>. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> for details, including restrictions that apply to tags and "Tag
        /// naming limits and requirements"; Amazon IVS has no constraints on tags beyond what
        /// is documented there.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter Video_Width
        /// <summary>
        /// <para>
        /// <para>Video-resolution width. Note that the maximum value is determined by <code>width</code>
        /// times <code>height</code>, such that the maximum total pixels is 2073600 (1920x1080
        /// or 1080x1920). Default: 1280.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Video_Width { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'EncoderConfiguration'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IVSRealTime.Model.CreateEncoderConfigurationResponse).
        /// Specifying the name of a property of type Amazon.IVSRealTime.Model.CreateEncoderConfigurationResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "EncoderConfiguration";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-IVSRTEncoderConfiguration (CreateEncoderConfiguration)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IVSRealTime.Model.CreateEncoderConfigurationResponse, NewIVSRTEncoderConfigurationCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Name = this.Name;
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            context.Video_Bitrate = this.Video_Bitrate;
            context.Video_Framerate = this.Video_Framerate;
            context.Video_Height = this.Video_Height;
            context.Video_Width = this.Video_Width;
            
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
            var request = new Amazon.IVSRealTime.Model.CreateEncoderConfigurationRequest();
            
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            
             // populate Video
            var requestVideoIsNull = true;
            request.Video = new Amazon.IVSRealTime.Model.Video();
            System.Int32? requestVideo_video_Bitrate = null;
            if (cmdletContext.Video_Bitrate != null)
            {
                requestVideo_video_Bitrate = cmdletContext.Video_Bitrate.Value;
            }
            if (requestVideo_video_Bitrate != null)
            {
                request.Video.Bitrate = requestVideo_video_Bitrate.Value;
                requestVideoIsNull = false;
            }
            System.Single? requestVideo_video_Framerate = null;
            if (cmdletContext.Video_Framerate != null)
            {
                requestVideo_video_Framerate = cmdletContext.Video_Framerate.Value;
            }
            if (requestVideo_video_Framerate != null)
            {
                request.Video.Framerate = requestVideo_video_Framerate.Value;
                requestVideoIsNull = false;
            }
            System.Int32? requestVideo_video_Height = null;
            if (cmdletContext.Video_Height != null)
            {
                requestVideo_video_Height = cmdletContext.Video_Height.Value;
            }
            if (requestVideo_video_Height != null)
            {
                request.Video.Height = requestVideo_video_Height.Value;
                requestVideoIsNull = false;
            }
            System.Int32? requestVideo_video_Width = null;
            if (cmdletContext.Video_Width != null)
            {
                requestVideo_video_Width = cmdletContext.Video_Width.Value;
            }
            if (requestVideo_video_Width != null)
            {
                request.Video.Width = requestVideo_video_Width.Value;
                requestVideoIsNull = false;
            }
             // determine if request.Video should be set to null
            if (requestVideoIsNull)
            {
                request.Video = null;
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
        
        private Amazon.IVSRealTime.Model.CreateEncoderConfigurationResponse CallAWSServiceOperation(IAmazonIVSRealTime client, Amazon.IVSRealTime.Model.CreateEncoderConfigurationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Interactive Video Service RealTime", "CreateEncoderConfiguration");
            try
            {
                #if DESKTOP
                return client.CreateEncoderConfiguration(request);
                #elif CORECLR
                return client.CreateEncoderConfigurationAsync(request).GetAwaiter().GetResult();
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
            public System.String Name { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public System.Int32? Video_Bitrate { get; set; }
            public System.Single? Video_Framerate { get; set; }
            public System.Int32? Video_Height { get; set; }
            public System.Int32? Video_Width { get; set; }
            public System.Func<Amazon.IVSRealTime.Model.CreateEncoderConfigurationResponse, NewIVSRTEncoderConfigurationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.EncoderConfiguration;
        }
        
    }
}