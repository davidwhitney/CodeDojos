## Origin

This kata was originally a Thoughtworks recruitment test that got widely circulated. They don't use it anymore, but it's still a fun puzzle.

## Problem Description - Mars Rovers

A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on-board cameras can get a complete view of the surrounding terrain to send back to Earth.

A rover's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation.

An example position might be  `0, 0, N`

which means the rover is in the bottom left corner and facing North.

In order to control a rover, NASA sends a simple string of letters.

* L - Rotate 90 degrees left
* R - Rotate 90 degrees right
* M - Move forward one grid point

**Assume that the square directly North from (x, y) is (x, y+1).**

The first line of input is the upper-right coordinates of the plateau, **the lower-left coordinates are assumed to be 0,0**.
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input.

The input data is in the following form:

    GRIDX GRIDY         <-- Grid dimensions
    XLoc YLoc Bearing   <-- Rover 1
    XXXXXXXXXX          <-- Instructions
    XLoc YLoc Bearing   <-- Rover 2
    XXXXXXXXXX          <-- Instructions


### Input

    5 5
    1 2 N
    LMLMLMLMM
    3 3 E
    MMRMMRMRRM

### Expected Output

    1 3 N
    5 1 E


Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.

----

### Story 1 - Generating a grid

    As a user
    When I input grid dimensions
    The appropriate grid is generated

      Accept: Input is parsed
              Grid generated based on input


### Story 2 - Placing a rover

    As a user
    When I input a rover location
    A rover is placed at the correct grid location

      Accept: Rover must be facing the right direction


### Story 3 - Rotating a rover

    As a parser processing rover instructions
    When I encounter an L or R
    The rover rotates on the spot


### Story 4 - Moving a rover

    As a parser processing rover instructions
    When I encounter an M
    I move the rover one location in the direction the rover is facing
