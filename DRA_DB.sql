USE [restaurant]
GO
/****** Object:  Table [dbo].[tbl_kategori]    Script Date: 29/06/2018 19.40.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_kategori](
	[id_kategori] [int] NOT NULL,
	[kategori] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_kategori] PRIMARY KEY CLUSTERED 
(
	[id_kategori] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_menu]    Script Date: 29/06/2018 19.40.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_menu](
	[id_menu] [int] IDENTITY(1,1) NOT NULL,
	[nama_menu] [nvarchar](50) NULL,
	[harga] [int] NULL,
	[id_kategori] [int] NULL,
	[id_supplier] [int] NULL,
	[gambar] [image] NULL,
 CONSTRAINT [PK_tbl_menu] PRIMARY KEY CLUSTERED 
(
	[id_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_supplier]    Script Date: 29/06/2018 19.40.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_supplier](
	[id_supplier] [int] IDENTITY(1,1) NOT NULL,
	[nama_supplier] [nvarchar](50) NULL,
	[tmpt_lahir] [nvarchar](50) NULL,
	[tgl_lahir] [date] NULL,
	[jenis_kelamin] [nvarchar](50) NULL,
	[agama] [nvarchar](50) NULL,
	[alamat] [text] NULL,
 CONSTRAINT [PK_tbl_supplier] PRIMARY KEY CLUSTERED 
(
	[id_supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
