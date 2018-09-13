#!/bin/bash
echo Informe um nome
read nome
mkdir $nome
echo -e "\tDiretório $nome criado"
touch $nome.txt
echo -e "\tArquivo $nome.txt criado\n"

