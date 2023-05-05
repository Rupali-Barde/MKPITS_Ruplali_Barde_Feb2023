create database Veichle
create table stores(store_id int primary key,store_name varchar(20),
phone int,email varchar(20),street varchar (20),city varchar (20),
state varchar (20),zip_code int )
 select * from stores

 create table category(category_id int primary key,category_name varchar(30))
 select * from category

 create table Brand (brand_id int primary key,brand_name varchar (20))
 select * from brand

 create table product(product_id int primary key, --primary key (product_id)
 prod_name varchar(20),
 brand_id int,									--foreign key(brand_id)
 category_id int,								--foreign key (category-id)
 model_yr int,
 list_price int 
 constraint b1 foreign key (brand_id) references Brand (brand_id),
 constraint c1 foreign key (category_id)references category (category_id)
 )
 select * from product

 create table stocks(store_id int,  --foreign key(store_id)
 product_id int	,					--foreign key(producyt_id)
 quantity int,
 constraint s1 foreign key (store_id)references stores (store_id),
 constraint q1 foreign key (product_id)references product (product_id))
 select * from stocks

 create table customer (cust_id int primary key,first_name varchar(20),
 last_name varchar (20),email varchar (20),street varchar (20),
 city varchar(20),state varchar (20),
 zip_code int)
 select * from customer

 create table staff(staff_id int primary key,
 first_name varchar(20),
 last_name varchar (20),
 email varchar (20),
 store_id int,				--foreign key(store_id)
 manager_id int,
 constraint s2 foreign key (store_id)references stores (store_id))
 select * from staff

 create table orders(order_id int primary key,
 cust_id int,							--foreign key(cust_id)
 order_status varchar(20),
 order_date varchar(20),
 required_date varchar(20),
 shipped_date varchar(20),
 store_id int,							--foreign key(store_id)
 staff_id int,							--foreign key(staff_id)
 constraint c2 foreign key (cust_id) references customer (cust_id),
 constraint s3 foreign key (store_id) references stores (store_id),
 constraint s4 foreign key (staff_id) references staff (staff_id))
 select * from orders

 create table order_items(item_id  int primary key,
 order_id int,			--foreign key (order_id)
 product_id int ,		--foreign key(product_id)
 quantity int,
 list_price int,
 constraint o1 foreign key (order_id) references orders (order_id),
 constraint q2 foreign key (product_id)references product (product_id))
 select * from order_items



