#
# Cookbook Name:: learn_chef_iis
# Recipe:: default
#
# Copyright (c) 2015 The Authors, All Rights Reserved.

powershell_script 'Install IIS' do
  code 'Add-WindowsFeature Web-Server'
  guard_interpreter :powershell_script
  not_if "(Get-WindowsFeature -Name Web-Server).Installed"
end

service 'w3svc' do
  action [:enable, :start]
end

#template 'c:\inetpub\wwwroot\Default.htm' do
#  source 'index.html.erb'
#end

file 'c:\inetpub\wwwroot\Default.htm' do
  content '<h1>Yes Chef!</h1>'
end
