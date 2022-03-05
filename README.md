# PoP - Assignment 5
PoP - 5g

This assignment is about working with arrays. In this case, we were tasked with creating multiple arrays of arrays, and transpose them, etc.


# PoP - 5g


## Kode


5g0 compiles med fsharpc, og køres derefter med mono;

	$ fsharpc 5g0.fsx
	$ mono 5g0.exe


Til sidst compiles og køres 5g1 med fsharpc og mono;

	$ fsharpc 5g1.fsx
	$ mono 5g1.exe


Både 5g0.fsx og 5g1.fsx compiles til XML med fsharpc;

	$ fsharpc --doc:5g0.xml -a 5g0.fsx
	$ fsharpc --doc:5g1.xml -a 5g1.fsx





# 5g1 (c)

Transpose list does not recognize any of the spaces, and instead reuses the other functions.
This means that all of the disadvantages of the other functions, will also apply to TransposeLstLst.
It is also has a for-loop, which means that, in this case, it has a generally higher/worse run-time, than transposeArr.

Despite the code having its disadvantages, it does what it is supposed to do, and runs without any issues in this case.

TransposeArr makes use of functional programming due to the fact that it does not make use of any loops,
and has a better run time than our TransposeLstLst, since it maps every element in our array to a new place, in a new array.
This is doable due to the index adress of an array.



# 5g1 (d)

The difference between an imperative and functional approach, is that functional programming is more declarative,
and purely functional data structures are more consistent around the structure itself.

Arrays are generally more flexible, since they are mutable and can easily access specific elements. 
This is immediately more useful in imperative programming than functional programming.
It will, however, not be as easy to change the length of a given array.
