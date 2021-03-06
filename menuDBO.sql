USE [SWP391_DB]
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1002, 0, 0, N'Trang chủ', N'/home', 10, 1, N'', CAST(N'2022-01-21T18:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1003, 0, 1, N'Giới thiệu', N'/gioi-thieu', 20, 1, N'', CAST(N'2022-02-13T17:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1004, 0, 1, N'Tin tức', N'/tin-tuc', 30, 1, N'', CAST(N'2022-02-13T17:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1005, 0, 1, N'Sự kiện nổi bật', N'/thu-vien', 40, 1, N'', CAST(N'2022-02-13T17:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1006, 0, 1, N'Ngành học', N'/nganh-hoc', 50, 1, N'', CAST(N'2022-02-13T17:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1007, 0, 1, N'Đời sống sinh viên', N'/doi-song-sinh-vien', 60, 1, N'', CAST(N'2022-02-13T17:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1008, 0, 1, N'Hợp tác', N'/hop-tac', 70, 1, N'', CAST(N'2022-02-13T17:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1009, 0, 1, N'Liên hệ', N'/lien-he', 80, 1, N'', CAST(N'2022-02-13T17:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (1010, 0, 1, N'Câu hỏi thường gặp', N'/faq', 90, 1, N'', CAST(N'2022-02-13T17:07:30.027' AS DateTime))
INSERT [dbo].[Menu] ([ID], [ParentID], [Active], [Name], [Url], [Priority], [GroupID], [Description], [CreatedTime]) VALUES (2003, 0, 1, N'Đăng Nhập', N'/dang-nhap', 100, 1, N'', CAST(N'2022-02-13T17:07:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
