## Problem Description

Fluent interfaces (http://en.wikipedia.org/wiki/Fluent_interface) are implementations APIs designed to look more human readable. You'll see them everywhere, with mainstream examples including FluentNHibernate and the assertion syntax in many libraries.

There's an interesting library by Michael Wolfenden called "Polly" (https://github.com/michael-wolfenden/Polly) that implements some interesting syntax:

      // Retry multiple times, calling an action on each retry
      // with the current exception and retry count
      Policy
          .Handle<DivideByZeroException>()
          .Retry(3, (exception, retryCount) =>
          {
              // do something
          });

We're going implement this kind of API in C# / Java

### Story 1 - Asserting Not equality

One of the simplest examples of an API is the following from NUnit:

    Assert.That(myString, Is.EqualTo("Hello") );

Implement this API.

### Story 2 - Asserting inverse equality

    Assert.That(myString, Is.Not.EqualTo("Hello") );

Implement this API.

### Story 3 - Stretch

Attempt to implement the larger API sample shown above
