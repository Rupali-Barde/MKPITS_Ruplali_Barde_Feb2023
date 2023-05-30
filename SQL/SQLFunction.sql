--Create Function
create function f2()
returns table
as
return(select * from salesmanInfo)

select * from f2()

create function f3(
@ord_no int,
@cust_id int,
@salesmen_id int)
returns int
as
begin 
return(select @ord_no+' ' +@cust_id+ ' ' +@salesmen_id)
end

select dbo.fun_salesmanInfo(ord_no,
cust_id,salesmen_id)


