import json
import xml.etree.ElementTree as ET

class Person:
    def __init__(self, personName, salary, hireDate):
        self.personName = personName
        self.salary = {"monthly": salary}
        self.hireDate = hireDate

# step 1, XML file reading
print("Starting to read the XML file.")
filename = "Salaries.xml"
puu = ET.parse(filename)
print("XML file has been read.")

# step 2, USD currency exchange rate reading
usdkurssi = 1.00
valuuttaxml = ET.parse("Currency rates.xml")
valuuttarootElem = valuuttaxml.getroot()
for valuutta in valuuttarootElem:
    if str(valuutta.tag) == "{http://www.ecb.int/vocabulary/2002-08-01/eurofxref}Cube":
        for lapsi in valuutta:
            for lapsi2 in lapsi:
                valuuttanimi = lapsi2.attrib["currency"]
                kurssi = lapsi2.attrib["rate"]
                print(valuuttanimi + ": " + kurssi)
                if valuuttanimi == "USD":
                    usdkurssi = float(kurssi)
                    break

print("USD currency rate is: " + str(usdkurssi))

# step 3, data conversion
rootElem = puu.getroot()
personList = []
for palkka in rootElem.findall('./palkka'):

    kkpalkka = ""
    nimi = ""
    työsuhdealkoi = ""

    for lapsi in palkka:
        if lapsi.tag == "kuukausittain":
            arvo = int(lapsi.text) * usdkurssi
            kkpalkka = str(arvo)
        elif lapsi.tag == "nimi":
            nimi = lapsi.text
        elif lapsi.tag == "työsuhdealkoi":
            työsuhdealkoi = lapsi.text
        # print(lapsi.tag + ": " + lapsi.text)

    onePerson = Person(nimi, kkpalkka, työsuhdealkoi)
    personList.append(onePerson.__dict__)
    # print(henkilö.__dict__)

# vaihe 4, JSON-tiedoston kirjoitus
print("--------------")
data = json.dumps(personList)
print(data)
