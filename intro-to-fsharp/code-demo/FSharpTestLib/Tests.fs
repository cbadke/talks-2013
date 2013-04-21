module Tests

open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``my special doubler tests`` () =

    [<Test>] member x.
        ``fsunit style test`` () =
            MyMathModule.DoubleIt 23 |> should equal 46

    [<Test>] member x.
        ``nunit style test`` () =
            Assert.AreEqual(46, (MyMathModule.DoubleIt 23))