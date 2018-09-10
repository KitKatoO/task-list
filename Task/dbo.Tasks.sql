CREATE TABLE [dbo].[Tasks] (
    [TaskID]    INT            IDENTITY (1, 1) NOT NULL,
    [TaskTopic] NVARCHAR (MAX) NULL,
    [TaskNote]  NVARCHAR (MAX) NULL,
    [Date]      DATETIME2       NOT NULL,
    CONSTRAINT [PK_dbo.Tasks] PRIMARY KEY CLUSTERED ([TaskID] ASC)
);

