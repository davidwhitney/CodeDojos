## Problem Description - Build monitor

You work in a nice, friendly, modern software development company - and as a result, you have a comprehensive build server.

But alas! Somebody keeps on breaking builds! In order to convince people that breaking builds is a really bad idea, you decide to build an alarm that rings every time a build is broken.

---

### Getting the build status for a build

    As a developer
    I want to get the build status for a build
    So I can raise an alarm if it breaks


### Ringing an alarm

    As a developer
    When a build breaks (API returns negative status)
    An alarm rings

    Accept: Can hear alarm!

### Alerting on multiple builds

    As a developer
    I want the build alarm to ring for more than one build
    So I can monitor multiple projects


### Coping with the build server being down

    As a developer
    I don't want the build alarm to ring when connectivity to the build server is interrupted.
    Because that'd be annoying

      Accept: Must be obvious somehow that the build results are stale


### Second build server

    As a developer
    I want to monitor a second, completely different build server using the same alarm
    Because we now build iOS software as well as websites and need a different build chain

      Accept: Mutiple servers monitored
              Servers run different build software / have different APIs

### Configuration

    As a developer
    I want to trivially configure the alarm to ring for many builds
    With as little configuration as possible.
