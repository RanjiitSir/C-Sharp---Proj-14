-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Customer_Bill]
	-- Add the parameters for the stored procedure here
	@Cust_ID int = 1001
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Customer_Details cd
	inner join Customer_Purchase_Details cpd on cd.Customer_ID = cpd.Customer_ID
	WHERE cd.Customer_ID = @Cust_ID
END