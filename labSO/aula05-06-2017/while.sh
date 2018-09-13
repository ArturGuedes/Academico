#!/bin/bash

n=$1
[ -z "$n" ] && echo Por favor defina um numero e tente novamente && exit;
fac=1 ; j=1

while [ $j -le $n ]
do
	fac=$(( $fac * $j ))
	j=$(($j+1))
done
echo O fatorial de $n, "$n"'!' = $fac
exit 0
