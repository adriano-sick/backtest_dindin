<h1>C# .net EF6 REST DinDin API</h1>

This is a REST .net API system to manage a MS SQL Server database.</br>
Developed as final project of Anima/Gama trainning</br>
The complete project consists in a SQL Server, controlled by this C# .net API,</br>
and consumed by a vue frontend webapp.</br>

Postman documentation: https://documenter.getpostman.com/view/9590967/UV5WCxDu </br>

</br>In this API project we did:

* MS SQL Server based database
* Code First: EF migration used to create database
* Data model creation to DB entity mapping
* REST Architeture standarts used on each operation implemented.
* Unity tests to validate utilities functionalities
* Cloud database implementation.
* Cloud system implemetation.

Requirements and packages:

* .net 5.0.
* NuGet Package Manager.
* Microsoft.EntityFrameworkCore.Design 5.0.10.
* Microsoft.EntityFrameworkCore.inMemory 5.0.10.
* Microsoft.EntityFrameworkCore.SqlServer 5.0.10.
* Microsoft.EntityFrameworkCore.Tools 5.0.10.
* Microsoft.VisualStudio.Web.CodeGenerator.Design 5.0.2

***
<br>

* Endpoints: 
  * Images table:
	* GetById: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Images/{id}
	* Post: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Images
	* Put: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Images
	* Delete: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Images/{id}?confirm=Yes
  
  * Teacher table:
	* Get: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Teachers/
	* GetById: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Teachers/{id}
	* Post: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Teachers
	* Put: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Teachers
	* Delete: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Teachers/{id}?confirm=Yes

  *Courses table:
	* Get: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Courses/
	* GetById: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Courses/{id}
	* Post: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Courses
	* Put: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Courses
	* Delete Course: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Courses/{id}?confirm=Yes
	* Delete Lesson: http://ec2-18-231-171-55.sa-east-1.compute.amazonaws.com:5000/Courses/{idCourse}/Lessons/{idLesson}?confirm=Yes

<br><br>
*Developed by: Adriano Siqueira, Aline Rosa, Arthur Camurca, Breno Xavier, Fabricio dos Santos, Jean Paul, Vitor Bandeira<br>
*10/21/21
