/* Author Michael Jespersen
 * Date : 30 august 2013
 * Time : 14:00
 */
using System;
namespace SPLC.week1{
	class Product : CompositeExp{
		public Product(IExpression lval, IExpression rval):base(lval, rval){}
		
		public override double Eval(){
			return lval.Eval() * rval.Eval();
		}
		public override string ToString(){ return string.Format("({0} * {1})", lval, rval); }
	}
}
