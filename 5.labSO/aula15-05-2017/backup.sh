#!/bin/bash
file=$1
ln=$(wc -l $file)

mov(){
echo "Arquivo $file movido"
}
dir($dir){
echo "Diretório $dir criado"
}

if [ ln -lt 100 ]
then
	if [! -d pequeno ]
	then
	mkdir pequeno
	dir(pequeno)
	fi
	mv $file pequeno/
	mov()
elif [[ln -lt  500] && [ln -gt 100] ]
then
	if [! -d medio ]
	then
	mkdir medio
	dir(medio)
	fi
	mv $file medio/
	mov()
else
if [! -d grande]
then
mkdir grande
dir(grande)
fi
vc $file grande/
mov()
fi

