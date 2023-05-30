--Create Function
create function f1()
returns table
as
return (select * from orders)

select * from f1()

