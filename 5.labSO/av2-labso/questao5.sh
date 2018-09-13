#!/bin/bash
url=$1
if [ -z $url ]; then
	echo "Informe um endereço: "  
        read url
fi
if [ -z $url ]; then
        echo "Endereço vazio"
else 
        ping -q -c 5 $url
        if [ $? -eq 0 ]; then
                echo -e  "\t$url esta funcionando\n"
        else
                echo -e  "\t$url não esta funcionando\n"
        fi
fi
