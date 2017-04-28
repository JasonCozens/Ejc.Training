Describe "Run a Passing Test" {
    Context "Simple Assert" {
        It "Should Pass" {
            $true | Should Be $true
        }
    }
}