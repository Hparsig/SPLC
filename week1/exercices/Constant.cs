/* Author Michael Jespersen
 * Date : 30 august 2013
 * Time : 14:00
 */

using System;

namespace SPLC.week1{

	public class Constant : IExpression{

		double val=0;
					
		public Constant(double val){
			this.val = val;
		}
	
		public double Eval(){ return val; }
		
		public override string ToString(){ return val.ToString(); }
	}
}
