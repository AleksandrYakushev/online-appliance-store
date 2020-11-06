CREATE PROCEDURE [dbo].[Order_SelectAll]
	@Id int
	as
	select *
	From dbo.[Order]
	where id = id