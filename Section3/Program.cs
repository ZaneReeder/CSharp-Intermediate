using System;

namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            var text1 = new Text();

            text1.Width = 100;
            text1.FontSize = 15;
            text1.FontName = "Raleway";
            text1.Copy();

            //Composition
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();


        }
    }
}
