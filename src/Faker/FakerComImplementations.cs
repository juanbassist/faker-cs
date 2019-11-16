using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Faker.Extensions;

namespace Faker
{
    [Guid("B078F9F4-B3BF-4549-AEDC-F86FE4E342C8"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComName : IFakerComName
    {
        public string First() => Name.First();
        public string FullName() => Name.FullName();
        public string FullName(NameFormats nameformat) => Name.FullName(nameformat);
        public string Last() => Name.Last();
        public string Prefix() => Name.Prefix();
        public string Suffix() => Name.Suffix();
    }

    [Guid("7CA6841B-A8F7-4DC8-BF76-C558CDD1CE84"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComAddress : IFakerComAddress
    {
        public string Country() => Address.Country();
        public string ZipCode() => Address.ZipCode();
        public string UsState() => Address.UsState();
        public string UsStateAbbr() => Address.UsStateAbbr();
        public string CityPrefix() => Address.CityPrefix();
        public string CitySufix() => Address.CitySufix();
        public string City() => Address.City();
        public string StreetSuffix() => Address.StreetSuffix();
        public string StreetName() => Address.StreetName();
        public string StreetAddress() => Address.StreetAddress();
        public string StreetAddress(bool includeSecondary) => Address.StreetAddress(includeSecondary);
        public string SecondaryAddress() => Address.SecondaryAddress();
        public string UkCounty() => Address.UkCounty();
        public string UkCountry() => Address.Country();
        public string UkPostCode() => Address.UkPostCode();
        public LatLng LatLng() => Address.LatLng();
    }

    [Guid("8D0BDC98-D6FC-430E-9F39-F53798ECB728"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComCompany : IFakerComCompany
    {
        public string Name() => Company.Name();
        public string Suffix() => Company.Suffix();
        public string CatchPhrase() => Company.CatchPhrase();
        public string BS() => Company.BS();
    }

    [Guid("C816F6FA-A354-40DE-A93E-AA7122B44F05"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComInternet : IFakerComInternet
    {
        public string Email(string name) => Internet.Email(name);
        public string FreeEmail() => Internet.FreeEmail();
        public string UserName() => Internet.UserName();
        public string UserName(string name) => Internet.UserName(name);
        public string DomainName() => Internet.DomainName();
        public string DomainWord() => Internet.DomainWord();
        public string DomainSuffix() => Internet.DomainSuffix();
        public string IPv4Address() => Internet.IPv4Address();
        public string IPv6Address() => Internet.IPv6Address();
        public string Url() => Internet.Url();
    }

    [Guid("30805754-4648-487B-87C6-385158E9FE6D"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComLorem : IFakerComLorem
    {
        public IEnumerable<string> Words(int count) => Lorem.Words(count);
        public string GetFirstWord() => Lorem.GetFirstWord();
        public string Sentence(int minWordCount) => Lorem.Sentence(minWordCount);
        public string Sentence() => Lorem.Sentence();
        public IEnumerable<string> Sentences(int sentenceCount) => Lorem.Sentences(sentenceCount);
        public string Paragraph(int minSentenceCount) => Lorem.Paragraph(minSentenceCount);
        public string Paragraph() => Lorem.Paragraph();
        public IEnumerable<string> Paragraphs(int paragraphCount) => Lorem.Paragraphs(paragraphCount);
    }

    [Guid("0B7F14D0-861A-41A7-81BD-0EF9D903D575"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComPhone : IFakerComPhone
    {
        public string Number() => Phone.Number();
        public string Number(string pattern) => Phone.Number(pattern);
    }
    
    [Guid("429BABE3-4B43-410E-B1D8-92EB787AEF2E"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComRandomNumber : IFakerComRandomNumber {
        public int Next() => RandomNumber.Next();
        public int Next(int max) => RandomNumber.Next(max);
        public int Next(int min, int max) => RandomNumber.Next(min, max);
    }
    
    [Guid("2A7F2FD1-1B81-4268-9FC1-FEC43F364425"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComArrayExtensions : IFakerComArrayExtensions
    {
        public string Random(string[] list) => ArrayExtensions.Random(list);
        public string Random(IEnumerable<Func<string>> list) => ArrayExtensions.Random(list);
        public string[] Random(IEnumerable<Func<string[]>> list) => ArrayExtensions.Random(list);
    }
    
    [Guid("0345AB49-6BE8-42A9-93F6-DBAC960E3B41"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComEnumerableExtensions : IFakerComEnumerableExtensions
    {
        public IEnumerable<T> Times<T>(int count, Func<int, T> func) => EnumerableExtensions.Times<T>(count, func);
    }
    
    [Guid("DE17630A-8427-476E-8367-7BFE01BB066D"),
 ClassInterface(ClassInterfaceType.None)]
    public class FakerComStringExtensions : IFakerComStringExtensions
    {
        public string Numerify(string s) => StringExtensions.Numerify(s);
        public string Letterify(string s) => StringExtensions.Letterify(s);
        public string AlphanumericOnly(string s) => StringExtensions.AlphanumericOnly(s);
        public string Capitalise(string s) => StringExtensions.Capitalise(s);
    }

}
