New-SSMDocument -Content (Get-Content -Raw "c:\temp\RunShellScript.json") -Name "RunShellScript" -DocumentType "Command"