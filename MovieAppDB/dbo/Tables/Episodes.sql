CREATE TABLE [dbo].[Episodes]
(
	[id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[movie_id] INT NOT NULL REFERENCES FEATURES(id),
	[status_id] INT NOT NULL REFERENCES STATUSES(id),
    [season] INT NULL, 
    [episode] INT NULL, 
    [title] INT NULL, 
    [plot] VARCHAR(MAX) NULL, 
    [rating] DECIMAL(4, 2) NULL,
	[imdb_id] VARCHAR(10) NULL, 
    [my_rating] INT NULL, 
    [on_disk] BIT NULL, 
    [file_path] VARCHAR(500) NULL, 
)
