$here = Split-Path -Parent $MyInvocation.MyCommand.Path
$sut = (Split-Path -Leaf $MyInvocation.MyCommand.Path) -replace '\.Tests\.', '.'
. "$here\$sut"

Describe "One Example Lesson" {
    Context "One Example" {
        It "RunLesson" {
            Invoke-Lesson | Should Be "Hello Student"
        }
    }
}