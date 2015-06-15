# example_proj

Add-WindowsFeature Web-Server
Add-WindowsFeature Web-Asp-Net45

# Asp.Net 3.5 (not required)
# Add-WindowsFeature Web-Asp-Net


# https://technet.microsoft.com/en-us/library/ee790599.aspx
Remove-Website -name 'Default Web Site'

New-WebAppPool test_site1
New-Website test_site1 -Port 55432 -PhysicalPath C:\inetpub\test_site1 -ApplicationPool test_site1
Start-WebAppPool -Name test_site1
Start-Website -Name test_site1
