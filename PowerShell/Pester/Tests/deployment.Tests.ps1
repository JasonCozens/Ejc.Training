(Get-Item $(Split-Path $MyInvocation.MyCommand.Source -Parent)).Parent.FullName
Write-Host "----"
$scriptLocation = Split-Path -Parent $MyInvocation.MyCommand.Source | Split-Path -Parent
$systemUnderTest = (Split-Path -Leaf $MyInvocation.MyCommand.Source) -replace '\.Tests\.', '.'
"$scriptLocation\$systemUnderTest"
. "$scriptLocation\$systemUnderTest"

Describe "File Version Name" {

    Context "Version is 10.26.11" {

    $result = Get-FileVersionName -Version "10.26.11"

        It "Returns correct file version name" {
            $result | Should Be "Trunk-2.0-Commit_10.26.11"
        }
    }
}