--Create SQL-code for getting info about the churches:
select City.CityName, Year.Year, ChurchName.Name
from ChurchName
join City on city.ID=ChurchName.CityID
join [Year] on Year.ID=ChurchName.YearID

--Write SQL-code to get where the inhabitants lives:
select Person.Name, CityName
from Person 
join City on City.ID=person.cityID

--Write SQL-code to get all inhabitants and the churches that they like:
select person.Name, ChurchName.Name, Year.Year
from Person
join PersonLikesChurch on PersonLikesChurch.PersonID=Person.ID
join ChurchName on PersonLikesChurch.ChurchID=ChurchName.ID
join [Year] on Year.ID=ChurchName.YearID
