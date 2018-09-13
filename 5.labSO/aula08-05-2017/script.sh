#INTERPRETADOR DE SCRIPTS:
#!/bin/bash

echo "Insira seu nome?"
read nome
mkdir $nome
cd $nome
touch "$nome"{1,2,3}.txt
