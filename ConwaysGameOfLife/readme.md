# Conways Game of Life

The Game of Life is a cellular automaton devised by the  mathematician John Horton Conway in 1970.

The "game" is a **zero-player game**, meaning that its **evolution is determined by its initial state**, requiring no further input. One interacts with the Game of Life by creating an initial configuration and observing how it evolves or, for advanced players, by creating patterns with particular properties.


## The Rules

The universe of the Game of Life is an infinite two-dimensional orthogonal grid of square cells, each of which is in one of two possible states, alive or dead.

Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent. At each step in time, cells evaluate their state and transition between being alive and dead depending on their neighbours.

The initial pattern constitutes the seed of the system.

The first generation is created by applying the rule in the user stories below simultaneously to every cell in the seed. Births and deaths occur simultaneously, and the discrete moment at which this happens is  called a tick.

The rules continue to be applied repeatedly to create further generations.

## Expressed as user stories

Scenario 1:

    As a *player*
    When I start the program
    I see a gameboard on screen

Scenario 2:

    As a *player*
    When I start the program
    I can generate a random initial state

    Accept:
      Half or less of the cells set to alive at random
      Living cells visible on the rendered gameboard

Scenario 3:

    As a *living cell*
    When the game ticks
    I change state

    Accept:
      If cell has < 2 living neighbours, cell dies
      If cell has > 3 living neighbours, cell dies
      If cell has 2-3 living neighbours, cell lives


Scenario 4:

    As a *dead or empty cell*
    When the game ticks
    I change state

    Accept:
      If cell has 3 living neighbours, cell lives

Feel free to render the board and the states in any way, and in any language you like - but I'd recommend a command line app for the purpose of this excercise.

We'll be spending an hour.

## Example

Initial State:

| &nbsp; | &nbsp; | &nbsp; | &nbsp; |
| - | - | - | - |
|   | A |   |   |
|   | A |   |   |
|   | A |   |   |
|   |   |   | &nbsp;  |


Tick 1:

| &nbsp; | &nbsp; | &nbsp; | &nbsp; |
| - | - | - | - |
| &nbsp;  |   |   |   |
| A | A | A |   |
| &nbsp;  |   |   |   |
|   |   |   | &nbsp;  |

There are lots of [example patterns on wikipedia](http://en.wikipedia.org/wiki/Conway's_Game_of_Life#Examples_of_pattern)

---

We're going to be implementing Conways game of life - using [ping pong TDD](http://c2.com/cgi/wiki?PairProgrammingPingPongPattern).

Ping Pong TDD is a simple practice:

  * Dev 1 writes a new test and sees that it fails.
  * Dev 2 implements the code needed to pass the test.
  * Dev 2 writes the next test and sees that it fails.
  * Dev 1 implements the code needed to pass the test.

If this is your first time, try pairing with someone you don't normally work with.
