using System;


class B {

	public int nf;
	public static int sf;
	public B( int i ) { nf = i; sf = i + 1; }

}

class C : B {

	new public int nf;
	new public static int sf;
	public C( int i ) : base( i+20 ) { nf = i; sf = i+2; }

}

class D : C {

	new public int nf;
	public D( int i ) : base( i+40 ) { nf = i; sf = i+4; }

}


public class TestClass{
	public static void Main(String[] args){
		Console.WriteLine("Application running");
		String t = new String[4]();

		Console.WriteLine( t );
		C c1 = new C(100);
		B b1 = c1;
		Console.WriteLine( C.sf + " " + B.sf );
	}
}
