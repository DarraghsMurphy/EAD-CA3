namespace PredictName
{
    public class Country
    {
        private string? country_id;
        private float probability;
        public string? Country_Id
        {
            get
            {
                return GetCountry(country_id);
            }
            set
            {
                country_id = value;
            }
 
        }
        public float Probability 
        {
            get
            {
                return ConvertToPercentage(probability);
            }
            set
            {
                probability = value;
            }
        }


        public float ConvertToPercentage(float number)
        {
            float percentage = number * 100;
            return (float)Math.Round(percentage, 2);
        }

        private List<CountryCodes> countries = new List<CountryCodes>() {
            new CountryCodes("FR","France"),
            new CountryCodes("IT","Italy"),
            new CountryCodes("ES","Spain"),
            new CountryCodes("TR","Turkey"),
            new CountryCodes("DE","Germany"),
            new CountryCodes("PL","Poland"),
            new CountryCodes("GB","United Kingdom"),
            new CountryCodes("RU","Russia"),
            new CountryCodes("CZ","Czech Republic"),
            new CountryCodes("PT","Portugal"),
            new CountryCodes("NL","Netherlands"),
            new CountryCodes("BE","Belgium"),
            new CountryCodes("MA","Morocco"),
            new CountryCodes("PH","Philippines"),
            new CountryCodes("US","United States"),
            new CountryCodes("RO","Romania"),
            new CountryCodes("DZ","Algeria"),
            new CountryCodes("NG","Nigeria"),
            new CountryCodes("CH","Switzerland"),
            new CountryCodes("HU","Hungary"),
            new CountryCodes("TH","Thailand"),
            new CountryCodes("SE","Sweden"),
            new CountryCodes("ID","Indonesia"),
            new CountryCodes("IN","India"),
            new CountryCodes("UA","Ukraine"),
            new CountryCodes("MY","Malaysia"),
            new CountryCodes("TN","Tunisia"),
            new CountryCodes("SA","Saudi Arabia"),
            new CountryCodes("GR","Greece"),
            new CountryCodes("CI","Ivory Coast"),
            new CountryCodes("AT","Austria"),
            new CountryCodes("ZA","South Africa"),
            new CountryCodes("KR","South Korea"),
            new CountryCodes("CN","China"),
            new CountryCodes("RS","Serbia"),
            new CountryCodes("JP","Japan"),
            new CountryCodes("EG","Egypt"),
            new CountryCodes("SK","Slovakia"),
            new CountryCodes("SN","Senegal"),
            new CountryCodes("DK","Denmark"),
            new CountryCodes("FI","Finland"),
            new CountryCodes("CM","Cameroon"),
            new CountryCodes("IR","Iran"),
            new CountryCodes("AR","Argentina"),
            new CountryCodes("CA","Canada"),
            new CountryCodes("SG","Singapore"),
            new CountryCodes("PK","Pakistan"),
            new CountryCodes("GH","Ghana"),
            new CountryCodes("LB","Lebanon"),
            new CountryCodes("IE","Ireland"),
            new CountryCodes("AO","Angola"),
            new CountryCodes("NO","Norway"),
            new CountryCodes("BY","Belarus"),
            new CountryCodes("BR","Brazil"),
            new CountryCodes("MX","Mexico"),
            new CountryCodes("CO","Colombia"),
            new CountryCodes("KE","Kenya"),
            new CountryCodes("CL","Chile"),
            new CountryCodes("KW","Kuwait"),
            new CountryCodes("AL","Albania"),
            new CountryCodes("VE","Venezuela"),
            new CountryCodes("RE","Reunion"),
            new CountryCodes("BA","Bosnia and Herzegovina"),
            new CountryCodes("IL","Israel"),
            new CountryCodes("TW","Taiwan"),
            new CountryCodes("SI","Slovenia"),
            new CountryCodes("KZ","Kazakhstan"),
            new CountryCodes("PE","Peru"),
            new CountryCodes("AZ","Azerbaijan"),
            new CountryCodes("AE","United Arab Emirates"),
            new CountryCodes("CY","Cyprus"),
            new CountryCodes("LT","Lithuania"),
            new CountryCodes("DO","Dominican Republic"),
            new CountryCodes("JO","Jordan"),
            new CountryCodes("MD","Moldova"),
            new CountryCodes("BJ","Benin"),
            new CountryCodes("BG","Bulgaria"),
            new CountryCodes("CD","Democratic Republic of the Congo"),
            new CountryCodes("HR","Croatia"),
            new CountryCodes("LV","Latvia"),
            new CountryCodes("HK","Hong Kong"),
            new CountryCodes("MZ","Mozambique"),
            new CountryCodes("AU","Australia"),
            new CountryCodes("LU","Luxembourg"),
            new CountryCodes("UG","Uganda"),
            new CountryCodes("ML","Mali"),
            new CountryCodes("BF","Burkina Faso"),
            new CountryCodes("MU","Mauritius"),
            new CountryCodes("OM","Oman"),
            new CountryCodes("TG","Togo"),
            new CountryCodes("QA","Qatar"),
            new CountryCodes("MK","Macedonia"),
            new CountryCodes("MG","Madagascar"),
            new CountryCodes("VN","Vietnam"),
            new CountryCodes("GA","Gabon"),
            new CountryCodes("EE","Estonia"),
            new CountryCodes("IQ","Iraq"),
            new CountryCodes("MT","Malta"),
            new CountryCodes("BH","Bahrain"),
            new CountryCodes("TZ","Tanzania"),
            new CountryCodes("EC","Ecuador"),
            new CountryCodes("GE","Georgia"),
            new CountryCodes("AM","Armenia"),
            new CountryCodes("SD","Sudan"),
            new CountryCodes("ET","Ethiopia"),
            new CountryCodes("MM","Myanmar"),
            new CountryCodes("ME","Montenegro"),
            new CountryCodes("SY","Syria"),
            new CountryCodes("UZ","Uzbekistan"),
            new CountryCodes("ZW","Zimbabwe"),
            new CountryCodes("DJ","Djibouti"),
            new CountryCodes("LK","Sri Lanka"),
            new CountryCodes("BD","Bangladesh"),
            new CountryCodes("SH","Saint Helena"),
            new CountryCodes("BW","Botswana"),
            new CountryCodes("CV","Cape Verde"),
            new CountryCodes("BO","Bolivia"),
            new CountryCodes("YE","Yemen"),
            new CountryCodes("RW","Rwanda"),
            new CountryCodes("IS","Iceland"),
            new CountryCodes("LY","Libya"),
            new CountryCodes("NE","Niger"),
            new CountryCodes("AD","Andorra"),
            new CountryCodes("GM","Gambia"),
            new CountryCodes("CG","Republic of the Congo"),
            new CountryCodes("ZM","Zambia"),
            new CountryCodes("AF","Afghanistan"),
            new CountryCodes("NA","Namibia"),
            new CountryCodes("MR","Mauritania"),
            new CountryCodes("UY","Uruguay"),
            new CountryCodes("CR","Costa Rica"),
            new CountryCodes("KG","Kyrgyzstan"),
            new CountryCodes("PA","Panama"),
            new CountryCodes("NP","Nepal"),
            new CountryCodes("GN","Guinea"),
            new CountryCodes("GP","Guadeloupe"),
            new CountryCodes("GQ","Equatorial Guinea"),
            new CountryCodes("MQ","Martinique"),
            new CountryCodes("SC","Seychelles"),
            new CountryCodes("CU","Cuba"),
            new CountryCodes("NZ","New Zealand"),
            new CountryCodes("GT","Guatemala"),
            new CountryCodes("MC","Monaco"),
            new CountryCodes("MV","Maldives"),
            new CountryCodes("MW","Malawi"),
            new CountryCodes("SV","El Salvador"),
            new CountryCodes("GF","French Guiana"),
            new CountryCodes("SL","Sierra Leone"),
            new CountryCodes("LR","Liberia"),
            new CountryCodes("NI","Nicaragua"),
            new CountryCodes("KH","Cambodia"),
            new CountryCodes("TJ","Tajikistan"),
            new CountryCodes("PR","Puerto Rico"),
            new CountryCodes("BI","Burundi"),
            new CountryCodes("PY","Paraguay"),
            new CountryCodes("KM","Comoros"),
            new CountryCodes("LS","Lesotho"),
            new CountryCodes("SO","Somalia"),
            new CountryCodes("HN","Honduras"),
            new CountryCodes("TD","Chad"),
            new CountryCodes("GI","Gibraltar"),
            new CountryCodes("BN","Brunei"),
            new CountryCodes("SM","San Marino"),
            new CountryCodes("JE","Jersey"),
            new CountryCodes("SZ","Swaziland"),
            new CountryCodes("TM","Turkmenistan"),
            new CountryCodes("NC","New Caledonia"),
            new CountryCodes("MN","Mongolia"),
            new CountryCodes("LI","Liechtenstein"),
            new CountryCodes("GL","Greenland"),
            new CountryCodes("BT","Bhutan"),
            new CountryCodes("PF","French Polynesia"),
            new CountryCodes("ST","Sao Tome and Principe"),
            new CountryCodes("YT","Mayotte"),
            new CountryCodes("FO","Faroe Islands"),
            new CountryCodes("JM","Jamaica"),
            new CountryCodes("HT","Haiti"),
            new CountryCodes("BS","Bahamas"),
            new CountryCodes("GW","Guinea-Bissau"),
            new CountryCodes("FJ","Fiji"),
            new CountryCodes("GG","Guernsey"),
            new CountryCodes("LA","Laos"),
            new CountryCodes("TL","East Timor"),
            new CountryCodes("TT","Trinidad and Tobago"),
            new CountryCodes("AG","Antigua and Barbuda"),
            new CountryCodes("EH","Western Sahara"),
            new CountryCodes("CF","Central African Republic"),
            new CountryCodes("PW","Palau"),
            new CountryCodes("IM","Isle of Man"),
            new CountryCodes("AW","Aruba"),
            new CountryCodes("BZ","Belize"),
            new CountryCodes("AS","American Samoa"),
            new CountryCodes("AI","Anguilla"),
            new CountryCodes("MP","Northern Mariana Islands"),
            new CountryCodes("BM","Bermuda"),
            new CountryCodes("ER","Eritrea"),
            new CountryCodes("SR","Suriname"),
            new CountryCodes("VG","British Virgin Islands"),
            new CountryCodes("VI","U.S. Virgin Islands"),
            new CountryCodes("GY","Guyana"),
            new CountryCodes("BB","Barbados"),
            new CountryCodes("MH","Marshall Islands"),
            new CountryCodes("MO","Macao"),
            new CountryCodes("PG","Papua New Guinea"),
            new CountryCodes("KY","Cayman Islands"),
            new CountryCodes("KI","Kiribati"),
            new CountryCodes("AN","Netherlands Antilles"),
            new CountryCodes("CK","Cook Islands"),
            new CountryCodes("GU","Guam"),
            new CountryCodes("WF","Wallis and Futuna"),
            new CountryCodes("PS","Palestine"),
            new CountryCodes("TC","Turks and Caicos Islands"),
            new CountryCodes("VU","Vanuatu"),
            new CountryCodes("LC","Saint Lucia"),
            new CountryCodes("TO","Tonga"),
            new CountryCodes("CC","Cocos Islands"),
            new CountryCodes("WS","Samoa"),
            new CountryCodes("GD","Grenada"),
            new CountryCodes("VA","Vatican"),
            new CountryCodes("IO","British Indian Ocean Territory"),
            new CountryCodes("FM","Micronesia"),
            new CountryCodes("NU","Niue"),
            new CountryCodes("BL","Saint Barthelemy"),
            new CountryCodes("KN","Saint Kitts and Nevis"),
            new CountryCodes("PM","Saint Pierre and Miquelon"),
            new CountryCodes("FK","Falkland Islands"),
            new CountryCodes("AQ","Antarctica"),
            new CountryCodes("PN","Pitcairn"),
            new CountryCodes("MF","Saint Martin"),
            new CountryCodes("TV","Tuvalu"),
            new CountryCodes("VC","Saint Vincent and the Grenadines"),
            new CountryCodes("DM","Dominica"),
            new CountryCodes("SB","Solomon Islands"),
            new CountryCodes("TK","Tokelau"),
            new CountryCodes("NF","Norfolk Island"),
            new CountryCodes("CX","Christmas Island"),
            new CountryCodes("NR","Nauru"),
            new CountryCodes("SJ","Svalbard and Jan Mayen"),
            new CountryCodes("MS","Montserrat"),
            new CountryCodes("KP","North Korea"),
            new CountryCodes("GS","South Georgia And Sandwich Isl."),
            new CountryCodes("BV","Bouvet Island")
        };


        public string GetCountry(string id)
        {

            if (countries.FirstOrDefault(c => c.Id.ToUpper() == id.ToUpper()) != null)
            {
                return countries.Where(c => c.Id == id).FirstOrDefault().Country;
            }
            else
            {
                throw new ArgumentException("Could not find matching Country to Country ID");
            }
        }

        public override string ToString()
        {
            return $"{GetCountry(Country_Id)} {ConvertToPercentage(Probability)} %";
        }
    }

}
