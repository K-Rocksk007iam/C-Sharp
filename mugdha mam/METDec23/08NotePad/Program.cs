namespace _08NotePad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactory spellCheckerFactory = new SpellCheckerFactory();
            ISpellCheck frChecker = spellCheckerFactory.GetSpellChecker("fr");
            Notepad notepad1 = new Notepad(frChecker);
            notepad1.SpellCheck();
            HindiSpellChecker hindiChecker = new HindiSpellChecker();
            Notepad notepad = new Notepad(hindiChecker);
            notepad.SpellCheck();
           
        }
    }
    public class HindiSpellChecker : ISpellCheck
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Hindi Spellcheck Done");
        }
    }
    public class Notepad
    {
        SpellCheckerFactory Factory = new SpellCheckerFactory();
        ISpellCheck someSpellChecker = null;
        public Notepad(ISpellCheck spellchecker)//Constructor Dependency Injection 
        {
            if (spellchecker == null)
            {
                someSpellChecker = Factory.GetSpellChecker("eng");
            }
            else
            {
                someSpellChecker = spellchecker;
            }

        }

        #region lang input 
        //SpellCheckerFactory Factory = new SpellCheckerFactory();
        //ISpellCheck someSpellChecker = null;
        //public Notepad(string lang)
        //{
        //    if(lang == null)
        //    {
        //        someSpellChecker = Factory.GetSpellChecker("eng");
        //    }
        //    else
        //    {
        //        someSpellChecker =Factory.GetSpellChecker(lang);
        //    }

        //} 
        #endregion
        public void SpellCheck()
        {
            someSpellChecker.DoSpellCheck();
        }
        public void Cut()
        {
            Console.WriteLine("Cut Done");
        }
        public void Copy()
        {
            Console.WriteLine("Copy Done");
        }
        public void Paste()
        {
            Console.WriteLine("Paste Done");
        }
    }

    public interface ISpellCheck
    {
        void DoSpellCheck();
    }
    public class SpellCheckerFactory
    {
        public ISpellCheck GetSpellChecker(string lang)
        {
            ISpellCheck spellChecker = null;
            switch (lang) 
            {
                case "eng":
                    spellChecker = new EnglishSpellChecker();
                    break;
                case "gr":
                    spellChecker = new GermanSpellChecker();
                    break;
                case "fr":
                    spellChecker = new FrenchSpellChecker();
                    break;
                default:
                    spellChecker = new EnglishSpellChecker();
                    break;
            }
            return spellChecker;
        }
    }
    public class EnglishSpellChecker :ISpellCheck
    {
        public void DoSpellCheck()
        {
            //like a mini Project
            Console.WriteLine("English SpellCheck Done");
        }

    }
    public class GermanSpellChecker:ISpellCheck
    {
        public void DoSpellCheck()
        {
            //like a mini Project
            Console.WriteLine("German SpellCheck Done");
        }
    }
    public class FrenchSpellChecker:ISpellCheck
    {
        public void DoSpellCheck()
        {
            //like a mini Project
            Console.WriteLine("French SpellCheck Done");
        }
    }
}