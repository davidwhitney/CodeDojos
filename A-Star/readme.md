A* for path-finding
======================================

The A* (A-Star) search algorithm is a path-finding algorithm with many uses, including Artificial Intelligence for games.

The search builds the route from tile to tile until it reaches the goal. To help choose the best possible tile the algorithm will use an equation that takes into account the distance from the tile to the goal and the cost of moving to that tile.

Example
==========

**Step 1:** Search the surrounding tiles for walkable choices.

**Step 2:** Go through that list finding the cost of movement for each of those choice tiles. The cost of movement is the path cost so far, plus the cost to move to the tile being considered.

**Step 3:** Determine the distance from the choice tiles to the goal and add that to the cost from Step 2 to find the score for each tile.

You can calculate the distance from the tile to the goal using **Manhattan distance** formula

> (x1 - x2) + (y1 - y2).

**Step 4:** Choose the best tile to move to by comparing the score of the surrounding tiles and choosing the lowest.

**Step 5:** **Repeat Steps 1-4** until you reach the goal tile. Be careful to prevent checking tiles twice and/or circling back.


Build a pathfinder
===================

We want to find the shortest path from S to D given the node layout below.
Paths can be diagonal.

* S: Starting point
* D: Destination
* \#: Traversable node
* @: Blocked / un-traversable


    ##########D####
    ###############
    ###@@@@@@@@####
    ########@@@####
    ##########@####
    ###############
    ####S##########
    ###############


## Story 1 - Display the path scores

    As a user
    When I provide two points
    I want see the #'s replaced with distance scores

        Accept: Output to screen

## Story 2 - Select the shortest route

    As a user
    I want to visualise the shortest path
    So I can marvel in its wonder.

        Accept: Some kind of visualisation on screen

## Story 3 - Animate the shortest path

    As a user
    I want to see an animation of the S walking towards the D
    Because that'd be cool!

        Accept: Stretch goal! Walk the path :)
