CREATE TABLE [dbo].[tblGuest] (
    [GuestID]       INT           IDENTITY (1, 1) NOT NULL,
    [GFirstName]    VARCHAR (50)  NOT NULL,
    [GMiddleName]   VARCHAR (50)  NOT NULL,
    [GLastName]     VARCHAR (50)  NOT NULL,
    [BirthDate]     DATE          NOT NULL,
    [Age]           INT           NOT NULL,
    [Gender]        VARCHAR (50)  NOT NULL,
    [Ethnicity]     VARCHAR (50)  NOT NULL,
    [GEmailAddress] NVARCHAR (50) NOT NULL,
    [GContactNo]    VARCHAR(50)   NOT NULL,
    [Registered]    DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([GuestID] ASC)
);

