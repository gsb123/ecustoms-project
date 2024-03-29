USE [dbECostoms]
GO
/****** Object:  User [sb]    Script Date: 04/26/2011 15:46:43 ******/
CREATE USER [sb] FOR LOGIN [sb] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 04/26/2011 15:46:46 ******/
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
SET IDENTITY_INSERT [dbo].[tblUser] ON
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (1, N'minh', 1, CAST(0x00009D8D00000000 AS DateTime), N'minh', N'minh@gmail.com', N'2222', N'vuongdd', N'vuongdd', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (2, N'Do Khac MInh', NULL, NULL, N'Ha Noi', N'minhvuong@yhaoo.comn', N'0987777', N'minh', N'minh', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (3, N'Admin', NULL, NULL, N'Hà Nội', N'vuongfat@gmail.com', N'(098) 447 33 99', N'admin', N'admin', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (4, N'Nhân viên nhập thông tin', NULL, NULL, N'Lạng sơn', N'nhanvien@yahoo.com', N'098888888', N'nhanvien', N'nhanvien', 1, 1)
SET IDENTITY_INSERT [dbo].[tblUser] OFF
/****** Object:  Table [dbo].[tblPermission]    Script Date: 04/26/2011 15:46:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPermission](
	[PermissionID] [int] NULL,
	[Permission] [nvarchar](250) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblPermission] ([PermissionID], [Permission]) VALUES (1, N'Nhân viên')
INSERT [dbo].[tblPermission] ([PermissionID], [Permission]) VALUES (2, N'Quản trị')
/****** Object:  Table [dbo].[tblDeclaration]    Script Date: 04/26/2011 15:46:46 ******/
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
	[ImpotUnit] [nvarchar](200) NULL,
	[ImportHasDeclaration] [bit] NULL,
 CONSTRAINT [PK_tblDeclaration] PRIMARY KEY CLUSTERED 
(
	[DeclarationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblDeclaration] ON
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImpotUnit], [ImportHasDeclaration]) VALUES (122, 1, N'1', N'1', N'1', N'1', 3, 3, CAST(0x00009ED0017D48EE AS DateTime), CAST(0x00009ED0017D4BF8 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImpotUnit], [ImportHasDeclaration]) VALUES (123, 1, N'1', N'1', N'1', N'1', 3, 3, CAST(0x00009ED0017DCD0C AS DateTime), CAST(0x00009ED0017DCDE6 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImpotUnit], [ImportHasDeclaration]) VALUES (124, 1, N'1', N'1', N'1', N'1', 3, 3, CAST(0x00009ED10001C3DC AS DateTime), CAST(0x00009ED10001C476 AS DateTime), 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImpotUnit], [ImportHasDeclaration]) VALUES (125, 1, N'1', N'to khai moi', N'1', N'1', 3, 3, CAST(0x00009ED100062C39 AS DateTime), CAST(0x00009ED100062D3E AS DateTime), 1, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblDeclaration] OFF
/****** Object:  StoredProcedure [dbo].[sp_deleteUser]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetUser]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SelectAllUser]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_selectAllPermission]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_updateUser]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_insertUser]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SelectUserByID]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_countUserByUserName]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  Table [dbo].[tblVehicle]    Script Date: 04/26/2011 15:46:51 ******/
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
 CONSTRAINT [PK_tblVehicle] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblVehicle] ON
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted]) VALUES (98, 122, N'1', 0, N'1', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'1', N'1', 0)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted]) VALUES (99, 123, N'1', 0, N'1', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'1', N'1', 0)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted]) VALUES (100, 123, N'2', 2, N'2', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'2', N'2', 0)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted]) VALUES (101, 123, N'3', 3, N'3', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'3', N'3', 0)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted]) VALUES (102, 124, N'1', 0, N'1', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'1', N'1', 0)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted]) VALUES (103, 125, N'1', 0, N'1', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'1', N'1', 0)
SET IDENTITY_INSERT [dbo].[tblVehicle] OFF
/****** Object:  StoredProcedure [dbo].[sp_selectDeclerationByID]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_selectDecleration]    Script Date: 04/26/2011 15:46:51 ******/
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
		ProductName,
		CompanyName,
		ProductAmount,
		Unit,
		ModifiedDate,
		tblUser.Name,
		CreatedDate
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
/****** Object:  StoredProcedure [dbo].[sp_InsertDeclaration]    Script Date: 04/26/2011 15:46:51 ******/
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
	@HasDeclaration bit 
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
		HasDeclaration
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
		@HasDeclaration
	)
	Select @@Identity
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateDeclaration]    Script Date: 04/26/2011 15:46:51 ******/
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
	@DeclerationID int,
	@Number int,
	@ProductName nvarchar(250),
	@CompanyName nvarchar(500),
	@ProductAmount nvarchar(500),
	@Unit nvarchar(200),	
	@ModifiedByID int,
	@ModifiedDate datetime,
	@HasDeclaration bit	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE
		tblDeclaration 		
	SET
		Number		  = @Number,
		ProductName   = @ProductName,
		CompanyName	  = @CompanyName,
		ProductAmount = @ProductAmount,
		Unit          = @Unit,
		ModifiedByID  = @ModifiedByID,
		ModifiedDate  = @ModifiedDate,
		HasDeclaration = @HasDeclaration
	WHERE
		DeclarationID = @DeclerationID
END
-- SELECT * FROM TBLDECLARATION
-- EXEC [sp_updateDeclaration] 27,1111, 'hello','company','so luong updated','vndong', 1,'10/10/2011'
GO
/****** Object:  StoredProcedure [dbo].[sp_updateVehicle]    Script Date: 04/26/2011 15:46:51 ******/
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
	@IsCompleted bit
			
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
		IsCompleted       = @IsCompleted
	WHERE
		VehicleID = @VehicleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectVehicleByID]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_selectVehicleByDeclarationID]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_getVehicleNotImportExport]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_searchVehicle]    Script Date: 04/26/2011 15:46:51 ******/
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
	@IsCompleted bit,
	@PlateNumber nvarchar(100),
	@ImportFrom datetime,
	@ImportTo datetime,
	@ExportFrom datetime,
	@ExportTo datetime,
	@SearchType int = 1		
AS
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF @SearchType = 1 AND @PlateNumber = '' -- Get Vehicle which not import/export
		BEGIN
			SELECT 
				Number,
				ProductName,
				CompanyName,
				ProductAmount,
				Unit,
				VehicleID,
				tblVehicle.DeclarationID,
				PlateNumber,
				NumberOfContainer,
				DriverName,
				ImportDate,
				ExportDate,				
				Note,
				Status		
			FROM
				tblVehicle,
				tblDeclaration
			WHERE
				tblVehicle.DeclarationID = tblDeclaration.DeclarationID AND
				IsExport = 0 AND
				IsCompleted = @IsCompleted					
	END
	
	IF @SearchType = 1 AND @PlateNumber <> '' -- Get Vehicle which not import/export
		BEGIN
			SELECT 
				Number,
				ProductName,
				CompanyName,
				ProductAmount,
				Unit,
				VehicleID,
				tblVehicle.DeclarationID,
				PlateNumber,
				NumberOfContainer,
				DriverName,
				ImportDate,
				ExportDate,				
				Note,
				Status		
			FROM
				tblVehicle,
				tblDeclaration
			WHERE
				tblVehicle.DeclarationID = tblDeclaration.DeclarationID AND
				IsExport = 0 AND
				PlateNumber like '%' + @PlateNumber + '%'	 AND
				IsCompleted = @IsCompleted									
	END
	
	
	IF @SearchType = 2  AND @PlateNumber = '' -- Exported and Not Import or Imported
		BEGIN
			SELECT 
				Number,
				ProductName,
				CompanyName,
				ProductAmount,
				Unit,
				VehicleID,
				tblVehicle.DeclarationID,
				PlateNumber,
				NumberOfContainer,
				DriverName,
				ImportDate,
				ExportDate,				
				Note,
				Status		
			FROM
				tblVehicle,
				tblDeclaration
			WHERE
				tblVehicle.DeclarationID = tblDeclaration.DeclarationID AND
				ExportDate >= @ExportFrom AND
				ExportDate <= @ExportTo AND
				IsExport = 1 AND
				IsCompleted = @IsCompleted					 								
	END	
	
	IF @SearchType = 2  AND @PlateNumber <> '' -- Exported and Not Import or Imported
		BEGIN
			SELECT 
				Number,
				ProductName,
				CompanyName,
				ProductAmount,
				Unit,
				VehicleID,
				tblVehicle.DeclarationID,
				PlateNumber,
				NumberOfContainer,
				DriverName,
				ImportDate,
				ExportDate,				
				Note,
				Status		
			FROM
				tblVehicle,
				tblDeclaration
			WHERE
				tblVehicle.DeclarationID = tblDeclaration.DeclarationID AND
				ExportDate >= @ExportFrom AND
				ExportDate <= @ExportTo AND
				IsExport = 1 AND
				PlateNumber like '%' + @PlateNumber + '%' AND
				IsCompleted = @IsCompleted									
	END	
	
	
	IF @SearchType = 3 AND @PlateNumber = '' -- Exported and Imported
		BEGIN
			SELECT 
				Number,
				ProductName,
				CompanyName,
				ProductAmount,
				Unit,
				VehicleID,
				tblVehicle.DeclarationID,
				PlateNumber,
				NumberOfContainer,
				DriverName,
				ImportDate,
				ExportDate,				
				Note,
				Status			
			FROM
				tblVehicle,
				tblDeclaration
			WHERE
				tblVehicle.DeclarationID = tblDeclaration.DeclarationID AND
				ExportDate >= @ExportFrom AND
				ExportDate <= @ExportTo AND
				ImportDate >= @ImportFrom AND
				ImportDate <= @ImportFrom AND
				IsExport = 1 AND
				IsImport = 1 AND
				IsCompleted = @IsCompleted										
	END
	
	IF @SearchType = 3 AND @PlateNumber <> '' -- Exported and Imported
		BEGIN
			SELECT 
				Number,
				ProductName,
				CompanyName,
				ProductAmount,
				Unit,
				VehicleID,
				tblVehicle.DeclarationID,
				PlateNumber,
				NumberOfContainer,
				DriverName,
				ImportDate,
				ExportDate,				
				Note,
				Status			
			FROM
				tblVehicle,
				tblDeclaration
			WHERE
				tblVehicle.DeclarationID = tblDeclaration.DeclarationID AND
				ExportDate >= @ExportFrom AND
				ExportDate <= @ExportTo AND
				ImportDate >= @ImportFrom AND
				ImportDate <= @ImportFrom AND
				IsExport = 1 AND
				IsImport = 1 AND
				PlateNumber like '%' + @PlateNumber + '%' AND
				IsCompleted = @IsCompleted						
	END
	
	
	IF @SearchType = 4 AND @PlateNumber = '' -- Exported and not imported
		BEGIN
			SELECT 
				Number,
				ProductName,
				CompanyName,
				ProductAmount,
				Unit,
				VehicleID,
				tblVehicle.DeclarationID,
				PlateNumber,
				NumberOfContainer,
				DriverName,
				ImportDate,
				ExportDate,				
				Note,
				Status		
			FROM
				tblVehicle,
				tblDeclaration
			WHERE
				tblVehicle.DeclarationID = tblDeclaration.DeclarationID AND
				ExportDate >= @ExportFrom AND
				ExportDate <= @ExportTo AND
				IsExport = 1 AND
				IsImport = 0 AND
				IsCompleted = @IsCompleted												
	END
	
	IF @SearchType = 4 AND @PlateNumber <> '' -- Exported and not imported
		BEGIN
			SELECT 
				Number,
				ProductName,
				CompanyName,
				ProductAmount,
				Unit,
				VehicleID,
				tblVehicle.DeclarationID,
				PlateNumber,
				NumberOfContainer,
				DriverName,
				ImportDate,
				ExportDate,				
				Note,
				Status		
			FROM
				tblVehicle,
				tblDeclaration
			WHERE
				tblVehicle.DeclarationID = tblDeclaration.DeclarationID AND
				ExportDate >= @ExportFrom AND
				ExportDate <= @ExportTo AND
				IsExport = 1 AND
				IsImport = 0 AND
				PlateNumber like '%' + @PlateNumber + '%' AND
				IsCompleted = @IsCompleted								
	END
	
    -- Insert statements for procedure here
-- exec [sp_searchVehicle] '4','10/10/2010','10/10/2010','10/10/2010','10/10/2010', 1
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertVehicle]    Script Date: 04/26/2011 15:46:51 ******/
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
	@IsImport bit	
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
		IsImport
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
		@IsImport
	)
	Select @@Identity
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteVehicleByID]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_deleteDecleration]    Script Date: 04/26/2011 15:46:51 ******/
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
/****** Object:  Default [DF_tblVehicle_ExportDate]    Script Date: 04/26/2011 15:46:51 ******/
ALTER TABLE [dbo].[tblVehicle] ADD  CONSTRAINT [DF_tblVehicle_ExportDate]  DEFAULT (((1)/(1))/(1900)) FOR [ExportDate]
GO
/****** Object:  ForeignKey [FK_tblDeclaration_tblUser]    Script Date: 04/26/2011 15:46:46 ******/
ALTER TABLE [dbo].[tblDeclaration]  WITH CHECK ADD  CONSTRAINT [FK_tblDeclaration_tblUser] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[tblUser] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblDeclaration] CHECK CONSTRAINT [FK_tblDeclaration_tblUser]
GO
/****** Object:  ForeignKey [FK_tblVehicle_tblDeclaration]    Script Date: 04/26/2011 15:46:51 ******/
ALTER TABLE [dbo].[tblVehicle]  WITH CHECK ADD  CONSTRAINT [FK_tblVehicle_tblDeclaration] FOREIGN KEY([DeclarationID])
REFERENCES [dbo].[tblDeclaration] ([DeclarationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblVehicle] CHECK CONSTRAINT [FK_tblVehicle_tblDeclaration]
GO
