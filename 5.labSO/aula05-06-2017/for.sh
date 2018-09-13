#!/bin/bash

sum=0

for j in 1 2 3 4 5 6 7 8 9 10
do
	sum=$(( $sum + $j ))
done
echo The sum is: $sum
echo The sum of numbers from 1 to n is : 'n*(n+1)/2'
echo Check value = $(( (sj*(sj+1))/2  ))
exit 0


