### Support for COM interop.

- Compile for COM Interop. (Example x64)
![compile](/docs/app-properties.png)

- Register COM Component (Example x64)
`C:\Windows\Microsoft.NET\Framework64\v4.0.30319>RegAsm.exe "A:\WKS-VisualStudio\faker-cs\src\Faker.NET47\bin\x64\Release\Faker.NET47.dll"`

- Test COM Component (Example ISE Powershell)
![test-com](/docs/test-com-powershell.png)

Faker
=====

C# port of the Ruby Faker gem (http://faker.rubyforge.org/) and is used to easily generate fake data: 
names, addresses, phone numbers, etc..

Available as a NuGet package (https://nuget.org/packages/Faker.Net).

Get the code via git:

    git clone git://github.com/slashdotdash/faker-cs.git

Supported versions:

	.NET framework 3.5 SP1,
	.NET framework 4.0,
	.NET framework 4.5,
	.NET framework 4.6,
	.NET framework 4.7,
	.NET Standard 2.0

No longer supported in nuGet package (1.1 going forward), code still exists in repo.

	Silverlight 3.0,
	Silverlight 4.0,
	Silverlight 5.0,
	Windows Phone 7,
	Windows Phone 7.1
