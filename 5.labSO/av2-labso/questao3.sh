#!bin/bash
for arq in *.*
do
	tam=$(wc -c <"$arq")
	if [ $tam -ge 500000 ]; then
		echo "$arq"
	fi
done

