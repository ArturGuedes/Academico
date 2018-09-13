#!/bin/bash
file=$1
if [ -z $file ]; then
        echo "Informe o nome do arquivo:"  
        read url
fi
case "$file" in
    *.txt)
        echo -e "\tÉ um arquivo de texto.\n"
        cat "$file";; 
    *.gif|*.jpg|*.png)
        echo -e "\tÉ uma figura.\n"
        xloadimage "$file";;
    *)
        echo -e "\tNão sei que arquivo é esse.\n";; 
esac
