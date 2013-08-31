/* Michael Jespersen
 * 
 * SPLC 2013
 */


using System;

namespace SPLC.week1{

	class Sum : CompositeExp{
	
		public Sum(IExpression lval, IExpression rval):base(lval, rval){}

		public override double Eval(){

			return lval.Eval() + rval.Eval();

		}
	}

}
