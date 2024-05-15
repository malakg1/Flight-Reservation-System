/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/20/2023 6:22:04 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_AIRCRAFT') and o.name = 'FK_TB_AIRCR_ADD_OR_UP_TB_ADMIN')
alter table TB_AIRCRAFT
   drop constraint FK_TB_AIRCR_ADD_OR_UP_TB_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_FLIGHT') and o.name = 'FK_TB_FLIGH_ADD_UPDAT_TB_ADMIN')
alter table TB_FLIGHT
   drop constraint FK_TB_FLIGH_ADD_UPDAT_TB_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_SEAT') and o.name = 'FK_TB_SEAT_HAS_TB_FLIGH')
alter table TB_SEAT
   drop constraint FK_TB_SEAT_HAS_TB_FLIGH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_USER_PHONE2') and o.name = 'FK_TB_USER__PHONENUM_TB_CUSTO')
alter table TB_USER_PHONE2
   drop constraint FK_TB_USER__PHONENUM_TB_CUSTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_WE_RESERVATION') and o.name = 'FK_TB_WE_RE_ADD_CHANG_TB_CUSTO')
alter table TB_WE_RESERVATION
   drop constraint FK_TB_WE_RE_ADD_CHANG_TB_CUSTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_WE_RESERVATION') and o.name = 'FK_TB_WE_RE_FLIGHT_HA_TB_FLIGH')
alter table TB_WE_RESERVATION
   drop constraint FK_TB_WE_RE_FLIGHT_HA_TB_FLIGH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tb_PROCESSED_BY') and o.name = 'FK_TB_PROCE_PROCESSED_TB_PAYME')
alter table tb_PROCESSED_BY
   drop constraint FK_TB_PROCE_PROCESSED_TB_PAYME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tb_PROCESSED_BY') and o.name = 'FK_TB_PROCE_PROCESSED_TB_SEAT')
alter table tb_PROCESSED_BY
   drop constraint FK_TB_PROCE_PROCESSED_TB_SEAT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_ADMIN')
            and   type = 'U')
   drop table TB_ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_AIRCRAFT')
            and   name  = 'ADD_OR_UPDATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_AIRCRAFT.ADD_OR_UPDATE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_AIRCRAFT')
            and   type = 'U')
   drop table TB_AIRCRAFT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_CUSTOMER')
            and   type = 'U')
   drop table TB_CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_FLIGHT')
            and   name  = 'ADD_UPDATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_FLIGHT.ADD_UPDATE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_FLIGHT')
            and   type = 'U')
   drop table TB_FLIGHT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_PAYMENT')
            and   type = 'U')
   drop table TB_PAYMENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_SEAT')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_SEAT.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_SEAT')
            and   type = 'U')
   drop table TB_SEAT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_USER_PHONE2')
            and   name  = 'PHONENUM_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_USER_PHONE2.PHONENUM_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_USER_PHONE2')
            and   type = 'U')
   drop table TB_USER_PHONE2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_WE_RESERVATION')
            and   name  = 'FLIGHT_HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_WE_RESERVATION.FLIGHT_HAS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_WE_RESERVATION')
            and   name  = 'ADD_CHANGE_CANCEL_RES_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_WE_RESERVATION.ADD_CHANGE_CANCEL_RES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_WE_RESERVATION')
            and   type = 'U')
   drop table TB_WE_RESERVATION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tb_PROCESSED_BY')
            and   name  = 'PROCESSED_BY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index tb_PROCESSED_BY.PROCESSED_BY2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tb_PROCESSED_BY')
            and   name  = 'PROCESSED_BY_FK'
            and   indid > 0
            and   indid < 255)
   drop index tb_PROCESSED_BY.PROCESSED_BY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tb_PROCESSED_BY')
            and   type = 'U')
   drop table tb_PROCESSED_BY
go

/*==============================================================*/
/* Table: TB_ADMIN                                              */
/*==============================================================*/
create table TB_ADMIN (
   ADMINID              numeric(8)           not null,
   ROLE                 varchar(10)          not null,
   EMAIL                varchar(20)          null,
   PASSWORD             numeric              null,
   DOB                  varchar(20)          null,
   FNAME                varchar(10)          null,
   LNAME                varchar(10)          null,
   USERNAME             char(15)             null,
   constraint PK_TB_ADMIN primary key nonclustered (ADMINID)
)
go

/*==============================================================*/
/* Table: TB_AIRCRAFT                                           */
/*==============================================================*/
create table TB_AIRCRAFT (
   SERIALNUM            numeric(5)           not null,
   ADMINID              numeric(8)           not null,
   CAPACITY             numeric(5)           not null,
   AIRLINE              varchar(20)          not null,
   MODELNUM             numeric(5)           not null,
   constraint PK_TB_AIRCRAFT primary key nonclustered (SERIALNUM)
)
go

/*==============================================================*/
/* Index: ADD_OR_UPDATE_FK                                      */
/*==============================================================*/
create index ADD_OR_UPDATE_FK on TB_AIRCRAFT (
ADMINID ASC
)
go

/*==============================================================*/
/* Table: TB_CUSTOMER                                           */
/*==============================================================*/
create table TB_CUSTOMER (
   CUSTOMERID           numeric(8)           not null,
   EMAIL                varchar(20)          null,
   PASSWORD             numeric              null,
   DOB                  varchar(20)          null,
   FNAME                varchar(10)          null,
   LNAME                varchar(10)          null,
   USERNAME             char(15)             null,
   PASSPORTNUM          varchar(15)          null,
   constraint PK_TB_CUSTOMER primary key nonclustered (CUSTOMERID)
)
go

/*==============================================================*/
/* Table: TB_FLIGHT                                             */
/*==============================================================*/
create table TB_FLIGHT (
   FLIGHID              numeric(8)           not null,
   ADMINID              numeric(8)           not null,
   ARRIVALDATE          varchar(20)          null,
   ARRIVALLOCATION      varchar(30)          null,
   ARRIVALTIME          varchar(20)          null,
   DEPTTIME             varchar(20)          null,
   DEPTDATE             varchar(20)          null,
   DEPTLOCATION         varchar(20)          null,
   constraint PK_TB_FLIGHT primary key nonclustered (FLIGHID)
)
go

/*==============================================================*/
/* Index: ADD_UPDATE_FK                                         */
/*==============================================================*/
create index ADD_UPDATE_FK on TB_FLIGHT (
ADMINID ASC
)
go

/*==============================================================*/
/* Table: TB_PAYMENT                                            */
/*==============================================================*/
create table TB_PAYMENT (
   PAYMENTID            numeric(8)           not null,
   PAYMENTTIME          varchar(20)          not null,
   AMOUNT               numeric              not null,
   PAYMENTDATE          varchar(20)          null,
   VISANUM              varchar(20)          null,
   constraint PK_TB_PAYMENT primary key nonclustered (PAYMENTID)
)
go

/*==============================================================*/
/* Table: TB_SEAT                                               */
/*==============================================================*/
create table TB_SEAT (
   SEATNUM              varchar(5)           not null,
   FLIGHID              numeric(8)           not null,
   CLASS                varchar(10)          not null,
   AVAILABILITY         bit                  not null,
   PRICE                numeric              not null,
   constraint PK_TB_SEAT primary key nonclustered (SEATNUM)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on TB_SEAT (
FLIGHID ASC
)
go

/*==============================================================*/
/* Table: TB_USER_PHONE2                                        */
/*==============================================================*/
create table TB_USER_PHONE2 (
   PHONENUM2            numeric(11)          not null,
   USER_NAME2           char(15)             not null,
   CUSTOMERID           numeric(8)           not null,
   constraint PK_TB_USER_PHONE2 primary key nonclustered (PHONENUM2, USER_NAME2)
)
go

/*==============================================================*/
/* Index: PHONENUM_FK                                           */
/*==============================================================*/
create index PHONENUM_FK on TB_USER_PHONE2 (
CUSTOMERID ASC
)
go

/*==============================================================*/
/* Table: TB_WE_RESERVATION                                     */
/*==============================================================*/
create table TB_WE_RESERVATION (
   CUSTOMERID           numeric(8)           not null,
   FLIGHID              numeric(8)           not null,
   RESNUM               numeric(10)          not null,
   DATE                 varchar(20)          null,
   RESSTATUS            varchar(7)           null,
   constraint PK_TB_WE_RESERVATION primary key nonclustered (CUSTOMERID, FLIGHID, RESNUM)
)
go

/*==============================================================*/
/* Index: ADD_CHANGE_CANCEL_RES_FK                              */
/*==============================================================*/
create index ADD_CHANGE_CANCEL_RES_FK on TB_WE_RESERVATION (
CUSTOMERID ASC
)
go

/*==============================================================*/
/* Index: FLIGHT_HAS_FK                                         */
/*==============================================================*/
create index FLIGHT_HAS_FK on TB_WE_RESERVATION (
FLIGHID ASC
)
go

/*==============================================================*/
/* Table: tb_PROCESSED_BY                                       */
/*==============================================================*/
create table tb_PROCESSED_BY (
   PAYMENTID            numeric(8)           not null,
   SEATNUM              varchar(5)           not null,
   constraint PK_TB_PROCESSED_BY primary key (PAYMENTID, SEATNUM)
)
go

/*==============================================================*/
/* Index: PROCESSED_BY_FK                                       */
/*==============================================================*/
create index PROCESSED_BY_FK on tb_PROCESSED_BY (
PAYMENTID ASC
)
go

/*==============================================================*/
/* Index: PROCESSED_BY2_FK                                      */
/*==============================================================*/
create index PROCESSED_BY2_FK on tb_PROCESSED_BY (
SEATNUM ASC
)
go

alter table TB_AIRCRAFT
   add constraint FK_TB_AIRCR_ADD_OR_UP_TB_ADMIN foreign key (ADMINID)
      references TB_ADMIN (ADMINID)
         on delete cascade
go

alter table TB_FLIGHT
   add constraint FK_TB_FLIGH_ADD_UPDAT_TB_ADMIN foreign key (ADMINID)
      references TB_ADMIN (ADMINID)
         on delete cascade
go

alter table TB_SEAT
   add constraint FK_TB_SEAT_HAS_TB_FLIGH foreign key (FLIGHID)
      references TB_FLIGHT (FLIGHID)
         on delete cascade
go

alter table TB_USER_PHONE2
   add constraint FK_TB_USER__PHONENUM_TB_CUSTO foreign key (CUSTOMERID)
      references TB_CUSTOMER (CUSTOMERID)
         on delete cascade
go

alter table TB_WE_RESERVATION
   add constraint FK_TB_WE_RE_ADD_CHANG_TB_CUSTO foreign key (CUSTOMERID)
      references TB_CUSTOMER (CUSTOMERID)
         on delete cascade
go

alter table TB_WE_RESERVATION
   add constraint FK_TB_WE_RE_FLIGHT_HA_TB_FLIGH foreign key (FLIGHID)
      references TB_FLIGHT (FLIGHID)
         on delete cascade
go

alter table tb_PROCESSED_BY
   add constraint FK_TB_PROCE_PROCESSED_TB_PAYME foreign key (PAYMENTID)
      references TB_PAYMENT (PAYMENTID)
         on delete cascade
go

alter table tb_PROCESSED_BY
   add constraint FK_TB_PROCE_PROCESSED_TB_SEAT foreign key (SEATNUM)
      references TB_SEAT (SEATNUM)
         on delete cascade
go

