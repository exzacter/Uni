# Number Theory 0.1P

## Module Learning Objectives

1. Compute the prime factorisation of integers and use it to compare the lowest common multiple and greatest common divisor of the two numbers
2. Apply the euclidean algorithm for finding the greatest common divisor of two numbers
3. Convert between number bases representations of numbers
4. Compute the values of large powers of a number in modular arithmetics

## Division 

If given numbers [a] and [b] it is possible that [a] / [b] gives a whole number. In this case we say that [b] divides [a]. (In symbols we write b | a).

If this holds, then [b] is a divsor or factor of [a], and [a] is a multiple of [b]. In other words, if [b] | [a], then [a] = [bk] for some integer [k] (this is saying [a] is some mulitple of [b])

### The Divisibility Relation
Given integers [m] and [n] we say "m divides n" and write:
  [m] | [n] 
e.g 4 (m) | 8 (n)
provided [n] / [m] is an integer (a whole number). Thus the following assertions mean the same thing:
  1. [m] | [n] 
  2. [n] = [mk] for some integer [k]
  3. [m] is a factor (or divsor) of [n]
  4. [n] is a multiple of [m]

[m] | [n] is a statement. True or False (boolean). On the other hand [n] / [m] is some number (it will always have an output wether integer or float)

If we want to claim that [n] / [m] is not a integer (so [m] does not divide [n]) then we write [m] \nmid [n] (special character but its a line through the pipe) 

#### Example 5.2.1
1. 4 | 20, or 20 / 4. In this circumstance we can see that 20 / 4 = 5. So, [True], 4 divides 20.
2. 20 | 4, or 4 / 20. In this case, it is possible to divide the 2, however not to an integer. Therefore [False] (20 \nmid 4)
3. 0 | 5, or 5 / 0. Nothing is divisible by 0 or other way around. Therefore [False] (0 \nmid 5)
4. 5 | 0, or 0 / 5. As above. [False] (5 \nmid 0) - Wrong according to examples. 0 is a multiple of every number therefore x = any number - x | 0 is true for all. 
5. 7 | 7, or 7 / 7. 7 is divisible by seven with no remainders. Therefore [True] - Where x (integer given) is the same both sides x | x is always true 
6. 1 | 37, or 37 / 1. Possible as 1 can go into any number (other than 0) that amount of times. [True]
7. -3 | 12, or 12 / -3. Possible due to negative times or divide negative equals a positive. [True]
8. 8 | 12, or 12 / 8. Not possible, leaves remainders. [False] (8 \nmid 12)
9. 1642 | 136299, or 136299 / 1642. Immediate answer is no, due to the fact 1642 is an even number therefore couldnt be divisable into a odd number. [False] (1642 \nmid 136299)

### Division Algorithm 
Given any two integers [a] and [b], we can always find an integer [q] (being the integer that can be multiplied into b that the queation can work to its min values) such that:
  [a] = [qb] + r 
where r is an integer satisfying 0 <= [r] < [|b|]
E.G. 
  1642 | 136299
    How much can i multiply 1642 ([b]) by to get 136299 [a]. 
  1642 * 100 = 164200 > [a]
  1642 * 50 = 82100
    So we know that it needs to be in between these values
    Because * 100 is closer than 50 we will work down by 10's until we pass or hit [a]
  1642 * 90 = 147780 > [a]
  1642 * 80 = 131360 < [a]
    Now we know between [b] * 90 and [b] * 80
  1642 * 81 = 133002 < [a]
  1642 * 82 = 134644 < [a]
  1642 * 83 = 136286 < [a]
  1642 * 84 = 137928 > [a]
    So we know now that the largest we can multiply without going over [a] = 83
    Therfore:
  136299 or [a] - (1642 * 84) 136286 =
  13
    From this the equation above is:
  135299 [a] = 83[q]1642[b] + 13 [r]  

The idea is that we can always take a large enough multiple of [b] so that the remainder of [r] is as small as possible. (We do allow the possibility of [r]=0, in which case [b] | [a]) 

### Remainder Classes 
The division algorithm tells us that there are only [b] possible remainders when dividing by [b]. If we fix this divisor, we can group integers by the remainder?. Each group is called a remainder class modulo [b] (or sometimes residue class).

Note in the example below every integer is in exactly on remainder class. The technical way to say this is that the remainder classes modulo [b] form a {partition} of the integers

The most important fact about partitions is that it is possible to define an !!equivalence relation!! from a partition. 
    !!equivalence relation, is binary relation on a set that satisfies 3 important properties:
        1. Reflexive: Every integer is equal to itself [a] = [a]
        2. Symmetric: If [a] = [b] then, [b] = [a]
        3. Transitive: If [a] = b and [b] = [c] then [a] = [c]
This is the relationship between pairs of numbers which acts ina ll the important ways like the "equals" relationship

TLDR. If two numbers belong to the same remainder class, then in some way, they are the same. That is, they are the same up to division by [b]. In the case where [b] = 5 above, the numbers 8 and 23, while not being the same number, are the same when it comes to dividing by 5. Because both have a remainder of 3. 


#### Example 5.2.2
Describe the remainder classes modulo 5 ([b])

not to certain about the question however going to guess before looking at solution.

interpeting this as what are the remaining remainders or integers in the class of 5? so it would be 1-5? or 0-4? unsure.

A: 1-5

Actual answer: The answer is 5. This is actually 0-4. As when dividing by 5. You can only have 5 remainders. Explanation:
  Use the equation a = 5[b]q + 0[r]. You get one set of values where the remainder is 0 or {-15, -10, -5, 0, 5, 10, 15}
  where r = 1 {-14, -9, -4, 1, 6, 11, 16}
  So on until you get to 4. 

### Congruence Modulo 
With this in mind. We want to say 8 and 23 are basically the same, but not exactly. It would be wrong to write 8 = 23, so we use 8 \equiv (3 line equals sign) 23. But this is also not always true. It works when we are talking about dividing by 5 but not 7 for example. So:
  8 \equiv 23 (mod 5)
    This is read as 8 is congruent to 23 modulo 5 (or just mod 5). AKA 8 is the same as 23 when dividing by 5
  8 \not\equiv 23 (mod 7)
    This is read as 8 is not congruent to 23 modulo 7 (or just mod 7). AKA 8 is not the same as 23 when dividing by 7

We say that [a] is congruent to [b] modulo [n] and write:
  a \equiv [b] (mod [n])


Main question of number theory: What mathematical discoveries can we make about the natural numbers themselves?
RSA cryptography uses number theory to encrypt data. 
