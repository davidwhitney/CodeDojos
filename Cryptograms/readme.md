# Original Description

This is derived from a quiz posted on rubyquiz.com see: http://rubyquiz.com/quiz13.html

## Problem Description

A cryptogram is piece of text that has been passed through a simple cipher that maps all instances of one letter to a different letter. The familiar rot13 encoding is a trivial example.

A solution to a cryptogram is a one-to-one mapping between two sets of (up to) 26 letters, such that applying the map to the cryptogram yields the greatest possible number from words in the dictionary.

Three unsolved cryptograms given. Each cryptogram uses a different cipher. **The cryptograms may contain a few words that are not in the dictionary**.

Theres a dictionary in the root of this repository you can use.

### Story - Detect cipher

    As a user, when I provide a cryptogram
    I want to detect the most likely cipher
    So I can crack codes!

        Accept: Translation output
                Translation with most valid detected words choosen

### Story - Output cipher

    As a user, when detect a cipher
    I want to output the cipher results to the screen
    So I can see which letters correspond in my match

    Accept: Cipher matches output

# Examples

Given this cryptogram

    gebo tev e cwaack cegn gsatkb ussyk

Output is


    Best match: mary had a little lamb mother goose

    Cipher
    abcdefghijklmnopqrstuvwxyz
    trl.a.m...e..by...ohgdi.s.


## CRYPTOGRAMS

Sample 1

    zfsbhd bd lsf xfe ofsr bsdxbejrbls sbsfra sbsf xfe ofsr xfedxbejrbls rqlujd jvwj fpbdls

Sample 2

    mkr ideerqruhr nrmsrru mkr ozgcym qdakm scqi oui mkr qdakm scqi dy mkr ideerqruhr nrmsrru mkr zdakmudua nja oui mkr zdakmudua goqb msodu

Sample 3

    ftyw uwmb yw ilwwv qvb bjtvi fupxiu t dqvi tv yj huqtvd mtrw fuw dwq bjmqv fupyqd
