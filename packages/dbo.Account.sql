CREATE TABLE [dbo].[Account] (
    [id]       NVARCHAR (50) NOT NULL,
    [fullname] NVARCHAR (50) NULL,
    [username] NVARCHAR (50) NULL,
    [password] NVARCHAR (50) NULL,
    [email]    NVARCHAR (50) NULL,
    [position] NVARCHAR(30) NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);

