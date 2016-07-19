# Human Readable Urls

Url shortening is a common (and often web breaking!) practice -
but sometimes you want your short Urls to be a little more... memorable.

Gfycat (https://gfycat.com/) popularised "human readable short Urls"

Let's take a look at one

    https://gfycat.com/SpotlessImpracticalCockatoo

What LOLS! What Larks! How Memorable! Much Cockatoo! So Wow!

In this kata, we're going to build our own human readable Url generator.
Be creative with your source data. Make some really memorable Urls.

We're going to make a program that shortens Urls for us.

# Story 1 - Generate readable Urls

    As a user
    I want to generate a human readable Url
    So that people can remember it


# Story 2 - Urls must not conflict

    As a user
    When I generate a Url
    It should not conflict with previously generated Urls

    (Think about running your code in a loop and maintaining state)

# Story 3 - Urls must not be rude

    As a user
    When I generate a Url
    It should be funny, but not offensive