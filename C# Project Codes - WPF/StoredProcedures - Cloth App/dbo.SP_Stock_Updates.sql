-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Stock_Updates]
	-- Add the parameters for the stored procedure here
	@Month int,
	@Year int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	Select * From Stock_Updates where Month(Stock_Added_Date) = @Month And Year(Stock_Added_Date) = @Year
END