using System;

class B {
	public static void SM() { Console.WriteLine("Hello from B.SM()"); }
	public virtual void VIM() { Console.WriteLine("Hello from B.VIM()"); }
	public void NIM() { Console.WriteLine("Hello from B.NIM()"); }
}

class C : B {

	new public static void SM() { Console.WriteLine("Hello from C.SM()"); }
	public override void VIM() { Console.WriteLine("Hello from C.VIM()"); }
	new public void NIM() { Console.WriteLine("Hello from C.NIM()"); }

}

class Test {
	public static void Main(String[] args){
		B b = new B();
		C c = new C();
		B.SM();
		b.VIM();
		b.NIM();
		C.SM();
		c.VIM();
		c.NIM();

	}
}
