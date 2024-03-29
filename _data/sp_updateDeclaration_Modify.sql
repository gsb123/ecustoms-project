set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Update Declaration
-- =============================================
ALTER PROCEDURE [dbo].[sp_updateDeclaration] 
	-- Add the parameters for the stored procedure here	
	@DeclerationID int,
	@Number int,
	@ProductName nvarchar(250),
	@CompanyName nvarchar(500),
	@ProductAmount nvarchar(500),
	@Unit nvarchar(200),	
	@ModifiedByID int,
	@ModifiedDate datetime,
	@HasDeclaration bit,
	@ImportNumber int,
	@ImportProductName nvarchar(250),
	@ImportCompanyName nvarchar(500),
	@ImportProductAmount nvarchar(500),
	@ImportUnit nvarchar(200),	
	@ImportHasDeclaration bit	
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
		HasDeclaration = @HasDeclaration,
		ImportNumber		  = @Number,
		ImportProductName   = @ImportProductName,
		ImportCompanyName	  = @ImportCompanyName,
		ImportProductAmount = @ImportProductAmount,
		ImportUnit          = @ImportUnit,
		ImportHasDeclaration = @ImportHasDeclaration
	WHERE
		DeclarationID = @DeclerationID
END
-- SELECT * FROM TBLDECLARATION
-- EXEC [sp_updateDeclaration] 27,1111, 'hello','company','so luong updated','vndong', 1,'10/10/2011'


