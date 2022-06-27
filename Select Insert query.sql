USE ZYX
GO

--SELECT * FROM TheTestAnswerTbl
--SELECT * FROM QuestionTbl
--SELECT * FROM QuestionSheetTbl
--SELECT * FROM QuestionSheetQuestionTbl
--SELECT * FROM TheTestTbl
--UPDATE TheTestAnswerTbl SET Submitted = 0
--UPDATE TheTestTbl SET [Status] = 0
--DELETE QuestionSheetQuestionTbl
--DELETE QuestionSheetTbl
--DELETE QuestionTbl
--DELETE StudentTbl
--DELETE SubjectTbl
--DELETE TheTestTbl
--DELETE TheTestAnswerTbl
--SELECT * FROM QuestionSheetQuestionTbl WHERE [QuestionSheetId] = 5 AND [deleted] is null
-- SELECT Id, Used FROM QuestionTbl WHERE Id IN ( SELECT QuestionId FROM QuestionSheetQuestionTbl WHERE QuestionSheetId = 5)