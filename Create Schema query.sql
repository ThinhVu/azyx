USE MASTER
GO
-- CREATE DATABASE
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ZYX')
BEGIN
    CREATE DATABASE ZYX
END
GO

USE ZYX
GO

IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'TeacherTbl' AND [type]='U')
CREATE TABLE [TeacherTbl]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Username] NVARCHAR(20),
	[Password] NVARCHAR(20)
)
GO

INSERT INTO [TeacherTbl]([Username], [Password]) VALUES ('root', '132456')
GO

IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'ClassTbl' AND [type] = 'U')
CREATE TABLE [ClassTbl]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Alias] NVARCHAR(100),
	[Name] NVARCHAR(100),
	[AdditionInfo] NVARCHAR(300)
)
GO

-- CREATE StudentTbl
IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'StudentTbl' AND [type] = 'U')
CREATE TABLE [StudentTbl]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[ClassId] INT NOT NULL,
	[Alias] NVARCHAR(100),
	[Name] NVARCHAR(50),
	[Email] NVARCHAR(100),
	[PhoneNumber] NVARCHAR(16),	
	[AdditionInfo] NVARCHAR(200),
	[UserName] NVARCHAR(30),
	[Password] NVARCHAR(30)
)
GO

-- CREATE SubjectTbl
IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'SubjectTbl' AND [type] = 'U')
CREATE TABLE [SubjectTbl]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[Alias] NVARCHAR(100),
	[Name] NVARCHAR(50),
	[AdditionInfo] NVARCHAR(200)
)
GO

-- CREATE QuestionTbl
IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'QuestionTbl' AND [type] = 'U')
CREATE TABLE [QuestionTbl]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[QuestionSheetId] INT NOT NULL,
	[Content] NVARCHAR(MAX),
	[A] NVARCHAR(MAX),
	[B] NVARCHAR(MAX),
	[C] NVARCHAR(MAX),
	[D] NVARCHAR(MAX),
	[Guide] NVARCHAR(MAX),
	[ShuffleAnswer] BIT,
	[CorrectAnswer] INT
)
GO
-- CREATE QuestionSheetTbl
IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'QuestionSheetTbl' AND [type] = 'U')
CREATE TABLE [QuestionSheetTbl]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[SubjectId] INT NOT NULL,
	[Alias] NVARCHAR(100),
	[TestTime] INT DEFAULT(60) NOT NULL,
	[AdditionInfo] NVARCHAR(200),
	[Used] BIT DEFAULT(0)
)
GO
---- CREATE QuestionSheetQuestionTbl
--IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'QuestionSheetQuestionTbl' AND [type] = 'U')
--CREATE TABLE [QuestionSheetQuestionTbl]
--(
--	[Id] INT PRIMARY KEY IDENTITY,
--	[QuestionSheetId] INT NOT NULL,
--	[QuestionId] INT NOT NULL,
--	[Deleted] BIT
--)
--GO

-- CREATE TestTbl
IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'TheTestTbl' AND [type] = 'U')
CREATE TABLE [TheTestTbl]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[SubjectId] INT NOT NULL,
	[QuestionSheetId] INT NOT NULL,
	[Alias] NVARCHAR(100),
	[Name] NVARCHAR(50),
	[CreatedDate] DATETIME,
	[AdditionInfo] NVARCHAR(200),
	[Status] INT
)
GO

-- CREATE TestAnswerTbl
IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'TheTestResultTbl' AND [type] = 'U')
CREATE TABLE [TheTestResultTbl]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[StudentId] INT NOT NULL, 
	[TheTestId] INT NOT NULL,
	[AnswerSheet] NVARCHAR(MAX),
	[Correct] INT, -- counter
	[Incorrect] INT, -- counter
	[NotDone] INT, -- counter
	[TimeSpent] INT, -- minutes
	[Submitted] BIT
)
GO