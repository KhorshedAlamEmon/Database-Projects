CREATE TABLE [dbo].[Table]
(
	[User_ID] INT NOT NULL , 
    [User_First_Name] NCHAR(100) NOT NULL, 
    [User_Last_Name] NCHAR(10) NOT NULL, 
    [Item_Number] INT NOT NULL, 
	[Schadule_Number] INT NOT NULL,
    [Product_Type] NCHAR(100) NOT NULL, 
    [Product_Weight] INT NOT NULL, 
    [Dimansions] INT NOT NULL, 
    [Retail_Center_Adress] NCHAR(1000) NOT NULL, 
    [Destination] NCHAR(1000) NOT NULL, 
    [Transport_Type] NCHAR(500) NOT NULL, 
    [Delivery_Route] INT NOT NULL, 
    [Final_Delivery_Date] NCHAR(1000) NULL, 
    [Delivery_Status] BIT NULL, 
    PRIMARY KEY ([Item_Number], [User_ID], [Schadule_Number])
)
