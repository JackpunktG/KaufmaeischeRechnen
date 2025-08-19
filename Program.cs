using System.ComponentModel.DataAnnotations;

Console.WriteLine("***Willkommen zu Kaufmaeische Rechner hilfe***\n   \tZusammen sind wir stark!!");

while (true)
{
    Console.WriteLine("\nOptions\n1 - Verkaufskalkulation\n2 - Einkaufskalkulation\n3 - Differenzkalkulation\n5 - Schliessen");

    int option = 0;
    try { option = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Ungueltig Eingaben"); }

    switch (option)
    {
        case 1:
            VerkaufsKalkulation();
            break;
        case 2:
            EinkaufsKalkulation();
            break;
        case 3:
            DifferenzKalkulation();
            break;
        case 5:
            Console.WriteLine("Ciao!");
            return;
        default:
            Console.WriteLine("Ungueltig Eingaben");
            break;
    }
}


void DifferenzKalkulation()
{
    decimal bruttoverkaufspreis = 0; decimal liefererrabatt = 0; decimal liefererskonto = 0;
    decimal beuzugskosten = 0; decimal handlungskostenzuschlagsatz = 0; decimal listeneinkauspreis = 0;
    decimal kundenskonto = 0; decimal vertreterprovision = 0; decimal kundenrabatt = 0;
    decimal umsatzsteuer = 0;

    Console.WriteLine("\nEinkaufsKalkulation... Lets go!!!\n");
    Console.WriteLine("Willst du langsam schritt für schritt gehen (also ich warte zwischen jeden zwischenergibniss?\n(Y/N - Eingeben)");
    string eingeben = Console.ReadLine().ToLower();

    bool langsam;

    if (eingeben == "y")
    {
        langsam = true;
        Console.WriteLine("Return nach jeden zwischen ergebniss");
    }
    else if (eingeben == "n") langsam = false;
    else
    {
        Console.WriteLine("Unguelitig Eingeben... Wir machen langsam");
        langsam = true;
    }

    bool richtigEingeben = false;
    Console.WriteLine("\nJetzt kommen die Eingabefelder  \n'0' eintippen wenn's nicht angegeben.\n'-1' eintippen falls du was falsch getippt hast - es bringt dir wieder zum Main menu\nAusgeben wurden mit punkt als decimal angezeigt.\nAchtung!!! Keinen Tausendertrennzeichen eingeben\n ");

    while (!richtigEingeben)
    {
        Console.Write("Listeneinkauspreis (€):");
        string input = Console.ReadLine();
        
        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            listeneinkauspreis = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;

        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("liefererrabatt (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            liefererrabatt = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("liefererskonto (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            liefererskonto = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("beuzugskosten (€):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            beuzugskosten = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("handlungskostenzuschlagsatz (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            handlungskostenzuschlagsatz = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("kundenskonto (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            kundenskonto = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("vertreterprovision (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            vertreterprovision = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("kundenrabatt (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            kundenrabatt = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("umsatzsteuer (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            umsatzsteuer = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("Bruttoverkaufspreis (€):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            bruttoverkaufspreis = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }

    Console.WriteLine("Los geht's :)\n");

    decimal differez = 100 - liefererrabatt;
    decimal zieleinkaufspreis = KaufmaeischeRunden(listeneinkauspreis * differez / 100);
    Console.WriteLine($"listeneinkauspreis - liefererrabatt\t {listeneinkauspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {zieleinkaufspreis} zieleinkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();


    differez = 100 - liefererskonto;
    decimal bareinkaufspreis = KaufmaeischeRunden(zieleinkaufspreis * differez / 100);
    Console.WriteLine($"zeileinkaufspreis - liefererskonto\t {zieleinkaufspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {bareinkaufspreis} bareinlaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    decimal bezugspreis = KaufmaeischeRunden(bareinkaufspreis + beuzugskosten);
    Console.WriteLine($"bareinkaufspreis + beuzugskosten\t {bareinkaufspreis} + {beuzugskosten}");
    Console.WriteLine($"\t\t\t= {bezugspreis} bezugspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 + handlungskostenzuschlagsatz;
    decimal selbstkosten = KaufmaeischeRunden(bezugspreis * differez / 100);
    Console.WriteLine($"bezugspreisgskostenzuschlagsatz\t {bezugspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {selbstkosten} selbstkosten");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    Console.WriteLine("-----------\nJetzt Rueckwaerts zu Barverkaufspreis\n");

    differez = 100 + umsatzsteuer;
    decimal nettoverkaufspreis = KaufmaeischeRunden(bruttoverkaufspreis * 100 / differez);
    Console.WriteLine($"bruttoverkaufspreis - umsatzsteuer \t {bruttoverkaufspreis} * 100 / {differez}");
    Console.WriteLine($"\t\t\t= {nettoverkaufspreis} nettoverkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 - kundenrabatt;
    decimal zeilverkaufspreis = KaufmaeischeRunden(nettoverkaufspreis * differez / 100);
    Console.WriteLine($"nettoverkaufspreis - kundenrabatt\t {nettoverkaufspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {zeilverkaufspreis} zeilverkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 - kundenskonto - vertreterprovision;
    decimal barverkaufspreis = KaufmaeischeRunden(zeilverkaufspreis * differez / 100);
    Console.WriteLine($"zeilverkaufspreis - kundenskonto & vertreterprovision\t {zeilverkaufspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {barverkaufspreis} barverkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    Console.WriteLine("----------------\nGewinnkalkulation\n");

    decimal gewinn = KaufmaeischeRunden(barverkaufspreis - selbstkosten);
    Console.WriteLine($"barverkaufspreis - selbstkosten\t {barverkaufspreis} - {selbstkosten}");
    Console.WriteLine($"\t\t\t= {gewinn} Gewinn (Euro)");

    decimal gewinnzuschladsatz = KaufmaeischeRunden(gewinn * 100 / selbstkosten);
    Console.WriteLine($"Gewinn * 100 / selbstkosten\t {gewinn} * 100 / {selbstkosten}");
    Console.WriteLine($"\t\t\t= {gewinnzuschladsatz} gewinnzuschladsatz (%)");
}

void EinkaufsKalkulation()
{
    decimal bruttoverkaufspreis = 0; decimal liefererrabatt = 0; decimal liefererskonto = 0;
    decimal beuzugskosten = 0; decimal handlungskostenzuschlagsatz = 0; decimal gewinnzuschlagsatz = 0;
    decimal kundenskonto = 0; decimal vertreterprovision = 0; decimal kundenrabatt = 0;
    decimal umsatzsteuer = 0;

    Console.WriteLine("\nEinkaufsKalkulation... Lets go!!!\n");
    Console.WriteLine("Willst du langsam schritt für schritt gehen (also ich warte zwischen jeden zwischenergibniss?\n(Y/N - Eingeben)");
    string eingeben = Console.ReadLine().ToLower();

    bool langsam;

    if (eingeben == "y")
    {
        langsam = true;
        Console.WriteLine("Return nach jeden zwischen ergebniss");
    }
    else if (eingeben == "n") langsam = false;
    else
    {
        Console.WriteLine("Unguelitig Eingeben... Wir machen langsam");
        langsam = true;
    }

    bool richtigEingeben = false;
    Console.WriteLine("\nJetzt kommen die Eingabefelder\n'0' eingeben wenn's nicht angegeben.\n'-1' angeben falls du was falsch getippt hast - es bringt dir wieder zum Main menu\nAusgeben wurden mit punkt als decimal angezeigt.\nAchtung!!! Keinen Tausendertrennzeichen eingeben\n");

    while (!richtigEingeben)
    {
        Console.Write("Bruttoverkaufspreis (€):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            bruttoverkaufspreis = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("liefererrabatt (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            liefererrabatt = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("liefererskonto (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            liefererskonto = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("beuzugskosten (€):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            beuzugskosten = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("handlungskostenzuschlagsatz (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            handlungskostenzuschlagsatz = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("gewinnzuschlagsatz (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            gewinnzuschlagsatz = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("kundenskonto (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            kundenskonto = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("vertreterprovision (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            vertreterprovision = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("kundenrabatt (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            kundenrabatt = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("umsatzsteuer (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            umsatzsteuer = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }

    Console.WriteLine("Los geht's :)\n");

    decimal differez = 100 + umsatzsteuer;
    decimal nettoverkaufspreis = KaufmaeischeRunden(bruttoverkaufspreis * 100 / differez);
    Console.WriteLine($"bruttoverkaufspreis - umsatzsteuer \t {bruttoverkaufspreis} * 100 / {differez}");
    Console.WriteLine($"\t\t\t= {nettoverkaufspreis} nettoverkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 - kundenrabatt;
    decimal zeilverkaufspreis = KaufmaeischeRunden(nettoverkaufspreis * differez / 100);
    Console.WriteLine($"nettoverkaufspreis - kundenrabatt\t {nettoverkaufspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {zeilverkaufspreis} zeilverkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 - kundenskonto - vertreterprovision;
    decimal barverkaufspreis = KaufmaeischeRunden(zeilverkaufspreis * differez / 100);
    Console.WriteLine($"zeilverkaufspreis - kundenskonto & vertreterprovision\t {zeilverkaufspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {barverkaufspreis} barverkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 + gewinnzuschlagsatz;
    decimal selbstkosten = KaufmaeischeRunden(barverkaufspreis * 100 / differez);
    Console.WriteLine($"barverkaufspreis - gewinnzuschladsatz\t {barverkaufspreis} * 100 / {differez}");
    Console.WriteLine($"\t\t\t= {selbstkosten} selbstkosten");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 + handlungskostenzuschlagsatz;
    decimal bezugspreis = KaufmaeischeRunden(selbstkosten * 100 / differez);
    Console.WriteLine($"selbstkosten - Handlungskosten\t {selbstkosten} * 100 / {differez}");
    Console.WriteLine($"\t\t\t= {bezugspreis} bezugspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    decimal bareinkaufspreis = KaufmaeischeRunden(bezugspreis - beuzugskosten);
    Console.WriteLine($"bezugspreis - Bezugskosten\t {bezugspreis} - {beuzugskosten}");
    Console.WriteLine($"\t\t\t= {bareinkaufspreis} bareinkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 - liefererskonto;
    decimal zeileinkaufspreis = KaufmaeischeRunden(bareinkaufspreis * 100 / differez);
    Console.WriteLine($"bareinkaufspreis + Lieferskonto\t {bareinkaufspreis} * 100 / {differez}");
    Console.WriteLine($"\t\t\t= {zeileinkaufspreis} zeileinkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 - liefererrabatt;
    decimal listeneinkauspreis = KaufmaeischeRunden(zeileinkaufspreis * 100 / differez);
    Console.WriteLine($"zeileinkaufspreis + Lieferrabatt\t {zeileinkaufspreis} * 100 / {differez}");
    Console.WriteLine($"\t\t\t= {listeneinkauspreis} listeneinkauspreis");

}

void VerkaufsKalkulation()
{

    decimal listeneinkauspreis = 0; decimal liefererrabatt = 0; decimal liefererskonto = 0;
    decimal beuzugskosten = 0; decimal handlungskostenzuschlagsatz = 0; decimal gewinnzuschlagsatz = 0;
    decimal kundenskonto = 0; decimal vertreterprovision = 0; decimal kundenrabatt = 0;
    decimal umsatzsteuer = 0;

    Console.WriteLine("\nVerkaufskalkullations... Lets go!!!\n");
    Console.WriteLine("Willst du langsam schritt für schritt gehen (also ich warte zwischen jeden zwischenergibniss?\n(Y/N - Eingeben)");
    string eingeben = Console.ReadLine().ToLower();

    bool langsam;

    if (eingeben == "y")
    {
        langsam = true;
        Console.WriteLine("Return nach jeden zwischen ergebniss");
    }
    else if (eingeben == "n") langsam = false;
    else
    {
        Console.WriteLine("Unguelitig Eingeben... Wir machen langsam");
        langsam = true;
    }

    bool richtigEingeben = false;
    Console.WriteLine("\nJetzt kommen die Eingabefelder\n'0' eingeben wenn's nicht angegeben.\n'-1' angeben falls du was falsch getippt hast - es bringt dir wieder zum Main menu\nAusgeben wurden mit punkt als decimal angezeigt.\nAchtung!!! Keinen Tausendertrennzeichen eingeben\n ");

    while (!richtigEingeben)
    {
        Console.Write("Listeneinkaufspreis (€):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            listeneinkauspreis = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("liefererrabatt (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            liefererrabatt = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("liefererskonto (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            liefererskonto = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("beuzugskosten (€):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            beuzugskosten = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("handlungskostenzuschlagsatz (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            handlungskostenzuschlagsatz = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("gewinnzuschlagsatz (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            gewinnzuschlagsatz = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("kundenskonto (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            kundenskonto = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("vertreterprovision (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            vertreterprovision = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("kundenrabatt (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            kundenrabatt = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }
    richtigEingeben = false;

    while (!richtigEingeben)
    {
        Console.Write("umsatzsteuer (%):");
        string input = Console.ReadLine();

        if (input.Contains(",")) input = input.Replace(',', '.');
        if (input == "-1") return;
        try
        {
            umsatzsteuer = decimal.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            richtigEingeben = true;
        }
        catch { Console.WriteLine("Ungueltig Eingabe"); }
    }

    Console.WriteLine("Los geht's :)\n");

    decimal differez = 100 - liefererrabatt;
    decimal zieleinkaufspreis = KaufmaeischeRunden(listeneinkauspreis * differez / 100);
    Console.WriteLine($"listeneinkauspreis - liefererrabatt\t {listeneinkauspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {zieleinkaufspreis} zieleinkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

     
    differez = 100 - liefererskonto;
    decimal bareinkaufspreis = KaufmaeischeRunden(zieleinkaufspreis * differez / 100);
    Console.WriteLine($"zeileinkaufspreis - liefererskonto\t {zieleinkaufspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {bareinkaufspreis} bareinlaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    decimal bezugspreis = KaufmaeischeRunden(bareinkaufspreis + beuzugskosten);
    Console.WriteLine($"bareinkaufspreis + beuzugskosten\t {bareinkaufspreis} + {beuzugskosten}");
    Console.WriteLine($"\t\t\t= {bezugspreis} bezugspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 + handlungskostenzuschlagsatz;
    decimal selbstkosten = KaufmaeischeRunden(bezugspreis * differez / 100);
    Console.WriteLine($"bezugspreisgskostenzuschlagsatz\t {bezugspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {selbstkosten} selbstkosten");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 + gewinnzuschlagsatz;
    decimal barkaufspreis = KaufmaeischeRunden(selbstkosten * differez / 100);
    Console.WriteLine($"selbstkosten + gewinnzuschlagsatz\t {selbstkosten} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {barkaufspreis} barkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 - kundenskonto - vertreterprovision;
    decimal zielverkaufspreis = KaufmaeischeRunden(barkaufspreis * 100 / differez);
    Console.WriteLine($"barkaufspreis + kundenskonto & vertreterprovision\t {barkaufspreis} * 100 / {differez}");
    Console.WriteLine($"\t\t\t= {zielverkaufspreis} zielverkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 - kundenrabatt;
    decimal nettoverkaufspreis = KaufmaeischeRunden(zielverkaufspreis * 100 / differez);
    Console.WriteLine($"zielverkaufspreis + kundensrabatt\t {zielverkaufspreis} * 100 / {differez}");
    Console.WriteLine($"\t\t\t= {nettoverkaufspreis} nettoverkaufspreis");

    if (langsam) Console.ReadLine();
    else Console.WriteLine();

    differez = 100 + umsatzsteuer;
    decimal bruttoverkaufspreis = KaufmaeischeRunden(nettoverkaufspreis * differez / 100);
    Console.WriteLine($"nettoverkaufspreis + umsatzsteuer\t {nettoverkaufspreis} * {differez} / 100");
    Console.WriteLine($"\t\t\t= {bruttoverkaufspreis} bruttoverkaufspreis");

}

decimal KaufmaeischeRunden(decimal wert) //will always round up from 5 in the third decimal place
{
    return Math.Round(wert, 2, MidpointRounding.AwayFromZero);
}