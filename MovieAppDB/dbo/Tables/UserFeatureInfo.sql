﻿CREATE TABLE [dbo].[UserFeatureInfo]
(
	[id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [user_id] INT NOT NULL REFERENCES USERPROFILE(UserId), 
    [feature_id] INT NOT NULL REFERENCES FEATURES(id), 
    [episode_id] INT NOT NULL REFERENCES EPISODES(id),
	[status_id] INT NOT NULL REFERENCES STATUSES(id),
    [my_rating] INT NULL, 
    [file_path] VARCHAR(500) NULL, 
    [on_disk] BIT NULL
)
