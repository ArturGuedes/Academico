echo "Insira o nome 1:"
read nome1
echo "Insira o nome 2:"
read nome2

lnome1=${#nome1}
lnome2=${#nome2}

if [ $lnome1 == $lnome2 ]; then
	echo "Nomes tem o mesmo tamanho"
else
	echo "nomes tem o tamanho diferente"
fi

if [ $lnome1 -gt $lnome2 ]; then
	echo "$nome1 é maior que $nome2"
else
	echo "$nome2 é maior que $nome1"
fi




echoAlfa(){
	echo "$1 vem antes de $2"
}
if [ "$lnome1" > "$lnome2" ]; then
	echoAlfa $nome1 $nome2
else
	echoAlfa $nome2 $nome1
fi


