namespace AbstractClass
{
    public abstract class Report
    {
        protected abstract void parse();
        protected abstract void process();

        protected abstract void save();
        protected abstract void download();

        public void stepsToFollow()
        {
            parse(); process(); save(); download();
        }
    }

    public class PDF : Report
    {   
        protected override void  parse()
        {
            System.Console.WriteLine("PDF parse");
        }
        protected override void process()
        {
            System.Console.WriteLine("PDF processing");
        }
        protected override void save()
        {
            System.Console.WriteLine("PDF saved");
        }
        protected override void download()
        {
            System.Console.WriteLine("PDF downloading");
        }

    }

    public class DOCX : Report
    {
        protected override void parse()
        {
            System.Console.WriteLine("DOCX parse");
        }
        protected override void process()
        {
            System.Console.WriteLine("DOCX processing");
        }
        protected override void save()
        {
            System.Console.WriteLine("DOCX saved");
        }
        protected override void download()
        {
            System.Console.WriteLine("DOCX downloading");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Report report1 = new PDF();
            Report report2 = new DOCX();
            Console.WriteLine("PDF :");
            report1.stepsToFollow();
            Console.WriteLine("DOCX :");
            report2.stepsToFollow();
        }
    }
}