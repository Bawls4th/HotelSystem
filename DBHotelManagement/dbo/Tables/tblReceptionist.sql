CREATE TABLE [dbo].[tblReceptionist] (
    [RPID]           INT           IDENTITY (1, 1) NOT NULL,
    [RPFirstName]    VARCHAR (50)  NOT NULL,
    [RPLastName]     VARCHAR (50)  NOT NULL,
    [RPEmailAddress] NVARCHAR (30) NOT NULL,
    [RPContactNo]    VARCHAR  (30)  NOT NULL,
    [RPUserName]     NVARCHAR (30) NOT NULL,
    [RPPassword]     NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([RPID] ASC)
);

