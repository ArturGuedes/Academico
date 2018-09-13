#!/bin/bash
a=$1
b=$2

if [[ $a -lt 100 ]] && [[ $b -gt 15 ]]
then
echo "$a -lt 100 -a $b -gt 15 : retorna verdadeiro"
else
echo "$a -lt 100 -a $b -gt 15 : retorna falso"
fi
