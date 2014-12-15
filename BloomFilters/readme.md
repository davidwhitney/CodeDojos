## Problem Description

A bloom filter (http://en.wikipedia.org/wiki/Bloom_filter#Algorithm_description http://billmill.org/bloomfilter-tutorial/) is a quick and memory efficient way to work out if some data is NOT in a given set, or MIGHT BE in a set.

You create a bloom filter by hashing each item in your set, and allocating them into bitmap - an array of bits with the hash used as the array position, and a bit set to 1 where the item is present.

At first it might not be apparent why you'd want to know if a item is definitely not in a set, and only that it MIGHT BE - but consider the problem of a dictionary. Hashes may well collide in a bloom filter, with two items producing the same hash, but there are plenty of scenarios where this isn't important.

We're going to build a dictionary using a bloom filter.

### Story 1 - Hashing words

    As a user
    Given a single word
    I can produce a single, bit-mappable-hash.

### Story 2 - Detecting mis-spelt words

    As a user
    When I type a sentence
    Words that are not in the word-list are returned as errors


### Hints

There's a built in hash function in .NET - how do you convert those into an array location?

There's a word list included.
