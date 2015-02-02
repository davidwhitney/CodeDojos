# Flood Filling

This dojo was derived from a post in reddit.com/r/dailyprogrammer here: http://www.reddit.com/r/dailyprogrammer/comments/2ug3hx/20150202_challenge_200_easy_floodfill/
There are a few changes, but this is mostly provided as-is.

Credit goes to the author and community there.

---

Flood-fill is a tool used in essentially any image editing program that's worth its salt. It allows you to fill in any contigious region of colour with another colour, like flooding a depression in a board with paint. For example, take this beautiful image. If I was to flood-fill the colour orange into this region of the image, then that region would be turned completely orange.

Today, you're going to implement an algorithm to perform a flood-fill on a text ASCII-style image.

### Challenge Input

You will accept two numbers, w and h, separated by a space.

* **You will then accept a grid of ASCII characters of size w*h.**
* **You will accept two numbers, x and y, and a character c**.
* `x` and `y` are the co-ordinates on the image where the flood fill should be done, and `c` is the character that will be filled.

Pixels are defined as contigious (touching) when they share at least one edge (pixels that only touch at corners aren't contigious).

For example:

    .....................................
    ...#######################...........
    ...#.....................#...........
    ...#.....................#...........
    ...#.....................#...........
    ...#.....................#...........
    ...#.....................#...........
    ...#.....................#######.....
    ...###.................##......#.....
    ...#..##.............##........#.....
    ...#....##.........##..........#.....
    ...#......##.....##............#.....
    ...#........#####..............#.....
    ...#........#..................#.....
    ...#.......##..................#.....
    ...#.....##....................#.....
    ...#...##......................#.....
    ...#############################.....
    .....................................
    .....................................
    .....................................
    .....................................

`8 12 @`

**Output**

    .....................................
    ...#######################...........
    ...#.....................#...........
    ...#.....................#...........
    ...#.....................#...........
    ...#.....................#...........
    ...#.....................#...........
    ...#.....................#######.....
    ...###.................##......#.....
    ...#@@##.............##........#.....
    ...#@@@@##.........##..........#.....
    ...#@@@@@@##.....##............#.....
    ...#@@@@@@@@#####..............#.....
    ...#@@@@@@@@#..................#.....
    ...#@@@@@@@##..................#.....
    ...#@@@@@##....................#.....
    ...#@@@##......................#.....
    ...#############################.....
    .....................................
    .....................................
    .....................................
    .....................................

# Sample Inputs and Outputs

**Input**

    ----------------
    -++++++++++++++-
    -+------------+-
    -++++++++++++-+-
    -+------------+-
    -+-++++++++++++-
    -+------------+-
    -++++++++++++-+-
    -+------------+-
    -+-++++++++++++-
    -+------------+-
    -++++++++++++++-
    -+------------+-
    -++++++++++++++-
    ----------------

`2 2 @`

**Output**

    ----------------
    -++++++++++++++-
    -+@@@@@@@@@@@@+-
    -++++++++++++@+-
    -+@@@@@@@@@@@@+-
    -+@++++++++++++-
    -+@@@@@@@@@@@@+-
    -++++++++++++@+-
    -+@@@@@@@@@@@@+-
    -+@++++++++++++-
    -+@@@@@@@@@@@@+-
    -++++++++++++++-
    -+------------+-
    -++++++++++++++-
    ----------------

**Input**

    aaaaaaaaa
    aaadefaaa
    abcdafgha
    abcdafgha
    abcdafgha
    abcdafgha
    aacdafgaa
    aaadafaaa
    aaaaaaaaa

`8 3 ,`

**Output**

    ,,,,,,,,,
    ,,,def,,,
    ,bcd,fgh,
    ,bcd,fgh,
    ,bcd,fgh,
    ,bcd,fgh,
    ,,cd,fg,,
    ,,,d,f,,,
    ,,,,,,,,,


# Extension (Easy/Intermediate)

Extend your program so that the image 'wraps' around from the bottom to the top, and from the left to the right (and vice versa). This makes it so that the top and bottom, and left and right edges of the image are touching (like the surface map of a torus).

**Input**

    \/\/\/\.\
    /./..././
    \.\.\.\.\
    /.../.../
    \/\/\/\/\
    /.../.../
    \.\.\.\.\
    /./..././
    \/\/\/\.\

`1 7 #`

**Output**

    \/\/\/\#\
    /#/###/#/
    \#\#\#\#\
    /###/###/
    \/\/\/\/\
    /###/###/
    \#\#\#\#\
    /#/###/#/
    \/\/\/\#\
