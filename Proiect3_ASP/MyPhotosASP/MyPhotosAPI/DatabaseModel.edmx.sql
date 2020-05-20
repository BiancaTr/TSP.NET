
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/23/2020 20:25:07
-- Generated from EDMX file: C:\Users\Bobibi\source\repos\MyPhotosProject\PhotosAPI\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotosDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MyPhotoTables'
CREATE TABLE [dbo].[MyPhotoTables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Place] nvarchar(max)  NOT NULL,
    [Person] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Event] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Create_Date] datetime  NOT NULL,
    [Path] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MyPhotoTables'
ALTER TABLE [dbo].[MyPhotoTables]
ADD CONSTRAINT [PK_MyPhotoTables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------