Dijkstra's Algorithm for path-finding
======================================

Dijkstra thought about shortest path problem when working at Mathematical Center in Amsterdam in 1956 as a program to demonstrate capabilities of the new computer called ARMAC.

His objective was to choose both a problem as well as answer (that will be produced by computer) that non-computing people can understand. He designed the shortest path algorithm in about 20 minutes without aid of paper and pen and later implemented it for ARMAC for slightly simplified transportation map of 64 cities in Netherland.

The algorithm and the A* variant are used for path finding in video games, attempting traveling salesman style problems, and are pretty fun to see working.

Algorithm
==========

**1)** **Assign to every node a tentative distance value**: set it to zero for our initial node and to infinity for all other nodes.

**2)** Set the initial node as current. Mark all other nodes unvisited. Create a set of all the unvisited nodes called the unvisited set.

**3)** For the current node, **consider all of its unvisited neighbors** and calculate their tentative distances.  The tentative distance can be as simple as the width + height offset of node elements in a 2D array.

        Compare the newly calculated tentative distance to the current assigned value and assign the smaller one.

        For example:

            If the current node A is marked with a distance of 6
            The edge connecting it with a neighbor B has length 2
            The distance to B (through A) will be 6 + 2 = 8.
            If B was previously marked with a distance greater than 8 then change it to 8.


**4)** When we are done considering all of the neighbors of the current node, mark the current node as visited and remove it from the unvisited set. **A visited node will never be checked again**.

**5)** If the destination node has been marked visited (when planning a route between two specific nodes) **or** if the smallest tentative distance among the nodes in the unvisited set is infinity (when planning a complete traversal; occurs when there is no connection between the initial node and remaining unvisited nodes), **then stop**. **The algorithm has finished.**

**6)** Select the unvisited node that is marked with the **smallest tentative distance**, and set it as the new "current node" then go back to step 3.


Build a pathfinder
===================

We want to find the shortest path from S to D given the node layout below.

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
