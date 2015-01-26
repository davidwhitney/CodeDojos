## Problem Description - Build monitor

You work in a nice, friendly, modern software development company - and as a result, you have a comprehensive build server.

But alas! Somebody keeps on breaking builds! In order to convince people that breaking builds is a really bad idea, you decide to build an alarm that rings every time a build is broken.

(Example API response in appendix)

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
            If the last build failed, don't ring the alarm again

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

### Stretch goal

    As a developer
    I want to know a build failed in ways other than a ringing alarm
    Because I can miss an alarm ringing

# Example call

GET http://tempuri.org/build/status


## Example API call response

    {
      "Projects": [
        {
          "Id": "0b33a915-8fa2-4edc-9a33-8a51ace565a2",
          "Name": "MyRockingApp",
          "Configurations": [
            {
              "Id": "2eaed57c-28e8-4ce4-a0e7-112f4077aa0a",
              "Name": "Build",
              "CurrentStatus": "Passing",
              "Message": null
            },
            {
              "Id": "59c4b0f8-d5d4-449a-841b-c1b180018a7e",
              "Name": "Deploy - Dev",
              "CurrentStatus": "Passing",
              "Message": null
            },
            {
              "Id": "0e6b8f47-a893-45fb-989b-08b5882a49b3",
              "Name": "Deploy - QA",
              "CurrentStatus": "Passing",
              "Message": null
            },
            {
              "Id": "1ac4bf7d-dfca-49a3-9100-546a9921517a",
              "Name": "Deploy - Production",
              "CurrentStatus": "Passing",
              "Message": null
            }
          ]
        },
        {
          "Id": "bbc484fb-e673-4ec4-9a7f-faf3279bdd0b",
          "Name": "MySuckingApp",
          "Configurations": [
            {
              "Id": "ab32d9f8-1914-4966-a8c4-dee195065a40",
              "Name": "Build",
              "CurrentStatus": "Failing",
              "Message": null
            },
            {
              "Id": "2d80a96a-b51a-438c-96ac-c99f9a83e3e5",
              "Name": "Deploy - Dev",
              "CurrentStatus": "Passing",
              "Message": null
            },
            {
              "Id": "110b79bf-b742-4dc8-94f4-a43199a19675",
              "Name": "Deploy - QA",
              "CurrentStatus": "Inconclusive",
              "Message": null
            },
            {
              "Id": "89f7ee03-c9a4-40b7-acb6-e87333e7ab1a",
              "Name": "Deploy - Production",
              "CurrentStatus": "Passing",
              "Message": null
            }
          ]
        }
      ]
    }
