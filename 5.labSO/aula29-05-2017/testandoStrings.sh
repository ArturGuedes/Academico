echo "insira um texto"	
read  numero
if [ -z $numero ]; then
	echo "string vazia"
else
	echo "string digitada = $numero"
fi
