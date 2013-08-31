/* Author Michael Jespersen
 * Date : 30 august 2013
 * Time : 14:00
 */

using System;

namespace SPLC.week1{

	public class Constant  IExpression{

		public Constant(double val){
			this.val = val;
		}
	
		public double Eval(){ return val; }
	}
}
