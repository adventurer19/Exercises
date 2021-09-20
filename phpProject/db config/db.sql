create database phpproject
 use database phpproject

 create table users
 (

     userId int(10) PRIMARY KEY AUTO_INCREMENT NOT NULL,
     usersName varchar(150) not null,
     usersEmail varchar(150) not null,
     usersUid varchar(150) not null,
     usersPwd varchar(150) not null
 )