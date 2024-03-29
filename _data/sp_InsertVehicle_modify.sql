set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 09/04/2011
-- Description:	Insert Vehilce
-- =============================================
ALTER PROCEDURE [dbo].[sp_InsertVehicle] 
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
	@IsGoodsImported bit
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
		IsGoodsImported
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
		@IsGoodsImported
	)
	Select @@Identity
END

