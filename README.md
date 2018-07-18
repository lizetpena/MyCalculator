# MyCalculator
This solution showcases the Live Unit Testing Feature available
in Visual Studio 2017 15.7.x or above.
The current solution uses the Microsoft.VisualStudio.QualityTools.UnitTestingFramework
namespace, but Live Unit Testing also works with other
Unit Testing frameworks such as NUnit and MSTest.

Live Unit Testing, when enabled via Test->Live Unit Testing -> Start in the
Visual Studio 2017 IDE menu, allows you to see which unit tests don't pass
after modifying the class that is tested (system under test).

Live Unit Testing relies on a good battery of unit tests covering the majority of
the source code.

Steps to show Live Unit Testing
1- Enable it via Test->Live Unit Testing -> Start
2- Run all tests
3- Pick a method on the class under test and modify it on purpose
4- You should see the method at the top of the method signature stating 1 or more
   unit tests don't pass...
