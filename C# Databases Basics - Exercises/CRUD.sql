---first name, last name, and salary for each employee.
select [FirstName],[LastName],[Salary]
from [Employees]

---Create an SQL query that finds the first, middle, and last name for each employee. 
select [FirstName],[MiddleName],[LastName]
from [Employees]

---Create an SQL query that finds the email address for each employee, by his first and last name.
--Consider that the email domain is softuni.bg. Emails should look like "John.Doe@softuni.bg".
--The produced column should be named "Full Email Address". 
--select [FirstName] 
--from Employees 
--where [FirstName] like 'a%'
select [FirstName]+'.'+[LastName]+'@softuni.bg' as ["Full Email Address"]
from [Employees]

---Create an SQL query that finds all different employee�s salaries. Display the salaries only in a column named "Salary".

select distinct [Salary]
from [Employees]

---Create an SQL query that finds all information about the employees whose job title is "Sales Representative�. 
select *
from Employees
where JobTitle ='Sales Representative'

---Create an SQL query to find the first name, last name,
--- and job title for all employees whose salary is in a range between 20000 and 30000.

select [FirstName],[LastName],[JobTitle]
from Employees
where[Salary] between 20000 and 30000

--Create an SQL query that finds the�full name�of all employees whose�salary�is
--exactly�25000, 14000, 12500, or 23600. The result should be displayed in a column named "Full Name",
--which is a combination of�first,�middle, and�last�names separated by a�single space.

select [FirstName]+' '+[MiddleName]+' '+[LastName] as [Full Name]
from Employees
where ([Salary] = 25000 or  [Salary] = 12500 or [Salary] = 14000 or[Salary] = 23600 )

--Create an SQL query that finds�the first and last names�of those employees that�do not have a manager.�
select 
[FirstName],[LastName]
from Employees
where ([ManagerID] is null)

---Create an SQL query that finds�the first name,�last name, and�salary�for employees with�a salary�higher than 50000.
---Order the result in decreasing order by salary.�

select 
[FirstName],[LastName],[Salary]
from Employees
where ([Salary]>50000)
order by [Salary] desc

---Create an SQL query that finds the�first and last names�of the�5 best-paid Employees,
---ordered in�descending by their salary
select top(5)
[FirstName],[LastName]
from Employees
order by [Salary] desc

---Create an SQL query that finds the�first�and�last names�of all employees whose�department ID is not 4.

select 
[FirstName],[LastName]
from Employees
where ([DepartmentID]!=4)

---By�salary�in�decreasing�order
--Then by the�first name�alphabetically
--Then by the�last name descending
--Then by�middle name alphabetically
select * from Employees
order by [Salary]Desc,[FirstName]ASC,[LastName]DESC,[MiddleName]ASC

---Create an SQL query that creates a view "V_EmployeesSalaries"�with�first name,�
--last name, and�salary�for each employee.

go

create view V_EmployeesSalaries
As( select [FirstName],[LastName],[Salary]
from Employees)


---Create an SQL query to create view
---"V_EmployeeNameJobTitle"�with�full employee name�and�job title.
---When the middle name is�NULL�replace it with�an empty string ('').
go

create view V_EmployeeNameJobTitle
As
(select
concat(FirstName,' ',ISNULL(MiddleName,''),' ',LastName) As[Full Name],
JobTitle
from	Employees)

go

---Create an SQL query that finds�all distinct job titles.
select  distinct JobTitle 
from Employees

---Create an SQL query that finds�the first 10 projects which were started,
---select�all information about them, and�sort�the result by�starting date,�then by name.

select top(10)*
from Projects 
ORDER BY StartDate asc,[Name]

---Create an SQL query that finds�the last 7 hired employees, select�their first, last name, and hire date.

select top(7)[FirstName],[LastName],[HireDate] 
from Employees
order by HireDate desc

select *from Employees

update Employees
set Salary +=Salary*0.12
where DepartmentID in ( 1,2,4,11)
select Salary from Employees

select top(30)[CountryName],[Population]
from Countries
where([ContinentCode] = 'EU')
order by [Population]desc,[CountryName]asc

--------
select [CountryName],[CountryCode],
case 
when [CurrencyCode] ='EUR' then'Euro'
else 'Not Euro'
End as[Currency]
from Countries
order by [CountryName]Asc
---------
select [Name]
from Characters
order by [Name] asc