#!/bin/bash
file=$1
if [ -f $file ]
then
echo -e "o $file existe"
else
echo -e "o arquivo $file nao existe"
fi
