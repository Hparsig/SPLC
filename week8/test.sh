#!/bin/bash

# files to test
FILES[0]='files/test.1.1.1'
FILES[1]='files/test.1.2.1'
FILES[2]='files/test.1.3.1'
FILES[3]='files/test.1.3.2'
FILES[4]='files/test.1.3.3'
FILES[5]='files/test.1.4.1'
FILES[6]='files/test.1.4.2'

# compile code
echo "----------------------------------------------------"
echo "compiling"

mono Coco.exe -namespace Expressions Expressions.ATG
gmcs Expressions.cs Scanner.cs Parser.cs

echo "----------------------------------------------------"
echo "compiling done"
echo "----------------------------------------------------"

echo "start tests"

for i in "${FILES[@]}"
do
  echo "------------------------------"
  echo "new test using file \"$i\" containing the following instructions"
  cat $i
  echo "output : "
  mono Expressions.exe $i run
  echo "check"
  mono Expressions.exe $i check
done
