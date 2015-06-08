Throttling
==========

Throttling is a cloud design pattern that exists to mitigate against floods of traffic to your websites or services.
There's a good outline of the pattern here - https://msdn.microsoft.com/en-gb/library/dn589798.aspx :

    "The load on a cloud application typically varies over time based on the number of active users or the types of activities they are performing.

    For example, more users are likely to be active during business hours, or the system may be required to perform computationally expensive analytics at the end of each month. There may also be sudden and unanticipated bursts in activity.

    If the processing requirements of the system exceed the capacity of the resources that are available, it will suffer from poor performance and may even fail. The system may be obliged to meet an agreed level of service, and such failure could be unacceptable.

    There are many strategies available for handling varying load in the cloud, depending on the business goals for the application. One strategy is to use autoscaling to match the provisioned resources to the user needs at any given time. This has the potential to consistently meet user demand, while optimizing running costs.

    However, while autoscaling may trigger the provisioning of additional resources, this provisioning is not instantaneous. If demand grows quickly, there may be a window of time where there is a resource deficit."  


## Task

We're going to write some code that'll allow us to throttle calls to ANY method or code block, according to a specific threshold, within a specific time window.


## Stories

### Throttling calls

    As a dev
    When I use my wrapper class or function to call a codeblock
    Only one single call is executed in a 5 second window

        Accept: Other calls rejected / throw

### Queuing throttled calls

    As a dev
    When I use my wrapper class or function to call a codeblock
    Any calls that would be throttled are executed after the throttle window elapses

        Accept: Calling code should know if execution is deferred
        Hint: Async / Await?

### Configuring throttling durations

    As a dev
    When I make a throttle-able call
    I can configure the throttling window in an idiomatic way
