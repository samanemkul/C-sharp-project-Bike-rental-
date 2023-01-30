/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[name]
      ,[address]
      ,[salary]
  FROM [emp_details].[dbo].[emp]