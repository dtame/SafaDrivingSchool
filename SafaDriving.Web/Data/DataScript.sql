DROP TABLE IF EXISTS [dbo].[DrivingPrograms]	
GO
CREATE TABLE [dbo].[DrivingPrograms](
		[ID] INT PRIMARY KEY IDENTITY,
		[NAME] VARCHAR(80) NOT NULL,
		[PRICE] DECIMAL(10,2) NOT NULL
	)
GO

INSERT INTO [dbo].[DrivingPrograms](NAME, PRICE)
VALUES ('RSEP (Complete Driving Course)', 699)
	 , ('Highway Driving Session (3 hours)', 300)
	 , ('Downtown Driving Session (2 hours)', 300)
	 , ('Winter Driving Session (6 hours)', 300)
	 , ('Extra Car-Session (6 hours/12 hours)', 300)
	 , ('Road test preparation in Dorval, Longueil & Henri-Bourassa (3 hours)', 300)


INSERT INTO [dbo].[AspNetRoles](Id, Name, NormalizedName)
VALUES('1', 'Student','Student')
	 ,('2', 'Instructor','Instructor')
	 ,('3', 'Admin','Admin')

/****************************** Paiement ******************************/
DROP TABLE IF EXISTS [dbo].[Paiements]	
GO
CREATE TABLE [dbo].[Paiements](
	[ID] INT PRIMARY KEY IDENTITY,
	[StudentID] INT NOT NULL,
	[DueDate] DateTime not null,
	[TimeStamp] DateTime null,
	[Amount] Decimal not null,
	[PaiementDone] bit not null default 0,
	[Description] Varchar(100) null
)

/***************************** Phase ****************************/
DROP TABLE IF EXISTS [dbo].[Phases]	
GO
CREATE TABLE [dbo].[Phases](
	[ID] INT PRIMARY KEY IDENTITY,
    [NAME] VARCHAR(80) NOT NULL,
	[Description] Varchar(100) null,
	[Seq] INT NOT NULL,
	[ProgramID] INT NOT NULL FOREIGN KEY REFERENCES (DrivingPrograms.ID)
)
GO

/************** course schedule ******************************/
DROP TABLE IF EXISTS [dbo].[CourseSchedules]	
GO
CREATE TABLE [dbo].[CourseSchedules](
	[CourseScheduleID] INT PRIMARY KEY IDENTITY,
	[StudentID] INT NOT NULL FOREIGN KEY REFERENCES (AspNetUsers.ID),
	[HasLearnersLicence] BIT NOT NULL DEFAULT 0
)


/************************** EventSchedule *************/
DROP TABLE IF EXISTS [dbo].[EventSchedules]	
GO
CREATE TABLE [dbo].[EventSchedule](
	[ID] INT PRIMARY KEY IDENTITY,
	[EventDate] Datetime not null,
	[Description] Varchar(100) null,
	[CanBeModifyByOthers] BIT NOT NULL DEFAULT 0,
	[CourseScheduleID] INT not null foreign key references (CourseSchedules.CourseScheduleID)
)

/************************  CourseEvent ***************/
DROP TABLE IF EXISTS [dbo].[CourseEvents]	
GO
CREATE TABLE [dbo].[CourseEvent](
	[ID] INT PRIMARY KEY IDENTITY,
	[Date] Datetime null,
	[Description] Varchar(100) null,
	[CanBeModifyByOthers] BIT NOT NULL Default 0,
	[StudentID] INT not null FOREIGN KEY REFERENCES (AspNetUsers.Id),
	[CourseID] INT not null FOREIGN KEY REFERENCES (Courses.ID),
	[Status] INT not null,
	[AssignToId] INT null,
	[InitById] INT null,
)