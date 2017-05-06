<#
.DESCRIPTION
    Swirch the physal director of an IIS Website.
#>
$WebAdministrationModule = 'WebAdministration'

If ( ! (Get-module $WebAdministrationModule )) {
    Write-Host "Loading module $WebAdministrationModule"
    Import-Module $WebAdministrationModule
}