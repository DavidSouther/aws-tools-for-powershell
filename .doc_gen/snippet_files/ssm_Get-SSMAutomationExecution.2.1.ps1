Get-SSMAutomationExecution -AutomationExecutionId e1d2bad3-4567-8901-ae23-456c7c8901be | Select-Object -ExpandProperty StepExecutions | Select-Object StepName, Action, StepStatus, ValidNextSteps