#!/usr/bin/env bash

mono Coco.exe -namespace Expressions Expressions.ATG
gmcs Expressions.cs Scanner.cs Parser.cs
mono Expressions.exe $1 run
mono Expressions.exe $1 check
