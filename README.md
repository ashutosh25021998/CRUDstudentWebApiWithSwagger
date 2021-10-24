# CRUDstudentWebApiWithSwagger
 Here the CRUD operations done by the webapis
 
#Steps to run the program
Create the table in the SqlServerDatabase by running the "StudentTableCreationQuery.sql" file

Change the servername by changing the connectionstring as the valid servername which is present in the appsettings.json file.

e.g-

  "ConnectionStrings": {
    "DefaultConnection": "Server=YourServerName;Database=Student;Trusted_Connection=true;MultipleActiveResultSets=true"
  },
  
  Then run the http://localhost:63236/swagger/index.html for Testing
