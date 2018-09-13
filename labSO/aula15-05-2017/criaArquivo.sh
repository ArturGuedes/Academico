#!/bin/bash
f=$1
if [ -f $f ]
then
echo -e "O $f existe"
else
echo -e "O $f não existe"
touch $f
echo -e "Arquivo $f criado"
ls
fi
