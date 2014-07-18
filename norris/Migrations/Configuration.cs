namespace norris.Migrations
{
    using norris.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<norris.Models.FactContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Suthar.Models.FactContext";
        }

        protected override void Seed(norris.Models.FactContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
           
         var fact = new Fact { Text = "When Mit Suthar throws exceptions, it's across the room.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);fact = new Fact { Text = "When Mit Suthar throws exceptions, it's across the room.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0}; context.Facts.Add(fact);

fact = new Fact { Text = "All arrays Mit Suthar declares are of infinite size, because Mit Suthar knows no bounds.", Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar doesn't have disk latency because the hard drive knows to hurry the hell up.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar writes code that optimizes itself.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can't test for equality because he has no equal.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar doesn't need garbage collection because he doesn't call .Dispose(), he calls .DropKick().",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' first program was kill -9.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "All browsers support the hex definitions #Mit and #Suthar for the colors black and blue.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "MySpace actually isn't your space, it's Mit's (he just lets you use it).",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can write infinite recursion functions... and have them return.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can solve the Towers of Hanoi in one move.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Project managers never ask Mit Suthar for estimations... ever!",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar doesn't use web standards as the web will conform to him.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "\"It works on my machine\" always holds true for Mit Suthar.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can delete the Recycle Bin.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' beard can type 140 wpm.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can unit-test entire applications with a single assert.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar doesn't bug hunt as that signifies a probability of failure, he goes bug killing.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' keyboard doesn't have a Ctrl key because NOTHING Controls Mit Suthar!",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "When Mit Suthar is surfing websites on Internet Explorer, he gets this warning message: \"Warning: Internet Explorer has deemed this user to be malicious or dangerous.  Proceed?\".",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Fact: Mit Suthar' keyboard has 2 keys: 0 and 1.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can make a class that is both abstract and final.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar could use anything in java.util.* to kill you, including the javadocs.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar demonstrated the meaning of Float.POSITIVE_INFINITY by counting to it, twice.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "A synchronize doesn't protect against Mit Suthar, if he wants the object, he takes it.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar doesn't use javac, he codes java by using a binary editor on the class files.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' java code never needs to be optimized. His code is so fast that it broke the speed of light during a test run in Sun's labs killing 37 people.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "When someone attempts to use one of Mit Suthar' deprecated methods, they automatically get a roundhouse kick to the face at compile time.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "The java.lang package originally contained a MitSuthar class, but it punched its way out the package during a design review and roundhouse kicked Bill Joy in the face.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar never has a bug in his code, EVER!",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar doesn't write code. He stares at a computer screen until he gets the progam he wants.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Code runs faster when Mit Suthar watches it.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' binary edited classes ignore Java bytecode verifier.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar methods don't catch exceptions because no one has the guts to throw any at them.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar will cast a value to any type just by staring at it.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "If you get a MitSutharException you'll probably die.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar is the only one who can use goto and const in Java.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can compile Java code in .NET Framework, obviously just by staring at it.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' code can roundhouse kick all other Java Objects' privates.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar eats JavaBeans and Roundhouse Kicks JavaServer Faces!",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can divide by 0!",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Garbage collector only runs on Mit Suthar' code to collect the bodies.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Every single line code of Mit Suthar runs in real time. Even in a multi threading application.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "When a CPU loads a Mit Suthar class file, it doubles the speed.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can execute 64bit length instructions in a 32bit CPU.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar implements \"Indestructible\". All the other creatures implements \"Killable\".",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar only programs Java web applications to get a .WAR in the end.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar once roundhouse kicked a Java class very hard. The result is known as a inner class.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can do multiple inheritance in Java.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "JVM never throws exceptions to Mit Suthar, not anymore. 753 killed Sun engineers is enough.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar doesn't need unit tests because his code always works. ALWAYS.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar extends God.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' classes can't be decompiled... don't bother trying.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can use pointers in Java.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can override a final function.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Java visibility levels are public, default, protected, private and \"protected by Mit Suthar\", don't try to access a field with this last modifier or you will get a Roundhouse kick to the face at runtime.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Attempting to throw a MitSutharException will result in failure and will terminate your program. Why? Because, you don't throw Mit Suthar... Mit Suthar throws YOU!",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit writes directly in binary. He then writes the source code as documentation for other developers.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit was forced to invent asynchronous APIs one day when he optimized a function so that it returned before it was invoked.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar wrote a complete Perl 6 implementation in a day, but then destroyed all evidence with his bare hands, so no one will know his secrets.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar refactors 10 million lines of Perl code before lunch.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar does not code; when he sits at a computer, it just does whatever he wants.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar doesn't make mistakes. He corrects God.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Code is too scared of Mit Suthar to be wrong.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar has actually been using Perl 6 since 1987, and has been waiting for Larry to play catch-up.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "\"My only boss is God. And Mit Suthar who is his boss.\"",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar writes understandable Perl code.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can read Perl code that was RSA encrypted.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar once wrote a 10 million lines C++ program in Microsoft Notepad without having to use the backspace key. And it compiled without errors or warnings, and was 100% bug-free.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Only perl and Mit Suthar can parse Perl.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "All Mit Suthar has to do is look at Perl code and it interprets itself out of fear and respect.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar wrote a program in Python that was easier to understand after being encrypted with RSA.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "The SQL condition \"LIKE '%Mit Suthar%'\" can only return Mit Suthar himself. Because nothing is like Mit Suthar.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar is never shown a login window. The computers sense his awesomeness and automagically log him in with administrator privileges.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "sudo is an alias for \"do this or i will roundhouse kick you\".",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "In C++ you only need to #include <MitSuthar>.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' Keyboard does not have any F1 key, he never needs any help.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar has no need for a compress utility. He just stares at the files and they shrink in fear.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar debugs binary code using a pencil and a sheet of paper.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "It was Mit Suthar that bit the apple in the Apple logo.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar uses windows 64 bit on 32 bit machine.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "The C in \"C language\" means Mit.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "An infinite loop in a Mit Suthar program takes 2.1 seconds to finish.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar' code has no error handling. Mit Suthar' code has no errors.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar's preferred sorting algorithm is killsort. It kills everything that is out of place.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "fork() in a Mit Suthar program returns a roundhouse kick in the face... there can be only one!!!",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "In plain C# every statement ends with a semicolon. But in Mit Suthar C# code all statements end with one or more exclamation marks. Because everything Mit Suthar does is amazing!",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar can deny the \"License Agreement\" and still be able to install the software.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Google won't search for Mit Suthar because it knows you don't find Mit Norrie finds you.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
fact = new Fact { Text = "Mit Suthar wrote Hello World once... it was called Unix.",Author = "Admin", Date = DateTime.Parse("2014-4-4"), UpVote = 0, DownVote = 0 }; context.Facts.Add(fact);
        }
    }
}
