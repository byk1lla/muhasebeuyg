/* 
1- Fatura
2- Gelir
3- Gider
4- Müşteri
5- Ödeme
6- Silinen Müşteriler
7- Ürünler
8- Log
9- Kullanıcılar

*/
CREATE TABLE [dbo].[fatura] (
    [id]         INT             IDENTITY (1, 1) NOT NULL,
    [firma_adi]  varchar(255)             NULL,
    [fatura_no]  VARCHAR (20)    NULL,
    [tarih]      DATETIME        NULL,
    [tutar]      DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[musteri] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [sube]           VARCHAR (255) NOT NULL,
    [musteri_adi]    VARCHAR (255) NULL,
    [musteri_soyadı] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[odeme] (
    [id]         INT             IDENTITY (1, 1) NOT NULL,
    [firma_adi]  varchar(255)    NULL,
    [odeme_no]   VARCHAR (20)    NULL,
    [odeme_turu] VARCHAR (50)    NULL,
    [tarih]      DATETIME        NULL,
    [tutar]      DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[urun] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [urun_adi] VARCHAR (255) NULL,
    [fiyat]    INT           NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[useractivity] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [usr_id]        NVARCHAR (100) NOT NULL,
    [activity]      NVARCHAR (100) NOT NULL,
    [activity_date] DATETIME       NOT NULL
);

CREATE TABLE [dbo].[users] (
    [id]            INT          IDENTITY (1, 1) NOT NULL,
    [ad]            VARCHAR (30) NOT NULL,
    [soyad]         VARCHAR (30) NOT NULL,
    [username]      VARCHAR (15) NOT NULL,
    [passwd]        VARCHAR (20) NOT NULL,
    [auth]          BIT          DEFAULT ((0)) NULL,
    [last_activity] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);