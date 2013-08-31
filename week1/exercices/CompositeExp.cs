/* Author Michael Jespersen
 * Date : 30 august 2013
 * Time : 14:00
 */

using System;

namespace SPLC.week1{

	public abstract class CompositeExp : IExpression{	
					
    protected IExpression lval;
    protected IExpression rval;

		public CompositeExp(IExpression lval, IExpression rval){

			this.lval = lval;
			this.rval = rval;

		}

		public abstract double Eval();

	}

}
