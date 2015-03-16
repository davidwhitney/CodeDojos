Build a test framework!
========================

Working through some of the katas you'll have hopefully grown an appreciation for test driven development - so it's time to work out how test frameworks really work.

In this dojo, we're going to build the simplest test framework imaginable.

This dojo is about developing code that detects conventions, and a excercise in using the meta-programming features of the language of your choice.

Here are some example conventions, feel free to use them or think up your own

### Example conventions

* The test runner runs on the command line, pointed at a directory.
* Any assembly in that directory is loaded
* Test classes are classes with names suffixed `Tests`
* Any public method called `SetUp` is invoked before each test run
* All other public methods are presumed to be tests.
* The test class is created fresh before each test is invoked.
* Exceptions are considered test failures

This is a reasonable and wide range of requirements. Don't expect to have a working and extensible test framework built in an hour!

* Assertion frameworks are out of scope.

### Story 1 - Running tests

    As a user
    When I invoke the test runner
    It executes all tests that match my convention

    Accept: Count of pass / fail output.
            List of failing test names output.
            Exception thrown = failing test.

### Story 2 - Support for setup

    As a user
    When I invoke the test runner
    My setup method is invoked

### Story 3 - Isolated test execution

    As a user
    When a single test is run
    The test can't overwrite local variables in use by other tests

    Accept: Tests run in single instance of their own classes
