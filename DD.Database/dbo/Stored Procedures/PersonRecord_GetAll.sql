-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PersonRecord_GetAll]
	@PersonId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select ID
			, PersonId
			, RecordTime
			, Insulin
			, Carbohydrates
			, BloodGloucoseBgm
			, BloodGloucoseCgm
			, BloodGloucoseCgmRaw
			, Note
	from [dbo].[PersonRecord]

END
