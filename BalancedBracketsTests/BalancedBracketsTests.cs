namespace BalancedBracketsTests;

using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // POSITIVE TEST CASES

    // Refactor example test from instructions to use AAA pattern and message parameter
    [TestMethod]
    public void OnlyBracketsReturnsTrue()
    {
        // ARRANGE
        string testData = "[]";
        // ACT
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        // ASSERT
        string message = "A single pair of balanced brackets returns true";
        Assert.IsTrue(actualResult, message);
    }

    // Test balanced brackets in front of other characters — "[]LaunchCode"
    [TestMethod]
    public void BracketsInFrontOfOtherCharsReturnsTrue()
    {
        string testData = "[]LaunchCode";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message =
            "A single pair of balanced brackets in front of other characters returns true";
        Assert.IsTrue(actualResult, message);
    }

    // Test balanced brackets around other characters — "[LaunchCode]"
    [TestMethod]
    public void BracketsSurroundingOtherCharsReturnsTrue()
    {
        string testData = "[LaunchCode]";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message =
            "A single pair of balanced brackets surrounding other characters returns true";
        Assert.IsTrue(actualResult, message);
    }

    // Test balanced brackets within other characters — "Launch[Code]"
    [TestMethod]
    public void BracketsAmongOtherCharsReturnsTrue()
    {
        string testData = "Launch[Code]";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "A single pair of balanced brackets among other characters returns true";
        Assert.IsTrue(actualResult, message);
    }

    // Test multiple consecutive pairs of balanced brackets — "[][][]"
    [TestMethod]
    public void TripleBracketsReturnsTrue()
    {
        string testData = "[][][]";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "Three pairs of balanced brackets returns true";
        Assert.IsTrue(actualResult, message);
    }

    // Test multiple nested balanced brackets — "[[[]]]"
    [TestMethod]
    public void TripleNestedBracketsReturnsTrue()
    {
        string testData = "[[[]]]";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "Three nested pairs of balanced brackets returns true";
        Assert.IsTrue(actualResult, message);
    }

    // NEGATIVE TEST CASES

    // Test single opening bracket — "["
    [TestMethod]
    public void SingleOpeningBracketReturnsFalse()
    {
        string testData = "[";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "A single opening bracket returns false";
        Assert.IsFalse(actualResult, message);
    }

    // Test single closing bracket — "]"
    [TestMethod]
    public void SingleClosingBracketReturnsFalse()
    {
        string testData = "]";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "A single closing bracket returns false";
        Assert.IsFalse(actualResult, message);
    }

    // Test reversed brackets — "]["
    [TestMethod]
    public void ReversedBracketsReturnsFalse()
    {
        string testData = "][";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "Reversed brackets returns false";
        Assert.IsFalse(actualResult, message);
    }

    // Test single bracket with other characters "[LaunchCode"
    [TestMethod]
    public void SingleBracketWithOtherCharsReturnsFalse()
    {
        string testData = "[LaunchCode";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "Single bracket with other characters returns false";
        Assert.IsFalse(actualResult, message);
    }

    // Test unbalanced brackets among other characters — "Launch]Code["
    [TestMethod]
    public void ReversedBracketsWithOtherCharsReturnsFalse()
    {
        string testData = "Launch]Code[";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "Reversed brackets with other characters returns false";
        Assert.IsFalse(actualResult, message);
    }

    // Test a series of mixed, unbalanced brackets — "[[]][]["
    [TestMethod]
    public void MixedUnbalancedBracketsReturnsFalse()
    {
        string testData = "[[]][][";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "Mixed unbalanced brackets returns false";
        Assert.IsFalse(actualResult, message);
    }

    // EDGE CASES

    // Test string with only characters other than brackets — "LaunchCode"
    [TestMethod]
    public void CharsWithoutBracketsReturnsTrue()
    {
        string testData = "LaunchCode";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "Characters without brackets returns true";
        Assert.IsTrue(actualResult, message);
    }

    // Test empty string — ""
    [TestMethod]
    public void EmptyStringReturnsTrue()
    {
        string testData = "";
        bool actualResult = BalancedBrackets.HasBalancedBrackets(testData);
        string message = "An empty string returns true";
        Assert.IsTrue(actualResult, message);
    }
}
