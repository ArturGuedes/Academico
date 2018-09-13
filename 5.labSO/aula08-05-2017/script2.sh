#INTERPRETADOR DE SCRIPTS:
#!/bin/bash

#Recebe o parametro passado junto a: ./script.sh "texto"
mkdir $1
cd $1
touch "$1"{1,2,3}.txt
