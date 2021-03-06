USE [Persons]
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 10/22/2016 4:59:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adress](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[addres_text] [nchar](100) NOT NULL,
	[townId] [int] NOT NULL,
 CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 10/22/2016 4:59:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[id] [int] NOT NULL,
	[continent_name] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contries]    Script Date: 10/22/2016 4:59:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contries](
	[id] [int] NOT NULL,
	[country_name] [nchar](100) NOT NULL,
	[continentId] [int] NOT NULL,
 CONSTRAINT [PK_Contries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persons]    Script Date: 10/22/2016 4:59:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[id] [int] NOT NULL,
	[first_name] [nvarchar](10) NOT NULL,
	[last_name] [nvarchar](10) NOT NULL,
	[addres_id] [int] NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 10/22/2016 4:59:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](100) NOT NULL,
	[countryId] [int] NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Adress] ON 

INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (1, N'zdravec                                                                                             ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (2, N'pesho                                                                                               ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (3, N'kjlkjkj                                                                                             ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (4, N'lkjlkjlkjlk                                                                                         ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (5, N'lkjlkjlkjlkj                                                                                        ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (6, N'lkjlkjlkj                                                                                           ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (7, N'lklkjlkj                                                                                            ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (8, N'klklklkl                                                                                            ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (9, N'klklklkl                                                                                            ', 1)
INSERT [dbo].[Adress] ([id], [addres_text], [townId]) VALUES (10, N'Lovech                                                                                              ', 1)
SET IDENTITY_INSERT [dbo].[Adress] OFF
INSERT [dbo].[Persons] ([id], [first_name], [last_name], [addres_id]) VALUES (1, N'KOki', N'pesho', 2)
INSERT [dbo].[Persons] ([id], [first_name], [last_name], [addres_id]) VALUES (2, N'kklk', N'lklklk', 2)
INSERT [dbo].[Persons] ([id], [first_name], [last_name], [addres_id]) VALUES (3, N'lklkl', N'klklk', 3)
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([id], [name], [countryId]) VALUES (1, N'Lovech                                                                                              ', NULL)
INSERT [dbo].[Towns] ([id], [name], [countryId]) VALUES (2, N'Pleven                                                                                              ', NULL)
INSERT [dbo].[Towns] ([id], [name], [countryId]) VALUES (3, N'Dobrich                                                                                             ', NULL)
INSERT [dbo].[Towns] ([id], [name], [countryId]) VALUES (4, N'Petrich                                                                                             ', NULL)
INSERT [dbo].[Towns] ([id], [name], [countryId]) VALUES (5, N'Lozenec                                                                                             ', NULL)
INSERT [dbo].[Towns] ([id], [name], [countryId]) VALUES (6, N'Dubnik                                                                                              ', NULL)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Adress] ADD  CONSTRAINT [DF_Adress_addres_text]  DEFAULT (N'Lovech') FOR [addres_text]
GO
ALTER TABLE [dbo].[Adress] ADD  CONSTRAINT [DF_Adress_townId]  DEFAULT ((1)) FOR [townId]
GO
ALTER TABLE [dbo].[Contries] ADD  CONSTRAINT [DF_Contries_continentId]  DEFAULT ((1)) FOR [continentId]
GO
ALTER TABLE [dbo].[Persons] ADD  CONSTRAINT [DF_Persons_addres_id]  DEFAULT ((1)) FOR [addres_id]
GO
ALTER TABLE [dbo].[Towns] ADD  CONSTRAINT [DF_Towns_countryId]  DEFAULT ((1)) FOR [countryId]
GO
ALTER TABLE [dbo].[Adress]  WITH CHECK ADD  CONSTRAINT [FK_Adress_Towns] FOREIGN KEY([townId])
REFERENCES [dbo].[Towns] ([id])
GO
ALTER TABLE [dbo].[Adress] CHECK CONSTRAINT [FK_Adress_Towns]
GO
ALTER TABLE [dbo].[Contries]  WITH CHECK ADD  CONSTRAINT [FK_Contries_Continents] FOREIGN KEY([continentId])
REFERENCES [dbo].[Continents] ([id])
GO
ALTER TABLE [dbo].[Contries] CHECK CONSTRAINT [FK_Contries_Continents]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Adress] FOREIGN KEY([addres_id])
REFERENCES [dbo].[Adress] ([id])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Adress]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Contries] FOREIGN KEY([countryId])
REFERENCES [dbo].[Contries] ([id])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Contries]
GO
