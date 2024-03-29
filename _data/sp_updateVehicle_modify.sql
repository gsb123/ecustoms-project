set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Update vehicle 
-- =============================================
ALTER PROCEDURE [dbo].[sp_updateVehicle]
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
	@IsGoodsImported bit
			
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
		IsGoodsImported   = @IsGoodsImported
	WHERE
		VehicleID = @VehicleID
END

