$option1 = @{Key="tag:Environment";Values=@("Production")}
Register-SSMTargetWithMaintenanceWindow -WindowId "mw-06cf17cbefcb4bf4f" -Target $option1 -OwnerInformation "Production Web Servers" -ResourceType "INSTANCE"