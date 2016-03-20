CREATE TABLE [dbo].[Project]
(
    [ProjectName] NVARCHAR(100) NOT NULL, 
    [Customer] NVARCHAR(50) NOT NULL, 
    [ProjectType] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Customer] FOREIGN KEY (Customer) REFERENCES [Customer]([CustomerName]), 
    CONSTRAINT [FK_ProjectType] FOREIGN KEY ([ProjectType]) REFERENCES [ProjectType]([ProjectTypeName]), 
    CONSTRAINT [PK_Project] PRIMARY KEY ([ProjectName],[Customer])
)
