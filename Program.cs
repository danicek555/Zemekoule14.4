// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadejte heslo: ");
string heslo = Console.ReadLine();

if (heslo == "XB?XB?")
{
    Console.WriteLine("Heslo je správné");
    //Console.Beep(1500, 400);
    Console.Clear();
    Console.WriteLine("Krásný den, Vaše Velikosti!");
    Console.WriteLine("Pro jaký kontinent chcete zobrazit statistiky?");
    Console.WriteLine("1. Afrika");
    Console.WriteLine("2. Asie");
    Console.WriteLine("3. Evropa");
    Console.WriteLine("4. Jižní Amerika");
    Console.WriteLine("5. Severní Amerika");
    Console.WriteLine("6. Oceánie");
    Console.WriteLine("Vaše volba:");
    string volba = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Načítání dat...");
    Thread.Sleep(5000);
    Console.Clear();
    switch (volba)
    {
        case "Afrika":
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Počet obyvatelů v roce 2050 pro Afriku:");
            double pocetObyvatelAlzirsko = Random.Shared.Next(52014, 57410) / 1000.0;
            Console.WriteLine($"Alzirsko: {pocetObyvatelAlzirsko} milionů");
            double pocetObyvatelNigerie = Random.Shared.Next(332189, 425773) / 1000.0;
            Console.WriteLine($"Nigerie: {pocetObyvatelNigerie} milionů");
            double pocetObyvatelEtiopie = Random.Shared.Next(195864, 234587) / 1000.0;
            Console.WriteLine($"Etiopie: {pocetObyvatelEtiopie} milionů");
            double pocetObyvatelEgypta = Random.Shared.Next(102334, 110000) / 1000.0;
            Console.WriteLine($"Egypt: {pocetObyvatelEgypta} milionů");
            double pocetObyvatelAngola = Random.Shared.Next(63680, 76650) / 1000.0;
            Console.WriteLine($"Angola: {pocetObyvatelAngola} milionů");
            double pocetObyvatelSúdánu = Random.Shared.Next(66460, 78685) / 1000.0;
            Console.WriteLine($"Súdán: {pocetObyvatelSúdánu} milionů");
            double celkovyPocetObyvateluAfrika = pocetObyvatelAlzirsko + pocetObyvatelNigerie + pocetObyvatelEtiopie + pocetObyvatelEgypta + pocetObyvatelAngola + pocetObyvatelSúdánu;
            Console.WriteLine($"Celkový počet obyvatelů Afriky: {celkovyPocetObyvateluAfrika} milionů");
            break;
        case "Asie":
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Počet obyvatelů v roce 2050 pro Asii:");
            double pocetObyvatelFilipiny = Random.Shared.Next(140877, 155427) / 1000.0;
            Console.WriteLine($"Filipíny: {pocetObyvatelFilipiny} milionů");
            double pocetObyvatelIndie = Random.Shared.Next(1628591, 1711060) / 1000.0;
            Console.WriteLine($"Indie: {pocetObyvatelIndie} milionů");
            double pocetObyvatelIndonesie = Random.Shared.Next(302068, 319807) / 1000.0;
            Console.WriteLine($"Indonésie: {pocetObyvatelIndonesie} milionů");
            double pocetObyvatelIrak = Random.Shared.Next(67956, 79298) / 1000.0;
            Console.WriteLine($"Irák: {pocetObyvatelIrak} milionů");
            double pocetObyvatelIran = Random.Shared.Next(90443, 96128) / 1000.0;
            Console.WriteLine($"Írán: {pocetObyvatelIran} milionů");
            double pocetObyvatelIzrael = Random.Shared.Next(12386, 14168) / 1000.0;
            Console.WriteLine($"Izrael: {pocetObyvatelIzrael} milionů");
            double pocetObyvatelJaponsko = Random.Shared.Next(99327, 108356) / 1000.0;
            Console.WriteLine($"Japonsko: {pocetObyvatelJaponsko} milionů");
            double pocetObyvatelJemen = Random.Shared.Next(49939, 59078) / 1000.0;
            Console.WriteLine($"Jemen: {pocetObyvatelJemen} milionů");
            double pocetObyvatelJizniKorea = Random.Shared.Next(43584, 48190) / 1000.0;
            Console.WriteLine($"Jižní Korea: {pocetObyvatelJizniKorea} milionů");
            double pocetObyvatelKambodza = Random.Shared.Next(19528, 21266) / 1000.0;
            Console.WriteLine($"Kambodža: {pocetObyvatelKambodza} milionů");
            double celkovyPocetObyvateluAsie = pocetObyvatelFilipiny + pocetObyvatelIndie + pocetObyvatelIndonesie + 
                                             pocetObyvatelIrak + pocetObyvatelIran + pocetObyvatelIzrael + 
                                             pocetObyvatelJaponsko + pocetObyvatelJemen + pocetObyvatelJizniKorea + 
                                             pocetObyvatelKambodza;
            Console.WriteLine($"Celkový počet obyvatelů Asie: {celkovyPocetObyvateluAsie} milionů");
            break;
        case "Evropa":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Počet obyvatelů v roce 2050 pro Evropu:");
            double pocetObyvatelBulharsko = Random.Shared.Next(4774, 5577) / 1000.0;
            Console.WriteLine($"Bulharsko: {pocetObyvatelBulharsko} milionů");
            double pocetObyvatelCernaHora = Random.Shared.Next(552, 611) / 1000.0;
            Console.WriteLine($"Černá Hora: {pocetObyvatelCernaHora} milionů");
            double pocetObyvatelCesko = Random.Shared.Next(9465, 10570) / 1000.0;
            Console.WriteLine($"Česko: {pocetObyvatelCesko} milionů");
            double pocetObyvatelDansko = Random.Shared.Next(6205, 6843) / 1000.0;
            Console.WriteLine($"Dánsko: {pocetObyvatelDansko} milionů");
            double pocetObyvatelEstonsko = Random.Shared.Next(1095, 1247) / 1000.0;
            Console.WriteLine($"Estonsko: {pocetObyvatelEstonsko} milionů");
            double pocetObyvatelFinsko = Random.Shared.Next(5127, 5669) / 1000.0;
            Console.WriteLine($"Finsko: {pocetObyvatelFinsko} milionů");
            double pocetObyvatelFrancie = Random.Shared.Next(62686, 67258) / 1000.0;
            Console.WriteLine($"Francie: {pocetObyvatelFrancie} milionů");
            double pocetObyvatelChorvatsko = Random.Shared.Next(3143, 3583) / 1000.0;
            Console.WriteLine($"Chorvatsko: {pocetObyvatelChorvatsko} milionů");
            double pocetObyvatelIrsko = Random.Shared.Next(5454, 6083) / 1000.0;
            Console.WriteLine($"Irsko: {pocetObyvatelIrsko} milionů");
            double pocetObyvatelIsland = Random.Shared.Next(404, 455) / 1000.0;
            Console.WriteLine($"Island: {pocetObyvatelIsland} milionů");
            double celkovyPocetObyvateluEvropa = pocetObyvatelBulharsko + pocetObyvatelCernaHora + 
                                               pocetObyvatelCesko + pocetObyvatelDansko + 
                                               pocetObyvatelEstonsko + pocetObyvatelFinsko + 
                                               pocetObyvatelFrancie + pocetObyvatelChorvatsko + 
                                               pocetObyvatelIrsko + pocetObyvatelIsland;
            Console.WriteLine($"Celkový počet obyvatelů Evropy: {celkovyPocetObyvateluEvropa} milionů");
            break;
        case "Jižní Amerika":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Počet obyvatelů v roce 2050 pro Jižní Ameriku:");
            double pocetObyvatelArgentina = Random.Shared.Next(49078, 52934) / 1000.0;
            Console.WriteLine($"Argentina: {pocetObyvatelArgentina} milionů");
            double pocetObyvatelBolivie = Random.Shared.Next(15244, 17144) / 1000.0;
            Console.WriteLine($"Bolívie: {pocetObyvatelBolivie} milionů");
            double pocetObyvatelBrazilie = Random.Shared.Next(217675, 233042) / 1000.0;
            Console.WriteLine($"Brazílie: {pocetObyvatelBrazilie} milionů");
            double pocetObyvatelChile = Random.Shared.Next(19517, 21004) / 1000.0;
            Console.WriteLine($"Chile: {pocetObyvatelChile} milionů");
            double pocetObyvatelEkvador = Random.Shared.Next(21242, 23248) / 1000.0;
            Console.WriteLine($"Ekvádor: {pocetObyvatelEkvador} milionů");
            double pocetObyvatelGuyana = Random.Shared.Next(857, 947) / 1000.0;
            Console.WriteLine($"Guyana: {pocetObyvatelGuyana} milionů");
            double pocetObyvatelKolumbie = Random.Shared.Next(55782, 60515) / 1000.0;
            Console.WriteLine($"Kolumbie: {pocetObyvatelKolumbie} milionů");
            double pocetObyvatelParaguay = Random.Shared.Next(8602, 9747) / 1000.0;
            Console.WriteLine($"Paraguay: {pocetObyvatelParaguay} milionů");
            double pocetObyvatelPeru = Random.Shared.Next(38563, 42271) / 1000.0;
            Console.WriteLine($"Peru: {pocetObyvatelPeru} milionů");
            double pocetObyvatelSurinam = Random.Shared.Next(667, 726) / 1000.0;
            Console.WriteLine($"Surinam: {pocetObyvatelSurinam} milionů");
            double pocetObyvatelUruguay = Random.Shared.Next(3340, 3526) / 1000.0;
            Console.WriteLine($"Uruguay: {pocetObyvatelUruguay} milionů");
            double pocetObyvatelVenezuela = Random.Shared.Next(31908, 35151) / 1000.0;
            Console.WriteLine($"Venezuela: {pocetObyvatelVenezuela} milionů");
            double celkovyPocetObyvateluJizniAmerika = pocetObyvatelArgentina + pocetObyvatelBolivie + 
                                                     pocetObyvatelBrazilie + pocetObyvatelChile + 
                                                     pocetObyvatelEkvador + pocetObyvatelGuyana + 
                                                     pocetObyvatelKolumbie + pocetObyvatelParaguay + 
                                                     pocetObyvatelPeru + pocetObyvatelSurinam + 
                                                     pocetObyvatelUruguay + pocetObyvatelVenezuela;
            Console.WriteLine($"Celkový počet obyvatelů Jižní Ameriky: {celkovyPocetObyvateluJizniAmerika} milionů");
            break;
        case "Severní Amerika":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Počet obyvatelů v roce 2050 pro Severní Ameriku:");
            double pocetObyvatelCuracao = Random.Shared.Next(170, 183) / 1000.0;
            Console.WriteLine($"Curaçao: {pocetObyvatelCuracao} milionů");
            double pocetObyvatelDominika = Random.Shared.Next(66, 70) / 1000.0;
            Console.WriteLine($"Dominika: {pocetObyvatelDominika} milionů");
            double pocetObyvatelDomRep = Random.Shared.Next(11789, 12727) / 1000.0;
            Console.WriteLine($"Dominikánská republika: {pocetObyvatelDomRep} milionů");
            double pocetObyvatelGrenada = Random.Shared.Next(124, 133) / 1000.0;
            Console.WriteLine($"Grenada: {pocetObyvatelGrenada} milionů");
            double pocetObyvatelGuatemala = Random.Shared.Next(24961, 28599) / 1000.0;
            Console.WriteLine($"Guatemala: {pocetObyvatelGuatemala} milionů");
            double pocetObyvatelHaiti = Random.Shared.Next(14123, 15729) / 1000.0;
            Console.WriteLine($"Haiti: {pocetObyvatelHaiti} milionů");
            double pocetObyvatelHonduras = Random.Shared.Next(13420, 15283) / 1000.0;
            Console.WriteLine($"Honduras: {pocetObyvatelHonduras} milionů");
            double pocetObyvatelJamajka = Random.Shared.Next(2698, 2851) / 1000.0;
            Console.WriteLine($"Jamajka: {pocetObyvatelJamajka} milionů");
            double pocetObyvatelKanada = Random.Shared.Next(43147, 48454) / 1000.0;
            Console.WriteLine($"Kanada: {pocetObyvatelKanada} milionů");
            double celkovyPocetObyvateluSeverniAmerika = pocetObyvatelCuracao + pocetObyvatelDominika + 
                                                       pocetObyvatelDomRep + pocetObyvatelGrenada + 
                                                       pocetObyvatelGuatemala + pocetObyvatelHaiti + 
                                                       pocetObyvatelHonduras + pocetObyvatelJamajka + 
                                                       pocetObyvatelKanada;
            Console.WriteLine($"Celkový počet obyvatelů Severní Ameriky: {celkovyPocetObyvateluSeverniAmerika} milionů");
            break;
        case "Oceánie":
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Počet obyvatelů v roce 2050 pro Oceánii:");
            double pocetObyvatelAustralie = Random.Shared.Next(29946, 32953) / 1000.0;
            Console.WriteLine($"Austrálie: {pocetObyvatelAustralie} milionů");
            double pocetObyvatelCookovy = Random.Shared.Next(16, 18) / 1000.0;
            Console.WriteLine($"Cookovy ostrovy: {pocetObyvatelCookovy} milionů");
            double pocetObyvatelFidzi = Random.Shared.Next(1013, 1089) / 1000.0;
            Console.WriteLine($"Fidži: {pocetObyvatelFidzi} milionů");
            double pocetObyvatelPolynesie = Random.Shared.Next(311, 342) / 1000.0;
            Console.WriteLine($"Francouzská Polynésie: {pocetObyvatelPolynesie} milionů");
            double pocetObyvatelKiribati = Random.Shared.Next(168, 191) / 1000.0;
            Console.WriteLine($"Kiribati: {pocetObyvatelKiribati} milionů");
            double pocetObyvatelMarshalovy = Random.Shared.Next(48, 56) / 1000.0;
            Console.WriteLine($"Marshallovy ostrovy: {pocetObyvatelMarshalovy} milionů");
            double pocetObyvatelMikronesie = Random.Shared.Next(118, 130) / 1000.0;
            Console.WriteLine($"Mikronésie: {pocetObyvatelMikronesie} milionů");
            double pocetObyvatelNauru = Random.Shared.Next(13, 15) / 1000.0;
            Console.WriteLine($"Nauru: {pocetObyvatelNauru} milionů");
            double pocetObyvatelNovaKaledonie = Random.Shared.Next(325, 357) / 1000.0;
            Console.WriteLine($"Nová Kaledonie: {pocetObyvatelNovaKaledonie} milionů");
            double pocetObyvatelNovyZeland = Random.Shared.Next(5475, 6035) / 1000.0;
            Console.WriteLine($"Nový Zéland: {pocetObyvatelNovyZeland} milionů");
            double pocetObyvatelSeverniMariany = Random.Shared.Next(47, 52) / 1000.0;
            Console.WriteLine($"Severní Mariany: {pocetObyvatelSeverniMariany} milionů");
            double pocetObyvatelVanuatu = Random.Shared.Next(19, 20) / 1000.0;
            Console.WriteLine($"Vanuatu: {pocetObyvatelVanuatu} milionů");
            double celkovyPocetObyvateluOceanie = pocetObyvatelAustralie + pocetObyvatelCookovy + 
                                               pocetObyvatelFidzi + pocetObyvatelPolynesie + 
                                               pocetObyvatelKiribati + pocetObyvatelMarshalovy + 
                                               pocetObyvatelMikronesie + pocetObyvatelNauru + 
                                               pocetObyvatelNovaKaledonie + pocetObyvatelNovyZeland + 
                                               pocetObyvatelSeverniMariany + pocetObyvatelVanuatu;
            Console.WriteLine($"Celkový počet obyvatelů Oceánie: {celkovyPocetObyvateluOceanie} milionů");
            break;
        case "Antarktida":
            double XYZ = Random.Shared.Next(500, 20000);
            Console.WriteLine($"Antarktida počet obyvatelů: {XYZ}");
            break;
        default:
            Console.WriteLine("Zkuste raději program spustit znovu, Vaše Velikosti!");
            break;
    }
}
else
{
    Console.WriteLine("Heslo je špatné");
    
}
