CREATE TABLE [dbo].[tblManager] (
    [MGID]           INT           IDENTITY (1, 1) NOT NULL,
    [MGFirstName]    VARCHAR (50)  NOT NULL,
    [MGLastName]     VARCHAR (50)  NOT NULL,
    [MGEmailAddress] NVARCHAR (30) NOT NULL,
    [MGContactNo]    NVARCHAR (15) NOT NULL,
    [MGUserName]     NVARCHAR (30) NOT NULL,
    [MGPassword]     NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([MGID] ASC),
);

