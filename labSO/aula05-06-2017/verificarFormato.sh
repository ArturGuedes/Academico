#!/bin/bash
nomearq=$1
if [ -z $nomearq ]; then
	echo "Defina o arquivo:"
	read nomearq
fi
case $nomearq in
	*.c ) echo "Codigo C";;
	*.py ) echo "Codigo Python";;
	*.txt) echo "Arquivo de texto";;
	*.o ) echo "Codigo Objeto";;
	* ) echo "Não reconhecido"
	return 1;;
esac
