// if (6 >= 3)
// {
//     Console.WriteLine("Hello, World!");
// }
// Console.ReadLine();



// Hämtar användarnamn från användaren
//  Console.Write("Ange ditt användarnamn: ");
//  string användarnamn = Console.ReadLine();

// Kontrollera om användarnamnet är "kalleanka"
//  if (användarnamn == "kalleanka")
//  {
//     Console.WriteLine("Welcome!");
//  }
//  else
//  {
//     Console.WriteLine("Fel användarnamn!");
//  }



// Hämtar användarnamn från användaren
//  Console.Write("Ange ditt användarnamn: ");
//  string användarnamn = Console.ReadLine();

// Hämtar lösenord från användaren
//  Console.Write("Ange ditt lösenord: ");
// string lösenord = Console.ReadLine();

// Kontrollera om användarnamnet är "kalleanka" och lösenordet är "12345"
//  if (användarnamn == "kalleanka" && lösenord == "12345")
//  {
//      Console.WriteLine("Welcome!");
//  }
//  else
//  {
//     Console.WriteLine("Wrong username or password");
//  }
    


// For-loop som skriver ut "Hello, World" 32 gånger
//     for (int i = 0; i < 32; i++)
// {
//      Console.WriteLine("Hello, World");
// }



// Det korrekta lösenordet
// string korrektLösenord = "12345";
// string användarensLösenord = "";

// While-loop som fortsätter tills användaren skriver in rätt lösenord
// while (användarensLösenord != korrektLösenord)
// {
// Fråga användaren efter lösenord
//     Console.Write("Ange ditt lösenord: ");
//     användarensLösenord = Console.ReadLine();

// Kontrollera om lösenordet är korrekt
//     if (användarensLösenord != korrektLösenord)
//     {
//         Console.WriteLine("Fel lösenord, försök igen.");
//     }
// }

// När rätt lösenord är inmatat
// Console.WriteLine("Welcome!");




// For-loop som körs 5 gånger
// for (int i = 0; i < 5; i++)
// {
// Fråga användaren om att skriva in ett tal
//     Console.Write("Ange ett tal: ");
//     string input = Console.ReadLine();

// Försök att konvertera inmatningen till ett heltal
//     int tal;
//     if (int.TryParse(input, out tal))
//     {
// Kontrollera om talet är högre än 5
//         if (tal > 5)
//         {
//             Console.WriteLine("högre än 5!");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Ogiltig inmatning, vänligen skriv in ett giltigt heltal.");
//     }
// }



    
// string input;
// int tal;

// While-loop som fortsätter så länge inmatningen inte kan konverteras till ett heltal
// while (true)
// {
// Fråga användaren om att skriva in en sträng
//     Console.Write("Ange ett tal: ");
//     input = Console.ReadLine();

// Försök att konvertera inmatningen till ett heltal
//     if (int.TryParse(input, out tal))
//     {
// Om konverteringen lyckas, bryt loopen
//         break;
//     }
//     else
//     {
// Om konverteringen misslyckas, skriv ut ett felmeddelande
//         Console.WriteLine("Ogiltig inmatning, vänligen skriv in ett giltigt heltal.");
//     }
// }

// När en giltig heltalsinmatning ges
// Console.WriteLine($"Du angav ett giltigt tal: {tal}");




        // Slumpa ett tal mellan 1 och 100
        Random random = new Random();
        int rättTal = random.Next(1, 101);

        // Variabel för användarens gissning
        int användarensGissning = 0;

        // Loop som körs tills användaren gissar rätt
        while (användarensGissning != rättTal)
        {
            // Fråga användaren om att skriva in en gissning
            Console.Write("Gissa ett tal mellan 1 och 100: ");
            string input = Console.ReadLine();

            // Försök att konvertera inmatningen till ett heltal
            if (int.TryParse(input, out användarensGissning))
            {
                // Kontrollera om gissningen är för låg, för hög eller exakt rätt
                if (användarensGissning < rättTal)
                {
                    Console.WriteLine("För låg gissning, försök igen.");
                }
                else if (användarensGissning > rättTal)
                {
                    Console.WriteLine("För hög gissning, försök igen.");
                }
                else
                {
                    Console.WriteLine("Grattis! Du gissade rätt!");
                }
            }
            else
            {
                // Om konverteringen misslyckas, skriv ut ett felmeddelande
                Console.WriteLine("Ogiltig inmatning, vänligen skriv in ett giltigt heltal.");
            }
        }






Console.ReadLine();