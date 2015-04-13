# Retrying

In modern web programming, we're frequently faced with connectivity issues as we depend on many components that we can't control.

In this kata, we're going to build some code to implement backed-off-retrys.

Pay close attention to the API you're designing - this code should be re-usable in multiple places in your codebase.

---

## Story 1 - A basic HTTP request

    As a programmer
    I can load {url} over HTTP
    And it works


## Story 2 - A failed HTTP request

    As a programmer
    When a HTTP request to {url} fails
    It is retried 5 seconds later

## Story 3 - Backing off

    As a programmer
    When a HTTP request to {url} fails more than once
    The retry delay is increased for each failure

    Accept:
        Each retry delay is double the last
        Maximum number of retries is 10

## Story 4 - Retry filtering

    As a programmer
    When a HTTP request fails due to an expected condition
    It is not retried, exception is thrown

    Accept:
        Status 404 Not Found immediately throws it's exception
        "Expected failing condition" could be anything


## Story 5 - Configuration per-code-block

    As a programmer
    I want to be able to configure retry delays per block of code
    So I can easily deal with different use cases.
