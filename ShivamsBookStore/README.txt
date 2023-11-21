Name: Shivam Shivam
ID  : 0829889
Project Name : ShivamsBookStore
Date: 10/30/2023

PART 1

Start Time 0841

0841 > Created the project and git hub repository. 

0841 > Created the README.txt file.

0843 > removed options => options.SignIn.RequireConfirmedAccount = true from startup.cs.

0846 > Added Breakpoints in HomeController.cs file in Controller folder at line 22 and 27 and tested the website, the breakpoints are working.

0848 > Downloaded theme Bootstrap.cs and replaed with the the Current bootstrap file in wwwroot > lib > bootstrap > dist > css.

0851 > replaced the site.css file in the wwwroot > css.

0852 > renamed the bootstrap.min.css to bootstrap.css in Shared > _Layout.cshtml.

0854 > changed nav class from navbar-light to navbar-dark and bg-white to bg-primary.

0855 > removed text-dark from _Layout.cshtml in Shared folder.

0857 > Added additional properties to the footer class.

0859 > removed reference to text-dark in _LoginPartial.cshtml file.

0902 > Added additional stylesheet and js script from the css_js.txt file in the _Layout.cshtml file.

0905 > Added a dropdown  in View/Shared/_Layout.cshtml file.

0907 > Changed DropDown to Content Management and ran the website to see the changes.

0947 > Created 3 new projects in the application.

0950 > Moved data folder into .DataAccess and deleted the original.

0950 > Installed Core.Relational and Core.sqlserver packages.

0959 > deletd the migration folder.

1002 > Installed Identity.EntityFrameWorkCore.

1003 > Changed ShivamsBookStore.Data to ShivamsBookStore.DataAccess.Data.

1004 > Deleted Class1.cs file from all projects.

1006 > Built the project.

1007 > Moved Models folder to ShivamsBooks.Models and deleted the original.

1010 > Added Project referece - .DataAccess and .Models.

1011 > Renamed Models folder to ViewModels.

1012 > Changed the ErrorViewModels.cs Namespace .Models.ViewModels.

1014 > built the project.

1027 > Modified Startup.cs service 'AddContext' with the using statement.

1030 > ran the site to view error and removed the using statement.

1032 > corrected default ErrorViewModel to the new .Models.ViewModels.ErrorViewModel.

1036 > there was an error on homecontroller and its fixed with using statement.

1043 > Created SD.cs class in utility project.

1045 > modified the properties of the class.

1046 > Added Project reference to main project.

1048 > in DataAccess project added project reference to Models and utility.

1050 > Added customers area to Areas.

1055 > changed the routes in Startup.cs like the one in the ScaffoldingReadMe.txt.

1058 > Moved HomeController to the Area> Customer > Controller folder and deleted Data and Models.

1101 > Edited the homecontroller.cs to explicity define that the controller is in the customer Area.

1104 > Moved View > Home and modify the HomeController namespace.

1125 > there was an error on the site (index not found) after seraching alot i realized i named "customer" folder as "customers" with a "s" so i removed and its working now.

1128 > copied _ViewImport and _ViewStart to Customer Area.

1131 > modified the _ViewStart.cshtml to refelect the new path.

1134 > Added a new Admin area and added a proper view files and deleted the data and Models folder.

1136 > Deleted the controller folder.

PART 2 

Date: 11/11/2023

0224 > Modified the database name and saved. 

0229 > using NuGet Package Manager Console and added the migration.but the traget project doesnt match the migrations assembly.

0232 > changed to the correct project and added migration again.

0233 > Migration Name : 20231112021957_AddCategoryToDb.cs.

0233 > tried to update database but failed.

0302 > Used the quick fix(That yellow ligh bulb thingy) and install the framework the error is fixed and the databse is updated.

0311 > added a new class file in .Models and added a new table to the DB.

0322 > added using console add-migration AddCategoryToDb.

0323 > updated database.

0408 > updated ApplicationDbContext.cs but the "Cateroy shows error".

0412 > fixed it by 'using' statement.

0416 > updated the database.

0840 > still having probelms with creating Category table.

0920 > its fixed now had to delete the existing migration folder and add it again, now its working.

date : 11/13/2023

0900 > added a folder name Repository in .DataAccess project and an another forlder IRepository inside the Repository folder. 

0904 > added <Folder Include="Data\" /> in .dataAccess.csproj.

0908 > added a new item of type interface to the folder and named it IRepository.cs.

0921 > modified the IRepository.cs so it can be used on the Category class to do all the CRUD operations.

0925 > added Repositoy.cs class in Repository folder.

0928 > included the using statement and fixed the error with Implement interface.

0937 > modified the code to create the constructor and dependency injection (DI).

0946 > created individual repos for category and all potential models to be added in the future.

1002 > modified CategoryRepository.

1006 > modified ICategoryRepository.

1013 > revied and mofied the error in CategoryRepository.cs 

1031 > added a new interface in the Irepository folder ISP_CALL.cs and extended IDisposable and installed nuget package for dapper.

1039 > and implement with a new class in the repository folder.

1047 > added a new class SP_Call in the repository folder, and implemented the new ISP_Call interface.

1052 > added additional using statement.

1135 > added conenction to the database, upadted the implemanttaiton of the ISP_Call interface.

1141 > Added a new interface IUnitOfWork ot IRepository folder	and updated the code.

1147 > modified the code.

Date : 11/14/2023

0949 > added controller folder in Areas/Admin and added empty mvc controller. 

1005 > modified the code to use the IUnitofWork from .DataAccess.

1054 > Added a new folder category in Areas/View.

1118 > Added empty razor into category and modified it.

1147 > added Category to dropdown. 

1208 > added js file and icons.

1224 > making the delete and edit button functional by adding code in it. 

1245 > modified the upsert list.

0141 > modified category controller.cs

0152 > modified Upsert.html.

11/15/2023

1051 > fixed errors (typos and missing code in CategoryController.cs).

PART 3

Date: 11/21/2023

0110 > Added CoverType.cs in models and modified it. 

0143 > Added CoverTypeRepository.cs class, ICoverTypeRepository.cs. added both of them to UnitOfWork and IUnitOfWork and Created Migration and updated db.

0204 > Added CoverType to NavBar, Added CoverTypeController, CoverType Index,Upsert.

0217 > Added CoverType.js and Modified.

0218 > Lauched the site and its working.

0227 > Added Product.cs in Models.

0236 > Added code to build the blueprint of this class and making sure it's "public" and that any errors are resolved.

0242 > Added reference to the new Products to ApplicationDbContext.cs file.

0245 > Added product Migration and updated the database.

0245 > Product Migration Name:  20231121074511_addProductToDb .

0254 > updated the product class so the Title, ISBN and Author are Required and created a new migration addValidationToProduct and updated the database.

0445 > Added IProductRepository,ProductRepository, and in unitofwork and Iunitofwork too, also added product controller,js,index View,Upsert.

0502 > Fixed Typos.

0508 > added IWebHostEnvironment call and its using statement to the Microsoft.AspNetCore.Hosting.

0512 > Added ProductVM in the Models.

0523 > modified ProductVM class and installed Microsoft.AspNetCore.Hosting package.

0541 > modified ProductController.

0552 > modified ProductController and Product.js.ran the application and its working.