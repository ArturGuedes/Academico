#!/bin/bash
for filename in $(ls)
do
	# Pegar a extensão
	ext=${filename##*\.}
	case "$ext" in
	c) echo -e  "$filename :\t\t\t Arquivo C";;
	o) echo -e "$filename :\t\t\t Arquivo Objeto";;
	sh) echo -e "$filename :\t\t\t Shell script";;
	txt) echo -e "$filename :\t\t\t Arquivo de Texto";;
	*) echo -e "$filename :\t\t\t Arquivo desconhecido";;
esac
done

