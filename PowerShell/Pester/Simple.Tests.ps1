Describe "Run a Passing Test" {
    Context "Simple Assert" {
        It "Should Pass" {
            $true | Should Be $true
        }
    }
}

Describe "Evluate Truth Tables" {
    Context "And" {
        It "False And False = False" {
            $false -and $false | Should Be $false
        }
        It "True And False = False" {
            $true -and $false | Should Be $false
        }
        It "False And True = False" {
            $false -and $true | Should Be $false
        }
        It "True And True = True" {
            $true -and $true | Should Be $true
        }
    }
    Context "Or" {
        It "False Or False = False" {
            $false -or $false | Should Be $false
        }
        It "True Or False = False" {
            $true -or $false | Should Be $true
        }
        It "False Or True = False" {
            $false -or $true | Should Be $true
        }
        It "True Or True = True" {
            $true -or $true | Should Be $true
        }
    }}