create database carinsurance
create Table Car_insurance
( Invoice int,
purchase_date date,
Make_Brand varchar(50),
Make_Year varchar(90),
Ver_sion varchar(30),
Registration  varchar(40),
Car_run varchar(20),
Fuel_Varient varchar(20),
Reg_Date date,
Last_Service_date date,
model varchar(30),
Color varchar(30),
RTO_district varchar(50),
Run_After_Service varchar(10),
CNG_LPG varchar(80),
GET_Duplicate_key varchar(40),
ownership varchar(30),
Purchase_Invoice varchar(30),
Meter_Tempered varchar(50),
Extra_Tool varchar(70),
RC_Availbility varchar(80),
Chasis_No varchar(50),
RTO_NOC varchar(10),
NOC_to_RTO varchar(80),
Name_RTO_Office varchar(40),
Issue_Chasis_No varchar(30),
Issue_Engine_No varchar(30),
MisMatch_Color varchar(50),
MisMatch_CC varchar(10),
Is_Hypothication varchar(80),
Have_from_No28 varchar(40),
Have_from_No29_30 varchar(30),
Have_from_No33 varchar(30),
Have_from_No35 varchar(50),
covering_letter varchar(10),
Miss_mail varchar(20),
Have_RTD_copy varchar(40),
Mail_Date date,
Have_challan varchar(30),
Challan_No varchar(30),
Challan_Date Date,
Challan_Amount varchar(10),
Paid_to varchar(20),
Have_Insurance varchar(50),
IDV_Value varchar(10),
Till_Date Date,
Name varchar(20),
Address varchar(30),
Permanent_Address varchar(50),
City varchar(20),
Contact_No varchar(30),
Occupation varchar(50),
SNo varchar(50),
Document varchar(20),
Document_No varchar(30),
Expiry_on varchar(50),
Select_image1 varchar(40),

Select_Associates1 varchar(50)


)
  Alter table Car_insurance add image varbinary(max) 

Alter table Car_insurance alter column  Invoiceid int 
Alter table Car_insurance add  Extratool2 varchar(40) 
Alter table Car_insurance add  Extratool3 varchar(40) 
update  Car_insurance set Extratool2='wrench' where Invoiceid=2

update  Car_insurance set Invoiceid=1 where Name ='Anjali Gupta'
update  Car_insurance set Invoiceid=0 where Invoice  ='23434'
delete From Car_insurance Where  Invoiceid =4
 insert into  Car_insurance values(1,12-02-2022,'mahindra',1-07-2011,'xuv','123abc','12','dark yellow',23-04-2012,21-06-2020,
 'x-10','black','katni','2','yes','no','1st','yes','pending','Wrench','yes','yes','no','yes','asp RTO','no','yes','yes','no','yes',
 'yes','no','not required','yes','no','yes','sawa',12-09-2131,'yes','no','yes','adnsj v',13-12-2022,'yes','234',12-02-22,'200','300','comprehensive','23sc',
 12-03-2020,'abhishek','katni','b-type bhopal','bhopal','2335123','bussines','1','djjrnc','12asc',13-03-2021,'single',
 '1','fdsxfctddssn ','dsdze','hvbjvgxs')
 insert into  Car_insurance (Select_Associates1) values(1)
 update  Car_insurance set image =(SELECT MyImage.* FROM Openrowset( Bulk 'D:\car.jpg', Single_Blob)MyImage) where Invoiceid =1
 update  Car_insurance set image =(SELECT MyImage.* FROM Openrowset( Bulk 'D:\car1.jpg', Single_Blob)MyImage) where Invoiceid =2

 select *from  Car_insurance
 Drop table Car_insurance
 --master classes  :-
 create table Make_Brand
( Make_Brandid int,
 Make_Brand varchar(15)
  )
  select * from Make_Brand
  Drop table Make_Brand
  insert into Make_Brand values(1,'normal')

  create table Ver_sion
( Ver_sionid int,
 Ver_sion varchar(15)
  )
  select * from Ver_sion
  Drop table Ver_sion
  insert into Ver_sion values(1,'x-20')

   create table Make_Year
( Make_Yearid int,
 Make_Year varchar(15)
  )
  select * from Make_Year
  Drop table Make_Year
  insert into Make_Year values(1,'2013')

  create table Fuel_Varient
( Fuel_Varientid int,
 Fuel_Varient varchar(15)
  )
  select * from Fuel_Varient
  Drop table Fuel_Varient
  insert into Fuel_Varient values(1,'petrol')

  create table model
( modelid int,
 model varchar(15)
  )
  select * from model
  Drop table model
  insert into model values(1,'alto')

  create table Color
( Colorid int,
 Color varchar(15)
  )
  select * from Color
  Drop table Color
  insert into Color values(1,'red')
  create table RTO_district
( RTO_districtid int,
 RTO_district varchar(15)
  )
  select * from RTO_district
  Drop table RTO_district
  insert into RTO_district values(1,'katni')

  create table Select_Associates1
( Select_Associates1id int,
 Select_Associates1 varchar(15)
  )
  select * from Select_Associates1
  Drop table Select_Associates1
  create table button(
  GET_Duplicate_key varchar(40),
  Purchase_Invoice varchar(30)
  )
 insert into button values('yes','no')
 drop table button 
 select * from button

  create table Grid_image(
  Invoiceid varchar(50),
  Sno int,
  Grid_image_path varbinary(max)
  
  )
  DECLARE @imageData varbinary(max)
SET @imageData = (SELECT * FROM OPENROWSET(BULK N'D:\car.jpg', SINGLE_BLOB) AS ImageFile)
 insert into Grid_image values(1,1, @imageData)
 drop table Grid_image 
 select * from Grid_image
 update Grid_image set Grid_image_path=(SELECT * FROM OPENROWSET(BULK 'D:\car.jpg', SINGLE_BLOB) As ImageFile) where Sno='1'
 