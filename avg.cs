using D=System.Console;

class std{

	public static void Main(string[] a){
		int m1,m2,m3,m4,m5;
		float avg;

		D.WriteLine("Enter marks of 5 sub:");
		m1=int.Parse(D.ReadLine());
		m2=int.Parse(D.ReadLine());
		m3=int.Parse(D.ReadLine());
		m4=int.Parse(D.ReadLine());
		m5=int.Parse(D.ReadLine());
		
		avg=(m1+m2+m3+m4+m5)/5;
		D.WriteLine("Average is: "+avg);

	}
}