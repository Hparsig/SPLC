using System;

public class HelloWorld{
	static void Main(String[] args){
		//var test = 1;
		String s = args.Length > 0 ? "Hello " + args[0] : "Hello World";
		System.Console.WriteLine(s);
	}
}
