# Original Description

This is derived from a quiz posted on rubyquiz.com see: http://rubyquiz.com/quiz6.html

## Problem Description

GEDCOM (http://en.wikipedia.org/wiki/GEDCOM) is the "GEnealogical Data COMmunication" file format. It is a plain-text electronic format used to transfer genealogical data. The purpose of this quiz is to develop a simple parser than can convert a GEDCOM file to an XML file.

The GEDCOM file format is very straightforward. Each line represents a node in a tree. It looks something like this:

      0 @I1@ INDI
      1 NAME Jamis Gordon /Buck/
      2 SURN Buck
      2 GIVN Jamis Gordon
      1 SEX M

In general, each line is formatted thus:

      LEVEL TAG-OR-ID [DATA]


The above sample would be rendered in XML as

    <gedcom>
      <indi id="@I1@">
        <name value="Jamis Gordon /Buck/">
          <surn>Buck</surn>
          <givn>Jamis Gordon</givn>
        </name>
        <sex>M</sex>
        ...
      </indi>
      ...
    </gedcom>

* "0 @I1@ INDI". This starts a new subtree of type INDI (individual). The id for this individual is "@I1@".
* "1 NAME Jamis Gordon /Buck/". This starts a NAME subtree with a value of "Jamis Gordon /Buck/".
* "2 SURN Buck". This is a subelement of the NAME subtree, of type SURN ("surname").
* "2 GIVN Jamis Gordon". As SURN, but specifies the given name of the individual.
* "1 SEX M". Creates a new subelement of the INDI element, of type "SEX" (i.e., "gender").

This is a simplified version of GEDCOM, the real spec is very broad and features many other elements and relationship types - produce a file format converter that isn't looking for specific tags.

### Story 1 - File format conversion

    As a user
    When I pass a block of GEDCOM data
    I can transcode it to XML
