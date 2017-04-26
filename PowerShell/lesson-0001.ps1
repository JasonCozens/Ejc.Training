<#
.DESCRIPTION
    PowerShell by EJC - Lesson 1.
.NOTES
    This lesson is very short as it is demonstrating how to provide help for
    a script.
#>
Set-Location $PSScriptRoot

$ScriptName = $MyInvocation.MyCommand.Name

Clear-Host

$Command = "Get-Help .\$ScriptName"

Write-Host Example 1 - Ask for help. -> $Command

Invoke-Expression $Command

Read-Host

Clear-Host

$Command_2 = "Get-Help -Full .\$ScriptName"

Write-Host Example 2 - Ask for more help. -> $Command_2

Invoke-Expression $($Command_2)

Read-Host
