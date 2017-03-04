using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for Timeline_Details.xaml
    /// </summary>
    public partial class Timeline_Details : Window
    {
        string globalCountryValue = "";

        public Timeline_Details()
        {
            InitializeComponent();
        }

        public Timeline_Details(string countryValue, string yearValue)
        {
            InitializeComponent();
            setText(countryValue, yearValue);
            globalCountryValue = countryValue;
            
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

        private void setText(string countryValue, string yearValue)
        {
            switch (countryValue)
            {
                case "Aerial":
                    aerialText(yearValue);
                    break;
                case "China":
                    chinaText(yearValue);
                    break;
                case "Japan":
                    japanText(yearValue);
                    break;
                case "East Germany":
                    eastGermanyText(yearValue);
                    break;
                case "West Germany":
                    westGermanyText(yearValue);
                    break;
                case "UK":
                    unitedKingdomText(yearValue);
                    break;
                case "France":
                    franceText(yearValue);
                    break;
                //case "Italy":
                  //  countryValue = "Italy";
                    //break;
                case "Russia":
                    russiaText(yearValue);
                    break;
                case "USA":
                    usaText(yearValue);
                    break;
                default:
                    MessageBox.Show("Country not yet implemented.");
                    break;
            }
        }

        private void aerialText(string yearValue)
        {
            switch (yearValue)
            {
                case "forties":
                    factBlock1.Text = "After the war, the focus of aviation and the development of aircraft began to move from the building of war planes to the building of commercial aircraft. Bombers like the B-29 and the Lancaster could be converted to commercial aircraft.";
                    factBlock2.Text = "In 1946, the British aircraft de Havilland D.H. 108 Swallow struggles to break the sound barrier. A pilot is killed during a test flight. The American X-1 eventually manages to achieve the feat in the autumn of 1947.";
                    factBlock3.Text = "The British De Havilland Comet takes its first test flight, and later becomes the first commercial passenger plane, taking passengers between London and Africa.";

                    summaryText.Content = "";
                    
                    //set image files to relevant pictures [reload push]
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/lancasterBomber.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/x-1.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/deHavillandComet.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "fifties":
                    factBlock1.Text = "The Korean War begins. This period saw the last use of propeller driven fighters and the beginning of the jet age. In 1954, the Spitfire made its last ever operational flight.";
                    factBlock2.Text = "The Mikoyan Gurevich series of planes enter use. The MiG 21 in particular was designed to be faster than other aircraft of the time. The first U-2 spy plane flies over Moscow.";
                    factBlock3.Text = "Richard Whitcomb proposes 'the area rule', which is a way of reducing drag and increasing speed without the need for additional power.  Boeing creates the B-52 bomber, which had eight engines.";

                    summaryText.Content = "";

                    //set image files to relevant pictures [reload push]
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/MiG21.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/U-2.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/b52.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    factBlock1.Text = "The first U-2 spy plane is shot down over the USSR and the pilot captured. US aircraft Learjet becomes the first mass produced aircraft.";
                    factBlock2.Text = "USA uses B-52's in a three year campaign during the Vietnam War. The UK develops the McDonnell Douglas Phantom line, which had supersonic radar and was later used in the Falkand Islands war.";
                    factBlock3.Text = "Boeing develops its landmark aircraft, the Boeing 747. Its wide body enabled more passengers to travel on a single flight and became one of the most successful commercial aircraft.";

                    summaryText.Content = "";
                    
                    //set image files to relevant pictures [reload push]
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/boeingMonomail.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/mcdonnellDouglasPhantom.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/douglasSkyhawk.jpeg", UriKind.RelativeOrAbsolute));
                    
                    break;

                case "seventies":
                    factBlock1.Text = "The Lockheed SR-71 sets a new world speed record of 2,193 mph.";
                    factBlock2.Text = "Great Britain and France introduced the Concorde SST, a commercial airline. It could carry a hundred passengers from London to New York in 3 and a half hours.";
                    factBlock3.Text = "The price of supersonic commercial flights remains high and are enjoyed mostly by the wealthy.";

                    summaryText.Content = "";

                    //set image files to relevant pictures [reload push]
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/lockeedSR71.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/concorde.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/supersonicPlane1.jpg", UriKind.RelativeOrAbsolute));
                    
                    break;

                case "eighties":
                    factBlock1.Text = "Progress slows and the focus moves to ground-proximity systems for better landings and higher fuel efficiency. Lightweight aircraft Voyager circumnavigates the globe in 9 days on one tank of fuel and two engines.";
                    factBlock2.Text = "The Vulcan Bomber carries out the longest bombing raid in history on the Falkland Islands. The Electronic Flight Instrument System is the beginning of screens replacing dials in cockpit dashboards.";
                    factBlock3.Text = "Simulators become so advanced that pilots in training could earn a type rating without flying an actual airplane. Cockpit Resource Management puts a greater emphasis on teamwork between the captain and the co-pilot.";

                    summaryText.Content = "";

                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/supersonicPlane2.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/voyagerAircraft1.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/vulcanBomber.JPEG", UriKind.RelativeOrAbsolute));

                    break;

                default:
                    break;
            }

        }

        private void chinaText(string yearValue)
        {
            switch (yearValue)
            {
                case "forties":
                    string chinaFortyFiveString = "1945: Civil War between the nationalists and the Communists resumes. China's economy is suffering, the people are starving and homeless. The UN sends relief packages, and the USA supports the nationalists.";
                    factBlock1.Text = chinaFortyFiveString;
                    string chinaFortyEightString = "1948: After years of fighting, Chiang over-extends his forces in the north, and the Communists launch a major offensive against China's cities. The Communists capture North China.";
                    factBlock2.Text = chinaFortyEightString;
                    string chinaFortyNineString = "1949: Chiang resigns 11 days after the battle for central China and flees to Thailand. The nationalists are routed by a lack of popular support. Mao forms the People's Republic of China.";
                    factBlock3.Text = chinaFortyNineString;

                    summaryText.Content = "Civil War comes to an end ~ Formation of the People's Republic of China";
                    
                    //set image files to relevant pictures [reload push]
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chineseCivilWar1.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chineseCivilWar2.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chineseCivilWar3.png", UriKind.RelativeOrAbsolute));

                    break;
                case "fifties":
                    string chinaFiftyOneString = "1950-53: Ban of arranged marriage and laws to strengthen women's position. Introduction of Soviet-style curriculum. Improvement of food security due to land reform. Wealth of landlords is redistributed to peasants. Supported North Korea against the US. Invasion of Tibet.";
                    factBlock1.Text = chinaFiftyOneString;
                    string chinaFiftyThreeString = "1953-56: Five Year Plan successfully develops industry. First unsucessful attempt to impose mass birth control. The Sino-Soviet agreement on technological aid is signed in Moscow.";
                    factBlock2.Text = chinaFiftyThreeString;
                    string chinaFiftySevenString = "1957-59: Land is collectivised and farmers are organised into communes. The Great Leap Forward leads to trading grain for Soviet machinery. This resulted in a famine and millions died. Suppression of Tibetan revolt.";
                    factBlock3.Text = chinaFiftySevenString;

                    summaryText.Content = "Mass reform in agriculture and society ~ Military action and famine";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/tibet.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chinaBackyardFurnace.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/greatLeapForward.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    string chinaSixtyOneString = "1960-63: Research into nuclear technology. Tensions between China and Khruschev's USSR. Border conflict with India. Population growth puts strain on resources.";
                    factBlock1.Text = chinaSixtyOneString;

                    string chinaSixtyThreeString = "1963-66: Test of China's first nuclear bomb. Diplomatic relations established with France. Tibet becomes an autonomous region. Beginning of the cultural revolution with the publication of Mao's Little Red Book.";
                    factBlock2.Text = chinaSixtyThreeString;

                    string chinaSixtySixString = "1966-69: Destruction of the Four Olds (ideas, culture, customs, habits) leads to intimidation and violence of citizens. Religious practice is condemned as feudalistic.";
                    factBlock3.Text = chinaSixtySixString;

                    summaryText.Content = "Conflicts and alliances with other countries ~ Further culture reformation";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/culturalRevolution.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/mushroomCloud.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/hongKong.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "seventies":
                    string chinaSeventyOneString = "1970-73: Violent incidents occur on the Sino-Vietnam border. Successful satellite launches. USA and China declare their intent to improve relations. The rivalry between USSR and China reaches a high point.";
                    factBlock1.Text = chinaSeventyOneString;

                    string chinaSeventyThreeString = "1973-76: Terracotta Army discovered. Nationwide birth control campaign has little impact. Mao dies and the 'Gang of Four' wrestle for power but all are convicted for crimes against the state.";
                    factBlock2.Text = chinaSeventyThreeString;

                    string chinaSeventySevenString = "1976-1979: Deng Xiaoping takes leadership and establishes economic reform.";
                    factBlock3.Text = chinaSeventySevenString;

                    summaryText.Content = "Further conflicts and fence mending with other nations ~ Political reform";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/longMarchSatelliteBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/terracottaArmyBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/dengXiaoping.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "eighties":
                    string chinaEightyOneString = "1980-83: Improvement of China's food production and reduction of rural poverty. Population surpasses 1 billion people. Debates happen between the 'Reds', who promote ideological commitment and the 'Technocrats', who wanted reform.";
                    factBlock1.Text = chinaEightyOneString;

                    string chinaEightyThreeString = "1983-86: Fourteen cities are opened to foreign investment as part of an 'open-door policy'. Thousands of students demonstrate for greater intellectual freedom. New regulations create labour camps for 're-education' purposes.";
                    factBlock2.Text = chinaEightyThreeString;

                    string chinaEightySixString = "1986-89: KFC and other Western-style food comes to China. General Secretary Hu Yaobang is forced to resign over accusations of being 'too liberal'. Tiananmen Square demonstrations are suppressed, leading to the murder of 200 people.";
                    factBlock3.Text = chinaEightySixString;

                    summaryText.Content = "Improvement of living conditions ~ Improved communications, harder crackdowns";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/tianamenSquare1BW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/tianamenSquare2BW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/tiananmenSquare3BW.jpg", UriKind.RelativeOrAbsolute));

                    break;
                default:
                    break;
            }
        }

        private void japanText(string yearValue)
        {
            switch (yearValue)
            {
                case "forties":
                    string japanFortyFiveString = "1945: Within the space of four days, two nuclear bombs are dropped, killing almost 250,000. The USSR decimates Japanese troops occuping China and North Korea. Japan surrenders and the USA occupies the country.";
                    factBlock1.Text = japanFortyFiveString;
                    string japanFortySixString = "1946-7: Emperor Hirohito publically renounces the notion of godhood. Prominent leaders of Japan are tried for war crimes and some are executed. A new constitution is announced.";
                    factBlock2.Text = japanFortySixString;
                    string japanFortyEightString = "1948-9: A Eugenics Protection Law is enacted to avoid the birth of 'defective' offspring. It was rescinded in 1996, after the sterilisation of nearly 845,000 people.";
                    factBlock3.Text = japanFortyEightString;

                    //set image files to relevant pictures
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/enolaGay.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/nagasakiImage2.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/nagasakiImage1.jpg", UriKind.RelativeOrAbsolute));

                    summaryText.Content = "Surrender and occupation ~ War reparations";

                    break;
                case "fifties":
                    string japanFiftyOneString = "1950-53: Japan signs a peace treaty with the US and other nations (except Russia). Independence is regained, with the US retaining islands like Okinawa for military use.";
                    factBlock1.Text = japanFiftyOneString;
                    string japanFiftyThreeString = "1953-56: The Liberal Democratic Party is formed, governing Japan into the 21st century. A Leprosy Prevention Law banishes lepers to remote islands. It was repealed in 1996. Japan joins the UN.";
                    factBlock2.Text = japanFiftyThreeString;
                    string japanFiftySevenString = "1957-59: The 1950s see a period of huge economic growth. American headquarters in Japan are dissolved. A law is passed to provide treatment to atomic bomb survivors.";
                    factBlock3.Text = japanFiftySevenString;

                    summaryText.Content = "Independence regained ~ Economic growth and gradual independence from the US";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/okinawaBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/unitedNationsBW.png", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/atomicBombVictim.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    string japanSixtyOneString = "1960-63: Formalised US-Japan alliance due to signing of US-Japan Treaty of Mutual Cooperation and Security. Prime Minister Kishi strengthens this alliance throughout his term.";
                    factBlock1.Text = japanSixtyOneString;

                    string japanSixtyThreeString = "1963-66: Olympics are held in Tokyo. The Shinkansen Bullet Train opens in Japan. Sato becomes the new Prime Minister. A peace treaty is signed with South Korea that includes reparations.";
                    factBlock2.Text = japanSixtyThreeString;

                    string japanSixtySixString = "1966-69: Exports of military equipment are restricted in keeping with the constitution. The Asian Development Bank opens. The first reported case of karoshi (a Japanese term for death from overwork) is reported.";
                    factBlock3.Text = japanSixtySixString;

                    summaryText.Content = "Strengthening alliances with other countries ~ Urban development";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/shinkansenBulletTrainBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/tokyoOlympicsBW.png", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/kishi.JPG", UriKind.RelativeOrAbsolute));

                    break;

                case "seventies":
                    string japanSeventyOneString = "1970-73: Okinawa is returned to Japan, but the US retains some bases in the country. Sato visits China and diplomatic relations are resumed. Japan launches a satellite, becoming the fourth nation to do so.";
                    factBlock1.Text = japanSeventyOneString;

                    string japanSeventyThreeString = "1973-76: The last Japanese soldier based in the Philippines, Hiroo Onoda, surrenders 29 years after the war ends. Yuko Shimizu, creator of Hello Kitty, decides Hello Kitty's birthday is 1st November. Junko Tabei becomes the first woman to climb Mount Everest.";
                    factBlock2.Text = japanSeventyThreeString;

                    string japanSeventySevenString = "1976-1979: The Japanese Red Army hijack a Japan Airlines plane and fly it to India. The Japanese government pay a ransom fee for the release of the passengers and crew. China and Japan sign a $20 billion trade deal. Cyclone Tip hits Japan.";
                    factBlock3.Text = japanSeventySevenString;

                    summaryText.Content = "Solidification of Japanese independence ~ Peace between neighbours";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/ohsumi1BW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/typhoonTipBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/japaneseRedArmyBW.png", UriKind.RelativeOrAbsolute));

                    break;

                case "eighties":
                    string japanEightyOneString = "1980-83: Honda car company opens a US plant. Arcade game Pac-Man is released. Flash memory is invented by Dr. Fujio Masuoka. Japan bails out the US government economically by buying government bonds. An earthquake and tsunami strike Hokkaido, leading to at least 100 deaths.";
                    factBlock1.Text = japanEightyOneString;

                    string japanEightyThreeString = "1983-86: An anti-tsunami structure is built in Fudai, protecting the town from the 2011 tsunami. A Boeing 747 crashes into Mount Otsuka due to technical failure, killing 520. Nintendo launches the Nintendo Entertainment System.";
                    factBlock2.Text = japanEightyThreeString;

                    string japanEightySixString = "1986-89: Japan removes most legal barriers to female employment, but discrimination remains rampant. Two years after the founding of the company, Studio Ghibli releases classic war film 'The Grave of the Fireflies.' Emperor Hirohito dies and is succeeded by Akihito.";
                    factBlock3.Text = japanEightySixString;

                    summaryText.Content = "Technological advancement ~ Beginning of the reign of a new emperor";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/studioGhibli.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/tsunamiDamageBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/NESBW.jpg", UriKind.RelativeOrAbsolute));

                    break;
                default:
                    break;
            }

        }

        private void eastGermanyText(string yearValue)
        {
            switch (yearValue)
            {
                case "forties":
                    string gdrFortyFiveString = "1945: Madjanek and Bergen-Belsen are among the first concentration camps to be liberated intact, where troops found tens of thousands of unburied bodies. By April, the Red Army arrives on the outskirts of Berlin. Hitler commits suicide and German forces surrender.";
                    factBlock1.Text = gdrFortyFiveString;
                    string gdrFortyEightString = "1946-7: The Allies seize 1,000 Germans who were attempting to revive the Nazi party. Trials of leading Nazis continue, with many sentenced to hanging. 800,00 'minor' members are given amnesty. Britain and France sign a 50 year pact to curb Germany.";
                    factBlock2.Text = gdrFortyEightString;
                    string gdrFortyNineString = "1948-9: The country is divided between the USSR, the US, the UK and France. The USSR blocks access to West Berlin. The General Democratice Republic (East Germany) and Federal Republic of Germany (West Germany) are formed.";
                    factBlock3.Text = gdrFortyNineString;

                    summaryText.Content = "Defeat and surrender ~ War crime trials ~ Division of the country";

                    //set image files to relevant pictures
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/massGrave.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/berlinAirlift.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/nurembergTrials.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case "fifties":
                    factBlock1.Text = "1950-3: New leader Walter Ulbricht announces the demolition of the Berlin City Palace. Soviet tanks fight thousands of rioting East German workers outside Berlin. The war between the USA and Germany is formally ended.";
                    factBlock2.Text = "1954-6: East and West Berlin drop propaganda leaflets on one another after a month long truce. East Germany police arrest 400 citizens on suspicion of being US spies. East Germany granted sovereignty by the USSR.";
                    factBlock3.Text = "1957-9: Erich Mielke becomes head of the German state security i.e. the Stasi. The Bad Godesberg Program is designed to broaden support for the Social Democratic Party, and rejects Marxist ideas.";

                    summaryText.Content = "Establishment of East Germany as a state ~ Tensions and mass arrests.";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/berlinCityPalace.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/flagEastGermanyBW.png", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/berlinTankFaceoff.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    factBlock1.Text = "1960-3: 160,000 people cross from East Germany to West Germany due to food shortages. The continual population drop leads to the creation of the Berlin Wall. People attempting to defect ran the risk of being shot and killed.";
                    factBlock2.Text = "1964-6: The Soviets down a jet over East Germany, killing three. Berlin citizens dig a tunnel to West Berlin and more than 50 people escaped. Figure skater Katarina Witt is born. She would later go on to win gold for figure skating.";
                    factBlock3.Text = "1967-9: Soviet troops found the Museum of the Unconditional Surrender of Fascist Germany in the Great Patriotic War of 1941-1945. 95% of voters approve a socialist constitution. Authorities blew up the University Church in Leipzig to reconstruct the city square.";

                    summaryText.Content = "Rise of the Berlin Wall ~ Formation of the new constituion";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/checkpointCharlie.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/berlinWall.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/wallChildren.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "seventies":
                    factBlock1.Text = "1970-3: The first East-West Germany summit is held in Germany. The Quadripartite Agreement on Berlin between the four occupying powers puts tensions to rest. Border guards were ordered to shoot anyone caught attempting to cross, even children.";
                    factBlock2.Text = "1974-6: Head doctor of the East German Swimming Federation, Lothar Kipke, gives swimmers performance enhancing steroids. He was later convicted.";
                    factBlock3.Text = "1977-9: Marxist Rudolf Bahro was imprisoned after smuggling a book out of East Germany. He was later released and allowed to resettle in West Germany. Oskar Brusewitz, a Lutheran vicar, immolates himself in protest of the country's repression of religion.";

                    summaryText.Content = "Mending tensions between East and West ~ Clampdown on attempted escape over the Wall";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/borderDefense.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/newspaperReading.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/wallGravesBW.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "eighties":
                    factBlock1.Text = "1980-3: Chemist and dissident Robert Havemann died. Christina Wolf publishes her novel 'Cassandra'. The active ingredient of the antibiotic Cipro is patented by drug maker Bayer.";
                    factBlock2.Text = "1984-6: Top West German intelligence agent Hans-Joachim Tiedge defected to East Germany. He later moved to the Soviet Union in 1990. Soviet KGB officer Vladimir Putin is assigned to Dresden to recruit spies. German hackers perform the 'Cuckoo's Nest' cyberattack on US networks.";
                    factBlock3.Text = "1987-9: President Reagan publicly challenges Soviet leader Gorbachev to tear down the wall. Thousands of East Germans are allowed to leave for the West. 10,000 people march to demand democratic reforms. Confusion at the border leads to the opening and fall of the Berlin Wall. ";

                    summaryText.Content = "Mounting pressures and slow bleeding to the population ~ Fall of the Berlin Wall ~ Beginning of the reunification of Germany";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/kgbLogo.png", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/fallOfBerlinWallBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chippingBerlinWallBW.jpg", UriKind.RelativeOrAbsolute));

                    break;
                default:
                    break;
            }
        }

        private void westGermanyText(string yearValue)
        {
            switch (yearValue)
            {
                case "forties":
                    string gdrFortyFiveString = "1945: Madjanek and Bergen-Belsen are among the first concentration camps to be liberated intact, where troops found tens of thousands of unburied bodies. By April, the Red Army arrives on the outskirts of Berlin. Hitler commits suicide and German forces surrender.";
                    factBlock1.Text = gdrFortyFiveString;
                    string gdrFortyEightString = "1946-7: The Allies seize 1,000 Germans who were attempting to revive the Nazi party. Trials of leading Nazis continue, with many sentenced to hanging. 800,00 'minor' members are given amnesty. Britain and France sign a 50 year pact to curb Germany.";
                    factBlock2.Text = gdrFortyEightString;
                    string gdrFortyNineString = "1948-9: The country is divided between the USSR, the US, the UK and France. The USSR blocks access to West Berlin. The General Democratice Republic (East Germany) and Federal Republic of Germany (West Germany) are formed.";
                    factBlock3.Text = gdrFortyNineString;

                    summaryText.Content = "Surrender and war trials ~ Division of the country between major Allied powers";

                    //set image files to relevant pictures
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/massGrave.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/berlinAirlift.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/nurembergTrials.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case "fifties":
                    factBlock1.Text = "1950-3: West Germany agree to pay reparations of 3 billion marks over the next 14 years to Israel. A compensation treaty for all victims of Nazi crimes is signed. The new neo-Nazi Socialist Reich Party is banned. Adenauer is elected Chancellor.";
                    factBlock2.Text = "1954-6: The CIA creates a tunnel between West and East Berlin to tap Soviet and GDR communications. West Germany is permitted to enter NATO and rearm. The Allied powers agree to end occupation of Germany. West Germany becomes a sovereign state.";
                    factBlock3.Text = "1957-9: Saarland, formerly under French administration, rejoins with West Germany. Adenauer is re-elected Chancellor of West Germany. The USA, France and Britain reject Soviet demands to withdraw troops from West Berlin but agree to liquidate Allied occupation there.";

                    summaryText.Content = "Reparations and election of the new leading party ~ Reduction of Allied presence ~ Beginning of tensions between East and West";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/flagOfGermanyBW.png", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/jerusalemTrain.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/alliedOccupation.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    factBlock1.Text = "1960-3: The Berlin Wall is built. Germany paid further reparations to Greece. After a synagogue is graffitied and a series of anti-Semitic acts sweeps Germany, Adenauer passes a law making the denial of Nazi crimes punishable by law.";
                    factBlock2.Text = "1964-6: Military aid to Tanzania ceased. Israel's Cabinet approved the founding of diplomatic relations with West Germany. West Germany extended its war crime retribution. Auschwitz trials ended with only 6 life sentences.";
                    factBlock3.Text = "1967-9: Chancellor Adenauer dies. Germans protest the Shah of Iran's visit. Some 100,000 people demonstrate against the USA's involvement in the Vietnam War. Riots break out after the attempted assassination of student leader Rudi Dutschke by a right-wing extremist.";

                    summaryText.Content = "Further reparations and war trials ~ Protests and political turmoil";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/checkpointCharlie.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/berlinWall.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/wallChildren.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "seventies":
                    factBlock1.Text = "1970-3: Treblinka commander Stangl was sentenced to life. The Quadripartite Agreement on Berlin between the four occupying powers puts tensions to rest. New Chancellor Brandt is awarded the Nobel Peace Prize for beginning reunification. He makes a 5-day trip to Israel.";
                    factBlock2.Text = "1974-6: A scandal forces Brandt to resign as Chancellor. Helmut Schmidt becomes the new Chancellor. Oskar Schindler, who saved about 1,200 Jews during the Shoah, dies and is buried by his own request in Jerusalem. About 10,000 Vietnamese take refuge in West Germany after the fall of Saigon.";
                    factBlock3.Text = "1977-9: Members of the Baader-Meinhof gang are sentenced to life. A Boeing 737 is hijacked by Palestinians who demand the release of other Palestinians from German jails. West German commandos storm the plane, freeing the hostages and killing 3/4 of the hijackers.";

                    summaryText.Content = "Reducing long-term tensions ~ New Chancellor ~ Move towards reunification";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/fallOfSaigon.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/redArmyFaction.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/oskarSchindler.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "eighties":
                    factBlock1.Text = "1980-3: Radio Free Europe is bombed, injuring 9 people. Child molester Klaus Grabowski was shot and killed by the mother of a girl he had molested and strangled. 1 million metal workers go on strike over wage disputes. Helmut Kohl becomes the new Chancellor, serving until 1998.";
                    factBlock2.Text = "1984-6: A record 295,000 dominoes toppled in Fuerth! West German scientists help identify remains found in Brazil as belonging to Nazi war criminal Josef Mengele. Mengele had carried out horrific experiments on prisoners of the death camps but managed to evade capture.";
                    factBlock3.Text = "1987-9: SPD Chairman Brandt resigns. Pope John Paul II visits and beatifies Edith Stein, a Jewish Carmelite nun who died in Auschwitz. President Bush visits and offers West Germany 'partnership in leadership'. The fall of the Berlin Wall begins the path to reunification.";

                    summaryText.Content = "Strengthening bonds with other countries ~ Fall of the Berlin Wall ~ Beginning of reunification";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/josefMengele.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/fallOfBerlinWallBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chippingBerlinWallBW.jpg", UriKind.RelativeOrAbsolute));

                    break;
                default:
                    break;
            }
        }

        private void unitedKingdomText(string yearValue)
        {
            switch (yearValue)
            {
                    //lord of the rings publication date
                case "forties":
                    factBlock1.Text = "1945: Labour wins the election by a landslide and Clement Atlee becomes Prime Minister. Japan surrenders Hong Kong to British control. Korea is divided between the US and UK, and the Soviet Union. The Bank of England was nationalised.";
                    factBlock2.Text = "1946-7: First assembly of the UN in London. Atlee supports Indian independence, Churchill opposes the removal of troops. Britain agreed to give Burma independence after negotiations. India gains independence. Bangladesh gains independence.";
                    factBlock3.Text = "1948-9: The NHS went into operation. Nationalisation of the London Underground. Clothes rationing in Britain ends. The NATO pact is signed by European countries as a means of protection. 26 countries leave the Commonwealth. Public access to countryside paths granted.";
                    
                    summaryText.Content = "Change in government ~ British territories begin to gain independence.";

                    //set image files to relevant pictures
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/britishRationing.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/londonUnderground.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/nationalHealthService.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case "fifties":
                    factBlock1.Text = "1950-3: Egyptian king Farouk demanded the departure of troops from Egypt. Alan Sainsbury started Britain's first self-service grocery. Radio play the Archers began and continues to this day. Elizabeth II succeeds the throne. Britain developed its own atomic bomb.";
                    factBlock2.Text = "1954-6: Alan Turing, whose machine broke the Enigma Code, committed suicide after being forced to take injections intended to remove his homosexuality. The Suez Canal Pact ends Britain's occupation of Egypt. Sudan became independent.";
                    factBlock3.Text = "1957-9: Harold Macmillan becomes Prime Minister. Malaysia gains independence. A fire in Windscale reactor spreads radioactive material into the countryside. Queen Elizabeth elevated the first women to the House of Lords.";

                    summaryText.Content = "Coronation of Queen Elizabeth II ~ Beginning of the end of rationing";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/queenElizabethCoronation.PNG", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/windscaleReactor.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/suezCanal.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    factBlock1.Text = "1960-3: British Somaliland became independent. Cyprus became independent. Nigeria became independent. Britain's 2 year National Service program ended. The British territory Tanganyika becomes independent. Jamaica becomes an independent dominion of the Commonwealth.";
                    factBlock2.Text = "1964-6: Pirate station Radio Caroline broadcasts off the coast of England. Malawi, Gambia, Singapore, the Republic of the Maldives, the Republic of Botswana and Zambia gain independence. Eleven nations donate to save the British currency. Death penalty abolished.";
                    factBlock3.Text = "1967-9: The Beatles release bestselling album Sgt. Pepper's Lonely Hearts Club Band. A peaceful protest against the Vietnam war leads to a riot. Protestors were assaulted by mounted police. Troops are sent to Northern Ireland to intervene in sectarian violence.";

                    summaryText.Content = "More countries gain independence ~ Increase of sectarian violence in Northern Ireland";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/thunderbirdMissile.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/vietnamProtests.PNG", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/commonwealthFlagBW.png", UriKind.RelativeOrAbsolute));

                    break;

                case "seventies":
                    factBlock1.Text = "1970-3: Pink Floyd releases one of the best-selling albums of all time, The Dark Side of the Moon. 27 year-old guitarist Jimi Hendrix dies of a drug overdose. Police fire on a peaceful protest in an event called Bloody Sunday.";
                    factBlock2.Text = "1974-6: The working week was cut down to three days due to miner's strikes. The IRA bomb pubs in England, killing members of the British public. The Sex Discrimination act was passed to lessen discrimination in education and employment.";
                    factBlock3.Text = "1977-9: Drama Grange Hill made its debut. After frustrations over limits opposed on wages, British unions begin the 'Winter of Discontent'. Tuvalu, the Gilbert Islands and Dominca became independent. Thatcher becomes the first female Prime Minister.";

                    summaryText.Content = "Bombings by the IRA ~ Crackdowns on protests";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/derry1900sBW.png", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/miners.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/irishRepublicanArmy.PNG", UriKind.RelativeOrAbsolute));

                    break;

                case "eighties":
                    factBlock1.Text = "1980-3: Thatcher bans 'sympathy strikes' to undercut the power of workers' unions. Argentinian troops seized the Falkland Islands but were repelled by the British. Unemployment hits a high of three million.";
                    factBlock2.Text = "1984-6: Hong Kong is transferred to Chinese sovereignty. Coal miners lost a 51-week strike against mine closings. Thatcher signs a deal to provide fighter jets to Saudi Arabia. Corporal punishment was outlawed in public schools.";
                    factBlock3.Text = "1987-9: Thatcher distances herself from the US policy of revenge against the bombers of Pan Am Flight 103. Unemployment drops but is not as low as it was in '79. The hugely unpopular poll tax is introduced. Property values drop .";

                    summaryText.Content = "Conflict between unions and Thatcher's government ~ Falkland Islands war";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/panAmMemorialBW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/hongKong2BW.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/thatcherBW.jpg", UriKind.RelativeOrAbsolute));

                    break;
                default:
                    break;
            }

        }

        private void franceText(string yearValue)
        {
            switch (yearValue)
            {
                //lord of the rings publication date
                case "forties":
                    factBlock1.Text = "1945: An uprising in Algeria led to the deaths of thousands of people. Pierre Laval, one of the leaders of the pro-Nazi Vichy government, was arrested and later executed. Women in France were allowed to vote.";
                    factBlock2.Text = "1946-7: Syria gains independence from France. Frech doctor Petiot, who murdered at least 26 Jewish people, was beheaded. France declares martial law in Algeria. France and Britain sign an alliance treaty. War hero Leclerc dies.";
                    factBlock3.Text = "1948-9: France signs the NATO pact. French priest Abbe Pierre began taking in the homeless, and soon his project would expand to include other countries. Presenting cowardice in a favourable light was banned from children's books.";

                    summaryText.Content = "Collapse of the Vichy Government ~ Alliances with Allied powers";

                    //set image files to relevant pictures
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/algerianWar.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/londonUnderground.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/algerianWar2.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case "fifties":
                    factBlock1.Text = "1950-3: French forces fight the Viet Minh. Massive arrests of communists. The Algerian Liberation Front beging guerrilla warfare against France. The National Secular Action Committee is established to support public education.";
                    factBlock2.Text = "1954-6: Vietnam is divided into a communist North and US-supporting south and French forces withdraw. France sends soldiers to Algeria. French generals approve the torture of Algerian fighters. Tunisia gains independence.";
                    factBlock3.Text = "1957-9: French troops took control of Algiers. France leaves Morocco. Chad becomes an autonomous nation within French rule. With French support, Senegal and Sudan form the Republic of Mali.";

                    summaryText.Content = "Former French territories become independent";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/indochinaWar.JPEG", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/vietMinh.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/algerianWar3.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    factBlock1.Text = "1960-3: Several African countries gain independence. The French army revolt in Algeria. Overseas territories were granted freedom of religion within the bounds of law. Algeria becomes independent.";
                    factBlock2.Text = "1964-6: French troops leave Algeria. France withdraws from NATO in protest of US domination of the origanisation. French fighter planes crashed over Spain. IBM establishes a manufacturing plant in Montpellier.";
                    factBlock3.Text = "1967-9: Peace talks between North Vietnam and the US are held in France. The first supersonic airliner, the Concorde, was unveiled. 10 million workers and large numbers of students go on strike.";

                    summaryText.Content = "Ending of the Algerian war ~ Sound barrier broken";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/algerianIndependence.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/concorde.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/vietnamPeace.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "seventies":
                    factBlock1.Text = "1970-3: An LGBT group interrupts a homophobic radio show, putting LGBT right's movements into the public eye. Mitterrand becomes leader of the French Socialist Party. Vietnam peace talks collapse.";
                    factBlock2.Text = "1974-6: A Turkish airline plane crashes after takeoff in Paris. Nearly 350 people were killed in the worst air disaster to date. Stuntman Philippe Petit tight rope walks between the Twin Towers. Abortions were made legal.";
                    factBlock3.Text = "1977-9: Djibouti gains independence. Djandoubi becomes the last person to be executed by guillotine.";

                    summaryText.Content = "Social reform in France";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/djibouti.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/guillotine.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/vietnamPeace2.JPG", UriKind.RelativeOrAbsolute));

                    break;

                case "eighties":
                    factBlock1.Text = "1980-3: Mitterrand takes power. Under him, the franc collapses and inflation increases. He also introduces a tax on great wealth. Peacekeeping troops from Italy, the US and France begin the Lebanon War.";
                    factBlock2.Text = "1984-6: After a meeting with Steve Jobs, Mitterrand promises a microcomputer in every school. French security forces sink a Greenpeace ship. A US-French ship locates the wreck of the Titanic.";
                    factBlock3.Text = "1987-9: Gestapo official Klaus Barbie is put on trial and sentenced to life. Democratic leaders meet in Paris and condemn repression in China. School ban on religious symbols lifted.";

                    summaryText.Content = "Further government reform ~ Alliance between Western powers";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/greenpeace.png", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/lebanon.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/titanicWreck.jpg", UriKind.RelativeOrAbsolute));

                    break;
                default:
                    break;
            }

        } //end France text

        private void russiaText(string yearValue)
        {
            switch (yearValue)
            {
                //lord of the rings publication date
                case "forties":
                    factBlock1.Text = "1945: The Russian army takes Berlin as the Allies announce Nazi surrender in other areas. Thousands of Japanese people were imprisoned in Soviet labour camps.";
                    factBlock2.Text = "1946-7: Stalin announces a five year plan for boosting productivity. Kennan's 'Long Telegram' begins US hostility in their policies towards Russia.";
                    factBlock3.Text = "1948-9: Beginning of the Cold War. Soviets refuse to let the UN oversee North Korean elections. Soviets begin blockading Berlin. Soviets take over Czechoslovakia.";

                    summaryText.Content = "Beginning tensions between USSR and US";

                    //set image files to relevant pictures
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/berlinSovietCapture.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/czechoslovakiaInvasion.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/newspaperSurrender.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case "fifties":
                    factBlock1.Text = "1950-3: China and Russia sign a mutual defence treaty. Soviet Union shoots down a US spy plane. The Soviet Union proposes a cease fire in the Korean War. Leaders of the alleged Jewish 'Doctor's Plot' to murder Soviet leadership. Stalin dies aged 73.";
                    factBlock2.Text = "1954-6: The Crimea was given to Ukraine by Khrushchev. First atomic plant created near Moscow. The Cheka recreated as the KGB. Khrushchev denounces Stalin. Students protest to desanctify Stalin's memory. Soviet troops are sent to Hungary after an anti-Stalinist revolt.";
                    factBlock3.Text = "1957-9: The space race begins as Russia launches the first man-made satellite, Sputnik and Luna 2 reaches the moon. Moscow declares a halt on atomic tests and asks other nations to follow suit. Soviet forces arrive in Afganistan.";

                    summaryText.Content = "Worsening tensions between Soviet Union and NATO ~ Alliance with China";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/koreanWar.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/stalinDeath.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/sputnik.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    factBlock1.Text = "1960-3: Gagarin and Tereshkova become the first man and woman to go to space. The US detects Soviet missiles in Cuba, resulting in the Cuban Missile Crisis. A hot line communication link was set up between the US and Soviet Union afterwards.";
                    factBlock2.Text = "1964-6: More than 40 listening surveillance devices were found in the US embassy in Moscow. Brezhnev and Kosygin take over leadership. Leonov performs the first space walk. First pro-democracy demonstration. Luna 13 lands on the moon.";
                    factBlock3.Text = "1967-9: More than 60 nations sign a treaty banning nuclear weapons from orbit and space activity, including the US and Russia. The Soviet Union invades Czechoslovakia to crush the move towards liberalisation. Violent Russian-Chinese border dispute kill hundreds.";

                    summaryText.Content = "Space race and scientific advancement";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/cubanMissileCrisis.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/yuriGagarin.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/ballisticMissile.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "seventies":
                    factBlock1.Text = "1970-3: A new five year plan for expanding consumer production is produced. 70 nations including the USSR and USA sign an agreement banning chemical warfare.";
                    factBlock2.Text = "1974-6: Ballet dancer Baryshnikov defects to Canada. Soviet Union creates world's first supersonic transport service. Putin joins the KGB. Pepsi enters the Soviet Union's market.";
                    factBlock3.Text = "1977-9: On Human Rights Day, twenty dissidents are put under house arrest and the government threatens to break up silent protests. The constitution adopts article 72, which lets republics separate from the USSR.";

                    summaryText.Content = "Lessening tension with the United States";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/supersonicPlane.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/kgbCard.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chemicalWarfare.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "eighties":
                    factBlock1.Text = "1980-3: The UN disapproves of Soviet actions in Afganistan. The US boycotts the Moscow Olypmic games. The Soviet Union announces a partial withdrawal from Afganistan. The US arms Afghan soldiers in the war.";
                    factBlock2.Text = "1984-6: The Soviets help the US deliver wheat to Ethiopia during a famine. Gorbachev announces 'perestroika' reforms - reconstructing and opening the Soviet Union's economy. The Chernobyl disaster releases radioactive material into the atmosphere.";
                    factBlock3.Text = "1987-9: Reagan and Gorbachev agree to ban medium range missile after talks in Washington. The Soviets pull out of Afganistan. The teaching of Hebrew was allowed. Gorbachev and Bush officially announce the end of the Cold War.";

                    summaryText.Content = "Move towards a democratic structure ~ End to the Cold War";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/sovietStamp.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chernobyl.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/endOfColdWar.jpg", UriKind.RelativeOrAbsolute));

                    break;
                default:
                    break;
            }

        } //end Russia text

        private void usaText(string yearValue)
        {
            switch (yearValue)
            {
                //lord of the rings publication date
                case "forties":
                    factBlock1.Text = "1945: Smokey the bear is chosen as the spokesperson for combating forest fires. US drops two atomic bombs on Nagasaki and Hiroshima and Japan, beginning the atomic age. Europe is divided between the Allied powers at the Potsdam Conference.";
                    factBlock2.Text = "1946-7: Government creates the Truman Doctrine, which promises to aid countries threatened by communism. Jackie Robinson becomes the first African-American to play Major League Baseball. The Taft-Hartley act was passed to address unfair labour laws.";
                    factBlock3.Text = "1948-9: The Marshall Plan was created to boost European economy by disbursing money. It was regarded as a success. The Alger Hiss case begins. Alger Hiss was accussed of being part of a communist espionage ring. He was later convicted with perjury.";

                    summaryText.Content = "Beginning tensions between USSR and US";

                    //set image files to relevant pictures
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/smokeyBear.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/jackieRobinson.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/potsdamConference.PNG", UriKind.RelativeOrAbsolute));

                    break;
                case "fifties":
                    factBlock1.Text = "1950-3: The Korean War begins. The US invades North Korea. Senator McCarthy carries out a crusade to find Communists. By 1954, the Senate expressed disapproval of his methods. The US ends Japanese occupation. Korean war ends with a truce.";
                    factBlock2.Text = "1954-6: Racial segregation is made unconstitutional. Partitioning of Vietnam begins. Summit meeting between Eisenhower and Russian leader Khrushchev. Frank Lloyd designs the New York Guggenheim Museum.";
                    factBlock3.Text = "1957-9: A white mob gathered at Little Rock high school, where nine African American students were now allowed to attend. Eisenhower ordered troops to protect the students. Fidel Castro becomes the Communist leader of Cuba.";

                    summaryText.Content = "Beginning of civil rights movement in America";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/senatorMcCarthy.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/littleRockHighSchool.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/eisenhower.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "sixties":
                    factBlock1.Text = "1960-3: John F Kennedy is elected President, narrowly defeating Nixon. The 'Bay of Pigs' was an unsuccessful attempt by the US to invade Cuba. The USA discovers Russian missiles in Cuba and urges Russia to remove them. Kennedy is assassinated.";
                    factBlock2.Text = "1964-6: The US sends troops to the Dominican Republic and South Vitnam. The Civil Rights Act aims to end discrimination. In New York several witnesses claimed to have failed to hear the cries of Kitty Genovese, who was stabbed to death. Her death provoked interest in 'bystander syndrome'.";
                    factBlock3.Text = "1967-9: Civil rights leader Martin Luther King is assassinated. Nixon is elected President amid increasing opposition to the Vietnam War. Neil Armstrong becomes the first person to walk on the moon.";

                    summaryText.Content = "Political upheaval and reform";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/kennedyAssassination.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/martinLutherKing.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/moonLanding.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "seventies":
                    factBlock1.Text = "1970-3: Painter Mark Rothko commits suicide. Nixon makes a historic visit to China. A US supported coup leads to the overthrow of the Chilean government. Vietnam ceasefire signed.";
                    factBlock2.Text = "1974-6: Nixon resigns over the Watergate scandal. Russia and Cuba install a Communist government in Angola. Beatle John Lennon makes his last concert appearance. Pan Am begins non-stop flights between New York and Tokyo.";
                    factBlock3.Text = "1977-9: Carter elected President. The US embassy in Iran is seized by radical students. The prolonged hostage situation impacts Carter's next election campaign. 'Human fly' George Willig climbs the World Trade Centre.";

                    summaryText.Content = "Continuing hostilities shown through foreign policy";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/chileCoup.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/iranHostageCrisis.jpg", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/nixonLeavingWhitehouse.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "eighties":
                    factBlock1.Text = "1980-3: Cases of AIDs grow throughtout the 80s, reaching tens of thousands of fatalities. Healthcare authorities were told to 'Look pretty and do as little as possible'. Massive demonstrations take place in protest.";
                    factBlock2.Text = "1984-6: Reagan is re-elected. The Challenger space shuttle explodes, killing all seven passengers. US warplanes bomb Libyan cities. Proceeds from secret arms sales to Iran were used illegally to fund rebels in Nicaragua. ";
                    factBlock3.Text = "1987-9: George Bush, is elected President. US troops invade Panama and arrest its former leader on drug-trafficking charges. The fall of the Berlin Wall starts the process of reunification between East and West.";

                    summaryText.Content = "Aggressive foreign policy ~ End to the Cold War";

                    //set images
                    placeholderImage1.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/challenger.JPEG", UriKind.RelativeOrAbsolute));
                    placeholderImage2.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/contras.PNG", UriKind.RelativeOrAbsolute));
                    placeholderImage3.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/usPanamaInvasion.jpg", UriKind.RelativeOrAbsolute));

                    break;
                default:
                    break;
            }

        }

        private void yearSelection_Click(object sender, RoutedEventArgs e)
        {
            Timeline returnTimeline = new Timeline(globalCountryValue);
            returnTimeline.Show();
            this.Close();

        }


    }
}
