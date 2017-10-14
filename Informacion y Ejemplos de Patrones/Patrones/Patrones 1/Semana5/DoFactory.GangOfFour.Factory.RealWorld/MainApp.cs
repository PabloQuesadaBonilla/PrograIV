using System;
using System.Collections;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Factory.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Factory Method Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name+ "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.Read();        
        }
    }
    // Estos son los tipos de paginaas q tengo
    // 
    // "Product"

    abstract class Page
    {
    }

    // "ConcreteProduct"

    class SkillsPage : Page
    {
    }

    // "ConcreteProduct"

    class EducationPage : Page
    {
    }

    // "ConcreteProduct"

    class ExperiencePage : Page
    {
    }

    // "ConcreteProduct"

    class IntroductionPage : Page
    {
    }

    // "ConcreteProduct"

    class ResultsPage : Page
    {
    }

    // "ConcreteProduct"

    class ConclusionPage : Page
    {
    }

    // "ConcreteProduct"

    class SummaryPage : Page
    {
    }

    // "ConcreteProduct"

    class BibliographyPage : Page
    {
    }

    //-------------------------------------------------------------------------------------------------------------------------------------//
    // "Creator"

    abstract class Document
    {
        //// este mae lo tenemos q agregar 
        //private List<Page> pages0 = new List<Page>();

        private ArrayList pages = new ArrayList();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public ArrayList Pages
        {
            get{ return pages; }
        }

        //// sobreescribimos para poder aceptar la lista
        //public List<Page> Pages
        //{
        //    get { return pages0; }
        //}

        // Factory Method
        public abstract void CreatePages();
    }

    // "ConcreteCreator"

    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new SummaryPage());
        }
    }

    // "ConcreteCreator"

    class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
            Pages.Add(new EducationPage());
        }
    }
}
