
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/17/2019 21:20:33
-- Generated from EDMX file: D:\temp文件(桌面相关)\研发部\内部研发\10.资料项目\ToBeLiftBetter.DOCProject\DataEntity\EntityModel\EFContextForDoc.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBForDocProject];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MainContentListTagFather_MainContentListShowCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MainContentListTagFather] DROP CONSTRAINT [FK_MainContentListTagFather_MainContentListShowCode];
GO
IF OBJECT_ID(N'[dbo].[FK_MainContentListTagSon_MainContentListShowCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MainContentListTagSon] DROP CONSTRAINT [FK_MainContentListTagSon_MainContentListShowCode];
GO
IF OBJECT_ID(N'[dbo].[FK_MainContentListTagSon_MainContentListTagFather]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MainContentListTagSon] DROP CONSTRAINT [FK_MainContentListTagSon_MainContentListTagFather];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MainContentListShowCode]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MainContentListShowCode];
GO
IF OBJECT_ID(N'[dbo].[MainContentListTagBehavior]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MainContentListTagBehavior];
GO
IF OBJECT_ID(N'[dbo].[MainContentListTagFather]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MainContentListTagFather];
GO
IF OBJECT_ID(N'[dbo].[MainContentListTagSon]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MainContentListTagSon];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MainContentListShowCode'
CREATE TABLE [dbo].[MainContentListShowCode] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(100)  NULL,
    [Description] nvarchar(100)  NULL
);
GO

-- Creating table 'MainContentListTagBehavior'
CREATE TABLE [dbo].[MainContentListTagBehavior] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NULL,
    [ContentListTagSonId] int  NULL,
    [UrlName] nvarchar(50)  NULL,
    [IsUpadte] smallint  NULL,
    [IsDelete] smallint  NULL,
    [CreateTime] datetime  NULL
);
GO

-- Creating table 'MainContentListTagFather'
CREATE TABLE [dbo].[MainContentListTagFather] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NULL,
    [ShowCodeId] int  NULL,
    [FatherId] int  NULL,
    [UrlName] nvarchar(50)  NULL,
    [IsUpadte] smallint  NULL,
    [IsDelete] smallint  NULL,
    [CreateTime] datetime  NULL
);
GO

-- Creating table 'MainContentListTagSon'
CREATE TABLE [dbo].[MainContentListTagSon] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NULL,
    [ContentListTagFatherId] int  NULL,
    [ShowCodeId] int  NULL,
    [UrlName] nvarchar(50)  NULL,
    [IsUpadte] smallint  NULL,
    [IsDelete] smallint  NULL,
    [CreateTime] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MainContentListShowCode'
ALTER TABLE [dbo].[MainContentListShowCode]
ADD CONSTRAINT [PK_MainContentListShowCode]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MainContentListTagBehavior'
ALTER TABLE [dbo].[MainContentListTagBehavior]
ADD CONSTRAINT [PK_MainContentListTagBehavior]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MainContentListTagFather'
ALTER TABLE [dbo].[MainContentListTagFather]
ADD CONSTRAINT [PK_MainContentListTagFather]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MainContentListTagSon'
ALTER TABLE [dbo].[MainContentListTagSon]
ADD CONSTRAINT [PK_MainContentListTagSon]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ShowCodeId] in table 'MainContentListTagFather'
ALTER TABLE [dbo].[MainContentListTagFather]
ADD CONSTRAINT [FK_MainContentListTagFather_MainContentListShowCode]
    FOREIGN KEY ([ShowCodeId])
    REFERENCES [dbo].[MainContentListShowCode]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MainContentListTagFather_MainContentListShowCode'
CREATE INDEX [IX_FK_MainContentListTagFather_MainContentListShowCode]
ON [dbo].[MainContentListTagFather]
    ([ShowCodeId]);
GO

-- Creating foreign key on [ShowCodeId] in table 'MainContentListTagSon'
ALTER TABLE [dbo].[MainContentListTagSon]
ADD CONSTRAINT [FK_MainContentListTagSon_MainContentListShowCode]
    FOREIGN KEY ([ShowCodeId])
    REFERENCES [dbo].[MainContentListShowCode]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MainContentListTagSon_MainContentListShowCode'
CREATE INDEX [IX_FK_MainContentListTagSon_MainContentListShowCode]
ON [dbo].[MainContentListTagSon]
    ([ShowCodeId]);
GO

-- Creating foreign key on [ContentListTagFatherId] in table 'MainContentListTagSon'
ALTER TABLE [dbo].[MainContentListTagSon]
ADD CONSTRAINT [FK_MainContentListTagSon_MainContentListTagFather]
    FOREIGN KEY ([ContentListTagFatherId])
    REFERENCES [dbo].[MainContentListTagFather]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MainContentListTagSon_MainContentListTagFather'
CREATE INDEX [IX_FK_MainContentListTagSon_MainContentListTagFather]
ON [dbo].[MainContentListTagSon]
    ([ContentListTagFatherId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------