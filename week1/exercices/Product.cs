using System;

namespace SPLC.week1{

	class Product : CompositeExp{

		public Product(IExpression lval, IExpression rval):base(lval, rval){}
		
		public override double Eval(){

			return lval.Eval() * rval.Eval();

		}
	}

}
