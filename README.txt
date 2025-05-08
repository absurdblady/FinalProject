CSC 260 – Object-Oriented Design | Final Project


-------------------------------------------------------------------------------------------------------------------------


Bagaincha is a desktop application designed to simulate a community-driven platform that supports rural development. It provides different user roles; farmers, artisans, and admins with tools to manage agricultural data, track local products, and promote sustainable practices.

This system is inspired by real challenges in underrepresented regions, where technology can help ensure fair trade, collective pricing, and cultural preservation.

Bagaincha aims to blend tradition with digital tools. It envisions a platform where:
Farmers can submit crop data, calculate profit, and list produce.
Artisans can share crafts and cultural content.
Admins can allocate resources and oversee system activity.

Communities can collectively benefit from localized data, pricing fairness, and promotion of heritage and homestay tourism.

This version focuses on a technical simulation that highlights Object-Oriented Design in action.


-------------------------------------------------------------------------------------------------------------------------


Role-Based Login
Users can log in as admin, farmer, or artisan.
Based on the role, the user is redirected to the correct dashboard.
Polymorphism is used to handle redirection through the abstract User class.

Farmer Dashboard
Add products (name and price).
View added product list.
Calculate estimated sales profit.
Access Record, Tax, and Employee modules through buttons.

Artisan Dashboard
Placeholder for future implementation: upload tutorials or promote cultural products.
Shares product-handling logic via IProductHandler interface.

Admin Dashboard
Basic layout showing potential to manage pricing and resource distribution.


-------------------------------------------------------------------------------------------------------------------------


Object-Oriented Design Summary
Abstraction: User is an abstract class with a polymorphic method OpenDashboard().
Inheritance: AdminUser, FarmerUser, and ArtisanUser inherit from User.
Polymorphism: Login flow depends on User type and calls OpenDashboard() accordingly.
Encapsulation: Each form (Farmer, Admin, etc.) is modular and manages its own UI and logic.
Interface Implementation: IProductHandler allows shared product features across different user roles.


-------------------------------------------------------------------------------------------------------------------------


Technologies Used
C# with Windows Forms (.NET Framework)
Visual Studio 2022
Object-Oriented Design principles
GitHub for version control


-------------------------------------------------------------------------------------------------------------------------


How to Use the App
Clone the repository or open the solution in Visual Studio.
Press F5 or click “Start” to run.
Use one of the following credentials:
Username: farmer, Password: farmer
Username: artisan, Password: artisan
Username: admin, Password: admin
Try adding products (in the Farmer dashboard) and viewing them in a list.


-------------------------------------------------------------------------------------------------------------------------


Pawan Chaudhary
Dakota State University
CSC 260 - Spring 2025
Instructor: Jason Jenkins

