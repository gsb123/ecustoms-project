UPDATE [dbECostoms].[dbo].[tblDeclaration]
   SET [Number] = <Number, int,>
      ,[ProductName] = <ProductName, nvarchar(250),>
      ,[CompanyName] = <CompanyName, nvarchar(500),>
      ,[ProductAmount] = <ProductAmount, nvarchar(500),>
      ,[Unit] = <Unit, nvarchar(200),>
      ,[CreatedByID] = <CreatedByID, int,>
      ,[ModifiedByID] = <ModifiedByID, int,>
      ,[ModifiedDate] = <ModifiedDate, datetime,>
      ,[CreatedDate] = <CreatedDate, datetime,>
      ,[HasDeclaration] = <HasDeclaration, bit,>
      ,[ImportNumber] = <ImportNumber, int,>
      ,[ImportProductName] = <ImportProductName, nvarchar(250),>
      ,[ImportCompanyName] = <ImportCompanyName, nvarchar(500),>
      ,[ImportProductAmount] = <ImportProductAmount, nvarchar(500),>
      ,[ImportUnit] = <ImportUnit, nvarchar(200),>
      ,[ImportHasDeclaration] = <ImportHasDeclaration, bit,>
 WHERE <Search Conditions,,>