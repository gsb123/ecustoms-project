USE [dbECostoms]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 05/22/2011 14:28:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Sex] [int] NULL,
	[Birthday] [datetime] NULL,
	[Address] [nvarchar](300) NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](300) NULL,
	[PermissionID] [int] NULL,
	[IsActive] [int] NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPermission]    Script Date: 05/22/2011 14:28:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPermission](
	[PermissionID] [int] NULL,
	[Permission] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDeclaration]    Script Date: 05/22/2011 14:28:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDeclaration](
	[DeclarationID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NULL,
	[ProductName] [nvarchar](250) NULL,
	[CompanyName] [nvarchar](500) NULL,
	[ProductAmount] [nvarchar](500) NULL,
	[Unit] [nvarchar](200) NULL,
	[CreatedByID] [int] NULL,
	[ModifiedByID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[HasDeclaration] [bit] NULL,
	[ImportProductName] [nvarchar](250) NULL,
	[ImportCompanyName] [nvarchar](500) NULL,
	[ImportProductAmount] [nvarchar](500) NULL,
	[ImportUnit] [nvarchar](200) NULL,
	[ImportHasDeclaration] [bit] NULL,
	[ImportNumber] [int] NULL,
	[ImportType] [nvarchar](200) NULL,
	[ExportType] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblDeclaration] PRIMARY KEY CLUSTERED 
(
	[DeclarationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectAllUser]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Select all usres
-- =============================================
CREATE PROCEDURE [dbo].[sp_SelectAllUser]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		UserID,
		Name,
		Sex,
		Birthday, 
		Address,
		Email,
		PhoneNumber,
		UserName,
		Password,
		Permission,
		IsActive
	FROM
		tblUser, tblPermission
	WHERE tblUser.permissionID = tblPermission.PermissionID
END
-- exec [sp_SelectAllUser]
GO
/****** Object:  StoredProcedure [dbo].[sp_selectAllPermission]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 12/04/2011
-- Description:	Get all Permission
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectAllPermission]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		*
	FROM
		tblPermission
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateUser]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 12/04/2011
-- Description:	Update User
-- =============================================
CREATE PROCEDURE [dbo].[sp_updateUser]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(500),		
	@Address nvarchar(300),
	@Email nvarchar(100),
	@PhoneNumber varchar(20),
	@UserName nvarchar(50),
	@Password nvarchar(300),
	@PermissionID int,	
	@IsActive int,
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE
		tblUser
	SET
		Name = @Name,
		Address = @Address,
		Email = @Email,
		PhoneNumber = @PhoneNumber,
		UserName = @UserName,
		Password = @Password,
		PermissionID = @PermissionID,
		IsActive = @IsActive
	WHERE
		UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_countUserByUserName]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 12/04/2011
-- Description:	Count user by Username
-- =============================================
CREATE PROCEDURE [dbo].[sp_countUserByUserName]
	-- Add the parameters for the stored procedure here
	@UserName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		COUNT(*)
	FROM
		tblUser
	WHERE
		UserName = @UserName
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetNameById]    Script Date: 05/22/2011 14:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_GetNameById] (@UserId int)
RETURNS NVARCHAR(500)
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @Name NVARCHAR(500);
		SELECT @Name = Name FROM tblUser as a WHERE a.UserId = @UserId
     RETURN(@Name);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteUser]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vuongdd
-- Create date: 14/04/2011
-- Description:	Delete user by UserID
-- =============================================
CREATE PROCEDURE [dbo].[sp_deleteUser]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE 
	FROM
		tblUser
	WHERE
		UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetUser]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 09/04/2011
-- Description:	Get user by username, password
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetUser]
	-- Add the parameters for the stored procedure here
	@UserName nvarchar(50),
	@Password nvarchar(300)		
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		UserName,
		Name,
		Email,
		Address,
		PhoneNumber,
		PermissionID,
		IsActive,
		UserID
	FROM 
		tblUser
	WHERE
		UserName = @UserName
	AND
		Password = @Password 
	AND
		IsActive = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertUser]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Add user
-- =============================================
CREATE PROCEDURE [dbo].[sp_insertUser]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(500),		
	@Address nvarchar(300),
	@Email nvarchar(100),
	@PhoneNumber varchar(20),
	@UserName nvarchar(50),
	@Password nvarchar(300),
	@PermissionID int,	
	@IsActive int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblUser
		(
			[Name]			           
           ,[Address]
           ,[Email]
           ,[PhoneNumber]
           ,[UserName]
           ,[Password]
           ,[PermissionID]           
           ,[IsActive]
        )
     VALUES
		(
			@Name,					
			@Address,
			@Email,
			@PhoneNumber,
			@UserName,
			@Password,
			@PermissionID,			
			@IsActive
        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectUserByID]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 12/04/2011
-- Description:	Get UserByID
-- =============================================
CREATE PROCEDURE [dbo].[sp_SelectUserByID]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		*
	FROM
		tblUser
	WHERE
		UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectDeclerationByID]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2010
-- Description:	Get Decleration by ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectDeclerationByID]
	-- Add the parameters for the stored procedure here
	@DeclarationID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		* 
	FROM
		tblDeclaration
	WHERE
		DeclarationID = @DeclarationID;
END

-- EXEC [sp_selectDeclerationByID] 27
-- select * from tblDeclaration
GO
/****** Object:  StoredProcedure [dbo].[sp_selectDecleration]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2010
-- Description:	Get Decleration
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectDecleration]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		DeclarationID,
		Number,
		ImportNumber,
		ProductName,
		ImportProductName,
		CompanyName,
		ImportCompanyName,
		ProductAmount,
		ImportProductAmount,
		Unit,
		ImportUnit,
		ModifiedDate,
		tblUser.Name,
		CreatedDate,
		ExportType,
		ImportType
	FROM
		tblDeclaration,
		tblUser
	WHERE
		tblUser.UserID = tblDeclaration.CreatedByID
		ORDER BY ModifiedDate DESC
END


-- exec [sp_selectDecleration]
-- select * from tblDeclaration order by ModifiedDate DESC
GO
/****** Object:  Table [dbo].[tblVehicle]    Script Date: 05/22/2011 14:28:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblVehicle](
	[VehicleID] [int] IDENTITY(1,1) NOT NULL,
	[DeclarationID] [int] NULL,
	[PlateNumber] [varchar](50) NULL,
	[NumberOfContainer] [int] NULL,
	[DriverName] [nvarchar](250) NULL,
	[ImportDate] [datetime] NULL,
	[IsImport] [bit] NULL,
	[ExportDate] [datetime] NULL,
	[IsExport] [bit] NULL,
	[Note] [nvarchar](500) NULL,
	[Status] [nvarchar](500) NULL,
	[IsCompleted] [bit] NULL,
	[IsGoodsImported] [bit] NULL,
	[ImportStatus] [nvarchar](500) NULL,
	[ImportedLocalTime] [datetime] NULL,
	[HasGoodsImported] [bit] NULL,
	[ConfirmImportBy] [int] NULL,
	[ConfirmExportBy] [int] NULL,
	[ConfirmLocalImportBy] [int] NULL,
 CONSTRAINT [PK_tblVehicle] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDeclaration]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 09/04/2011
-- Description:	Insert Declaration
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertDeclaration] 
	-- Add the parameters for the stored procedure here	
	@Number int,
	@ProductName nvarchar(250),
	@CompanyName nvarchar(500),
	@ProductAmount nvarchar(500),
	@Unit nvarchar(200),
	@CreatedByID int,
	@ModifiedByID int,
	@ModifiedDate datetime,
	@CreatedDate datetime,
	@HasDeclaration bit,
	@ImportNumber int,
	@ImportProductName nvarchar(250),
	@ImportCompanyName nvarchar(500),
	@ImportProductAmount nvarchar(500),
	@ImportUnit nvarchar(200),
	@ImportHasDeclaration BIT,
	@ImportType nvarchar(200),
	@ExportType nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT 
	INTO tblDeclaration 		
	(
		Number,
		ProductName,
		CompanyName,
		ProductAmount,
		Unit,
		CreatedByID,
		ModifiedByID,
		ModifiedDate,
		CreatedDate,
		HasDeclaration,
		ImportNumber,
		ImportProductName,
		ImportCompanyName,
		ImportProductAmount,
		ImportUnit,
		ImportHasDeclaration,
		ExportType,
		ImportType
	)
	VALUES 
	(
		@Number,
		@ProductName,
		@CompanyName,
		@ProductAmount,
		@Unit,
		@CreatedByID,
		@ModifiedByID,
		@ModifiedDate,
		@CreatedDate,
		@HasDeclaration,
		@ImportNumber,
		@ImportProductName,
		@ImportCompanyName,
		@ImportProductAmount,
		@ImportUnit,
		@ImportHasDeclaration,
		@ExportType,
		@ImportType
	)
	Select @@Identity
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateDeclaration]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Update Declaration
-- =============================================
CREATE PROCEDURE [dbo].[sp_updateDeclaration] 
	-- Add the parameters for the stored procedure here	
    @DeclerationID INT ,
    @Number INT ,
    @ProductName NVARCHAR(250) ,
    @CompanyName NVARCHAR(500) ,
    @ProductAmount NVARCHAR(500) ,
    @Unit NVARCHAR(200) ,
    @ModifiedByID INT ,
    @ModifiedDate DATETIME ,
    @HasDeclaration BIT ,
    @ImportNumber INT ,
    @ImportProductName NVARCHAR(250) ,
    @ImportCompanyName NVARCHAR(500) ,
    @ImportProductAmount NVARCHAR(500) ,
    @ImportUnit NVARCHAR(200) ,
    @ImportHasDeclaration BIT,
    @ImportType nvarchar(200),
	@ExportType nvarchar(200)
AS 
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON ;

    -- Insert statements for procedure here
        UPDATE  tblDeclaration
        SET     Number = @Number ,
                ProductName = @ProductName ,
                CompanyName = @CompanyName ,
                ProductAmount = @ProductAmount ,
                Unit = @Unit ,
                ModifiedByID = @ModifiedByID ,
                ModifiedDate = @ModifiedDate ,
                HasDeclaration = @HasDeclaration ,
                ImportNumber = @ImportNumber ,
                ImportProductName = @ImportProductName ,
                ImportCompanyName = @ImportCompanyName ,
                ImportProductAmount = @ImportProductAmount ,
                ImportUnit = @ImportUnit ,
                ImportHasDeclaration = @ImportHasDeclaration,
                ExportType = @ExportType,
                ImportType = @ImportType
        WHERE   DeclarationID = @DeclerationID
    END
-- SELECT * FROM TBLDECLARATION
-- EXEC [sp_updateDeclaration] 27,1111, 'hello','company','so luong updated','vndong', 1,'10/10/2011'
GO
/****** Object:  StoredProcedure [dbo].[st_IsExistVehicleInDeclaration]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[st_IsExistVehicleInDeclaration]
    @PlateNumber AS NVARCHAR(200) ,
    @DeclarationID AS INT
AS 
    BEGIN
	
	
        SELECT  *
        FROM    dbo.tblVehicle
        WHERE   PlateNumber = @PlateNumber
                AND DeclarationID = @DeclarationID
    END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateVehicle]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Update vehicle 
-- =============================================
CREATE PROCEDURE [dbo].[sp_updateVehicle]
	-- Add the parameters for the stored procedure here
	@VehicleID int,
	@PlateNumber nvarchar(50),
	@NumberOfContainer int,
	@DriverName nvarchar(250),
	@ImportDate datetime,
	@ExportDate datetime,		
	@Status nvarchar(500),
	@Note nvarchar(500),
	@IsExport bit,
	@IsImport bit,
	@IsCompleted bit,
	@ImportedLocalTime datetime,
	@ImportStatus nvarchar(500),
	@HasGoodsImported bit,
	@IsGoodsImported bit,
	@DeclarationID int ,
	@ConfirmImportBy int,
	@ConfirmExportBy int,
	@ConfirmLocalImportBy int
			
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE
		tblVehicle
	SET
		PlateNumber		  = @PlateNumber,
		NumberOfContainer = @NumberOfContainer,
		DriverName        = @DriverName,
		ImportDate        = @ImportDate,
		ExportDate        = @ExportDate,
		Status            = @Status,
		Note              = @Note,
		IsExport          = @IsExport,
		IsImport          = @IsImport,
		IsCompleted       = @IsCompleted,
		ImportedLocalTime = @ImportedLocalTime,
		ImportStatus      = @ImportStatus,
		HasGoodsImported  = @HasGoodsImported,
		IsGoodsImported   = @IsGoodsImported,
        DeclarationID	  = @DeclarationID ,
        ConfirmExportBy = @ConfirmExportBy,
        ConfirmImportBy = @ConfirmImportBy,
        ConfirmLocalImportBy = @ConfirmLocalImportBy
	WHERE
		VehicleID = @VehicleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectVehicleByID]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vuongdd
-- Create date: 10/04/2011
-- Description:	Select Vehicel by Vehicle ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_SelectVehicleByID]
	-- Add the parameters for the stored procedure here
	@VehicleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		*
	FROM
		tblVehicle
	WHERE
		VehicleID = @VehicleID	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectVehicleByDeclarationID]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Get vehicle by DeclarationID
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectVehicleByDeclarationID]
	-- Add the parameters for the stored procedure here
	@DeclarationID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		*
	FROM
		tblVehicle
	WHERE
		DeclarationID = @DeclarationID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_searchVehicle]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2010
-- Description:	Search Vehicle
-- =============================================
CREATE PROCEDURE [dbo].[sp_searchVehicle]
	-- Add the parameters for the stored procedure here		
    @IsCompleted BIT ,
    @PlateNumber NVARCHAR(100) ,
    @ImportFrom DATETIME ,
    @ImportTo DATETIME ,
    @ExportFrom DATETIME ,
    @ExportTo DATETIME ,
    @SearchType INT = 1
AS -- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON ;
    IF @SearchType = 1
        AND @PlateNumber = '' -- Get Vehicle which not import/export
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportBy' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportBy' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportBy'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND IsExport = 0
                    AND IsCompleted = @IsCompleted					
        END
	
    IF @SearchType = 1
        AND @PlateNumber <> '' -- Get Vehicle which not import/export
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportBy' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportBy' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportBy'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND IsExport = 0
                    AND PlateNumber LIKE '%' + @PlateNumber + '%'
                    AND IsCompleted = @IsCompleted									
        END
	
	
    IF @SearchType = 2
        AND @PlateNumber = '' -- Exported and Not Import or Imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportBy' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportBy' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportBy'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND IsExport = 1
                    AND IsCompleted = @IsCompleted					 								
        END	
	
    IF @SearchType = 2
        AND @PlateNumber <> '' -- Exported and Not Import or Imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportBy' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportBy' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportBy'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND IsExport = 1
                    AND PlateNumber LIKE '%' + @PlateNumber + '%'
                    AND IsCompleted = @IsCompleted									
        END	
	
	
    IF @SearchType = 3
        AND @PlateNumber = '' -- Exported and Imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportBy' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportBy' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportBy'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND ImportDate >= @ImportFrom
                    AND ImportDate <= @ImportFrom
                    AND IsExport = 1
                    AND IsImport = 1
                    AND IsCompleted = @IsCompleted										
        END
	
    IF @SearchType = 3
        AND @PlateNumber <> '' -- Exported and Imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportBy' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportBy' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportBy'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND ImportDate >= @ImportFrom
                    AND ImportDate <= @ImportFrom
                    AND IsExport = 1
                    AND IsImport = 1
                    AND PlateNumber LIKE '%' + @PlateNumber + '%'
                    AND IsCompleted = @IsCompleted						
        END
	
	
    IF @SearchType = 4
        AND @PlateNumber = '' -- Exported and not imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportBy' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportBy' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportBy'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND IsExport = 1
                    AND IsImport = 0
                    AND IsCompleted = @IsCompleted												
        END
	
    IF @SearchType = 4
        AND @PlateNumber <> '' -- Exported and not imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportBy' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportBy' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportBy'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND IsExport = 1
                    AND IsImport = 0
                    AND PlateNumber LIKE '%' + @PlateNumber + '%'
                    AND IsCompleted = @IsCompleted								
        END
	
    -- Insert statements for procedure here
-- exec [sp_searchVehicle] '4','10/10/2010','10/10/2010','10/10/2010','10/10/2010', 1
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertVehicle]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 09/04/2011
-- Description:	Insert Vehilce
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertVehicle] 
	-- Add the parameters for the stored procedure here	
	@DeclarationID int,
	@PlateNumber nvarchar(50),
	@NumberOfContainer int,
	@DriverName nvarchar(250),
	@ExportDate datetime,	
	@Note nvarchar(500),
	@Status nvarchar(500),
	@IsExport bit,
	@IsCompleted bit,
	@ImportDate datetime,
	@IsImport bit,
	@IsGoodsImported bit,
	@ConfirmImportBy int,
	@ConfirmExportBy int,
	@ConfirmLocalImportBy int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT 
	INTO tblVehicle 		
	(
		DeclarationID,
		PlateNumber,
		NumberOfContainer,
		DriverName,
		ExportDate,		
		Note,
		Status,
		IsExport,
		IsCompleted,
		ImportDate,
		IsImport,
		IsGoodsImported,
		ConfirmImportBy ,
		ConfirmExportBy ,
		ConfirmLocalImportBy 
	)
	VALUES 
	(
		@DeclarationID,
		@PlateNumber,
		@NumberOfContainer,
		@DriverName,
		@ExportDate,		
		@Note,
		@Status,
		@IsExport,
		@IsCompleted,
		@ImportDate,
		@IsImport,
		@IsGoodsImported,
		@ConfirmImportBy ,
		@ConfirmExportBy ,
		@ConfirmLocalImportBy 
	)
	Select @@Identity
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getVehicleNotImportExport]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2010
-- Description:	Get all Vehicle which not export/Import
-- =============================================
CREATE PROCEDURE [dbo].[sp_getVehicleNotImportExport]
	-- Add the parameters for the stored procedure here	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		*
	FROM
		tblVehicle
	WHERE 
		ExportDate IS NULL	OR 
		ImportDate IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteVehicleByID]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Delete Vehicle by ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_deleteVehicleByID]
	-- Add the parameters for the stored procedure here
	@VehicleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE 
	FROM	
		tblVehicle	
	WHERE
		VehicleID = @VehicleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteDecleration]    Script Date: 05/22/2011 14:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Delete Decleration by ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_deleteDecleration]
	-- Add the parameters for the stored procedure here
	@DeclerationID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- Delete vehicle
	DELETE 
	FROM
		tblVehicle
	WHERE
		DeclarationID = @DeclerationID
		
	-- Delete Decleration
	DELETE
	FROM	
		tblDeclaration
	WHERE
		DeclarationID = @DeclerationID
END
GO
/****** Object:  Default [DF_tblVehicle_ExportDate]    Script Date: 05/22/2011 14:28:06 ******/
ALTER TABLE [dbo].[tblVehicle] ADD  CONSTRAINT [DF_tblVehicle_ExportDate]  DEFAULT (((1)/(1))/(1900)) FOR [ExportDate]
GO
/****** Object:  ForeignKey [FK_tblDeclaration_tblUser]    Script Date: 05/22/2011 14:28:06 ******/
ALTER TABLE [dbo].[tblDeclaration]  WITH CHECK ADD  CONSTRAINT [FK_tblDeclaration_tblUser] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[tblUser] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblDeclaration] CHECK CONSTRAINT [FK_tblDeclaration_tblUser]
GO
/****** Object:  ForeignKey [FK_tblVehicle_tblDeclaration]    Script Date: 05/22/2011 14:28:06 ******/
ALTER TABLE [dbo].[tblVehicle]  WITH CHECK ADD  CONSTRAINT [FK_tblVehicle_tblDeclaration] FOREIGN KEY([DeclarationID])
REFERENCES [dbo].[tblDeclaration] ([DeclarationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblVehicle] CHECK CONSTRAINT [FK_tblVehicle_tblDeclaration]
GO
