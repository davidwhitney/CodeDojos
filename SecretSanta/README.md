# Original Description

This is derived from a quiz posted on rubyquiz.com see: http://rubyquiz.com/quiz2.html

## Problem Description

Secret Santa is a game played by friends around the world to add a little mystery into seasonal gift giving.

To play secret santa:
 * All the participants names are placed in a hat
 * Names are drawn and allocated to other players
 * Gifts are bought and shared anonymously

Obviously, the problem with a random hat draw is you can get yourself - so lets solve this problem with software!

Here are some sample names:

<pre>
  Luke Skywalker   [luke@theforce.net]
  Leia Skywalker   [leia@therebellion.org]
  Toula Portokalos [toula@manhunter.org]
  Gus Portokalos   [gus@weareallfruit.net]
  Bruce Wayne      [bruce@imbatman.com]
  Virgil Brigman   [virgil@rigworkersunion.org]
  Lindsey Brigman  [lindsey@iseealiens.net]
</pre>

### Story 1

Allocating secret santas

    As a user
    When I pass a list of names in a file
    Secret santas are allocated

### Story 2

    Families must be split up

    As a user
    When I allocate secret santas
    Santas are not paired when they are related

### Story 3 (Stretch goal)

    Email the santas

    As a user
    When I allocate secret santas
    The santas are emailed, so nobody can cheat
