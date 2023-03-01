using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using Lab_13;

Car My_Car = new("72AB45","Germany","Toyota");
My_Car.last_tech_osmotr = "11.16.2023";
My_Car.owner = "Makson";

// ------- Бинарная сериализация и десериализация -------
BinaryFormatter binary_formatter = new BinaryFormatter();

using (FileStream FS = new FileStream("Binary_Ser.dat",FileMode.OpenOrCreate))
 {
     binary_formatter.Serialize(FS,My_Car);

     Console.WriteLine("Объект сериализован!");
 }

 using (FileStream FS = new FileStream("Binary_Ser.dat",FileMode.OpenOrCreate))
 {
     Car New_Car = (Car)binary_formatter.Deserialize(FS);

     Console.WriteLine("Объект десириализован!");

     Console.WriteLine($"Старана производитель: {New_Car.origin_country}, Серийный номер: {New_Car.serial_number}, Марка машины: {New_Car.car_name}");
 }

 // ------- XML сериализация и десериализация  -------
 XmlSerializer xml_Formatter = new XmlSerializer(typeof(Car));

 
 using (FileStream FS = new FileStream("XML_Ser.xml",FileMode.OpenOrCreate))
 {
     xml_Formatter.Serialize(FS,My_Car);

     Console.WriteLine("Объект сериализован!");
 }

 using (FileStream FS = new FileStream("XML_Ser.xml",FileMode.OpenOrCreate))
 {
     Car? New_Car = xml_Formatter.Deserialize(FS) as Car;

     Console.WriteLine("Объект десириализован!");

     Console.WriteLine($"Старана производитель: {New_Car.origin_country}, Серийный номер: {New_Car.serial_number}, Марка машины: {New_Car.car_name}");
 }

 // ------- JSON сериализация и десериализация  -------
string fileName = "JSON_Ser.json"; 
string jsonString = JsonSerializer.Serialize(My_Car);
File.WriteAllText(fileName, jsonString);

string jsonString2 = File.ReadAllText(fileName);
Car New_Car2 = JsonSerializer.Deserialize<Car>(jsonString)!;
Console.WriteLine($"Owner: {New_Car2.owner}");
Console.WriteLine($"Last Tech Osmotr: {New_Car2.last_tech_osmotr}");





Car[] Car_Collection = new Car[]
{
    new Car("665SE8","USA","NISAN"),
    new Car("8476YT","Japan","URAL"),
    new Car("253OT1","Belarus","TESLA")
};

XmlSerializer xml_serik = new XmlSerializer(typeof(Car[]));
using (FileStream FS = new FileStream("XML_Collection.xml",FileMode.OpenOrCreate))
{
    xml_serik.Serialize(FS,Car_Collection);
}
using (FileStream FS = new FileStream("XML_Collection.xml", FileMode.OpenOrCreate))
{
    Car[]? newcars = xml_serik.Deserialize(FS) as Car[];
 
    if(newcars != null)
    {
        foreach (Car carchik in newcars)
        {
            Console.WriteLine($"Serial Number: {carchik.serial_number} --- Country: {carchik.origin_country} --- Marka: {carchik.car_name}");
        }
    }
}

XmlDocument My_XML = new XmlDocument();
My_XML.Load("XML_Collection.xml");
XmlElement? Xroot = My_XML.DocumentElement;
XmlNodeList? car_names = Xroot?.SelectNodes("//Car/car_name");
if (car_names is not null)
{
    foreach (XmlNode item in car_names)
    {
        Console.WriteLine(item.InnerText);
    }
}

XmlDocument xDoc = new XmlDocument();
xDoc.Load("XML_Collection.xml");
XmlElement? xRoot = xDoc.DocumentElement;
 
// выбор всех дочерних узлов
XmlNodeList? nodes = xRoot?.SelectNodes("*");
if (nodes is not null)
{
    foreach (XmlNode node in nodes)
        Console.WriteLine(node.OuterXml);
}

XDocument xdoc = new XDocument();
XElement Maksim = new XElement("person");
XAttribute MaksimNameAttr = new XAttribute("name","Maksim");
XElement MaksimCompanyElem = new XElement("company", "Microsoft");
XElement MaksimAgeElem = new XElement("age", 37);
Maksim.Add(MaksimNameAttr);
Maksim.Add(MaksimAgeElem);
Maksim.Add(MaksimCompanyElem);
XElement people = new XElement("people");
people.Add(Maksim);
xdoc.Add(people);
xdoc.Save("Linq_XML.xml");
Console.WriteLine("READY!");

// var Maksim_copy = xdoc.Element("people")?
//                 .Elements("person")
//                 .FirstOrDefault(p => p.Attribute("name")?.Value == "Maksim");

// if (Maksim_copy != null)
// {
//     var new_name = Maksim.Attribute("name");
//     new_name.Value = "Tomas";
// var new_age = Maksim.Element("age");
// if (new_age != null) new_age.Value = "55";
// var new_company = Maksim.Element("company");
// if(new_company is not null) new_company.Value = "Лукойл";
//     xdoc.Save("Linq_XML.xml");
// }

