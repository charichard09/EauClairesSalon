# _Eau Claire's Salon_

#### By _**Richard Cha**_

#### _This web app adds stylists and their clients to a database._

## Technologies Used

* _C#_
* _.Net 6_
* _ASP.NET Core 6 MVC_
* _Visual Studio Code 2019_
* _MySql_
* _MySql Workbench_
* _Entity Framework Core 6_
* _Pomelo Entity Framework Core 6 MySql_

## Description

_This web application adds hair stylist employees and their specialties to a database through a form. It then allows adding clients through a form to each stylist and saving the information to a database. By clicking on the Stylists or Clients links on the header, a user can view all added Stylists and Clients. A user can also search for a stylist through the search bar on the home page._

## Setup/Installation Requirements

* _Install .Net 6 SDK:_
* [OS X and Windows Instructions](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
* _Setup MySql Workbench:_
* [OS X and Windows Instructions](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* _Clone this repo to a local directory_
* _After following the MySqlWorkbench installation instructions, open MySql Workbench and select the Local 3306 server. Then select the "Administration" tab and click on "Data Import/Restore"_
* _In Import Options select "Import from Self-Contained File" and click the "..." button to navigate to the file "richard_cha.sql" in the top level of this repo. Click "Start Import"_
* _Confirm the import was successful by clicking on the "Schemas" tab and seeing the richard_cha schema listed._ 
* _Navigate to the local directory (YourPath/HairSalon.Solution) and create a new file "appsettings.json" 
* _Open this file with Visual Studio Code 2019 and add:
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
} 
```
replace [YOUR-USERNAME-HERE] and [YOUR-PASSWORD-HERE] with the your own user and password values._

* _Using Terminal on OS X or PowerShell on Windows navigate to the top directory that this repo was cloned to (YourPath/HairSalon.Solution) and run terminal commands:_ 
* _$ dotnet restore ./HairSalon.Tests_
* _Then run the program with command :_
* _$ dotnet run --project HairSalon_

## Known Bugs

* _None_

## License

_If you have any issues or have questions, ideas or concerns please contact me at [charichard09@gmail.com](mailto:charichard09@gmail.com)_

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _12-23-22_ _Richard Cha_