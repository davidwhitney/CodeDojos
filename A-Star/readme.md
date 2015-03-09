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

We're going to implement the A* algorithm to pathfind our way across maps like the one provided below.
Paths can be diagonal.

* **S** Starting point
* **D** Destination
* **.** Flat ground - difficultly cost 1
* **V** Forest - difficulty cost 5
* **#** Cliffs / un-traversable

<pre>

    ..........D.VVV
    ..........VVVVV
    ..#########VVVV
    ......#####VVVV
    ........###VVVV
    ...........VVVV
    .............VV
    .............S.

</pre>

# Simple pathfinding

As an Pathfinding AI
Given a 3x3 block
I will pathfind diagonally

<pre>
    S..
    ...
    ..D
</pre>

Accept

    * Path output to console
    * Path marked with X's
    
# Pathfinding around a blockaid

As an Pathfinding AI
Given a 3x3 block with a blockaid
I will pathfind around the blockaid

<pre>
    S..
    ##.
    D..
</pre>

# Pathfinding around slow terrain

As an Pathfinding AI
Given a 3x3 block where the direct route is slow
I will pathfind around the slow path

<pre>
    S..
    V..
    D..
</pre>

# Acknowledgements

This is derived from a Rubyquiz.com quiz here - http://rubyquiz.com/quiz98.html
