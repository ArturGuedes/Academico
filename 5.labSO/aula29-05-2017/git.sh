#!/bin/bash
echo "User name:"
read guser
echo "Email:"
read gemail
echo "Commit:"
read gcommit

git config --global user.name "$guser"
git config --global user.email "$gemail"

git add *
git commit -m "$gcommit"
git push
