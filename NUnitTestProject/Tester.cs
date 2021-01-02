using System;
using NUnit.Framework;
using TestDomePractice;

[TestFixture]
public class Tester
{
    private double epsilon = 1e-6;

    [Test]
    public void AccountCannotHaveNegativeOverdraftLimit()
    {
        AccountTest account = new AccountTest(-20);
        Assert.AreEqual(0, account.OverdraftLimit, epsilon);
    }
}