# Circuit Breakers

To quote Martin Fowler:

    It's common for software systems to make remote calls to software running in different processes, probably on different machines across a network.

    One of the big differences between in-memory calls and remote calls is that remote calls can fail, or hang without a response until some timeout limit is reached.

    What's worse if you have many callers on a unresponsive supplier, then you can run out of critical resources leading to cascading failures across multiple systems.

    In his excellent book Release It, Michael Nygard popularized the Circuit Breaker pattern to prevent this kind of catastrophic cascade.


Circuit breakers are very simple - they:

* Wrap a protected function call in a circuit breaker object, which monitors for failures.
* Once the failures reach a certain threshold, the circuit breaker trips
* Further calls to the circuit breaker return with an error without the protected call being made at all.
* After a time limit, the circuit enters a "half-open" state
  * While half-open, the next call is allowed through
  * If the call succeeds, the circuit closes
  * If the call fails, the circuit opens and a timer is reset

A circuit breaker has three states, and is modeled after electrical circuits

* Closed - A closed circuit sends requests naturally
* Open - Automatically returns an error when a call is attempted.
* Half open - After a timeout, a open circuit becomes "half open" allowing a single call through



---
## Story - Implement a circuit breaker

    As a systems maintainer
    I want my calls to be resilient to failure
    So I don't need to turn features on and off

        - Implement the circuit breaker pattern
        - Fault tolerance should be configurable
        - Half-open timeouts should be configurable


### Scenario 1 - Monitoring failure

    As a developer
    I want to count failures when I make calls
    A failure count is incremented

### Scenario 2 - Opening a circuit

    As a developer
    When my failure count exceeds a configured tolerance
    All subsequent calls throw an exception and block the call

### Scenario 3 -  Half opened state

    As a developer
    When my code is blocking calls and a configured timeout passes
    I allow a single call to proceed

        - Single call succeeding closes circuit
        - Single call failing resets some kind of timeout
