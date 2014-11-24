# ID3 Tags

The MP3 file format, didn't provide any means for including metadata about the song.

**ID3 tags** were invented to solve this problem.

* You can tell if an MP3 file includes **ID3 tags** by examining the *last 128 bytes* of the file.
* If they begin with the characters TAG, you have found a ID3 tag.

**Tags are fixed-width fields with no spacing between them.**

`Song`, `album`, `artist`, and `comment` are **30 bytes each**.
The `year` is four bytes and the `genre` just gets one, which is an index into a list of predefined genres.

The format of the tag is as follows:

    Field      | TAG | song | artist | album | year | comment | genre
    Byte Width | 3   | 30   | 30     | 30    | 4    | 30      | 1
    ------------------------------------------------------------------
    128 Bytes

A minor change was later made to ID3 tags to allow them to include track numbers, creating ID3v1.1. In that format, if the 29th byte of a comment is null and the 30th is not, the 30th byte is an integer representing the track number.


This is derived from a quiz posted on rubyquiz.com see: http://rubyquiz.com/quiz136.html

## Lets write a parser!

Scenario 1:

    As a *user*
    When I run the program against an MP3 file
    Any tag present is identified

Scenario 2:

    As a *user*
    When an ID3 tag is detected
    Tag data is output to the screen

    Accept:
      When no tag found "No tag found" outputted

Scenario 3:

    As a *user*
    When an ID3 tag has a track number
    The track number is correctly outputted

## Test Data

The file `frederic-chopin-piano-sonata-2-op35-3-funeral-march.mp3` is included in this repository - sourced from the collection at [mfiles](http://www.mfiles.co.uk/mp3-files.htm)

If you open this file up in a hex editor (tip: you can rename the file to .bin and Visual Studio will happily open it) and the last 128 bytes of the file look like this

    TAGFuneral March (Sonata Op.35)Frederic Chopinwww.mfiles.co.uk© Music Files Ltd

This is an ID3V1 tag, with no track information.

## Genre list

The official ID3v1 genre list is this, and it's zero-indexed (i.e. Blues is 0, Classic Rock is 1...)

    Blues
    Classic Rock
    Country
    Dance
    Disco
    Funk
    Grunge
    Hip-Hop
    Jazz
    Metal
    New Age
    Oldies
    Other
    Pop
    R&B
    Rap
    Reggae
    Rock
    Techno
    Industrial
    Alternative
    Ska
    Death Metal
    Pranks
    Soundtrack
    Euro-Techno
    Ambient
    Trip-Hop
    Vocal
    Jazz+Funk
    Fusion
    Trance
    Classical
    Instrumental
    Acid
    House
    Game
    Sound Clip
    Gospel
    Noise
    AlternRock
    Bass
    Soul
    Punk
    Space
    Meditative
    Instrumental Pop
    Instrumental Rock
    Ethnic
    Gothic
    Darkwave
    Techno-Industrial
    Electronic
    Pop-Folk
    Eurodance
    Dream
    Southern Rock
    Comedy
    Cult
    Gangsta
    Top 40
    Christian Rap
    Pop/Funk
    Jungle
    Native American
    Cabaret
    New Wave
    Psychadelic
    Rave
    Showtunes
    Trailer
    Lo-Fi
    Tribal
    Acid Punk
    Acid Jazz
    Polka
    Retro
    Musical
    Rock & Roll
    Hard Rock
    Folk
    Folk-Rock
    National Folk
    Swing
    Fast Fusion
    Bebob
    Latin
    Revival
    Celtic
    Bluegrass
    Avantgarde
    Gothic Rock
    Progressive Rock
    Psychedelic Rock
    Symphonic Rock
    Slow Rock
    Big Band
    Chorus
    Easy Listening
    Acoustic
    Humour
    Speech
    Chanson
    Opera
    Chamber Music
    Sonata
    Symphony
    Booty Bass
    Primus
    Porn Groove
    Satire
    Slow Jam
    Club
    Tango
    Samba
    Folklore
    Ballad
    Power Ballad
    Rhythmic Soul
    Freestyle
    Duet
    Punk Rock
    Drum Solo
    A capella
    Euro-House
    Dance Hall
