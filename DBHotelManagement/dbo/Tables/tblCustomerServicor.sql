CREATE TABLE [dbo].[tblCustomerServicor] (
    [ServiceID]   INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (30)    NOT NULL,
    [MiddleName]  VARCHAR (30)    NOT NULL,
    [LastName]    VARCHAR (30)    NOT NULL,
    [Gender]      VARCHAR (30)    NOT NULL,
    [Description] VARCHAR (MAX)   NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [Available]   BIT             NOT NULL,
    [DateService] DATETIME        NOT NULL,
    PRIMARY KEY CLUSTERED ([ServiceID] ASC)
);

