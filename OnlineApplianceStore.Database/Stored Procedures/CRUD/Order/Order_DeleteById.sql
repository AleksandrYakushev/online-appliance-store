﻿--CREATE PROCEDURE [dbo].[Order_DeleteById]
--@ID BIGINT
--As
--	UPDATE dbo.[Order]
--	SET 
--	IsDeleted = 1
--	WHERE (Id = @ID)