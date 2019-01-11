using D=System.Console;

class std{

	public static void Main(string[] a){
		string name;
		int rollno;
		float per;

		D.WriteLine("Enter your name ");
		name=D.ReadLine();
		D.WriteLine("Enter your roll no ");
		rollno=int.Parse(D.ReadLine());
		D.WriteLine("Enter your percentage ");
		per=float.Parse(D.ReadLine());


		D.WriteLine("Name: "+name+" Roll no: "+rollno+" Percentage: "+per);

	}
}