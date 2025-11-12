create proc pGetCitiesByCountryName
@country_name nvarchar(200)
as
select ci.name
from city ci join country co
on ci.country_id = co.id
where co.name = @country_name
order by ci.name

pGetCitiesByCountryName 'EN'