# Origin

This kata is adapted from reddit.com/r/dailyprogrammer - http://www.reddit.com/r/dailyprogrammer/comments/2ptrmp/20141219_challenge_193_easy_acronym_expander/

# Description

During online gaming (or any video game that requires teamwork), there is often times that you need to speak to your teammates.
Given the nature of the game, it may be inconvenient to say full sentences and it's for this reason that a lot of games have acronyms in place of sentences that are regularly said.

Example

    gg : expands to 'Good Game'
    brb : expands to 'be right back'

All this abbreviated text can be confusing and intimidating for someone new to a game. They're not going to instantly know what

    'gl hf all' (good luck have fun all)

means.

You are tasked with converting an abbreviated sentence into its full version.

## Wordlist

    lol - laugh out loud
    dw - don't worry
    hf - have fun
    gg - good game
    brb - be right back
    g2g - got to go
    wp - well played
    gl - good luck
    imo - in my opinion

## Story 1 - Expand abbreviations

As a newbie
When I read some text
Abbreviations are exploded into their full phrases

## Story 2 - Avoid sub-words

As a newbie
When a word contains an abbreviation
The word isn't broken up

    Accept: "there's a global variable over there"
            does not explode to
            "there's a good luck obal variable over there"
