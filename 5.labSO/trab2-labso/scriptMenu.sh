#!/bin/bash
clear
echo "Trabalho 2 - Aluno: Artur Oliveira Guedes"
Menu(){
echo "Escolha uma opção:"
echo -e "\t[1] Listar conteúdo da pasta atual"
echo -e "\t[2] Ver conteúdo de um arquivo"
echo -e "\t[3] Testar se uma maquina ip/nome está no ar"
echo -e "\t[0] Sair"
read op
case $op in
	1) Listar ;;
	2) Conteudo ;;
	3) Ping ;;
	0) Sair ;;
	*) clear; Menu ;;
esac
}
Fim(){
echo -e "\n"
Menu
}
Listar(){
clear
ls
Fim
}
Conteudo(){
clear
echo "Informe o nome do arquivo:"
read nome
if [ -f $nome ]; then
	clear
	echo -e "\n"
	cat $nome
else
	echo "Arquivo não encontrado"
fi
Fim
}
Ping(){
clear
echo "Informe um endereço:"
read endereco
if [ -z $endereco ]; then
	echo "Endereço vazio"
else
	ping -c 1 $endereco
	if [ $? -eq 0 ]; then
		echo -e "\nEndereço Online"
	else
		echo -e "\nEndereço Offline"
	fi
fi
Fim
}
Sair(){
exit
}
Menu
