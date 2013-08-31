/* Author Michael Jespersen
 * Date : 30 august 2013
 * Time : 14:00
 */

using System;
using SPLC.week1;

public class Test{

	public static void Main(String[] args){

		IExpression threePlusFour = new Sum(new Constant(3), new Constant(4));
		System.Console.WriteLine("Sum : " + threePlusFour.Eval());
		IExpression myExpression = new Product(new Constant(2), threePlusFour);
		System.Console.WriteLine("Product : " + myExpression.Eval());
    System.Console.WriteLine( myExpression.ToString() );
	}

}
