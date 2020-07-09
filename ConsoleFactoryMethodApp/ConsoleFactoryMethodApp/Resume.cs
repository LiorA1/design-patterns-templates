using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFactoryMethodApp
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {

        // Factory Method implementation
        public override void CreatePages()
        {
            //Pages.Add(new Page()); // Cannot create an instance of the abstract class or interface 'Page'
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
