Write-S3BucketTagging -BucketName cloudtrail-test-2018 -TagSet @( @{ Key="Stage"; Value="Test" }, @{ Key="Environment"; Value="Alpha" } )