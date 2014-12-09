## Videogame matchmaking kata

Matchmaking is a common part of online video games.  While reading the changelog for the latest revision of "Halo: The Master Chief Collection" (http://www.polygon.com/2014/12/8/7352941/another-major-update-hits-halo-the-master-chief-collection-for), it became apparent that it's something that can easily go wrong, and has lots of interesting subtleties - and is ripe for the slaying with some traditional TDD.

#### Matchmaking for games

Given a pool of players searching for a game, there are a number of factors to consider:

  * The **skill** of the player
  * If the game requires a **host player**
  * The **latency / ping** of the player
  * If the player is **looking for a specific game type**
  * If the player is looking for a **team based or free-for-all game**
    * If the game type is team based, **correctly balancing the teams**
  * If a set of players are already "partied up" and wish to play on the same team
    * If the game type is team based, ensuring **partied players are on the same team**, and the opposing team is balanced

There are a few **common "game types"**, in modern first person shooters
  * **Deathmatch** (*free for all*, no teams)
  * **Team Deathmatch** (*two teams*)
  * **Team objective based games** (*two or more teams*)

With so many permutations and variables, it's no surprise that matchmaking is something that frequently goes wrong, especially during launch periods of games.

Calculating the skill of players is a difficult topic, with some of the most dominant research in the field being the Microsoft Research "TrueSkill" ranking system: http://research.microsoft.com/en-us/projects/trueskill/  For the sake of this kata, we'll **descope "player skill calculations" and presume that we have a single number representing player skill**.

From these factors, emerge *the following requirements*:

  * Each game needs a host
  * Each game should be balanced
  * Players that look for a specific game-type should only be paired with others seeking the same game-type
  * Players who share a screen, should be on the same team
  * Players who are partied, should be on the same team
  * Players should be ideally paired with people of the same level of latency
  * The game should be balanced
  * The lower the latency of the host, the better
  * Matchmaking should be as quick as possible

---  

## Lets build a matchmaker!

Given a representation of a pool of players, we want to produce balanced, match-made games.

    "Id",  "Can host", "Latency ", "In-Party of Player", "Skill"
    1, 1, 27,, 100
    2, 1, 500,, 90
    3, 0, 200,, 50  
    4, 0, 250,6, 100
    5, 0, 600,, 10
    6, 1, 15,, 1  
    7, 0, 60,, 99  
    8, 0, 27,, 45
    9, 0, 50,, 30  
    10, 0, 50,, 67  
    11, 1, 2000, 2, 12
    12, 0, 97,,100
    13, 1, 550,, 90
    14, 0, 120,, 50  
    15, 0, 60, 6, 100  
    16, 0, 4000,, 10  
    17, 1, 15,, 1
    18, 0, 80,, 99
    19, 0, 27,, 45
    20, 1, 22,, 30
    21, 0, 500,, 67  


## Kata 1 - Matchmaking for a balanced free-for-all deathmatch game

We have a pool of players all looking to play a balanced, 6 player, free-for-all deathmatch.

### Story 1 - Electing Hosts

    As a server
    When I have a queue of players waiting for a free for all deathmatch
    Then I should elect the most appropriate hosts for those matches

    Accept:
      Hosts should be as low-latency as possible

### Story 2 - Balancing games

    As a server
    When I have a pool of players waiting for a free for all deathmatch
    Then players in the game should be of roughly the same skill level

    Accept:
      Minimise the standard deviation of skill between players
      It's OK to make smaller, more balanced games if enough hosts are available


## Kata 2 - Matchmaking for a team deathmatch

We have a pool of players all looking to play a balanced, 3v3 player, team deathmatch.
Maximum party size is 3.
In addition to the rules in the first kata, consider these stories.
How does it effect how you matchmake?

### Story 1 - Teams must be evenly balanced

    As a server
    When I select players
    Then the pool of players should be split into balanced teams

### Story 2 - Friends play together

    As a server
    When I form teams
    Then players who are partied together should be on the same team

## Final thoughts and clues

In the real world, you want to optimise for getting players into a game as soon as possible, so it's likely that you would matchmake on intervals, splitting on game types.

People would join queues for specific game types, and you'd either wait until you had a sufficient set of people to matchmake from, or a certain time window had elapsed, favouring "getting people playing" over perfect balancing. The data provided above would likely represent one "chunk" of players to matchmake.

Would your solution change "at scale"?

## Appendix

Here's the "matchmaking" portion of the Halo changelog. Some of these issues are just regular bugs, other are matchmaking related.

* Made improvements to matchmaking team balance
* Made an update to improve matchmaking search times and success rates, specifically expediting the "Players Found" and "Connecting Session" search phases
* Made improvements to prevent a player's rank from resetting unexpectedly
* Made an update to resolve an issue that allowed players to be placed into an incorrect lobby after a matchmaking game
* Made improvements to prevent the party from being disbanded upon returning to lobby
* Made an update to ensure that players are sorted by team in the "Match Found" screen
* Resolved an issue where Team Slayer matches in Halo 3 could separate players onto individual teams
* Resolved an issue where players could be placed into a group of 7 players and unable to find more
* Made improvements to ensure that the party-leader is prompted to "Bring Party" when leaving a lobby
* Made an update to ensure that split-screen players cannot be divided onto different teams
* Made improvements to ensure that clients are not kicked from parties at the end of matchmaking games with a "failed to connect" error
* Made an update to ensure that Halo 2: Anniversary matches do not continue indefinitely after entire opposing team quits
* Made an update to ensure that parties are not separated when the party leader navigates through multiple titles
