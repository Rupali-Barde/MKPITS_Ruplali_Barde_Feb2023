create table teachers(teacher_id int primary key ,age int)
select * from teachers

create table subject (teacher_id int, teacher_name varchar(20),
constraint t1 foreign key(teacher_id) references teachers (teacher_id))
select * from subject

drop table subject

create table subject (teacher_id int,sub_name varchar(20),
constraint t1 foreign key (teacher_id) references teachers (teacher_id))

select * from subject

select * from teachers
insert into subject values (1,'Chemistry')
insert into subject values (1,'Biology')
select * from subject

insert into teachers values(2,26)
insert into subject values (2,'English')
insert into subject values (2,'Math')

select * from teachers

insert into teachers values(3,25)
insert into subject values (3,'Computer')

select * from subject
