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
using Amazon.GameLift;
using Amazon.GameLift.Model;

namespace Amazon.PowerShell.Cmdlets.GML
{
    /// <summary>
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b><para>
    /// Creates a new game server resource and notifies GameLift FleetIQ that the game server
    /// is ready to host gameplay and players. This action is called by a game server process
    /// that is running on an instance in a game server group. Registering game servers enables
    /// GameLift FleetIQ to track available game servers and enables game clients and services
    /// to claim a game server for a new game session. 
    /// </para><para>
    /// To register a game server, identify the game server group and instance where the game
    /// server is running, and provide a unique identifier for the game server. You can also
    /// include connection and game server data; when a game client or service requests a
    /// game server by calling <a>ClaimGameServer</a>, this information is returned in response.
    /// </para><para>
    /// Once a game server is successfully registered, it is put in status AVAILABLE. A request
    /// to register a game server may fail if the instance it is in the process of shutting
    /// down as part of instance rebalancing or scale-down activity. 
    /// </para><para><b>Learn more</b></para><para><a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
    /// FleetIQ Guide</a></para><para><b>Related operations</b></para><ul><li><para><a>RegisterGameServer</a></para></li><li><para><a>ListGameServers</a></para></li><li><para><a>ClaimGameServer</a></para></li><li><para><a>DescribeGameServer</a></para></li><li><para><a>UpdateGameServer</a></para></li><li><para><a>DeregisterGameServer</a></para></li></ul>
    /// </summary>
    [Cmdlet("Register", "GMLGameServer", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.GameLift.Model.GameServer")]
    [AWSCmdlet("Calls the Amazon GameLift Service RegisterGameServer API operation.", Operation = new[] {"RegisterGameServer"}, SelectReturnType = typeof(Amazon.GameLift.Model.RegisterGameServerResponse))]
    [AWSCmdletOutput("Amazon.GameLift.Model.GameServer or Amazon.GameLift.Model.RegisterGameServerResponse",
        "This cmdlet returns an Amazon.GameLift.Model.GameServer object.",
        "The service call response (type Amazon.GameLift.Model.RegisterGameServerResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RegisterGMLGameServerCmdlet : AmazonGameLiftClientCmdlet, IExecutor
    {
        
        #region Parameter ConnectionInfo
        /// <summary>
        /// <para>
        /// <para>Information needed to make inbound client connections to the game server. This might
        /// include IP address and port, DNS name, etc.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ConnectionInfo { get; set; }
        #endregion
        
        #region Parameter CustomSortKey
        /// <summary>
        /// <para>
        /// <para>A game server tag that can be used to request sorted lists of game servers using <a>ListGameServers</a>.
        /// Custom sort keys are developer-defined based on how you want to organize the retrieved
        /// game server information.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CustomSortKey { get; set; }
        #endregion
        
        #region Parameter GameServerData
        /// <summary>
        /// <para>
        /// <para>A set of custom game server properties, formatted as a single string value. This data
        /// is passed to a game client or service when it requests information on a game servers
        /// using <a>ListGameServers</a> or <a>ClaimGameServer</a>. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String GameServerData { get; set; }
        #endregion
        
        #region Parameter GameServerGroupName
        /// <summary>
        /// <para>
        /// <para>An identifier for the game server group where the game server is running. You can
        /// use either the <a>GameServerGroup</a> name or ARN value.</para>
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
        public System.String GameServerGroupName { get; set; }
        #endregion
        
        #region Parameter GameServerId
        /// <summary>
        /// <para>
        /// <para>A custom string that uniquely identifies the new game server. Game server IDs are
        /// developer-defined and must be unique across all game server groups in your AWS account.</para>
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
        public System.String GameServerId { get; set; }
        #endregion
        
        #region Parameter InstanceId
        /// <summary>
        /// <para>
        /// <para>The unique identifier for the instance where the game server is running. This ID is
        /// available in the instance metadata.</para>
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
        public System.String InstanceId { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>A list of labels to assign to the new game server resource. Tags are developer-defined
        /// key-value pairs. Tagging AWS resources are useful for resource management, access
        /// management, and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging AWS Resources</a> in the <i>AWS General Reference</i>. Once the resource is
        /// created, you can use <a>TagResource</a>, <a>UntagResource</a>, and <a>ListTagsForResource</a>
        /// to add, remove, and view tags. The maximum tag limit may be lower than stated. See
        /// the AWS General Reference for actual tagging limits.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.GameLift.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'GameServer'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.GameLift.Model.RegisterGameServerResponse).
        /// Specifying the name of a property of type Amazon.GameLift.Model.RegisterGameServerResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "GameServer";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the GameServerId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^GameServerId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^GameServerId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.GameServerId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Register-GMLGameServer (RegisterGameServer)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.GameLift.Model.RegisterGameServerResponse, RegisterGMLGameServerCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.GameServerId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ConnectionInfo = this.ConnectionInfo;
            context.CustomSortKey = this.CustomSortKey;
            context.GameServerData = this.GameServerData;
            context.GameServerGroupName = this.GameServerGroupName;
            #if MODULAR
            if (this.GameServerGroupName == null && ParameterWasBound(nameof(this.GameServerGroupName)))
            {
                WriteWarning("You are passing $null as a value for parameter GameServerGroupName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.GameServerId = this.GameServerId;
            #if MODULAR
            if (this.GameServerId == null && ParameterWasBound(nameof(this.GameServerId)))
            {
                WriteWarning("You are passing $null as a value for parameter GameServerId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.InstanceId = this.InstanceId;
            #if MODULAR
            if (this.InstanceId == null && ParameterWasBound(nameof(this.InstanceId)))
            {
                WriteWarning("You are passing $null as a value for parameter InstanceId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.GameLift.Model.Tag>(this.Tag);
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
            var request = new Amazon.GameLift.Model.RegisterGameServerRequest();
            
            if (cmdletContext.ConnectionInfo != null)
            {
                request.ConnectionInfo = cmdletContext.ConnectionInfo;
            }
            if (cmdletContext.CustomSortKey != null)
            {
                request.CustomSortKey = cmdletContext.CustomSortKey;
            }
            if (cmdletContext.GameServerData != null)
            {
                request.GameServerData = cmdletContext.GameServerData;
            }
            if (cmdletContext.GameServerGroupName != null)
            {
                request.GameServerGroupName = cmdletContext.GameServerGroupName;
            }
            if (cmdletContext.GameServerId != null)
            {
                request.GameServerId = cmdletContext.GameServerId;
            }
            if (cmdletContext.InstanceId != null)
            {
                request.InstanceId = cmdletContext.InstanceId;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.GameLift.Model.RegisterGameServerResponse CallAWSServiceOperation(IAmazonGameLift client, Amazon.GameLift.Model.RegisterGameServerRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon GameLift Service", "RegisterGameServer");
            try
            {
                #if DESKTOP
                return client.RegisterGameServer(request);
                #elif CORECLR
                return client.RegisterGameServerAsync(request).GetAwaiter().GetResult();
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
            public System.String ConnectionInfo { get; set; }
            public System.String CustomSortKey { get; set; }
            public System.String GameServerData { get; set; }
            public System.String GameServerGroupName { get; set; }
            public System.String GameServerId { get; set; }
            public System.String InstanceId { get; set; }
            public List<Amazon.GameLift.Model.Tag> Tag { get; set; }
            public System.Func<Amazon.GameLift.Model.RegisterGameServerResponse, RegisterGMLGameServerCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.GameServer;
        }
        
    }
}