# 143-TddAsYouMeanIt
Repository to share source from this dojo


## Objectif: [TDD as if you meant it](https://cumulative-hypotheses.org/2011/08/30/tdd-as-if-you-meant-it/)

Du site voici un extrait
* Write exactly one new test, the smallest test you can that seems to point in the direction of a solution
* See it fail	
* Make the test from (1) pass by writing the least implementation code you can in the test method.
* Refactor to remove duplication, and otherwise as required to improve the design. Be strict about using these moves:
    * you want a new method—wait until refactoring time, then… create new (non-test) methods by doing one of these, and in no other way: 
        * preferred: do Extract Method on implementation code created as per (3) to create a new method in the test class, or 
        * if you must: move implementation code as per (3) into an existing implementation method 
    * you want a new class—wait until refactoring time, then… create non-test classes to provide a destination for a Move Method and for no other reason
        * populate implementation classes with methods by doing Move Method, and no other way

The member of the pair without their hands on the keyboard must be very strict in enforcing these rules, especially 4.1 and 4.2			

