using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Parak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //část 1: hlavní menu
            string menu;
            string menucheck = ("start"); //kontroluje vstup od uživatele, porovnává s předchozím stringem který uživatel zadává
            Console.WriteLine("Vítej ve hře Parak. Tvým úkolem bude procházet kobky hradu Parak, nasbírat 5 pokladů a nezemřít u toho.");
            Console.WriteLine("Pokud prohraješ souboj, přijdeš o život. Pokud není řečeno, co máš stisknout, stiskni Enter. Prosím, začni napsáním start.");
            menu = Console.ReadLine();//načte první vstup uživatele
            
            //část 2: herní mapa a obtížnost
            if (menu == menucheck)//zkontroluje vstup uživatele s menucheckem a v případě shody spustí hru
            {
                Console.Clear();//vymaže úvodní věty "hlavní menu"
                Console.WriteLine("Zvol si počet životů. Doporučené hodnoty jsou:");
                Console.WriteLine("9 a víc pro extra lehkou obtížnost");
                Console.WriteLine("7 nebo 8 pro lehkou obtížnost");
                Console.WriteLine("5 nebo 6 pro střední obtížnost");
                Console.WriteLine("4 nebo 3 pro těžkou obtížnost");
                Console.WriteLine("2 a míň pro extra těžkou obtížnost");
                int hp = 0;
                while (!Int32.TryParse(Console.ReadLine(), out hp) || hp <= 0)//načte vstup od uživatele a určí tak počet životů ve hře
                {
                    Console.WriteLine("Nezadal jsi číslo");
                }



                int[,] map = new int[10, 10];//generace herní mapy
                Random random = new Random();//naplnění mapy náhodnými čísly, z části ChatGPT
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        map[i, j] = random.Next(6);
                    }
                }
                int treasureCounter = 0;
                int keyKeeperCounter = 0;
                foreach (int room in map)//počítá poklady a klíčníky na vygenerované mapě
                {
                    if(room == 1)
                    {
                        treasureCounter++;
                    }
                    if(room == 5)
                    {
                        keyKeeperCounter++;
                    }
                }
                while(treasureCounter <=5)//pokud je míň pokladů než je potřeba k výhře (5),náhodně rozmístí zbytek
                {
                    int offset = random.Next(2,13);//náhodná vzdálenost mezi poklady
                    int pointer = 0;//pomocný ukazatel
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            pointer++;
                            if (pointer >= offset && map[i,j]!= 1 && treasureCounter<5)
                            {
                                map[i,j] = 1;
                                offset = random.Next(2, 13);
                                pointer = 0;
                                treasureCounter++;
                            }
                        }
                    }
                }
                while (keyKeeperCounter <= treasureCounter+2 && keyKeeperCounter<=9)//pokud je nedostatek, náhodně rozmístí zbytek, max 9
                {
                    int offset = random.Next(2, 13);//náhodná vzdálenost mezi klíčníky
                    int pointer = 0;//pomocný ukazatel
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            pointer++;
                            if (pointer >= offset && map[i, j] != 1 && map[i, j] != 5 && keyKeeperCounter < treasureCounter+2)
                            {
                                map[i, j] = 5;
                                offset = random.Next(2, 13);
                                pointer = 0;
                                keyKeeperCounter++;
                            }
                        }
                    }
                }

             //část 3: deklarace některých proměnných hry
                int foundTreasures = 0; //poklady hráče, pokud dostatečný počet, výhra
                int[] position = new int[2]; //ukládá aktuální pozici hráče
                position[0] = 0;//nastavuje startovní pozici hráče
                position[1] = 0;//to samé
                bool play = true;//umožňuje hráči skončit hru předčasně (níže)
                bool key = false; //vlastnictví/nevlastnictví klíče
                bool dagger = false; //zbraně, které dávají hráčovi bonus do soubojů
                bool axe = false;
                int[] lastPosition = new int[2];

                while (hp > 0 && foundTreasures < 5 && play)//Hlavní while cyklus, dokud běží, běží hra
                {
             //část 4: pohyb hráče na mapě
                    lastPosition = position; //ukládá poslední pozici, využití níže
                    Console.Clear();
                    Console.WriteLine($"Máš {hp} životů");//writeliny a následující 4 ify ukazují hráčovi kolik má zrovna životů a pokladů a jaké má zrovna předměty
                    if(foundTreasures>0)
                    {
                        Console.WriteLine($"Už jsi objevil {foundTreasures} pokladů");
                    }
                    else
                    {
                        Console.WriteLine($"Zatím jsi nenašel žádný poklad.");
                    }
                    if(key)
                    {
                        Console.WriteLine("Máš klíč.");
                    }
                    if(dagger)
                    {
                        Console.WriteLine("Máš krysí dýku (+ 1 k tvé síle).");
                    }
                    if (axe)
                    {
                        Console.WriteLine("Máš královskou sekeru (+ 3 k tvé síle).");
                    }
                    Console.WriteLine("Kam se vydáš dál hrdino? Nahoru [W], dolů [S], doleva [A] nebo doprava [D]? Nebo své dobrodružství vzdáš? (konec hry) [K]");
                    string input = "";//dokud je defaultní input a nebo žádný není, opakuje se while cyklus který čte inputy
                    while (input == "" || input == null)
                    {
                        input = Console.ReadLine();
                        if (!(input.Length > 0) || !"wsadk".Contains(input.ToLower()[0])) input = "";
                    }
                    switch (input.ToLower()[0])//provede pohyb hráče podle zadaného inputu
                    {
                        case 'w':
                            if (position[1] + 1 < 10)//kontroluje jestli hráč nedošel na konec mapy
                            {
                                position[1]++;//posune hráče
                            }
                            else
                            {
                                Console.WriteLine("Tudy ne. Bohužel zatím nejsi duch a zdí neprojdeš.");
                            }
                            break;

                        case 's':
                            if (position[1] - 1 >= 0)
                            {
                                position[1]--;
                            }
                            else
                            {
                                Console.WriteLine("Tudy ne. Bohužel zatím nejsi duch a zdí neprojdeš.");
                            }
                            break;

                        case 'a':
                            if (position[0] - 1 >= 0)
                            {
                                position[0]--;
                            }
                            else
                            {
                                Console.WriteLine("Tudy ne. Bohužel zatím nejsi duch a zdí neprojdeš.");
                            }
                            break;

                        case 'd':
                            if (position[0] + 1 < 10)
                            {
                                position[0]++;
                            }
                            else
                            {
                                Console.WriteLine("Tudy ne. Bohužel zatím nejsi duch a zdí neprojdeš.");
                            }
                            break;
         
                        case 'k'://předčasné ukončení hry

                            play = false;
                            break;

                        default:
                            Console.WriteLine("Zkus to znovu a tentokrát použij hlavu.");
                            break;
                    }

                    if (play)
                    {
             //část 5: vyhodnocení místností
                        int room = map[position[0], position[1]];//int pro rozlišení typu místnosti
                        switch (room)//podívá se v jaké místnosti hráč je a podle toho vykoná akci
                        {
                            case 0:
                                Console.WriteLine("Jsi v prázdné místnosti. Docela nuda.");
                                Console.ReadLine();
                                break;

                            case 1:
                                Console.WriteLine("Našel jsi zamčenou truhlu s pokladem.");
                                Console.ReadLine();
                                if (key)
                                {
                                    Console.WriteLine("Naštěstí máš klíč, takže získáváš poklad.");
                                    foundTreasures++;//přidá hráči poklad
                                    Console.WriteLine($"Momentálně máš {foundTreasures} pokladů.");
                                    key = false;//odebere hráči klíč
                                    map[position[0], position[1]] = 0;//změní místnost v prázdnou místnost
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Bohužel nemáš klíč, takže poklad nezískáváš.");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                Console.WriteLine("Narazil jsi na krysího válečníka! Abys ho porazil, musíš vyvinout sílu alespoň 6!");
                                Console.ReadLine();
                                int playerTurn = random.Next(2, 13);//číslo pro soubojovou sílu hráče, náhodné od 2 do 12 (simulace hodu 2 klasických kostek)
                                if (dagger)//podmínky pro přičítání bonusu za zbraně
                                {
                                    Console.WriteLine("Krysí dýka ti pomůže v boji.");
                                    playerTurn++;//přidá sílu za dýku
                                    Console.ReadLine();
                                }
                                if (axe)
                                {
                                    Console.WriteLine("Královská sekera ti pomůže v boji.");
                                    playerTurn += 3;//přidá sílu za sekeru
                                    Console.ReadLine();
                                }
                                int rat = 5; //síla krysy
                                if (rat > playerTurn)
                                {
                                    hp--; //odebere život
                                    Console.WriteLine($"Aj! To je hanba, prohrát proti nejslabšímu nepříteli ve hře. Krysák tě překonal. Máš {hp} životů.");
                                    Console.ReadLine();
                                    position = lastPosition; //vrátí hráče zpět do minulé místnosti
                                }
                                else if (rat == playerTurn)
                                {
                                    Console.WriteLine("Tak to bylo těsné, málem tě dostala krysa! Nakonec jen remíza.");
                                    position = lastPosition;
                                    Console.ReadLine();
                                }
                                else
                                {
                                    if (dagger)
                                    {
                                        Console.WriteLine("Vyhrál jsi! Krysák je mrtvý. Dýku už máš.");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        dagger = true;//dá hráčovi dýku
                                        Console.WriteLine("Vyhrál jsi! Krysák je mrtvý a ty získáváš jeho dýku.");
                                        Console.ReadLine();
                                    }
                                    map[position[0], position[1]] = 0;//vyprázdní místnost
                                }



                                break;

                            case 3:
                                Console.WriteLine("Překvapil tě kostlivec král. Na jeho poražení potřebuješ sílu alespoň 10!");
                                Console.ReadLine();
                                int playerTurn2 = random.Next(2, 13);
                                if (dagger)
                                {
                                    Console.WriteLine("Krysí dýka ti pomůže v boji.");
                                    playerTurn2++;
                                    Console.ReadLine();
                                }
                                if (axe)
                                {
                                    Console.WriteLine("Královská sekera ti pomůže v boji.");
                                    playerTurn2 += 3;
                                    Console.ReadLine();
                                }
                                int king = 9; //síla kostlivčího krále
                                if (king > playerTurn2)
                                {
                                    hp--; //odebere život
                                    Console.WriteLine($"Vzal sekeru, rozmáchl se a bylo to. Kostlivčí král tě zasáhl a to fatálně. Máš {hp} životů.");
                                    Console.ReadLine();
                                    position = lastPosition; //vrátí hráče zpět do minulé místnosti
                                }
                                else if (king == playerTurn2)
                                {
                                    Console.WriteLine("Ah, těsné! Málem jsi krále překonal. Chyběl jen vlásek. Snad to vyjde příště, pro teď remíza.");
                                    position = lastPosition;
                                    Console.ReadLine();
                                }
                                else
                                {
                                    if (axe)
                                    {
                                        Console.WriteLine("Z krále kostlivce zbyla jen hromádka kostí. Sekeru už máš.");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        axe = true;
                                        Console.WriteLine("Z krále kostlivce zbyla jen hromádka kostí. A sekera. Ta se bude určitě hodit.");
                                        Console.ReadLine();
                                        map[position[0], position[1]] = 0;//vyprázdní místnost
                                    }
                                    
                                }
                                break;

                            case 4:
                                Console.WriteLine("Natrefil jsi na...co to je? Duchovitě vypadající nestvůra vyhlíží mimořádně nebezpečným dojmem. Na její poraží budeš potřebovat alespoň sílu 12.");
                                Console.ReadLine();
                                int playerTurn3 = random.Next(2, 13);
                                if (dagger)
                                {
                                    Console.WriteLine("Krysí dýka ti pomůže v boji.");
                                    playerTurn3++;
                                    Console.ReadLine();
                                }
                                if (axe)
                                {
                                    Console.WriteLine("Královská sekera ti pomůže v boji.");
                                    playerTurn3 += 3;
                                    Console.ReadLine();
                                }
                                int ghost = 11; //síla ducha
                                if (ghost > playerTurn3)
                                {
                                    hp--; //odebere život
                                    Console.WriteLine($"Panebože...tak tohle bylo opravdu duchařsky zničující. Duch tě zcela pohltil svou temnotou. Máš {hp} životů.");
                                    Console.ReadLine();
                                    position = lastPosition; //vrátí hráče zpět do minulé místnosti
                                }
                                else if (ghost == playerTurn3)
                                {
                                    Console.WriteLine("Dělal jsi co jsi mohl, ale ducha jsi nepřekonal. Bohudík nepřekonal ani on tebe. Remíza.");
                                    position = lastPosition;
                                    Console.ReadLine();
                                }
                                else
                                {
                                    foundTreasures++;
                                    Console.WriteLine("Nasadil jsi všchnu svou sílu, zkrátka do toho boje dal vše. Vydařilo se. Duch se rozplynul a po zbyla po něm jen...truhla? A odemčená!");
                                    Console.ReadLine();
                                    map[position[0], position[1]] = 0;//vyprázdní místnost
                                }
                                
                                break;

                            case 5:
                                Console.WriteLine("Narazil jsi na kostlivce, který nemá zbraň. Má klíč. je to kostlivec klíčník. Na jeho poražení potřebujš sílu alespoň 7!");
                                Console.ReadLine();
                                int playerTurn4 = random.Next(2, 13);
                                if (dagger)
                                {
                                    Console.WriteLine("Krysí dýka ti pomůže v boji.");
                                    playerTurn4++;
                                    Console.ReadLine();
                                }
                                if (axe)
                                {
                                    Console.WriteLine("Královská sekera ti pomůže v boji.");
                                    playerTurn4 += 3;
                                    Console.ReadLine();
                                }
                                int keyKeeper = 6; //síla klíčníka
                                if (keyKeeper > playerTurn4)
                                {
                                    hp--; //odebere život
                                    Console.WriteLine($"Klíč byl na chvíli v tvém dosahu...to když ho klíčník vší silou hodil přímo mezi tvoje oči. Překonal tě. Máš {hp} životů.");
                                    Console.ReadLine();
                                    position = lastPosition; //vrátí hráče zpět do minulé místnosti
                                }
                                else if (keyKeeper == playerTurn4)
                                {
                                    Console.WriteLine("Klíčník vytrvale odolává tvým útokům a klíč tak zůstává v jeho vlastnictví. Nicméně život ti nesebral.");
                                    position = lastPosition;
                                    Console.ReadLine();
                                }
                                else
                                {
                                    key = true;
                                    Console.WriteLine("Pomocí svojí síly jsi klíčníka pokořil a jsi hrdým majitelem klíče k pokladu.");
                                    Console.ReadLine();
                                    map[position[0], position[1]] = 0;//vyprázdní místnost
                                }
                                break;

                            default:
                                Console.WriteLine("Nastala chyba.");//chybová hláška
                                break;

                        }
                    }
                }
             //část 6: konec
                if (hp ==0)
                {
                    Console.WriteLine("To byl tvůj poslední život... Prohrál jsi.");
                    Console.ReadLine();
                }
                else if (!play)//předčasné ukončení hry
                {
                    Console.WriteLine("Předčasně jsi se vypařil.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Gratuluji hrdino. Na svých toulkách kobkami hradu Parak jsi získal 5 pokladů. Vyhrál jsi.");
                    Console.ReadLine();
                }
            }
            //chybová hláška
            else
            {
                Console.WriteLine("Musíš napsat start.");
            }

            Console.ReadKey();
            
        }

    }
}
