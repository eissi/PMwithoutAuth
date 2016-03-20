﻿CREATE TABLE [dbo].[Customer]
(
    [CustomerName] NVARCHAR(50) NOT NULL, 
    [AE] NVARCHAR(10) NULL, 
    [PSS] NVARCHAR(10) NULL, 
    [CSA] NVARCHAR(10) NULL, 
    [DSA] NVARCHAR(10) NULL, 
    [ATU] NCHAR(10) NULL, 
    [C+E] NVARCHAR(10) NULL, 
    CONSTRAINT [fk_ATU] FOREIGN KEY ([ATU]) REFERENCES [ATU]([ATUname]), 
    PRIMARY KEY ([CustomerName]) 
)
