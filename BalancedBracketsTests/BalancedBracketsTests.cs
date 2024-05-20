namespace BalancedBracketsTests;

[TestClass]
public class BalancedBracketsTests
{
    // POSITIVE TEST CASES

    // TODO: Refactor example test from instructions to use AAA pattern and message parameter
    [TestMethod]
    public void OnlyBracketsReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
    }

    // TODO: Test balanced brackets in front of other characters — "[]LaunchCode"


    // TODO: Test balanced brackets around other characters — "[LaunchCode]"


    // TODO: Test balanced brackets within other characters — "Launch[Code]"


    // TODO: Test multiple consecutive pairs of balanced brackets — "[][][]"


    // TODO: Test multiple nested balanced brackets — "[[[]]]"


    // NEGATIVE TEST CASES

    // TODO: Test single opening bracket — "["


    // TODO: Test single closing bracket — "]"


    // TODO: Test reversed brackets — "]["


    // TODO: Test single bracket with other characters "[LaunchCode"


    // TODO: Test unbalanced brackets among other characters — "Launch]Code["


    // TODO: Test a series of mixed, unbalanced brackets — "[[]][]["



    // EDGE CASES

    // TODO: Test string with only characters other than brackets — "LaunchCode"


    // TODO: Test empty string — ""
}
