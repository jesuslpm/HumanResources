
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/21/2014 14:13:14
-- Generated from EDMX file: C:\Projects\HumanResources\HumanResources.Entities\Entities\HumanResourcesDbContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HumanResources];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Personal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personal];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personal'
CREATE TABLE [dbo].[Personal] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(128)  NULL,
    [LastName] nvarchar(256)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [Address] nvarchar(256)  NOT NULL,
    [HomePhoneNumber] nvarchar(16)  NULL,
    [CellPhoneNumber] nvarchar(16)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personal'
ALTER TABLE [dbo].[Personal]
ADD CONSTRAINT [PK_Personal]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------