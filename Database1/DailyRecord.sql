CREATE TABLE [dbo].[DailyRecord]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [StartTime] DATETIME NULL, 
    [EndTime] DATETIME NULL, 
    [TaskDescription] NVARCHAR(100) NULL, 
    [TaskType] NVARCHAR(50) NULL, 
    [ProjectName] NVARCHAR(100) NULL, 
    [Customer] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_ProjectName] FOREIGN KEY ([ProjectName],[Customer]) REFERENCES [Project]([ProjectName],[Customer]), 
    CONSTRAINT [FK_TaskType] FOREIGN KEY ([TaskType]) REFERENCES [TaskType]([TaskTypeName])
)
