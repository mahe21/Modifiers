namespace AccessModifiers
{
    public class Program : PrivateProtectedAccessModifier
    {
        static void Main(string[] args)
        {
            PublicModifier publicModifier = new PublicModifier();
            publicModifier.Intro();

            ConstructorsExample constructorsExample = new ConstructorsExample("Mahesh");
            ConstructorsExample constructorsExamples = new ConstructorsExample();

            PrivateProtectedAccessModifier privateProtectedAccessModifier = new PrivateProtectedAccessModifier(); 
            Program program = new Program();
            Console.WriteLine(program.name);
            Console.ReadLine();

            ProtectedInternalAccessModifier protectedInternalAccessModifier = new ProtectedInternalAccessModifier();
            Console.WriteLine(protectedInternalAccessModifier.name);


            

        }
    }
}