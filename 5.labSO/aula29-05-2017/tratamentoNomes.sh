echo "Digite seu nome:"
read  nome
echo "Letra inicial: ${nome:0:1}"
echo "Primeiro nome: ${nome%% *}"
echo "Sobrenome: ${nome#* }"
