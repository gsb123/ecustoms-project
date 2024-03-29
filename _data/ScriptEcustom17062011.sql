USE [dbEcustom]
GO
/****** Object:  User [tth-giamsat2]    Script Date: 06/17/2011 21:05:26 ******/
CREATE USER [tth-giamsat2] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[tth-giamsat2]
GO
/****** Object:  User [gs]    Script Date: 06/17/2011 21:05:26 ******/
CREATE USER [gs] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [tth-giamsat2]    Script Date: 06/17/2011 21:05:26 ******/
CREATE SCHEMA [tth-giamsat2] AUTHORIZATION [tth-giamsat2]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 06/17/2011 21:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] [varchar](255) NOT NULL,
	[Level] [varchar](50) NOT NULL,
	[Logger] [varchar](255) NOT NULL,
	[Message] [varchar](4000) NOT NULL,
	[Exception] [varchar](2000) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Log] ON
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (1, CAST(0x00009F0300A01FDD AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (2, CAST(0x00009F0300A02535 AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (3, CAST(0x00009F0300A025F8 AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (4, CAST(0x00009F0300A026FD AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (5, CAST(0x00009F0300A0277F AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (6, CAST(0x00009F0300A02CC4 AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (7, CAST(0x00009F0300A02D19 AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (8, CAST(0x00009F03016DAB23 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (9, CAST(0x00009F030171807A AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (10, CAST(0x00009F030171E7A8 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (13, CAST(0x00009F04010B3E10 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (14, CAST(0x00009F04011A61B2 AS DateTime), N'11', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (15, CAST(0x00009F04011E1CEF AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (16, CAST(0x00009F04011E9EF2 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (17, CAST(0x00009F04011FEAC2 AS DateTime), N'11', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (18, CAST(0x00009F04015D2B83 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (19, CAST(0x00009F04015D2F63 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (20, CAST(0x00009F04015D3213 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (21, CAST(0x00009F04015D326F AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (22, CAST(0x00009F0401603975 AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (23, CAST(0x00009F04016A7003 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (24, CAST(0x00009F04016B4876 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (25, CAST(0x00009F04016DCAF7 AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (26, CAST(0x00009F04016E257C AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (27, CAST(0x00009F04016E2B6D AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (31, CAST(0x00009F04016F3FB9 AS DateTime), N'11', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (32, CAST(0x00009F04016F835A AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (33, CAST(0x00009F0401712A37 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (34, CAST(0x00009F040171817A AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (35, CAST(0x00009F04017258DD AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (36, CAST(0x00009F0401725C5F AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (37, CAST(0x00009F040172FF8E AS DateTime), N'11', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (38, CAST(0x00009F0401749E5C AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (39, CAST(0x00009F04017559D2 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (40, CAST(0x00009F0401765520 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (41, CAST(0x00009F040177140D AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (42, CAST(0x00009F04017780A5 AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (43, CAST(0x00009F040177AAE3 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (44, CAST(0x00009F040178C3AB AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (46, CAST(0x00009F04017B007B AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (47, CAST(0x00009F04017B2537 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (48, CAST(0x00009F04017CAF57 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (49, CAST(0x00009F04017CC14E AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (50, CAST(0x00009F04017CC1BA AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (51, CAST(0x00009F04017CC229 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (52, CAST(0x00009F04017CC2A6 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (53, CAST(0x00009F04017CC33B AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (54, CAST(0x00009F04017CC3F0 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (55, CAST(0x00009F04017CC450 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (56, CAST(0x00009F04017CC4A9 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (57, CAST(0x00009F04017CE941 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (58, CAST(0x00009F04017D6FDC AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (59, CAST(0x00009F04017DA71A AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (60, CAST(0x00009F04017DBFF6 AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (61, CAST(0x00009F04017DC015 AS DateTime), N'9', N'ERROR', N'Ecustoms.frmDecleration', N'System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection.
Parameter name: index
   at System.Collections.ArrayList.get_Item(Int32 index)
   at System.Windows.Forms.DataGridViewRowCollection.SharedRow(Int32 rowIndex)
   at System.Windows.Forms.DataGridViewRowCollection.get_Item(Int32 index)
   at ECustoms.frmDecleration.grvDecleration_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e) in D:\Working\ECUstoms\SourceCode\ECustoms\frmDecleration.cs:line 280', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (62, CAST(0x00009F04017DC0DA AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (63, CAST(0x00009F04017DC0E0 AS DateTime), N'9', N'ERROR', N'Ecustoms.frmDecleration', N'System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection.
Parameter name: index
   at System.Collections.ArrayList.get_Item(Int32 index)
   at System.Windows.Forms.DataGridViewRowCollection.SharedRow(Int32 rowIndex)
   at System.Windows.Forms.DataGridViewRowCollection.get_Item(Int32 index)
   at ECustoms.frmDecleration.grvDecleration_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e) in D:\Working\ECUstoms\SourceCode\ECustoms\frmDecleration.cs:line 280', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (64, CAST(0x00009F04017DC18E AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (65, CAST(0x00009F04017DC196 AS DateTime), N'9', N'ERROR', N'Ecustoms.frmDecleration', N'System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection.
Parameter name: index
   at System.Collections.ArrayList.get_Item(Int32 index)
   at System.Windows.Forms.DataGridViewRowCollection.SharedRow(Int32 rowIndex)
   at System.Windows.Forms.DataGridViewRowCollection.get_Item(Int32 index)
   at ECustoms.frmDecleration.grvDecleration_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e) in D:\Working\ECUstoms\SourceCode\ECustoms\frmDecleration.cs:line 280', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (66, CAST(0x00009F04017DD0BA AS DateTime), N'9', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (67, CAST(0x00009F04017DD0C2 AS DateTime), N'9', N'ERROR', N'Ecustoms.frmDecleration', N'System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection.
Parameter name: index
   at System.Collections.ArrayList.get_Item(Int32 index)
   at System.Windows.Forms.DataGridViewRowCollection.SharedRow(Int32 rowIndex)
   at System.Windows.Forms.DataGridViewRowCollection.get_Item(Int32 index)
   at ECustoms.frmDecleration.grvDecleration_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e) in D:\Working\ECUstoms\SourceCode\ECustoms\frmDecleration.cs:line 280', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (68, CAST(0x00009F04017E1A1A AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (69, CAST(0x00009F04017ED6E3 AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (70, CAST(0x00009F04017FECEF AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (71, CAST(0x00009F04018387C1 AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (73, CAST(0x00009F0401888DDC AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (74, CAST(0x00009F04018A3461 AS DateTime), N'8', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (75, CAST(0x00009F04018B3916 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (76, CAST(0x00009F0500BC709D AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (77, CAST(0x00009F0500BCE265 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (82, CAST(0x00009F0500D2D82F AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (83, CAST(0x00009F0500D2DBE8 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (11, CAST(0x00009F03017268C2 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (12, CAST(0x00009F030175AB83 AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (72, CAST(0x00009F040184DC33 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (78, CAST(0x00009F0500CE585E AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (79, CAST(0x00009F0500CF0A5A AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (84, CAST(0x00009F0500D2F398 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (85, CAST(0x00009F0500D2F806 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (110, CAST(0x00009F050103C141 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (111, CAST(0x00009F0501076874 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (112, CAST(0x00009F050107ADF2 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (113, CAST(0x00009F0501084D85 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (114, CAST(0x00009F05010B1C0E AS DateTime), N'8', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (115, CAST(0x00009F05011B772C AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (28, CAST(0x00009F04016E7F3A AS DateTime), N'10', N'ERROR', N'Ecustoms.frmDecleration', N'System.NotSupportedException: LINQ to Entities does not recognize the method ''System.String ToString()'' method, and this method cannot be translated into a store expression.
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.DefaultTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateIntoCanonicalFunction(String functionName, Expression linqExpression, Expression[] linqArguments)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.BinaryTranslator.TypedTranslate(ExpressionConverter parent, BinaryExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.BinaryTranslator.TypedTranslate(ExpressionConverter parent, BinaryExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateLambda(LambdaExpression lambda, DbExpression input)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateLambda(LambdaExpression lambda, DbExpression input, DbExpressionBinding& binding)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator.Translate(ExpressionConverter parent, MethodCallExpression call, DbExpression& source, DbExpressionBinding& sourceBinding, DbExpression& lambda)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator.Translate(ExpressionConverter parent, MethodCallExpression call, SequenceMethod sequenceMethod)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.Convert()
   at System.Data.Objects.ELinq.ELinqQueryState.GetExecutionPlan(Nullable`1 forMergeOption)
   at System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   at System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at ECustoms.BOL.DeclarationBOL.Search(String number, String companyName) in D:\Working\ECUstoms\SourceCode\ECustoms.BOL\DeclarationBOL.cs:line 197
   at ECustoms.frmDecleration.BindSearch() in D:\Working\ECUstoms\SourceCode\ECustoms\frm', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (29, CAST(0x00009F04016E84F2 AS DateTime), N'10', N'ERROR', N'Ecustoms.frmDecleration', N'System.NotSupportedException: LINQ to Entities does not recognize the method ''System.String ToString()'' method, and this method cannot be translated into a store expression.
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.DefaultTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateIntoCanonicalFunction(String functionName, Expression linqExpression, Expression[] linqArguments)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.BinaryTranslator.TypedTranslate(ExpressionConverter parent, BinaryExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.BinaryTranslator.TypedTranslate(ExpressionConverter parent, BinaryExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateLambda(LambdaExpression lambda, DbExpression input)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateLambda(LambdaExpression lambda, DbExpression input, DbExpressionBinding& binding)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator.Translate(ExpressionConverter parent, MethodCallExpression call, DbExpression& source, DbExpressionBinding& sourceBinding, DbExpression& lambda)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator.Translate(ExpressionConverter parent, MethodCallExpression call, SequenceMethod sequenceMethod)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.Convert()
   at System.Data.Objects.ELinq.ELinqQueryState.GetExecutionPlan(Nullable`1 forMergeOption)
   at System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   at System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at ECustoms.BOL.DeclarationBOL.Search(String number, String companyName) in D:\Working\ECUstoms\SourceCode\ECustoms.BOL\DeclarationBOL.cs:line 197
   at ECustoms.frmDecleration.BindSearch() in D:\Working\ECUstoms\SourceCode\ECustoms\frm', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (30, CAST(0x00009F04016E8CB1 AS DateTime), N'10', N'ERROR', N'Ecustoms.frmDecleration', N'System.NotSupportedException: LINQ to Entities does not recognize the method ''System.String ToString()'' method, and this method cannot be translated into a store expression.
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.DefaultTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateIntoCanonicalFunction(String functionName, Expression linqExpression, Expression[] linqArguments)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.BinaryTranslator.TypedTranslate(ExpressionConverter parent, BinaryExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.BinaryTranslator.TypedTranslate(ExpressionConverter parent, BinaryExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateLambda(LambdaExpression lambda, DbExpression input)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateLambda(LambdaExpression lambda, DbExpression input, DbExpressionBinding& binding)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator.Translate(ExpressionConverter parent, MethodCallExpression call, DbExpression& source, DbExpressionBinding& sourceBinding, DbExpression& lambda)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator.Translate(ExpressionConverter parent, MethodCallExpression call)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator.Translate(ExpressionConverter parent, MethodCallExpression call, SequenceMethod sequenceMethod)
   at System.Data.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TypedTranslate(ExpressionConverter parent, MethodCallExpression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TypedTranslator`1.Translate(ExpressionConverter parent, Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.TranslateExpression(Expression linq)
   at System.Data.Objects.ELinq.ExpressionConverter.Convert()
   at System.Data.Objects.ELinq.ELinqQueryState.GetExecutionPlan(Nullable`1 forMergeOption)
   at System.Data.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   at System.Data.Objects.ObjectQuery`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at ECustoms.BOL.DeclarationBOL.Search(String number, String companyName) in D:\Working\ECUstoms\SourceCode\ECustoms.BOL\DeclarationBOL.cs:line 197
   at ECustoms.frmDecleration.BindSearch() in D:\Working\ECUstoms\SourceCode\ECustoms\frm', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (45, CAST(0x00009F04017AC758 AS DateTime), N'9', N'ERROR', N'Ecustoms.frmLogin', N'System.OutOfMemoryException: Error creating window handle. ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ECustoms.frmDecleration.<>c__DisplayClass1.<BindData>b__0(tblDeclaration d) in D:\Working\ECUstoms\SourceCode\ECustoms\frmDecleration.cs:line 105
   at System.Linq.Enumerable.WhereListIterator`1.MoveNext()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at ECustoms.frmDecleration.BindData() in D:\Working\ECUstoms\SourceCode\ECustoms\frmDecleration.cs:line 105
   at ECustoms.frmDecleration.frmDecleration_Load(Object sender, EventArgs e) in D:\Working\ECUstoms\SourceCode\ECustoms\frmDecleration.cs:line 48
   at System.Windows.Forms.Form.OnLoad(EventArgs e)
   at System.Windows.Forms.Form.OnCreateControl()
   at System.Windows.Forms.Control.CreateControl(Boolean fIgnoreVisible)
   at System.Windows.Forms.Control.CreateControl()
   at System.Windows.Forms.Control.WmShowWindow(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ScrollableControl.WndProc(Message& m)
   at System.Windows.Forms.ContainerControl.WndProc(Message& m)
   at System.Windows.Forms.Form.WmShowWindow(Message& m)
   at System.Windows.Forms.Form.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.DebuggableCallback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)
   at System.Windows.Forms.UnsafeNativeMethods.IntCreateWindowEx(Int32 dwExStyle, String lpszClassName, String lpszWindowName, Int32 style, Int32 x, Int32 y, Int32 width, Int32 height, HandleRef hWndParent, HandleRef hMenu, HandleRef hInst, Object pvParam)
   at System.Windows.Forms.UnsafeNativeMethods.CreateWindowEx(Int32 dwExStyle, String lpszClassName, String lpszWindowName, Int32 style, Int32 x, Int32 y, Int32 width, Int32 height, HandleRef hWndParent, HandleRef hMenu, HandleRef hInst, Object pvParam)
   at System.Windows.Forms.NativeWindow.CreateHandle(CreateParams cp)
   --- End of inner exception stack trace ---
   at System.Windows.Forms.NativeWindow.CreateHandle(CreateParams cp)
   at System.Windows.Forms.Control.CreateHandle()
   at System.Windows.Forms.Form.CreateHandle()
   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Form.SetVisibleCore(Boolean value)
   at System.Windows.Forms.Control.Show()
   at ECustoms.frmMainForm.InitData() in D:\Working\ECUstoms\SourceCode\ECustoms\frmMainForm.cs:line 48
   at ECustoms.frmMainForm.frmMainForm_Load(Object sender, EventArgs e) in D:\Working\ECUstoms\SourceCode\ECustoms\frmMainForm.cs:line 30
   at System.Windows.Forms.Form.OnLoad(EventArgs e)
   at System.Windows.Forms.Form.OnCreateControl()
   at System.Windows.Forms.Control.CreateControl(Boolean fIgnoreVisible)
   at System.Windows.Forms.Control.CreateControl()
   at System.Windows.Forms.Control.WmShowWindow(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ScrollableControl.WndProc(Message& m)
   at System.Windows.Forms.ContainerControl.WndProc(Message& m)
   at System.Windows.Forms.Form.WmShowWindow(Message& m)
   at System.Windows.Forms.Form.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.DebuggableCallback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)
   at System.Windows.Forms.UnsafeNativeMethods.SendMessage(HandleRef hWnd, Int32 msg, Int32 wParam, Int32 lParam)
   at System.Windows.Forms.Form.SetVisibleCore(Boolean value)
   at System.Windows.Forms.Control.Show()
   at ECustoms.frmLogin.txtPassword_KeyPress(Object sender, KeyPressEventArgs e) in D:\Working\ECUst', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (80, CAST(0x00009F0500CFB227 AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (81, CAST(0x00009F0500D044DE AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (86, CAST(0x00009F0500D5B938 AS DateTime), N'9', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (87, CAST(0x00009F0500D7614C AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (88, CAST(0x00009F0500D7643E AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (89, CAST(0x00009F0500D7649D AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (90, CAST(0x00009F0500D764F1 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (91, CAST(0x00009F0500D76542 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (92, CAST(0x00009F0500D783F5 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (93, CAST(0x00009F0500D985A7 AS DateTime), N'10', N'INFO', N'Ecustoms.frmLogin', N'txtPassword_KeyPress', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (94, CAST(0x00009F0500D98958 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
GO
print 'Processed 100 total records'
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (95, CAST(0x00009F0500D989C4 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (96, CAST(0x00009F0500D98A34 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (97, CAST(0x00009F0500D98A9D AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (98, CAST(0x00009F0500D98B04 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (99, CAST(0x00009F0500D98B61 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (100, CAST(0x00009F0500D99A91 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (101, CAST(0x00009F0500DA0DF4 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (102, CAST(0x00009F0500DA935F AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (103, CAST(0x00009F0500DA950B AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (104, CAST(0x00009F0500DA9566 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (105, CAST(0x00009F0500DA95C6 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (106, CAST(0x00009F0500DA966B AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (107, CAST(0x00009F0500DA96D1 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (108, CAST(0x00009F0501027E81 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (109, CAST(0x00009F05010280A4 AS DateTime), N'10', N'INFO', N'Ecustoms.frmDecleration', N'grvDecleration_CellMouseClick', N'')
SET IDENTITY_INSERT [dbo].[Log] OFF
/****** Object:  Table [dbo].[tblUser]    Script Date: 06/17/2011 21:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Sex] [int] NULL,
	[Birthday] [datetime] NULL,
	[Address] [nvarchar](300) NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](300) NULL,
	[PermissionID] [int] NULL,
	[IsActive] [int] NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblUser] ON
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (3, N'Admin', NULL, NULL, N'Hà Nội', N'vuongfat@gmail.com', N'(098) 447 33 99', N'admin', N'21-23-2F-29-7A-57-A5-A7-43-89-4A-0E-4A-80-1F-C3', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (7, N'Lương Văn Chung', NULL, NULL, N'HQTT', N'chunglv@lscustoms.gov.vn', N'0904791618', N'chunglv', N'85-5D-84-76-6C-60-3A-17-FD-44-C1-56-0E-8A-7C-90', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (8, N'Hoàng Huy Hưởng', NULL, NULL, N'', N'huonghh@lscustoms.gov.vn', N'', N'huonghh', N'62-06-9C-0A-51-01-47-66-77-45-1D-67-0F-89-56-44', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (9, N'Lê Tiến Mạnh', NULL, NULL, N'', N'manhlt@lscustoms.gov.vn', N'', N'manhlt', N'3A-B4-9F-37-2D-CD-C9-AF-27-10-77-C6-CF-1D-0E-4F', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (11, N'Vũ Quân', NULL, NULL, N'', N'Quan@lscustoms.gov.vn', N'', N'Quan', N'17-4D-04-DF-4E-1F-69-CD-59-E3-24-A7-E3-8C-95-2F', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (12, N'Hoàng Văn Đoàn', NULL, NULL, N'', N'doanhv@lscustoms.gov.vn', N'', N'doanhv', N'DF-FA-22-30-F8-BB-5D-98-55-D6-7E-08-BC-1D-B5-CC', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (13, N'Đinh Mạnh Thắng', NULL, NULL, N'HQTT', N'thangdm@lscustoms.gov.vn', N'', N'thangdm', N'AC-55-20-C2-E2-52-8A-49-2F-FB-E1-E9-99-46-09-43', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (14, N'Nguyễn Công Thành', NULL, NULL, N'', N'thanhnc@lscustoms.gov.vn', N'', N'thanhnc', N'C4-CA-42-38-A0-B9-23-82-0D-CC-50-9A-6F-75-84-9B', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (15, N'Hứa Quang Huy', NULL, NULL, N'', N'huyhq@lscustoms.gov.vn', N'', N'huyhq', N'18-9D-83-E3-DD-DF-7F-0F-8F-52-FD-26-7B-39-4E-51', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (17, N'Dương Hải Đăng', NULL, NULL, N'', N'dangdh@lscustoms.gov.vn', N'', N'dangdh', N'A6-B9-37-4F-72-74-25-B9-F4-21-01-D3-5F-6C-51-6D', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (18, N'Nguyễn Duy Thương', NULL, NULL, N'', N'thuongnd@lscustoms.gov.vn', N'', N'thuongnd', N'CD-95-2A-F6-D4-60-7A-78-B1-64-29-F6-42-E8-31-0B', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (19, N'Nguyễn Đình Thái', NULL, NULL, N'', N'thaind@lscustoms.gov.vn', N'', N'thaind', N'47-35-89-3F-7A-7A-13-DF-8B-43-3A-FA-65-1E-61-8B', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (20, N'Nguyễn Tuấn Nghĩa', NULL, NULL, N'', N'nghiant@lscustoms.gov.vn', N'', N'nghiant', N'3D-54-5B-F0-20-7C-1E-8A-71-CF-5B-F0-44-70-43-35', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (21, N'Vũ Mạnh Tuyền', NULL, NULL, N'', N'tuyenvm@lscustoms.gov.vn', N'', N'tuyenvm', N'D9-7B-BE-E1-CE-81-05-FC-D6-6C-D4-6E-A8-50-9E-B1', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (22, N'Dương Công Thới', NULL, NULL, N'HQTT', N'thoidc@lscustoms.gov.vn', N'0914566888', N'thoidc', N'8D-D9-72-D3-5A-7E-E0-4F-D5-64-94-08-09-97-F0-4A', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (23, N'Lâm Việt Cường', NULL, NULL, N'HQTT', N'cuonglv@lscustoms.gov.vn', N'', N'cuonglv', N'3D-99-39-1F-BB-BF-91-23-5C-1A-9F-86-2B-DD-44-86', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (24, N'Phạm Văn Hùng', NULL, NULL, N'', N'hungpv@lscustoms.gov.vn', N'', N'hungpv', N'5A-84-25-13-99-11-14-70-B1-30-C9-3E-03-DE-CB-6D', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (25, N'Nguyễn Kim Chung', NULL, NULL, N'', N'chungnk@lscustoms.gov.vn', N'', N'chungnk', N'1E-60-AB-55-5E-AC-4A-67-9E-E5-15-1B-8D-7E-DB-2B', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (26, N'Tô Hoài Nam', NULL, NULL, N'HQTT', N'namth@lscustoms.gov.vn', N'', N'namth', N'72-4A-6A-8D-48-0E-FB-56-7A-D7-90-DE-74-59-59-C0', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (27, N'Phan Văn Chương', NULL, NULL, N'', N'chuongpv@lscustoms.gov.vn', N'', N'chuongpv', N'DE-B5-4F-FB-41-E0-85-FD-7F-69-A7-5B-63-59-C9-89', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (28, N'Nguyễn Trường Sơn', NULL, NULL, N'HQTT', N'sonnt@lscustoms.gov.vn', N'', N'sonnt', N'FB-50-1A-29-C0-BD-35-83-90-FB-76-2D-C9-AF-2C-2E', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (29, N'Cao Anh Tú', NULL, NULL, N'', N'tuca@lscustoms.gov.vn', N'', N'tuca', N'1B-1C-9C-9E-8E-19-9C-BA-6A-E1-6E-9F-AA-BA-43-84', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (30, N'Đỗ Trần Ánh', NULL, NULL, N'', N'anhdt@lscustoms.gov.vn', N'', N'anhdt', N'2C-C1-63-CD-8B-7A-A6-6A-9A-84-5D-C5-37-59-8D-CC', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (31, N'Hoàng Tuấn Phương', NULL, NULL, N'HQTT', N'phuonght@lscustoms.gov.vn', N'', N'phuonght', N'53-89-E5-E1-CA-A8-49-38-CB-A4-28-DB-D8-90-1D-A5', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (32, N'Ngô Hiệp', NULL, NULL, N'', N'hiep@lscustoms.gov.vn', N'', N'hiep', N'80-53-92-44-9A-0D-73-0A-A2-49-A4-F0-A5-B0-0D-2B', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (33, N'Nguyễn Quang Duy', NULL, NULL, N'HQTT', N'duynq@lscustoms.gov.vn', N'', N'duynq', N'1F-9F-F3-3F-70-80-81-16-16-D3-A2-4F-6C-D7-2B-54', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (34, N'Đặng Anh Vinh', NULL, NULL, N'HQTT', N'vinhda@lscustoms.gov.vn', N'', N'vinhda', N'E0-04-06-14-4C-1E-7E-35-24-0A-FE-D7-0F-34-16-6A', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (35, N'Nguyễn Cấp Tiến', NULL, NULL, N'HQTT', N'tiennc@lscustoms.gov.vn', N'', N'tiennc', N'08-CD-6B-12-71-B9-6D-A9-21-E3-EC-6C-A8-23-45-A4', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (36, N'Nguyen the long', NULL, NULL, N'tan my tan thanh', N'longnt@lscustom.gov.vn', N'', N'longnt', N'E1-0A-DC-39-49-BA-59-AB-BE-56-E0-57-F2-0F-88-3E', 3, 1)
INSERT [dbo].[tblUser] ([UserID], [Name], [Sex], [Birthday], [Address], [Email], [PhoneNumber], [UserName], [Password], [PermissionID], [IsActive]) VALUES (37, N'Nguyễn Hồng Hạnh', NULL, NULL, N'HQTT', N'hanhnh1@lscustoms.gov.vn', N'0919241103', N'hanhnh', N'AC-70-22-21-5B-D5-73-8C-6B-1B-32-A8-79-FA-90-6A', 3, 1)
SET IDENTITY_INSERT [dbo].[tblUser] OFF
/****** Object:  Table [dbo].[tblPermission]    Script Date: 06/17/2011 21:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPermission](
	[PermissionID] [int] NULL,
	[Permission] [nvarchar](250) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblPermission] ([PermissionID], [Permission]) VALUES (1, N'Xác nhận giám sát')
INSERT [dbo].[tblPermission] ([PermissionID], [Permission]) VALUES (2, N'Quản trị')
INSERT [dbo].[tblPermission] ([PermissionID], [Permission]) VALUES (3, N'Nhập liệu')
/****** Object:  Table [dbo].[tblDeclaration]    Script Date: 06/17/2011 21:05:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDeclaration](
	[DeclarationID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NULL,
	[ProductName] [nvarchar](250) NULL,
	[CompanyName] [nvarchar](500) NULL,
	[ProductAmount] [nvarchar](500) NULL,
	[Unit] [nvarchar](200) NULL,
	[CreatedByID] [int] NULL,
	[ModifiedByID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[HasDeclaration] [bit] NULL,
	[CompanyCode] [nvarchar](500) NULL,
	[RegisterDate] [datetime] NULL,
	[ImportProductName] [nvarchar](500) NULL,
	[ImportCompanyName] [nvarchar](500) NULL,
	[ImportProductAmount] [nvarchar](500) NULL,
	[ImportUnit] [nvarchar](500) NULL,
	[ImportHasDeclaration] [bit] NULL,
	[ImportNumber] [int] NULL,
	[ImportType] [nvarchar](500) NULL,
	[ExportType] [nvarchar](500) NULL,
	[ImportCompanyCode] [nvarchar](500) NULL,
	[ImportRegisterDate] [datetime] NULL,
 CONSTRAINT [PK_tblDeclaration] PRIMARY KEY CLUSTERED 
(
	[DeclarationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblDeclaration] ON
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [CompanyCode], [RegisterDate], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImportUnit], [ImportHasDeclaration], [ImportNumber], [ImportType], [ExportType], [ImportCompanyCode], [ImportRegisterDate]) VALUES (689, 1111, N'ten hang xuat updtaed
updated', N'ten doanh nghiep xuatupdated', N'luong hang xuat updated', N'don vi tinh xaut updated', 3, 3, CAST(0x00009F0501083842 AS DateTime), CAST(0x00009F01016B282B AS DateTime), 1, N'ma doanh nghiep xuatupdated', CAST(0x00009F1200DBA86C AS DateTime), N'ten hang nhap updated', N'ten doanh ngeip nhap updted', N'luong hang nhap upted', N'do vi tinh nhp upted', 1, 1212, N'loai hinh nhap updated', N'loai hinh xuatupdated', N'ma dn xuat updated', CAST(0x00009F0500DBA948 AS DateTime))
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [CompanyCode], [RegisterDate], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImportUnit], [ImportHasDeclaration], [ImportNumber], [ImportType], [ExportType], [ImportCompanyCode], [ImportRegisterDate]) VALUES (690, 0, N'', N'', N'', N'', 3, 3, CAST(0x00009F010170E594 AS DateTime), CAST(0x00009F010170E597 AS DateTime), 0, NULL, NULL, N'', N'', N'', N'', 1, 0, N'', N'', NULL, NULL)
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [CompanyCode], [RegisterDate], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImportUnit], [ImportHasDeclaration], [ImportNumber], [ImportType], [ExportType], [ImportCompanyCode], [ImportRegisterDate]) VALUES (691, 1313, N'ten hang', N'doanh nghie', N'luong hangd', N'don vi tinh', 3, 3, CAST(0x00009F02018B7F91 AS DateTime), CAST(0x00009F02018B7F94 AS DateTime), 1, NULL, NULL, N'', N'', N'', N'', 1, 0, N'', N'lai hinh', NULL, NULL)
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [CompanyCode], [RegisterDate], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImportUnit], [ImportHasDeclaration], [ImportNumber], [ImportType], [ExportType], [ImportCompanyCode], [ImportRegisterDate]) VALUES (692, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [CompanyCode], [RegisterDate], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImportUnit], [ImportHasDeclaration], [ImportNumber], [ImportType], [ExportType], [ImportCompanyCode], [ImportRegisterDate]) VALUES (693, 1, N'', N'', N'', N'', NULL, 3, CAST(0x00009F04011EAB76 AS DateTime), NULL, 1, NULL, NULL, N'', N'', N'', N'', 1, NULL, N'', N'', NULL, NULL)
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [CompanyCode], [RegisterDate], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImportUnit], [ImportHasDeclaration], [ImportNumber], [ImportType], [ExportType], [ImportCompanyCode], [ImportRegisterDate]) VALUES (694, 1, N'ten hang
do dinh', N'1', N'luong hang', N'don vi tinh', 3, 3, CAST(0x00009F04015D80A1 AS DateTime), NULL, 1, N'ma doanh nghiep', CAST(0x00009F04015D3469 AS DateTime), N'asdf', N'import doanh nghiep', N'asf', N'sadf', 1, 2, N'importloai hinh', N'1', N'import ma doanh', CAST(0x00009F04015D3462 AS DateTime))
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [CompanyCode], [RegisterDate], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImportUnit], [ImportHasDeclaration], [ImportNumber], [ImportType], [ExportType], [ImportCompanyCode], [ImportRegisterDate]) VALUES (695, 1, N'', N'', N'', N'', 3, 3, CAST(0x00009F0401606A4E AS DateTime), NULL, 1, N'', CAST(0x00009F040160506D AS DateTime), N'', N'', N'', N'', 1, NULL, N'', N'', N'', CAST(0x00009F0401605067 AS DateTime))
INSERT [dbo].[tblDeclaration] ([DeclarationID], [Number], [ProductName], [CompanyName], [ProductAmount], [Unit], [CreatedByID], [ModifiedByID], [ModifiedDate], [CreatedDate], [HasDeclaration], [CompanyCode], [RegisterDate], [ImportProductName], [ImportCompanyName], [ImportProductAmount], [ImportUnit], [ImportHasDeclaration], [ImportNumber], [ImportType], [ExportType], [ImportCompanyCode], [ImportRegisterDate]) VALUES (696, 33, N'', N'', N'', N'', 3, 3, CAST(0x00009F04016084A1 AS DateTime), NULL, 1, N'', CAST(0x00009F0C01605030 AS DateTime), N'', N'', N'', N'', 1, NULL, N'', N'', N'', CAST(0x00009F0401605067 AS DateTime))
SET IDENTITY_INSERT [dbo].[tblDeclaration] OFF
/****** Object:  StoredProcedure [dbo].[sp_SelectAllUser]    Script Date: 06/17/2011 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Select all usres
-- =============================================
CREATE PROCEDURE [dbo].[sp_SelectAllUser]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		UserID,
		Name,
		Sex,
		Birthday, 
		Address,
		Email,
		PhoneNumber,
		UserName,
		Password,
		Permission,
		IsActive
	FROM
		tblUser, tblPermission
	WHERE tblUser.permissionID = tblPermission.PermissionID
END
-- exec [sp_SelectAllUser]
GO
/****** Object:  StoredProcedure [dbo].[sp_selectAllPermission]    Script Date: 06/17/2011 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 12/04/2011
-- Description:	Get all Permission
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectAllPermission]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		*
	FROM
		tblPermission
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateUser]    Script Date: 06/17/2011 21:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 12/04/2011
-- Description:	Update User
-- =============================================
CREATE PROCEDURE [dbo].[sp_updateUser]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(500),		
	@Address nvarchar(300),
	@Email nvarchar(100),
	@PhoneNumber varchar(20),
	@UserName nvarchar(50),
	@Password nvarchar(300),
	@PermissionID int,	
	@IsActive int,
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE
		tblUser
	SET
		Name = @Name,
		Address = @Address,
		Email = @Email,
		PhoneNumber = @PhoneNumber,
		UserName = @UserName,
		Password = @Password,
		PermissionID = @PermissionID,
		IsActive = @IsActive
	WHERE
		UserID = @UserID
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetNameById]    Script Date: 06/17/2011 21:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_GetNameById] (@UserId int)
RETURNS NVARCHAR(500)
WITH EXECUTE AS CALLER
AS
BEGIN
     DECLARE @Name NVARCHAR(500);
		SELECT @Name = Name FROM tblUser as a WHERE a.UserId = @UserId
     RETURN(@Name);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteUser]    Script Date: 06/17/2011 21:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vuongdd
-- Create date: 14/04/2011
-- Description:	Delete user by UserID
-- =============================================
CREATE PROCEDURE [dbo].[sp_deleteUser]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE 
	FROM
		tblUser
	WHERE
		UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetUser]    Script Date: 06/17/2011 21:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 09/04/2011
-- Description:	Get user by username, password
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetUser]
	-- Add the parameters for the stored procedure here
	@UserName nvarchar(50),
	@Password nvarchar(300)		
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		UserName,
		Name,
		Email,
		Address,
		PhoneNumber,
		PermissionID,
		IsActive,
		UserID
	FROM 
		tblUser
	WHERE
		UserName = @UserName
	AND
		Password = @Password 
	AND
		IsActive = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertUser]    Script Date: 06/17/2011 21:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Add user
-- =============================================
CREATE PROCEDURE [dbo].[sp_insertUser]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(500),		
	@Address nvarchar(300),
	@Email nvarchar(100),
	@PhoneNumber varchar(20),
	@UserName nvarchar(50),
	@Password nvarchar(300),
	@PermissionID int,	
	@IsActive int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblUser
		(
			[Name]			           
           ,[Address]
           ,[Email]
           ,[PhoneNumber]
           ,[UserName]
           ,[Password]
           ,[PermissionID]           
           ,[IsActive]
        )
     VALUES
		(
			@Name,					
			@Address,
			@Email,
			@PhoneNumber,
			@UserName,
			@Password,
			@PermissionID,			
			@IsActive
        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_countUserByUserName]    Script Date: 06/17/2011 21:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 12/04/2011
-- Description:	Count user by Username
-- =============================================
CREATE PROCEDURE [dbo].[sp_countUserByUserName]
	-- Add the parameters for the stored procedure here
	@UserName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		COUNT(*)
	FROM
		tblUser
	WHERE
		UserName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectUserByID]    Script Date: 06/17/2011 21:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 12/04/2011
-- Description:	Get UserByID
-- =============================================
CREATE PROCEDURE [dbo].[sp_SelectUserByID]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		*
	FROM
		tblUser
	WHERE
		UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectDeclerationByID]    Script Date: 06/17/2011 21:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2010
-- Description:	Get Decleration by ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectDeclerationByID]
	-- Add the parameters for the stored procedure here
	@DeclarationID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		* 
	FROM
		tblDeclaration
	WHERE
		DeclarationID = @DeclarationID;
END

-- EXEC [sp_selectDeclerationByID] 27
-- select * from tblDeclaration
GO
/****** Object:  StoredProcedure [dbo].[sp_selectDecleration]    Script Date: 06/17/2011 21:05:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2010
-- Description:	Get Decleration
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectDecleration]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		DeclarationID,
		Number,
		ImportNumber,
		ProductName,
		ImportProductName,
		CompanyName,
		ImportCompanyName,
		ProductAmount,
		ImportProductAmount,
		Unit,
		ImportUnit,
		ModifiedDate,
		tblUser.Name,
		CreatedDate,
		ExportType,
		ImportType
	FROM
		tblDeclaration,
		tblUser
	WHERE
		tblUser.UserID = tblDeclaration.CreatedByID
		ORDER BY ModifiedDate DESC
END


-- exec [sp_selectDecleration]
-- select * from tblDeclaration order by ModifiedDate DESC
GO
/****** Object:  View [dbo].[ViewAllDeclaration]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewAllDeclaration]
AS
SELECT     dbo.tblDeclaration.DeclarationID, dbo.tblDeclaration.Number, dbo.tblDeclaration.ProductName, dbo.tblDeclaration.CompanyName, dbo.tblDeclaration.ProductAmount, 
                      dbo.tblDeclaration.Unit, dbo.tblDeclaration.CreatedByID, dbo.tblDeclaration.ModifiedByID, dbo.tblDeclaration.ModifiedDate, dbo.tblDeclaration.CreatedDate, 
                      dbo.tblDeclaration.HasDeclaration, dbo.tblDeclaration.CompanyCode, dbo.tblDeclaration.RegisterDate, dbo.tblDeclaration.ImportProductName, 
                      dbo.tblDeclaration.ImportCompanyName, dbo.tblDeclaration.ImportProductAmount, dbo.tblDeclaration.ImportUnit, dbo.tblDeclaration.ImportHasDeclaration, 
                      dbo.tblDeclaration.ImportNumber, dbo.tblDeclaration.ImportType, dbo.tblDeclaration.ExportType, dbo.tblDeclaration.ImportCompanyCode, 
                      dbo.tblDeclaration.ImportRegisterDate, tblUser_1.UserID, tblUser_1.Name, tblUser_1.UserName AS CreatedBy,
                          (SELECT     UserName
                            FROM          dbo.tblUser
                            WHERE      (UserID = dbo.tblDeclaration.ModifiedByID)) AS ModifiedBy
FROM         dbo.tblDeclaration INNER JOIN
                      dbo.tblUser AS tblUser_1 ON dbo.tblDeclaration.CreatedByID = tblUser_1.UserID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[15] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblDeclaration"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 318
               Right = 239
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblUser_1"
            Begin Extent = 
               Top = 6
               Left = 271
               Bottom = 265
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 28
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewAllDeclaration'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewAllDeclaration'
GO
/****** Object:  Table [dbo].[tblVehicle]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblVehicle](
	[VehicleID] [int] IDENTITY(1,1) NOT NULL,
	[DeclarationID] [int] NULL,
	[PlateNumber] [varchar](50) NULL,
	[NumberOfContainer] [int] NULL,
	[DriverName] [nvarchar](250) NULL,
	[ImportDate] [datetime] NULL,
	[IsImport] [bit] NULL,
	[ExportDate] [datetime] NULL,
	[IsExport] [bit] NULL,
	[Note] [nvarchar](500) NULL,
	[Status] [nvarchar](500) NULL,
	[IsCompleted] [bit] NULL,
	[IsGoodsImported] [bit] NULL,
	[ImportStatus] [nvarchar](500) NULL,
	[ImportedLocalTime] [datetime] NULL,
	[HasGoodsImported] [bit] NULL,
	[ConfirmImportBy] [int] NULL,
	[ConfirmExportBy] [int] NULL,
	[ConfirmLocalImportBy] [int] NULL,
 CONSTRAINT [PK_tblVehicle] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblVehicle] ON
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted], [IsGoodsImported], [ImportStatus], [ImportedLocalTime], [HasGoodsImported], [ConfirmImportBy], [ConfirmExportBy], [ConfirmLocalImportBy]) VALUES (1868, 689, N'bks', 2, N'ten lai xe', CAST(0x00009F0501083200 AS DateTime), 1, CAST(0x00009F0501082952 AS DateTime), 1, N'ghi chu', N'trang thaisaf', 1, 1, N'Nhập cảnh không có hàng', CAST(0x00009F01016E8358 AS DateTime), 0, 3, 3, 3)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted], [IsGoodsImported], [ImportStatus], [ImportedLocalTime], [HasGoodsImported], [ConfirmImportBy], [ConfirmExportBy], [ConfirmLocalImportBy]) VALUES (1869, 690, N'bsk', 0, N'ten laix e', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N' ghi chu', N'dien gia', 0, 0, NULL, NULL, NULL, 0, 0, 0)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted], [IsGoodsImported], [ImportStatus], [ImportedLocalTime], [HasGoodsImported], [ConfirmImportBy], [ConfirmExportBy], [ConfirmLocalImportBy]) VALUES (1870, 691, N'bks2', 0, N'k', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'k', N'k', 0, 0, NULL, NULL, NULL, 0, 0, 0)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted], [IsGoodsImported], [ImportStatus], [ImportedLocalTime], [HasGoodsImported], [ConfirmImportBy], [ConfirmExportBy], [ConfirmLocalImportBy]) VALUES (1871, 691, N'k', 0, N'kh', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'h', N'h', 0, 0, NULL, NULL, NULL, 0, 0, 0)
INSERT [dbo].[tblVehicle] ([VehicleID], [DeclarationID], [PlateNumber], [NumberOfContainer], [DriverName], [ImportDate], [IsImport], [ExportDate], [IsExport], [Note], [Status], [IsCompleted], [IsGoodsImported], [ImportStatus], [ImportedLocalTime], [HasGoodsImported], [ConfirmImportBy], [ConfirmExportBy], [ConfirmLocalImportBy]) VALUES (1872, 691, N'lj', 0, N'lj', CAST(0x0000000000000000 AS DateTime), 0, CAST(0x0000000000000000 AS DateTime), 0, N'ljlj', N'sadf', 0, 0, NULL, NULL, NULL, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[tblVehicle] OFF
/****** Object:  StoredProcedure [dbo].[sp_InsertDeclaration]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 09/04/2011
-- Description:	Insert Declaration
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertDeclaration] 
	-- Add the parameters for the stored procedure here	
	@Number int,
	@ProductName nvarchar(250),
	@CompanyName nvarchar(500),
	@ProductAmount nvarchar(500),
	@Unit nvarchar(200),
	@CreatedByID int,
	@ModifiedByID int,
	@ModifiedDate datetime,
	@CreatedDate datetime,
	@HasDeclaration bit,
	@ImportNumber int,
	@ImportProductName nvarchar(250),
	@ImportCompanyName nvarchar(500),
	@ImportProductAmount nvarchar(500),
	@ImportUnit nvarchar(200),
	@ImportHasDeclaration BIT,
	@ImportType nvarchar(200),
	@ExportType nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT 
	INTO tblDeclaration 		
	(
		Number,
		ProductName,
		CompanyName,
		ProductAmount,
		Unit,
		CreatedByID,
		ModifiedByID,
		ModifiedDate,
		CreatedDate,
		HasDeclaration,
		ImportNumber,
		ImportProductName,
		ImportCompanyName,
		ImportProductAmount,
		ImportUnit,
		ImportHasDeclaration,
		ExportType,
		ImportType
	)
	VALUES 
	(
		@Number,
		@ProductName,
		@CompanyName,
		@ProductAmount,
		@Unit,
		@CreatedByID,
		@ModifiedByID,
		@ModifiedDate,
		@CreatedDate,
		@HasDeclaration,
		@ImportNumber,
		@ImportProductName,
		@ImportCompanyName,
		@ImportProductAmount,
		@ImportUnit,
		@ImportHasDeclaration,
		@ExportType,
		@ImportType
	)
	Select @@Identity
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateDeclaration]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Update Declaration
-- =============================================
CREATE PROCEDURE [dbo].[sp_updateDeclaration] 
	-- Add the parameters for the stored procedure here	
    @DeclerationID INT ,
    @Number INT ,
    @ProductName NVARCHAR(250) ,
    @CompanyName NVARCHAR(500) ,
    @ProductAmount NVARCHAR(500) ,
    @Unit NVARCHAR(200) ,
    @ModifiedByID INT ,
    @ModifiedDate DATETIME ,
    @HasDeclaration BIT ,
    @ImportNumber INT ,
    @ImportProductName NVARCHAR(250) ,
    @ImportCompanyName NVARCHAR(500) ,
    @ImportProductAmount NVARCHAR(500) ,
    @ImportUnit NVARCHAR(200) ,
    @ImportHasDeclaration BIT,
    @ImportType nvarchar(200),
	@ExportType nvarchar(200)
AS 
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON ;

    -- Insert statements for procedure here
        UPDATE  tblDeclaration
        SET     Number = @Number ,
                ProductName = @ProductName ,
                CompanyName = @CompanyName ,
                ProductAmount = @ProductAmount ,
                Unit = @Unit ,
                ModifiedByID = @ModifiedByID ,
                ModifiedDate = @ModifiedDate ,
                HasDeclaration = @HasDeclaration ,
                ImportNumber = @ImportNumber ,
                ImportProductName = @ImportProductName ,
                ImportCompanyName = @ImportCompanyName ,
                ImportProductAmount = @ImportProductAmount ,
                ImportUnit = @ImportUnit ,
                ImportHasDeclaration = @ImportHasDeclaration,
                ExportType = @ExportType,
                ImportType = @ImportType
        WHERE   DeclarationID = @DeclerationID
    END
-- SELECT * FROM TBLDECLARATION
-- EXEC [sp_updateDeclaration] 27,1111, 'hello','company','so luong updated','vndong', 1,'10/10/2011'
GO
/****** Object:  StoredProcedure [dbo].[st_IsExistVehicleInDeclaration]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[st_IsExistVehicleInDeclaration]
    @PlateNumber AS NVARCHAR(200) ,
    @DeclarationID AS INT
AS 
    BEGIN
	
	
        SELECT  *
        FROM    dbo.tblVehicle
        WHERE   PlateNumber = @PlateNumber
                AND DeclarationID = @DeclarationID
    END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateVehicle]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Update vehicle 
-- =============================================
CREATE PROCEDURE [dbo].[sp_updateVehicle]
	-- Add the parameters for the stored procedure here
	@VehicleID int,
	@PlateNumber nvarchar(50),
	@NumberOfContainer int,
	@DriverName nvarchar(250),
	@ImportDate datetime,
	@ExportDate datetime,		
	@Status nvarchar(500),
	@Note nvarchar(500),
	@IsExport bit,
	@IsImport bit,
	@IsCompleted bit,
	@ImportedLocalTime datetime,
	@ImportStatus nvarchar(500),
	@HasGoodsImported bit,
	@IsGoodsImported bit,
	@DeclarationID int ,
	@ConfirmImportBy int,
	@ConfirmExportBy int,
	@ConfirmLocalImportBy int
			
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE
		tblVehicle
	SET
		PlateNumber		  = @PlateNumber,
		NumberOfContainer = @NumberOfContainer,
		DriverName        = @DriverName,
		ImportDate        = @ImportDate,
		ExportDate        = @ExportDate,
		Status            = @Status,
		Note              = @Note,
		IsExport          = @IsExport,
		IsImport          = @IsImport,
		IsCompleted       = @IsCompleted,
		ImportedLocalTime = @ImportedLocalTime,
		ImportStatus      = @ImportStatus,
		HasGoodsImported  = @HasGoodsImported,
		IsGoodsImported   = @IsGoodsImported,
        DeclarationID	  = @DeclarationID ,
        ConfirmExportBy = @ConfirmExportBy,
        ConfirmImportBy = @ConfirmImportBy,
        ConfirmLocalImportBy = @ConfirmLocalImportBy
	WHERE
		VehicleID = @VehicleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectVehicleByID]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vuongdd
-- Create date: 10/04/2011
-- Description:	Select Vehicel by Vehicle ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_SelectVehicleByID]
	-- Add the parameters for the stored procedure here
	@VehicleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		*
	FROM
		tblVehicle
	WHERE
		VehicleID = @VehicleID	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectVehicleByDeclarationID]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Get vehicle by DeclarationID
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectVehicleByDeclarationID]
	-- Add the parameters for the stored procedure here
	@DeclarationID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		*
	FROM
		tblVehicle
	WHERE
		DeclarationID = @DeclarationID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_searchVehicle]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2010
-- Description:	Search Vehicle
-- =============================================
CREATE PROCEDURE [dbo].[sp_searchVehicle]
	-- Add the parameters for the stored procedure here	
    @IsCompleted BIT ,
    @PlateNumber NVARCHAR(100) ,
    @ImportFrom DATETIME ,
    @ImportTo DATETIME ,
    @ExportFrom DATETIME ,
    @ExportTo DATETIME ,
    @SearchType INT = 1
AS -- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON ;
    IF @SearchType = 1
        AND @PlateNumber = '' -- Get Vehicle which not import/export
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    tblDeclaration.ExportType ,
                    tblDeclaration.ImportType ,
                    tblDeclaration.Number AS 'DeclarationNumberExport' ,
                    tblDeclaration.ImportNumber AS 'DeclarationNumberImport' ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportByName' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportByName' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportByName'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND IsExport = 0
                    AND IsCompleted = @IsCompleted
                    AND ExportDate = ( SELECT   MAX(a.ExportDate)
                                       FROM     tblVehicle AS a
                                       WHERE    a.PlateNumber = tblVehicle.PlateNumber
                                     )
                   
        END
	
    IF @SearchType = 1
        AND @PlateNumber <> '' -- Get Vehicle which not import/export
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    tblDeclaration.ExportType ,
                    tblDeclaration.ImportType ,
                    tblDeclaration.Number AS 'DeclarationNumberExport' ,
                    tblDeclaration.ImportNumber AS 'DeclarationNumberImport' ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportByName' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportByName' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportByName'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND IsExport = 0
                    AND PlateNumber LIKE '%' + @PlateNumber + '%'
                    AND IsCompleted = @IsCompleted
                    AND ExportDate = ( SELECT   MAX(a.ExportDate)
                                       FROM     tblVehicle AS a
                                       WHERE    a.PlateNumber = tblVehicle.PlateNumber
                                     )
                 									
        END
	
	
    IF @SearchType = 2
        AND @PlateNumber = '' -- Exported and Not Import or Imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    tblDeclaration.ExportType ,
                    tblDeclaration.ImportType ,
                    tblDeclaration.Number AS 'DeclarationNumberExport' ,
                    tblDeclaration.ImportNumber AS 'DeclarationNumberImport' ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportByName' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportByName' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportByName'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND IsExport = 1
                    AND IsCompleted = @IsCompleted
                    AND ExportDate = ( SELECT   MAX(a.ExportDate)
                                       FROM     tblVehicle AS a
                                       WHERE    a.PlateNumber = tblVehicle.PlateNumber
                                     )
                   				 								
        END	
	
    IF @SearchType = 2
        AND @PlateNumber <> '' -- Exported and Not Import or Imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    tblDeclaration.ExportType ,
                    tblDeclaration.ImportType ,
                    tblDeclaration.Number AS 'DeclarationNumberExport' ,
                    tblDeclaration.ImportNumber AS 'DeclarationNumberImport' ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportByName' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportByName' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportByName'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND IsExport = 1
                    AND PlateNumber LIKE '%' + @PlateNumber + '%'
                    AND IsCompleted = @IsCompleted
                    AND ExportDate = ( SELECT   MAX(a.ExportDate)
                                       FROM     tblVehicle AS a
                                       WHERE    a.PlateNumber = tblVehicle.PlateNumber
                                     )
                  						
        END	
	
	
    IF @SearchType = 3
        AND @PlateNumber = '' -- Exported and Imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    tblDeclaration.ExportType ,
                    tblDeclaration.ImportType ,
                    tblDeclaration.Number AS 'DeclarationNumberExport' ,
                    tblDeclaration.ImportNumber AS 'DeclarationNumberImport' ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportByName' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportByName' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportByName'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND ImportDate >= @ImportFrom
                    AND ImportDate <= @ImportTo
                    AND IsExport = 1
                    AND IsImport = 1
                    AND IsCompleted = @IsCompleted
                    AND ExportDate = ( SELECT   MAX(a.ExportDate)
                                       FROM     tblVehicle AS a
                                       WHERE    a.PlateNumber = tblVehicle.PlateNumber
                                     )
                 								
        END
	
    IF @SearchType = 3
        AND @PlateNumber <> '' -- Exported and Imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    tblDeclaration.ExportType ,
                    tblDeclaration.ImportType ,
                    tblDeclaration.Number AS 'DeclarationNumberExport' ,
                    tblDeclaration.ImportNumber AS 'DeclarationNumberImport' ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportByName' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportByName' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportByName'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND ImportDate >= @ImportFrom
                    AND ImportDate <= @ImportTo
                    AND IsExport = 1
                    AND IsImport = 1
                    AND PlateNumber LIKE '%' + @PlateNumber + '%'
                    AND IsCompleted = @IsCompleted
                    AND ExportDate = ( SELECT   MAX(a.ExportDate)
                                       FROM     tblVehicle AS a
                                       WHERE    a.PlateNumber = tblVehicle.PlateNumber
                                     )
                   			
        END
	
	
    IF @SearchType = 4
        AND @PlateNumber = '' -- Exported and not imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    tblDeclaration.ExportType ,
                    tblDeclaration.ImportType ,
                    tblDeclaration.Number AS 'DeclarationNumberExport' ,
                    tblDeclaration.ImportNumber AS 'DeclarationNumberImport' ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportByName' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportByName' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportByName'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND IsExport = 1
                    AND IsImport = 0
                    AND IsCompleted = @IsCompleted
                    AND ExportDate = ( SELECT   MAX(a.ExportDate)
                                       FROM     tblVehicle AS a
                                       WHERE    a.PlateNumber = tblVehicle.PlateNumber
                                     )
                  										
        END
	
    IF @SearchType = 4
        AND @PlateNumber <> '' -- Exported and not imported
        BEGIN
            SELECT  Number ,
                    ProductName ,
                    CompanyName ,
                    ProductAmount ,
                    Unit ,
                    VehicleID ,
                    tblVehicle.DeclarationID ,
                    PlateNumber ,
                    NumberOfContainer ,
                    DriverName ,
                    ImportDate ,
                    ExportDate ,
                    Note ,
                    Status ,
                    ImportNumber ,
                    ImportStatus ,
                    ImportedLocalTime ,
                    --ImportCompanyName ,
                    ImportProductName ,
                    ImportProductAmount ,
                    IsImport ,
                    IsExport ,
                    HasGoodsImported ,
                    IsGoodsImported ,
                    tblDeclaration.ExportType ,
                    tblDeclaration.ImportType ,
                    tblDeclaration.Number AS 'DeclarationNumberExport' ,
                    tblDeclaration.ImportNumber AS 'DeclarationNumberImport' ,
                    dbo.fn_GetNameById(ConfirmExportBy) AS 'ConfirmExportByName' ,
                    dbo.fn_GetNameById(ConfirmImportBy) AS 'ConfirmImportByName' ,
                    dbo.fn_GetNameById(ConfirmLocalImportBy) AS 'ConfirmLocalImportByName'
            FROM    tblVehicle ,
                    tblDeclaration
            WHERE   tblVehicle.DeclarationID = tblDeclaration.DeclarationID
                    AND ExportDate >= @ExportFrom
                    AND ExportDate <= @ExportTo
                    AND IsExport = 1
                    AND IsImport = 0
                    AND PlateNumber LIKE '%' + @PlateNumber + '%'
                    AND IsCompleted = @IsCompleted
                    AND ExportDate = ( SELECT   MAX(a.ExportDate)
                                       FROM     tblVehicle AS a
                                       WHERE    a.PlateNumber = tblVehicle.PlateNumber
                                     )
                   					
        END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertVehicle]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 09/04/2011
-- Description:	Insert Vehilce
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertVehicle] 
	-- Add the parameters for the stored procedure here	
	@DeclarationID int,
	@PlateNumber nvarchar(50),
	@NumberOfContainer int,
	@DriverName nvarchar(250),
	@ExportDate datetime,	
	@Note nvarchar(500),
	@Status nvarchar(500),
	@IsExport bit,
	@IsCompleted bit,
	@ImportDate datetime,
	@IsImport bit,
	@IsGoodsImported bit,
	@ConfirmImportBy int,
	@ConfirmExportBy int,
	@ConfirmLocalImportBy int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT 
	INTO tblVehicle 		
	(
		DeclarationID,
		PlateNumber,
		NumberOfContainer,
		DriverName,
		ExportDate,		
		Note,
		Status,
		IsExport,
		IsCompleted,
		ImportDate,
		IsImport,
		IsGoodsImported,
		ConfirmImportBy ,
		ConfirmExportBy ,
		ConfirmLocalImportBy 
	)
	VALUES 
	(
		@DeclarationID,
		@PlateNumber,
		@NumberOfContainer,
		@DriverName,
		@ExportDate,		
		@Note,
		@Status,
		@IsExport,
		@IsCompleted,
		@ImportDate,
		@IsImport,
		@IsGoodsImported,
		@ConfirmImportBy ,
		@ConfirmExportBy ,
		@ConfirmLocalImportBy 
	)
	Select @@Identity
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getVehicleNotImportExport]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2010
-- Description:	Get all Vehicle which not export/Import
-- =============================================
CREATE PROCEDURE [dbo].[sp_getVehicleNotImportExport]
	-- Add the parameters for the stored procedure here	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		*
	FROM
		tblVehicle
	WHERE 
		ExportDate IS NULL	OR 
		ImportDate IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteVehicleByID]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Delete Vehicle by ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_deleteVehicleByID]
	-- Add the parameters for the stored procedure here
	@VehicleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE 
	FROM	
		tblVehicle	
	WHERE
		VehicleID = @VehicleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteDecleration]    Script Date: 06/17/2011 21:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		VuongDD
-- Create date: 10/04/2011
-- Description:	Delete Decleration by ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_deleteDecleration]
	-- Add the parameters for the stored procedure here
	@DeclerationID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- Delete vehicle
	DELETE 
	FROM
		tblVehicle
	WHERE
		DeclarationID = @DeclerationID
		
	-- Delete Decleration
	DELETE
	FROM	
		tblDeclaration
	WHERE
		DeclarationID = @DeclerationID
END
GO
/****** Object:  Default [DF_tblVehicle_ExportDate]    Script Date: 06/17/2011 21:05:42 ******/
ALTER TABLE [dbo].[tblVehicle] ADD  CONSTRAINT [DF_tblVehicle_ExportDate]  DEFAULT (1 / 1 / 1900) FOR [ExportDate]
GO
/****** Object:  ForeignKey [FK_tblDeclaration_tblUser]    Script Date: 06/17/2011 21:05:32 ******/
ALTER TABLE [dbo].[tblDeclaration]  WITH CHECK ADD  CONSTRAINT [FK_tblDeclaration_tblUser] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[tblUser] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblDeclaration] CHECK CONSTRAINT [FK_tblDeclaration_tblUser]
GO
/****** Object:  ForeignKey [FK_tblVehicle_tblDeclaration]    Script Date: 06/17/2011 21:05:42 ******/
ALTER TABLE [dbo].[tblVehicle]  WITH CHECK ADD  CONSTRAINT [FK_tblVehicle_tblDeclaration] FOREIGN KEY([DeclarationID])
REFERENCES [dbo].[tblDeclaration] ([DeclarationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblVehicle] CHECK CONSTRAINT [FK_tblVehicle_tblDeclaration]
GO
