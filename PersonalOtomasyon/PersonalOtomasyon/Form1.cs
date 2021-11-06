using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalOtomasyon.Core.Extension;

namespace PersonalOtomasyon
{
    //class bir nesne olarak yazılıma tanıtılır. 
    //class içerisinde field - property - method bulunur.
    //field => değişkenler 
    //Property => özellikler
    //method => yapabildikleri

    //Start
    //Program.cs içerisindeki Application.Run metoduna geldiğinde içerisinde yazan formumdan örnek aldığı sırada
    //O formun constructor tetiklenir. 
    //formun constructor da InitializeComponent() metodu çağırılır.
    //bu methodun içerisinde ekranda bulunan tüm componentlerin register edilmesi işlemleri ve diğer özellikleri set edilir.
    //sonrasında formun Form_Load event tetiklenir.
    //ve sonra form ekranan gelir.
    //o yüzden formda ekranan hazır gelmesini istiyorsak load event hazırlıkları yapmamız gerekir.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Ulke
        public string[] Ulkeler =
    {
"Afghanistan",
"Albania",
"Algeria",
"American Samoa",
"Andorra",
"Angola",
"Anguilla",
"Antarctica",
"Antigua and Barbuda",
"Argentina",
"Armenia",
"Aruba",
"Australia",
"Austria",
"Azerbaijan",
"Bahamas",
"Bahrain",
"Bangladesh",
"Barbados",
"Belarus",
"Belgium",
"Belize",
"Benin",
"Bermuda",
"Bhutan",
"Bolivia",
"Bosnia and Herzegovina",
"Botswana",
"Bouvet Island",
"Brazil",
"British Indian Ocean Territory",
"Brunei Darussalam",
"Bulgaria",
"Burkina Faso",
"Burundi",
"Cambodia",
"Cameroon",
"Canada",
"Cape Verde",
"Cayman Islands",
"Central African Republic",
"Chad",
"Chile",
"China",
"Christmas Island",
"Cocos (Keeling) Islands",
"Colombia",
"Comoros",
"Congo",
"Congo, the Democratic Republic of the",
"Cook Islands",
"Costa Rica",
"Cote D'Ivoire",
"Croatia",
"Cuba",
"Cyprus",
"Czech Republic",
"Denmark",
"Djibouti",
"Dominica",
"Dominican Republic",
"Ecuador",
"Egypt",
"El Salvador",
"Equatorial Guinea",
"Eritrea",
"Estonia",
"Ethiopia",
"Falkland Islands (Malvinas)",
"Faroe Islands",
"Fiji",
"Finland",
"France",
"French Guiana",
"French Polynesia",
"French Southern Territories",
"Gabon",
"Gambia",
"Georgia",
"Germany",
"Ghana",
"Gibraltar",
"Greece",
"Greenland",
"Grenada",
"Guadeloupe",
"Guam",
"Guatemala",
"Guinea",
"Guinea-Bissau",
"Guyana",
"Haiti",
"Heard Island and Mcdonald Islands",
"Holy See (Vatican City State)",
"Honduras",
"Hong Kong",
"Hungary",
"Iceland",
"India",
"Indonesia",
"Iran, Islamic Republic of",
"Iraq",
"Ireland",
"Israel",
"Italy",
"Jamaica",
"Japan",
"Jordan",
"Kazakhstan",
"Kenya",
"Kiribati",
"Korea, Democratic People's Republic of",
"Korea, Republic of",
"Kuwait",
"Kyrgyzstan",
"Lao People's Democratic Republic",
"Latvia",
"Lebanon",
"Lesotho",
"Liberia",
"Libyan Arab Jamahiriya",
"Liechtenstein",
"Lithuania",
"Luxembourg",
"Macao",
"Macedonia, the Former Yugoslav Republic of",
"Madagascar",
"Malawi",
"Malaysia",
"Maldives",
"Mali",
"Malta",
"Marshall Islands",
"Martinique",
"Mauritania",
"Mauritius",
"Mayotte",
"Mexico",
"Micronesia, Federated States of",
"Moldova, Republic of",
"Monaco",
"Mongolia",
"Montserrat",
"Morocco",
"Mozambique",
"Myanmar",
"Namibia",
"Nauru",
"Nepal",
"Netherlands",
"Netherlands Antilles",
"New Caledonia",
"New Zealand",
"Nicaragua",
"Niger",
"Nigeria",
"Niue",
"Norfolk Island",
"Northern Mariana Islands",
"Norway",
"Oman",
"Pakistan",
"Palau",
"Palestinian Territory, Occupied",
"Panama",
"Papua New Guinea",
"Paraguay",
"Peru",
"Philippines",
"Pitcairn",
"Poland",
"Portugal",
"Puerto Rico",
"Qatar",
"Reunion",
"Romania",
"Russian Federation",
"Rwanda",
"Saint Helena",
"Saint Kitts and Nevis",
"Saint Lucia",
"Saint Pierre and Miquelon",
"Saint Vincent and the Grenadines",
"Samoa",
"San Marino",
"Sao Tome and Principe",
"Saudi Arabia",
"Senegal",
"Serbia and Montenegro",
"Seychelles",
"Sierra Leone",
"Singapore",
"Slovakia",
"Slovenia",
"Solomon Islands",
"Somalia",
"South Africa",
"South Georgia and the South Sandwich Islands",
"Spain",
"Sri Lanka",
"Sudan",
"Suriname",
"Svalbard and Jan Mayen",
"Swaziland",
"Sweden",
"Switzerland",
"Syrian Arab Republic",
"Taiwan, Province of China",
"Tajikistan",
"Tanzania, United Republic of",
"Thailand",
"Timor-Leste",
"Togo",
"Tokelau",
"Tonga",
"Trinidad and Tobago",
"Tunisia",
"090_Turkey",
"Turkmenistan",
"Turks and Caicos Islands",
"Tuvalu",
"Uganda",
"380_Ukraine",
"United Arab Emirates",
"United Kingdom",
"United States",
"United States Minor Outlying Islands",
"Uruguay",
"Uzbekistan",
"Vanuatu",
"Venezuela",
"Viet Nam",
"Virgin Islands, British",
"Virgin Islands, US",
"Wallis and Futuna",
"Western Sahara",
"Yemen",
"Zambia",
"Zimbabwe",
    };
        #endregion
        #region Iller
        string[] Iller = {
        "090_ADANA",
    "090_ADIYAMAN",
    "090_AFYONKARAHİSAR",
    "090_AĞRI",
    "090_AMASYA",
    "090_ANKARA",
    "090_ANTALYA",
    "090_ARTVİN",
    "090_AYDIN",
    "090_BALIKESİR",
    "090_BİLECİKK",
    "090_BİNGÖL",
    "090_BİTLİS",
    "090_BOLU",
    "090_BURDUR",
    "090_BURSA",
    "090_ÇANAKKALE",
    "090_ÇANKIRI",
    "090_ÇORUM",
    "090_DENİZLİ",
    "090_DİYARBAKIR",
    "090_EDİRNE",
    "090_ELAZIĞ",
    "090_ERZİNCAN",
    "090_ERZURUM",
    "090_ESKİŞEHİR",
    "090_GAZİANTEP",
    "090_GİRESUN",
    "090_GÜMÜŞHANE",
    "090_HAKKARİ",
    "090_HATAY",
    "090_ISPARTA",
    "090_MERSİN",
    "090_İSTANBUL",
    "090_İZMİR",
    "090_KARS",
    "090_KASTAMONU",
    "090_KAYSERİ",
    "090_KIRKLARELİ",
    "090_KIRŞEHİR",
    "090_KOCAELİ",
    "090_KONYA",
    "090_KÜTAHYA",
    "090_MALATYA",
    "090_MANİSA",
    "090_KAHRAMANMARAŞ",
    "090_MARDİN",
    "090_MUĞLA",
    "090_MUŞ",
    "090_NEVŞEHİR",
    "090_NİĞDE",
    "090_ORDU",
    "090_RİZE",
    "090_SAKARYA",
    "090_SAMSUN",
    "090_SİİRT",
    "090_SİNOP",
    "090_SİVAS",
    "090_TEKİRDAĞ",
    "090_TOKAT",
    "090_TRABZON",
    "090_TUNCELİ",
    "090_ŞANLIURFA",
    "090_UŞAK",
    "090_VAN",
    "090_YOZGAT",
    "090_ZONGULDAK",
    "090_AKSARAY",
    "090_BAYBURT",
    "090_KARAMAN",
    "090_KIRIKKALE",
    "090_BATMAN",
    "090_ŞIRNAK",
    "090_BARTIN",
    "090_ARDAHAN",
    "090_IĞDIR",
    "090_YALOVA",
    "090_KARABüK",
    "090_KİLİS",
    "090_OSMANİYE",
    "090_DÜZCE" ,
     "380_Kiev",
     "380_Harkov",
    "380_Odessa"
        };
        #endregion

        string[] departmanlar = { "Satış", "Muhasebe", "Finans", "Yazılım", "Pazarlama" };
        string[] kanGruplari = { "A+", "A-", "B+", "B-", "0+", "0-", "AB+", "AB-" };

        private void Form1_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        public void FillForm()
        {
            cmbDepartman.FillDataSource(departmanlar);
            cmbKanGrubu.FillDataSource(kanGruplari);
            cmbUlke.FillDataSource(Ulkeler);
        }

        private void cmbUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbUlke.SelectedIndex > 0)
            {
                cmbSehir.Items.Clear();
                string secilenItem = cmbUlke.SelectedItem.ToString();
                if (secilenItem.Contains("_"))
                {
                    string UlkeKod = secilenItem.Substring(0, 3);

                    string[] tempIller = new string[0];
                    for (int i = 0; i < Iller.Length; i++)
                    {
                        string sehir = Iller[i];
                        if (sehir.StartsWith(UlkeKod))
                        {
                            Array.Resize(ref tempIller, tempIller.Length + 1);
                            tempIller[tempIller.Length - 1] = sehir.Substring(4);
                        }
                    }
                    cmbSehir.FillDataSource(tempIller);
                }
            }
        }
    }
}
