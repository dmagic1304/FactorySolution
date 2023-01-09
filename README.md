# _Eau Claire's Salon_

#### By _**Dominik Magic**_

#### _A web application managing stylists and related clients._<p>&nbsp;</p>  

## Technologies Used

- HTML
- Bootstrap
- C#
- .NET 5.0
- ASP.Net
- Razor
- MySQL
- MySQL Workbench
- EF Core

## Description

_This web application displays the use of MySQL databases with EF Core and Asp Net Core MVC in combination with C# in order to create web aplication. The application offers the user to create new stylists and clients belonging to specific stylists. User can also see a full list of stylists or clients. If there are not stylists or clients created, the list will give a warning and display links for creation. For client creation, the application will recognize if the "Create client" link is selected from within a specific stylist, in which case the new clien will automatically be added to that stylist. In case the creation of the client is initiated from outside, the form will offer a dropdown menu with existing stylists to attach the client to._

## Setup/Installation Requirements

* _Clone [this](https://github.com/dmagic1304/Hair-Salon) repositiory to your desktop_
* _Import the database located at ~Desktop/HairSalon.Solution/dominik_magic.sql using MySQL Workbench
* _Using your terminal, navigate to the cloned project folder located on your desktop_
* _Once inside of the root folder, first create .gitignore file with "touch .gitignore" command and then use "echo "*/obj/ */bin/ */appsettings.json" > .gitignore" command to ignore necessary folders/files_
* _Now navigate to HairSalon folder with "cd HairSalon" and then create appsettings.json file with "touch appsettings.json" command. Use the following command to fill the file with necessary data (make sure to ender your personal MySQL password instead of [YOURPASSWORD]):
```
echo '{
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=dominik_magic;uid=root;pwd=[YOURPASSWORD];"
    }
  }' > appsettings.json
```  

* _To run the application, make sure you are in  "root/HairSalon" folder using your terminal and once there, run "dotnet run" command in the terminal. Once you see in your terminal that the server is running, go to the following URL using your internet browser http://localhost:5000_


## Known Bugs

* _No known bugs at this time_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) _2022_ _Dominik Magic_

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