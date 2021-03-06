USE [myOrder]
GO
/****** Object:  Table [dbo].[myAccount]    Script Date: 2021/11/29 下午 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[myAccount](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ACCOUNT] [nvarchar](50) NULL,
	[PASSWORD] [nvarchar](50) NULL,
	[CLASS] [nvarchar](50) NULL,
	[CAN_DO] [int] NULL,
 CONSTRAINT [PK_myAccount_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[myMenu]    Script Date: 2021/11/29 下午 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[myMenu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SHOP_NAME] [nvarchar](50) NULL,
	[MEAL] [nvarchar](50) NULL,
	[PRICE] [int] NULL,
 CONSTRAINT [PK_myMenu_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[myOrder]    Script Date: 2021/11/29 下午 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[myOrder](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ACCOUNT] [nvarchar](50) NULL,
	[CLASS] [nvarchar](50) NULL,
	[SHOP_NAME] [nvarchar](50) NULL,
	[ITEM] [nvarchar](50) NULL,
	[QTY] [int] NULL,
 CONSTRAINT [PK_myMenu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[myShop]    Script Date: 2021/11/29 下午 11:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[myShop](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SHOP_NAME] [nvarchar](50) NULL,
	[PHONE] [nvarchar](50) NULL,
 CONSTRAINT [PK_myShop] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[myAccount] ON 

INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (1, N'AAA', N'aaa111', N'管理員', 1)
INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (2, N'BBB', N'bbb222', N'管理員', 1)
INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (21, N'CCC', N'ccc333', N'值日生', 10)
INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (22, N'DDD', N'ddd444', N'值日生', 10)
INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (101, N'EEE', N'eee123', N'全端班', 100)
INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (102, N'FFF', N'fff123', N'JAVA班', 100)
INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (103, N'GGG', N'ggg123', N'JAVA班', 100)
INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (104, N'HHH', N'hhh123', N'JAVA班', 100)
INSERT [dbo].[myAccount] ([id], [ACCOUNT], [PASSWORD], [CLASS], [CAN_DO]) VALUES (105, N'III', N'iii123', N'全端班', 100)
SET IDENTITY_INSERT [dbo].[myAccount] OFF
GO
SET IDENTITY_INSERT [dbo].[myMenu] ON 

INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (4, N'達美樂', N'夏威夷披薩', 560)
INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (6, N'達美樂', N'黃金超級墨西哥披薩', 630)
INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (7, N'正忠排骨飯', N'宮保雞丁飯', 80)
INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (9, N'正忠排骨飯', N'雞排飯', 85)
INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (11, N'發財燒臘', N'化皮燒肉飯', 90)
INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (12, N'發財燒臘', N'蜜汁叉燒飯', 80)
INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (13, N'發財燒臘', N'香菇牛肉湯', 50)
INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (15, N'發財燒臘', N'蛋花湯', 30)
INSERT [dbo].[myMenu] ([id], [SHOP_NAME], [MEAL], [PRICE]) VALUES (18, N'正忠排骨飯', N'紫菜蛋花湯', 50)
SET IDENTITY_INSERT [dbo].[myMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[myOrder] ON 

INSERT [dbo].[myOrder] ([id], [ACCOUNT], [CLASS], [SHOP_NAME], [ITEM], [QTY]) VALUES (8, N'HHH', N'JAVA班', N'正忠排骨飯', N'宮保雞丁飯', 1)
INSERT [dbo].[myOrder] ([id], [ACCOUNT], [CLASS], [SHOP_NAME], [ITEM], [QTY]) VALUES (25, N'HHH', N'JAVA班', N'達美樂', N'夏威夷披薩', 1)
INSERT [dbo].[myOrder] ([id], [ACCOUNT], [CLASS], [SHOP_NAME], [ITEM], [QTY]) VALUES (26, N'III', N'全端班', N'發財燒臘', N'香菇牛肉湯', 1)
INSERT [dbo].[myOrder] ([id], [ACCOUNT], [CLASS], [SHOP_NAME], [ITEM], [QTY]) VALUES (27, N'III', N'全端班', N'發財燒臘', N'蛋花湯', 2)
INSERT [dbo].[myOrder] ([id], [ACCOUNT], [CLASS], [SHOP_NAME], [ITEM], [QTY]) VALUES (29, N'EEE', N'全端班', N'正忠排骨飯', N'雞排飯', 1)
INSERT [dbo].[myOrder] ([id], [ACCOUNT], [CLASS], [SHOP_NAME], [ITEM], [QTY]) VALUES (30, N'EEE', N'全端班', N'達美樂', N'夏威夷披薩', 1)
INSERT [dbo].[myOrder] ([id], [ACCOUNT], [CLASS], [SHOP_NAME], [ITEM], [QTY]) VALUES (36, N'FFF', N'JAVA班', N'達美樂', N'夏威夷披薩', 3)
INSERT [dbo].[myOrder] ([id], [ACCOUNT], [CLASS], [SHOP_NAME], [ITEM], [QTY]) VALUES (37, N'FFF', N'JAVA班', N'正忠排骨飯', N'雞排飯', 1)
SET IDENTITY_INSERT [dbo].[myOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[myShop] ON 

INSERT [dbo].[myShop] ([id], [SHOP_NAME], [PHONE]) VALUES (2, N'正忠排骨飯', N'073853850')
INSERT [dbo].[myShop] ([id], [SHOP_NAME], [PHONE]) VALUES (3, N'達美樂', N'074125252')
INSERT [dbo].[myShop] ([id], [SHOP_NAME], [PHONE]) VALUES (4, N'發財燒臘', N'073314871')
SET IDENTITY_INSERT [dbo].[myShop] OFF
GO
