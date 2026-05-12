USE [p2869415]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblProduct_FilterByProductID]
		@ProductID = 1

SELECT	@return_value as 'Return Value'

GO
