# Deleting Code Comments

One of the biggest frustrations that people often have with with legacy code-bases is the prevalence of huge blocks of commented out code. This code is clutter that confuses the future maintenance of software, so today we're going to write a program that removes them.

As a secondary concern, we want to retain "narrative comments" and XDoc / Ghost doc style comments on class, method, and interface signatures.

The syntax of comment blocks varies from language to language - pick one of your choice to start with. Requirement examples are in C#.

## Requirements

### Story 1 - Stripping commented out code

    As a user
    When I run the program over a specific file
    Single line comment blocks are removed

    Accept:

    Single line code comments removed
        // Console.WriteLine("remove this");

### Story 2 - Retaining single line text comments

    As a user
    When I run the program over a specific file
    Single line text comments retained

    Accept:

    Single line text comments retained
      // Do not remove me

### Story 3 - Removing multi-line comments

    As a user
    When I run the program over a specific file
    Multi-line comment blocks are removed

    Accept:

    /* Remove

          anything like this
    */

### Story 3 - XMLDoc style comments retained

    As a user
    When I run the program
    Comments on method, interface and class declarations are retained

    Accept:

    Comments in this style retained

      /// <summary>
      /// Class level summary documentation goes here.</summary>
      /// <remarks>
      /// Longer comments can be associated with a type or member
      /// through the remarks tag</remarks>
      public class SomeClass
      {....


## Example file

```csharp
/// <summary>
/// Good comment
/// </summary>
public class Test
{
  /// <summary>
  /// Good comment
  /// </summary>
  public void Method()
  {
    // Console.WriteLine("haha"); // BAD COMMENT!

    Console.WriteLine("Hi"); // Good comment

    // Good comment
    Console.WriteLine("with some narrative");

    /*
    * Good comment
    */

    //Console.WriteLine("Bad");
    //Console.WriteLine("Bad");
    //Console.WriteLine("Bad");
    //Console.WriteLine("Bad");
    //Console.WriteLine("Bad");

    /*
    Console.WriteLine("Very bad");
    Console.WriteLine("Very bad");
    Console.WriteLine("Very bad");
    Console.WriteLine("Very bad");
    Console.WriteLine("Very bad");
    Console.WriteLine("Very bad");
    Console.WriteLine("Very bad");*/

    /*
    Good comment
    */
    Console.WriteLine("Some code");

    //Console.WriteLine("Bad comment");
    Console.WriteLine("Good code");
  }
}
```
