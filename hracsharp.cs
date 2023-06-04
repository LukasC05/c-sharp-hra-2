using System;

namespace RPGProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            Console.Clear();
            string userInput= "";
            string whereUserwantgo="";
            bool isSetupfinished=false;
            bool doUserwantgo=false;
            bool isDoorunlocked=false;
            bool didUsergoback=false;
            bool doUserhavekey=false;
            bool usergotcorrectanswer=false;
            bool didUsergoback2=false;
            bool doUserwantgoback=false;
            bool doUserhavecorrectanswer=false;
            int selectWeapon=0;
            int userFailedAttempt=0;

            // What did you selectd weapon?
            bool weaponCrowbar=false;
            bool weaponFireflower=false;
            bool weaponPickaxe=false;
            bool weaponEnergySword=false;
            bool weaponMasterSword=false;

            // Player's Stat
            string playerName = "Player";
            int playerHP=100; // HP = Health
            int playerDMG=0; // DMG = Damage
            int playerDEF=0; // DEF = Defense
            int playerMAG=0; // MAG = Magic
            double playerMoney=15.00;
            double playerBagel=0;

            // Enemy's Stat
            int enemyHP = 500;
            int enemyDMG = 55;

            // Start Game
            Console.WriteLine("Vítej v textové hře.\nStojíš v bílé místnosti s 'odpočívárna' cedulí. Vidíš před sebou stojící bytost, řekla ahoj, Hráči. Jmenuji se Nastavení. Jak se jmenuješ?'.\n");
            Console.Write("Player > ");
            playerName = Console.ReadLine();
            if (string.IsNullOrEmpty(playerName)){ // Pokud hráč nezadal žádne jméno, pojmenujeme tě "Hráč".
                playerName="Player";
            }
            Console.WriteLine("\n Nastavení řeklo 'Ráda tě poznávám, "+playerName+"!'. Nastavení tleskla a najednou se objevil bíly stůl. A na něm zbraně.");
            Console.WriteLine("1. Freeman's Crowbar \n2. Mario's Fireflower \n3. Steve's Pickaxe \n4. Master Chief's Energy Sword \n5. Link's Master Sword");
            Console.WriteLine("Řekla 'Prosím vyber si zbraň. (1-5)!'\n");
            while (isSetupfinished!=true){
                Console.Write(playerName+" > ");
                userInput = Console.ReadLine();
                int.TryParse(userInput, out selectWeapon);
                switch (selectWeapon){
                    case 1:
                    weaponCrowbar=true;
                    Console.WriteLine("\n Vybral sis Freeman's Crowbar.\n");
                    isSetupfinished=true;
                    break;
                    case 2:
                    weaponFireflower=true;
                    Console.WriteLine("\n Vybral sis Mario's Fireflower.\n");
                    isSetupfinished=true;
                    break;
                    case 3:
                    weaponPickaxe=true;
                    Console.WriteLine("\n Vybral sis Steve's Pickaxe.\n");
                    isSetupfinished=true;
                    break;
                    case 4:
                    weaponEnergySword=true;
                    Console.WriteLine("\n Vybral sis Master Chief's Energy Sword.\n");
                    isSetupfinished=true;
                    break;
                    case 5:
                    weaponMasterSword=true;
                    Console.WriteLine("\n Vybral sis Link's Master Sword.\n");
                    isSetupfinished=true;
                    break;
                    default:
                        Console.WriteLine("\nSetup said 'Zadej pouze číslo zbraně'.\n");
                    break;
                }
            }
           
            if (weaponCrowbar!=true){
                playerDMG=85;
                playerDEF=50;
                playerMAG=5;
            }
            else if (weaponFireflower!=true){
                playerDMG=75;
                playerDEF=45;
                playerMAG=25;
            }
            else if (weaponPickaxe!=true){
                playerDMG=50;
                playerDEF=50;
                playerMAG=40;
            }
            else if (weaponEnergySword!=true){
                playerDMG=100;
                playerDEF=20;
                playerMAG=0;
            }
            else if (weaponMasterSword!=true){
                playerDMG=75;
                playerDEF=40;
                playerMAG=35;
            }

           
            while (doUserwantgo!=true){
                Console.WriteLine("\n objevily se dveře k východu. Nastavení zvážnila výraz, chceš jít?"+playerName+", Je čas jít na dobrodružství \nChceš jít na dobrodružství? (ano/ne)\n");
                Console.Write(playerName+" > ");
                string selectFirstDoor = Console.ReadLine();
                switch (selectFirstDoor){
                    case "ano":
                    Console.WriteLine("\nVyšel si ven. A místnost zmizela. Jsi ve starém lese.\n");
                    doUserwantgo=true;
                    break;
                    case "ne":
                    Console.WriteLine("\nRozhodl ses zůstat, neměl si žádný příjem potravy ani vody, jen žehnoucí slunce na nebi, které se ti smálo do obličeje. \n \n \n \n          **** Konec hry **** \n \n \n ");
                    System.Environment.Exit(1);
                    break;
                    default:
                    Console.WriteLine("\nSYSTEM: vyber možnost ano/ne!\n");
                    break;
                }
            }
            while (isDoorunlocked!=true){
                Console.WriteLine("\n Kam půjdeš?? (sever/jih/východ/západ)\n");
                Console.Write(playerName+" > ");
                whereUserwantgo = Console.ReadLine();
                switch (whereUserwantgo){
                    case "sever":
                    while (didUsergoback!=true){
                    Console.WriteLine("\n Šel si na sever. Po dlouhé cestě vidíš malou boudu s nápisem 'Hamza kebab třinec'. Co teď? (koupit/mluvit/zpet)\n");
                    Console.Write(playerName+" > ");
                    string whatNow1 = Console.ReadLine();
                        switch(whatNow1){
                            case "koupit":
                            if (playerMoney>=1.00){
                                playerMoney = playerMoney - 3.00;
                                playerBagel++;
                                Console.WriteLine("\n koupil si kebab! Zbývá ti "+playerMoney.ToString("C2")+" a "+playerBagel+" kebab");
                            }
                            else if (playerMoney<=0.00){
                                Console.WriteLine("\n nemáš peníze.");
                            }
                            break;
                            case "mluvit":
                                Console.WriteLine("\n Turek řekl 'Ahoj kamo! Chceš kebab?");
                            break;
                            case "zpet":
                            Console.WriteLine("\nVrátil ses na předešlou lokaci.");
                            didUsergoback=true;
                            break;
                            default:
                            Console.WriteLine("\nSYSTEM: Vyber možost, co uděláš? koupit/mluvit/jitzpet!\n");
                            break;
                        }
                    }
                    break;
                    case "jih":
                    doUserwantgoback=false;
                    Console.WriteLine("\n Šel si na jih. Je tam zničený most. Došlo ti že jsi na mostach. Vidíš pod ním trolla. Ale pak si všimneš že to je jen opilý mostoř Kryštof po robitusinu. (mluvit/zpet)\n");
                    while (doUserwantgoback!=true){
                        Console.Write(playerName+" > ");
                        string whatNow2 = Console.ReadLine();
                            switch(whatNow2){
                            case "mluvit":
                            while (doUserhavecorrectanswer!=true){
                                Console.WriteLine("\nMostoř řekl 'POČKEJ! TY! Musíš odpovědět na mou nejtěžší otázku! Už 25 let žádný mostoř nepřišel na odpověd. Kolik je 25 + 74?'\n");
                                Console.Write(playerName+" > ");
                                userInput = Console.ReadLine();
                                if (userInput=="99"){
                                    doUserhavecorrectanswer=true;
                                }
                                else {
                                    Console.WriteLine("\nTroll řekl 'Gratuluju, si tupý jak mostoř co se vrací od Gruňa.!'\n");
                                    userFailedAttempt++;
                                }
                                if (userFailedAttempt==3){
                                    Console.WriteLine("\nDonutil tě vypít domácí pálenku. Nedal si to a umřel.'\n");
                                    Console.WriteLine("Umřel jsi!  \n \n \n \n          **** Konec hry **** \n \n \n");
                                    System.Environment.Exit(1);
                                }
                            }
                            Console.WriteLine("\nTy jsi mostořky mesiáš! Správna odpověd. Tady máš klíč. (jitzpet)\n");
                            doUserhavekey=true;
                            break;
                            case "jitzpet":
                                Console.WriteLine("\nVrátil ses na předešlou lokaci.");
                                doUserwantgoback=true;
                            break;
                            default:
                            Console.WriteLine("\nSYSTEM: Vyber možnost, co uděláš. mluvit/jitzpet!\n");
                            break;
                        }
                    }
                    break;
                    case "vychod":
                    Console.WriteLine("\nŠel jsi na východ a došel do lomné. Spadl jsi do ďury. \n \n \n \n          **** Konec hry **** \n \n \n ");
                    System.Environment.Exit(1);
                    break;
                    case "zapad":
                    Console.Write("\nŠel jsi na západ. Vrátil ses zpátky na mosty ale vzal to oklikou, rozhodl ses jít na skálku ale minul jsi značky. Ztratil ses v lese, slyšíš vrčení, podíváš se kolem a vidíš divokého jezevčíka.");
                    if (doUserhavekey==true){
                        isDoorunlocked=true;
                        Console.Write("\nNepřátelský jezevčík se objevil. Připrav se!\n");
                    }
                    else
                    {
                        Console.Write(", nakonec si našel původní cestu. Vrátil ses na původní lokaci.\n");
                    }
                    break;
                    default:
                    Console.WriteLine("\nSYSTEM: vyber co uděláš, kam půjdeš sever/jih/vychod/zapad!");
                    break;
                }

            }
            while (playerHP>=0){
                if (enemyHP<=0){
                    Console.WriteLine("Nepřatelský jezevčík byl poražen! \n \n \n \n          **** Vyhrál jsi! Porazil jsi kruté vládnutí jezevčíka a zachránil mosty! **** \n \n \n");
                    System.Environment.Exit(1);
                }
                Console.WriteLine("Bojuješ s nepřítelem. \n");
                Console.WriteLine("Player Health: "+playerHP);
                Console.WriteLine("Životy jezevčika: "+enemyHP+"\n");
                Console.Write("Co teď? utok/obrana/magie/kebab/bez \n"+playerName+" > ");
                userInput = Console.ReadLine();
                switch (userInput){
                    case "utok":
                        enemyHP = enemyHP - playerDMG;
                        Console.WriteLine("\nZautočil jsi na jezevčíka. BÁC!\n");
                        playerHP = playerHP + playerDEF - enemyDMG;
                        Console.WriteLine("\n jezevčík na tebe zaútočil! JAU!\n");
                    break;
                    case "obrana":
                        Console.WriteLine("\nObránil ses!\n");
                        playerHP = playerHP + playerDMG - enemyDMG;
                        Console.WriteLine("\n Jezevčík na tebe zaútočil JAU!\n");
                    break;
                    case "magie": // magie neexistuje, je to jenom vtip.
                        Console.WriteLine("\n použil si hůlku na jezevčíka, AVADA KEDAVRA. Jezevčík se ti vysmál do ksychtu. Cítíš se trapně.\n");
                        enemyHP = enemyHP - playerMAG;
                    break;
                    case "kebab": // Přidat životu 10
                        if (playerBagel>=1){
                            playerHP = playerHP + 10;
                            Console.WriteLine("\n snědl jsi kebab. Zvýšil se ti život o +10!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nNemáš kebab!\n");
                        }
                    break;
                    case "bez":
                        Console.WriteLine("\nSYSTEM: Nemůžes utéct, bolí tě nohy po výšlapu na skalku!\n");
                    break;
                    default:
                        Console.WriteLine("\nSYSTEM: vyber možnost, co uděláš: utok/obrana/magie/kebab/bez!\n");
                    break;
                }
            }
            Console.WriteLine("Odešel jsi z toho života :(!  \n \n \n \n          **** Konec hry **** \n \n \n");
        }
    }
}
