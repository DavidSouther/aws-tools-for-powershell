Update-CFNStack -StackName "myStack" `
                -TemplateURL https://s3.amazonaws.com/mytemplates/templatefile.template `
                -Parameter @( @{ ParameterKey="PK1"; ParameterValue="PV1" }, @{ ParameterKey="PK2"; ParameterValue="PV2" } ) `
                -Capabilities "CAPABILITY_IAM"