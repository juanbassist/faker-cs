using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Faker
{
    [Guid("02061A6D-917F-4C03-88EF-869CD2B190CC"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComName {
        [DispId(1)] string FullName();
        [DispId(2)] string FullName(NameFormats format);
        [DispId(3)] string First();
        [DispId(4)] string Last();
        [DispId(5)] string Prefix();
        [DispId(6)] string Suffix();
    }

    [Guid("A825B80A-B574-4067-9D41-19F489443DAA"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComAddress {
        [DispId(1)] string Country();
        [DispId(2)] string ZipCode();
        [DispId(3)] string UsState();
        [DispId(4)] string UsStateAbbr();
        [DispId(5)] string CityPrefix();
        [DispId(6)] string CitySufix();
        [DispId(7)] string City();
        [DispId(8)] string StreetSuffix();
        [DispId(9)] string StreetName();
        [DispId(10)] string StreetAddress();
        [DispId(11)] string StreetAddress(bool includeSecondary);
        [DispId(12)] string SecondaryAddress();
        [DispId(13)] string UkCounty();
        [DispId(14)] string UkCountry();
        [DispId(15)] string UkPostCode();
        [DispId(16)] LatLng LatLng();
    }

    [Guid("66783923-06C9-4806-9ECF-328C73E3A647"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComCompany {
        [DispId(1)] string Name();
        [DispId(2)] string Suffix();
        [DispId(3)] string CatchPhrase();
        [DispId(4)] string BS();
    }

    [Guid("7179B57E-E1A4-48F6-87D1-8CBD89914D74"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComInternet {
        [DispId(1)] string Email(string name);
        [DispId(2)] string FreeEmail();
        [DispId(3)] string UserName();
        [DispId(4)] string UserName(string name);
        [DispId(5)] string DomainName();
        [DispId(6)] string DomainWord();
        [DispId(7)] string DomainSuffix();
        [DispId(8)] string IPv4Address();
        [DispId(9)] string IPv6Address();
        [DispId(10)] string Url();
    }

    [Guid("A0B9F0D5-38F9-4184-A35D-A02213201821"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComLorem {
        [DispId(1)] IEnumerable<string> Words(int count);
        [DispId(2)] string GetFirstWord();
        [DispId(3)] string Sentence(int minWordCount);
        [DispId(4)] string Sentence();
        [DispId(5)] IEnumerable<string> Sentences(int sentenceCount);
        [DispId(6)] string Paragraph(int minSentenceCount);
        [DispId(7)] string Paragraph();
        [DispId(8)] IEnumerable<string> Paragraphs(int paragraphCount);
    }

    [Guid("25565CDD-5CE6-43CD-8C92-19E6D13B0524"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComPhone {
        [DispId(1)] string Number();
        [DispId(2)] string Number(string pattern);
    }

    [Guid("624ED2F4-C537-416C-8D5D-A91A442878D2"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComRandomNumber {
        [DispId(1)] int Next();
        [DispId(2)] int Next(int max);
        [DispId(3)] int Next(int min, int max);
    }

    [Guid("BAAF21EF-B852-4971-9081-35B12E2CDD22"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComArrayExtensions {
        [DispId(1)] string Random(string[] list);
        [DispId(2)] string Random(IEnumerable<Func<string>> list);
        [DispId(3)] string[] Random(IEnumerable<Func<string[]>> list);
    }

    [Guid("925A9A84-7FA8-4C22-A27D-28DE42DFAB5B"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComEnumerableExtensions {
        [DispId(1)] IEnumerable<T> Times<T>(int count, Func<int, T> func);
    }

    [Guid("11AF1F7C-576F-4441-96FA-45B4C5C7ED53"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IFakerComStringExtensions {
        [DispId(1)] string Numerify(string s);
        [DispId(2)] string Letterify(string s);
        [DispId(3)] string AlphanumericOnly(string s);
        [DispId(4)] string Capitalise(string s);
    }
}
