﻿IF NOT EXISTS (SELECT 1 from INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SearchFilter')
BEGIN
CREATE TABLE [dbo].[SearchFilter](
	[SearchFilterID] [bigint] IDENTITY(1,1) NOT NULL,
	[FilterText] [varchar](max) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Description] [varchar](max) NULL,
 CONSTRAINT [PK_SearchFilter] PRIMARY KEY CLUSTERED 
(
	[SearchFilterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END