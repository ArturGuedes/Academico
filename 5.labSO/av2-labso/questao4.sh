#!/bin/bash
if ! [ $dir ]
then
dir='.'
fi
ndir=$(ls -lR "$dir" | grep '^d' | wc -l)
nlin=$(ls -lR "$dir" | grep '^l' | wc -l)
narq=$(ls -lR "$dir" | grep '^-' | wc -l)
echo "No diretório atual:"
echo -e "\t Existem $ndir pastas e $narq arquivos\n"
