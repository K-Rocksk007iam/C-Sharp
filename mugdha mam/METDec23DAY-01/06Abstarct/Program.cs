using System.ComponentModel.Design;

namespace _06Abstarct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Report report = new PDF();
            report.GetReports();
            
        }
    }

    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public void GetReports()
        {
            Parse();
            Validate();
            Save();
        }
    }
    
    public class PDF : Report
    {
        protected override void Parse()
        {
            //code here
            Console.WriteLine("PDF Parsed");
        }
        protected override void Validate()
        {
            //Code here
            Console.WriteLine("PDF Validated");
        }
        protected override void Save()
        {
            //Code here
            Console.WriteLine("PDF Saved");
        }
        
    }
    public class DOCX : Report
    {
        protected override void Parse()
        {
            //code here
            Console.WriteLine("DOCX Parsed");
        }
        protected override void Validate()
        {
            //Code here
            Console.WriteLine("DOCX Validated");
        }
        protected override void Save()
        {
            //Code here
            Console.WriteLine("DOCX Saved");
        }
        
    }
}