CREATE TABLE shipped_items
(
	[Item Number] INT NOT NULL PRIMARY KEY, 
    [Weight] INT NOT NULL, 
    [Destination] NCHAR(100) NOT NULL, 
    [Insurence amount ] INT NOT NULL, 
    [Dimension Number] TEXT NOT NULL, 
    [Final Delivery Date] DATETIME NULL
)
