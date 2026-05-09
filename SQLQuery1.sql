USE [p2869415]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_FilterByCustomerID]
		@CustomerID = 1

SELECT	@return_value as 'Return Value'

GO
