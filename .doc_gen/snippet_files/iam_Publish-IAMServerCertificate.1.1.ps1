Publish-IAMServerCertificate -ServerCertificateName MyTestCert -CertificateBody (Get-Content -Raw server.crt) -PrivateKey (Get-Content -Raw server.key)