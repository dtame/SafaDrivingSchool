--DROP TABLE IF EXISTS [dbo].[DrivingPrograms]	
--GO

--CREATE TABLE [dbo].[DrivingPrograms](
--		[ID] INT PRIMARY KEY IDENTITY,
--		[NAME] VARCHAR(80) NOT NULL,
--		[PRICE] DECIMAL(10,2) NOT NULL
--	)
--GO
--/***************************** Phase ****************************/
--DROP TABLE IF EXISTS [dbo].[Phases]	
--GO
--CREATE TABLE [dbo].[Phases](
--	[ID] INT PRIMARY KEY IDENTITY,
--    [NAME] VARCHAR(10) NOT NULL,
--	[Description] Varchar(100) null,
--	[Seq] INT NOT NULL,
--	[ProgramID] INT NOT NULL FOREIGN KEY REFERENCES DrivingPrograms(ID)
--)
--/* Courses*/
--DROP TABLE IF EXISTS [dbo].[Courses]
--GO
--CREATE TABLE [dbo].[Courses](
--	[ID] INT PRIMARY KEY IDENTITY,
--	[SeqNumber] INT NOT NULL,
--	[Title] Varchar(30) NOT NULL,
--	[Type] INT NOT NULL,
--	[PhaseId] INT NOT NULL FOREIGN KEY REFERENCES Phases(ID)
--)

/* insert values */
DECLARE @programId int 
DECLARE @phaseId int

INSERT INTO [dbo].[DrivingPrograms](NAME, PRICE) VALUES ('RSEP (Complete Driving Course)', 699)
SET @programId = (select scope_Identity())

INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 1', 'RSEP Phase 1', 1, @programId)
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'The Vehicle', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(2, 'The Driver', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(3, 'The Environment', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(4, 'At-Risk Behaviours', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(5, 'Evaluation', 1, @phaseId)

INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 2', 'RSEP Phase 2', 1, @programId)
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'Accompagnied Driving', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(2, 'In-Car Session 1', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(3, 'In-Car Session 2', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(4, 'OEA Strategy', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(5, 'In-Car Session 3', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(6, 'In-Car Session 4', 2, @phaseId)


INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 3', 'RSEP Phase 3', 1, @programId)
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'Speed', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(2, 'In-Car Session 5', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(3, 'In-Car Session 6', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(4, 'Sharing the Road', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(5, 'In-Car Session 7', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(6, 'In-Car Session 8', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(7, 'Alcohol and Drugs', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(8, 'In-Car Session 9', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(9, 'In-Car Session 10', 2, @phaseId)


INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 4', 'RSEP Phase 4', 1, @programId)
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'Fatigue and Distractions', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(2, 'In-Car Session 11', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(3, 'In-Car Session 12', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(4, 'Eco-Driving', 1, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(5, 'In-Car Session 13', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(6, 'In-Car Session 14', 2, @phaseId)
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(6, 'In-Car Session 15', 2, @phaseId)
------------------------
INSERT INTO [dbo].[DrivingPrograms](NAME, PRICE) VALUES('Highway Driving Session (3 hours)', 300)
SET @programId = (select scope_Identity())
INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 1', 'Highway Driving Session Phase 1', 1, @programId)	
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'Highway Driving Session', 2, @phaseId)
------------------------
INSERT INTO [dbo].[DrivingPrograms](NAME, PRICE) VALUES ('Downtown Driving Session (2 hours)', 300)
SET @programId = (select scope_Identity())
INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 1', 'Downtown Driving Session Phase 1', 1, @programId)	
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'Downtown Driving Session', 2, @phaseId)
------------------------
INSERT INTO [dbo].[DrivingPrograms](NAME, PRICE) VALUES ('Winter Driving Session (6 hours)', 300)
SET @programId = (select scope_Identity())
INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 1', 'Winter Driving Session Phase 1', 1, @programId)	
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'Winter Driving Session', 2, @phaseId)
------------------------
INSERT INTO [dbo].[DrivingPrograms](NAME, PRICE) VALUES ('Extra Car-Session (6 hours/12 hours)', 300)
SET @programId = (select scope_Identity())
INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 1', 'Extra Car-Session Phase 1', 1, @programId)	
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'Extra Car-Session', 2, @phaseId)
------------------------
INSERT INTO [dbo].[DrivingPrograms](NAME, PRICE) VALUES ('Road test preparation in Dorval, Longueil & Henri-Bourassa (3 hours)', 300)
SET @programId = (select scope_Identity())
INSERT INTO [dbo].[Phases]([Name], [Description], [Seq], [ProgramId]) VALUES ('Phase 1', 'Road test preparation Phase 1', 1, @programId)	
SET @phaseId = (select scope_Identity())
INSERT INTO [dbo].[Courses]([SeqNumber], [Title], [Type], [PhaseId])VALUES(1, 'Road test preparation', 2, @phaseId)
------------------------
GO

INSERT INTO [dbo].[AspNetRoles]([Id], [Name], [NormalizedName])
VALUES(1, 'Student','Student')
	 ,(2, 'Instructor','Instructor')
	 ,(3, 'Admin','Admin')

/****************************** Paiement ******************************/
--DROP TABLE IF EXISTS [dbo].[Paiements]	
--GO
--CREATE TABLE [dbo].[Paiements](
--	[ID] INT PRIMARY KEY IDENTITY,
--	[StudentID] INT NOT NULL,
--	[DueDate] DateTime not null,
--	[TimeStamp] DateTime null,
--	[Amount] Decimal not null,
--	[PaiementDone] bit not null default 0,
--	[Description] Varchar(100) null
--)



/************** course schedule ******************************/
--DROP TABLE IF EXISTS [dbo].[CourseSchedules]	
--GO
--CREATE TABLE [dbo].[CourseSchedules](
--	[CourseScheduleID] INT PRIMARY KEY IDENTITY,
--	[StudentID] INT NOT NULL FOREIGN KEY REFERENCES AspNetUsers(Id),
--	[HasLearnersLicence] BIT NOT NULL DEFAULT 0
--)


/************************** EventSchedule *************/
--DROP TABLE IF EXISTS [dbo].[EventSchedules]	
--GO
--CREATE TABLE [dbo].[EventSchedule](
--	[ID] INT PRIMARY KEY IDENTITY,
--	[EventDate] Datetime not null,
--	[Description] Varchar(100) null,
--	[CanBeModifyByOthers] BIT NOT NULL DEFAULT 0,
--	[CourseScheduleID] INT not null foreign key references CourseSchedules(CourseScheduleID)
--)

/************************  CourseEvent ***************/
--DROP TABLE IF EXISTS [dbo].[CourseEvents]	
--GO
--CREATE TABLE [dbo].[CourseEvent](
--	[ID] INT PRIMARY KEY IDENTITY,
--	[Date] Datetime null,
--	[Description] Varchar(100) null,
--	[CanBeModifyByOthers] BIT NOT NULL Default 0,
--	[StudentID] INT not null FOREIGN KEY REFERENCES AspNetUsers(Id),
--	[CourseID] INT not null FOREIGN KEY REFERENCES Courses(ID),
--	[Status] INT not null,
--	[AssignToId] INT null,
--	[InitById] INT null,
--)