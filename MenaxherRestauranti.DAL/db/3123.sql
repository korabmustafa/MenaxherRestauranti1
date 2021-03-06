USE [RestaurantManager]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[categoryID] [int] IDENTITY(1,1) NOT NULL,
	[categoryName] [nvarchar](50) NOT NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderDetails]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderDetails](
	[orderDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[orderID] [int] NOT NULL,
	[orderSubtotal] [money] NOT NULL,
	[orderTotal] [money] NOT NULL,
	[orderTax] [money] NOT NULL,
	[orderChange] [money] NOT NULL,
	[orderCharge] [money] NOT NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_orderDetails] PRIMARY KEY CLUSTERED 
(
	[orderDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[orderID] [int] IDENTITY(1,1) NOT NULL,
	[userID] [int] NOT NULL,
	[productID] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[categoryID] [int] NOT NULL,
	[userID] [int] NOT NULL,
	[productName] [nvarchar](50) NOT NULL,
	[productDescription] [text] NOT NULL,
	[productPrice] [money] NOT NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservations]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservations](
	[reservationID] [int] IDENTITY(1,1) NOT NULL,
	[userID] [int] NOT NULL,
	[reservationName] [nvarchar](50) NOT NULL,
	[reservationDate] [datetime] NOT NULL,
	[guests] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_reservations] PRIMARY KEY CLUSTERED 
(
	[reservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[roleID] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NOT NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tableDetails]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tableDetails](
	[tableDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[tableID] [int] NOT NULL,
	[reservationID] [int] NOT NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_tableDetails] PRIMARY KEY CLUSTERED 
(
	[tableDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tables]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tables](
	[tableID] [int] IDENTITY(1,1) NOT NULL,
	[isFree] [bit] NOT NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_tables] PRIMARY KEY CLUSTERED 
(
	[tableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[roleID] [int] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[ExpiresDate] [date] NOT NULL,
	[LastLoginDate] [datetime] NULL,
	[insertBy] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[lastUpdatedBy] [int] NOT NULL,
	[lastUpdateDate] [date] NOT NULL,
	[updateNo] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([categoryID], [categoryName], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (1, N'Pije', 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 0)
INSERT [dbo].[categories] ([categoryID], [categoryName], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (2, N'Pasta', 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 0)
INSERT [dbo].[categories] ([categoryID], [categoryName], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (3, N'Pica', 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 1)
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([productID], [categoryID], [userID], [productName], [productDescription], [productPrice], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (1, 1, 1, N'Uje Rugove', N'Uje Rugove', 0.5000, 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 0)
INSERT [dbo].[products] ([productID], [categoryID], [userID], [productName], [productDescription], [productPrice], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (2, 2, 1, N'Makarona Boloneze', N'Makarona boloneze', 3.5000, 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 0)
INSERT [dbo].[products] ([productID], [categoryID], [userID], [productName], [productDescription], [productPrice], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (3, 3, 1, N'Pice Vesuvio', N'Pice me pershute,domate,suxhuk.', 3.0000, 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 1)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([roleID], [roleName], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (1, N'admin', 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 1)
INSERT [dbo].[roles] ([roleID], [roleName], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (2, N'Kamarier', 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 0)
SET IDENTITY_INSERT [dbo].[roles] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([userID], [roleID], [username], [password], [firstname], [lastname], [ExpiresDate], [LastLoginDate], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (1, 1, N'admin', N'admin', N'Korab', N'Mustafa', CAST(N'2020-11-13' AS Date), CAST(N'2020-11-13T20:48:51.000' AS DateTime), 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 1)
INSERT [dbo].[users] ([userID], [roleID], [username], [password], [firstname], [lastname], [ExpiresDate], [LastLoginDate], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (2, 2, N'shegamustafa', N'shega', N'Shega', N'Mustafa', CAST(N'2156-11-13' AS Date), CAST(N'2020-11-13T21:35:38.587' AS DateTime), 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 0)
INSERT [dbo].[users] ([userID], [roleID], [username], [password], [firstname], [lastname], [ExpiresDate], [LastLoginDate], [insertBy], [insertDate], [lastUpdatedBy], [lastUpdateDate], [updateNo]) VALUES (3, 1, N'admini', N'admin', N'Korab', N'Mustafa', CAST(N'2029-12-12' AS Date), CAST(N'2020-11-13T21:35:27.630' AS DateTime), 1, CAST(N'2020-11-13' AS Date), 1, CAST(N'2020-11-13' AS Date), 0)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[orderDetails]  WITH CHECK ADD  CONSTRAINT [FK_orderDetails_orders] FOREIGN KEY([orderID])
REFERENCES [dbo].[orders] ([orderID])
GO
ALTER TABLE [dbo].[orderDetails] CHECK CONSTRAINT [FK_orderDetails_orders]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_products] FOREIGN KEY([productID])
REFERENCES [dbo].[products] ([productID])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_products]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_users] FOREIGN KEY([userID])
REFERENCES [dbo].[users] ([userID])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_users]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_categories] FOREIGN KEY([categoryID])
REFERENCES [dbo].[categories] ([categoryID])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_categories]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_users] FOREIGN KEY([userID])
REFERENCES [dbo].[users] ([userID])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_users]
GO
ALTER TABLE [dbo].[reservations]  WITH CHECK ADD  CONSTRAINT [FK_reservations_users] FOREIGN KEY([userID])
REFERENCES [dbo].[users] ([userID])
GO
ALTER TABLE [dbo].[reservations] CHECK CONSTRAINT [FK_reservations_users]
GO
ALTER TABLE [dbo].[tableDetails]  WITH CHECK ADD  CONSTRAINT [FK_tableDetails_reservations] FOREIGN KEY([reservationID])
REFERENCES [dbo].[reservations] ([reservationID])
GO
ALTER TABLE [dbo].[tableDetails] CHECK CONSTRAINT [FK_tableDetails_reservations]
GO
ALTER TABLE [dbo].[tableDetails]  WITH CHECK ADD  CONSTRAINT [FK_tableDetails_tables] FOREIGN KEY([tableID])
REFERENCES [dbo].[tables] ([tableID])
GO
ALTER TABLE [dbo].[tableDetails] CHECK CONSTRAINT [FK_tableDetails_tables]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_roles] FOREIGN KEY([roleID])
REFERENCES [dbo].[roles] ([roleID])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_roles]
GO
/****** Object:  StoredProcedure [dbo].[usp_Authenticate]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Authenticate]
	@username nVARCHAR(50),
	@password nVARCHAR(50)
AS

UPDATE dbo.Users
	SET dbo.Users.LastLoginDate = GETDATE()
	WHERE dbo.Users.username = @username AND dbo.Users.password = @password;

SELECT *
FROM dbo.Users AS u
WHERE u.username = @username AND u.password	= @password;
GO
/****** Object:  StoredProcedure [dbo].[usp_Authenticate2]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Authenticate2]
@username varchar(50),
@password varchar(50) 
AS
SELECT * FROM dbo.users AS u WHERE u.username = @username AND u.password =@password
GO
/****** Object:  StoredProcedure [dbo].[usp_Categories_GetAll]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Categories_GetAll]
as
select * from dbo.categories as r
GO
/****** Object:  StoredProcedure [dbo].[usp_Categories_Insert]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Categories_Insert]
@categoryName nvarchar(50),
@insertBy int,
@lastUpdatedBy int,
@updateNo int
as
begin
insert into dbo.categories(
categoryName,
insertBy,
insertDate,
lastUpdatedBy,
lastUpdateDate,
updateNo)
Values
(
@categoryName,
@insertBy,
GETDATE(),
@lastUpdatedBy,
GETDATE(),
@updateNo
)
end

GO
/****** Object:  StoredProcedure [dbo].[usp_Product_Insert]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_Product_Insert]
@productName nvarchar(50),
@productDescription text,
@productPrice money,
@categoryID int,
@insertBy int,
@lastUpdatedBy int,
@updateNo int,
@userID int
as
begin
	insert into dbo.products (
		productName,
		productDescription,
		productPrice,
		categoryID,
		userID,
		insertBy,
		insertDate,
		lastUpdatedBy,
	    lastUpdateDate,
		updateNo

	)
	values (
		@productName,
		@productDescription,
		@productPrice,
		@categoryID,
		@userID,
		@insertBy,
        GETDATE(),
        @lastUpdatedBy,
        GETDATE(),
        @updateNo
	)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Products_GetAll]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Products_GetAll]
as
select * from dbo.products as r
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_Insert]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Role_Insert]
@roleName nvarchar(50),
@insertBy int,
@lastUpdatedBy int,
@updateNo int
as
begin
	insert into dbo.roles (
		roleName,
		insertBy,
		insertDate,
		lastUpdatedBy,
	    lastUpdateDate,
		updateNo

	)
	values (
		@roleName,
		@insertBy,
        GETDATE(),
        @lastUpdatedBy,
        GETDATE(),
        @updateNo
	)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_RemovebyID]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Role_RemovebyID]
@RoleID int
as
begin
delete from dbo.roles where roleID=@RoleID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Roles_GetAll]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Roles_GetAll]
as
select * from dbo.roles as r
GO
/****** Object:  StoredProcedure [dbo].[usp_User_Insert]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_User_Insert]
@username nvarchar(50),
@password nvarchar(50),
@firstname nvarchar(50),
@lastname nvarchar(50),
@roleid int,
@ExpiresDate date,
@insertBy int,
@lastUpdatedBy int,
@updateNo int
as
begin
	insert into dbo.users (
		username,
		password,
		firstname,
		lastname,
		roleID,
		ExpiresDate,
		insertBy,
		insertDate,
		lastUpdatedBy,
	    lastUpdateDate,
		updateNo

	)
	values (
		@username,
		@password,
		@firstname,
		@lastname,
		@roleid,
		@ExpiresDate,
		@insertBy,
        GETDATE(),
        @lastUpdatedBy,
        GETDATE(),
        @updateNo
	)
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Users_GetAll]    Script Date: 11/13/2020 9:41:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_Users_GetAll]
as
select * from dbo.users as r
GO
