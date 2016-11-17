USE [vmap]
GO
/****** Object:  Table [dbo].[GCoordSystem]    Script Date: 2015-07-13 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GCoordSystem](
	[CSGUID] [nvarchar](39) NULL,
	[CSGUIDTYPE] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[BaseStorageType] [tinyint] NULL,
	[Stor2CompMatrix1] [float] NULL,
	[Stor2CompMatrix2] [float] NULL,
	[Stor2CompMatrix3] [float] NULL,
	[Stor2CompMatrix4] [float] NULL,
	[Stor2CompMatrix5] [float] NULL,
	[Stor2CompMatrix6] [float] NULL,
	[Stor2CompMatrix7] [float] NULL,
	[Stor2CompMatrix8] [float] NULL,
	[Stor2CompMatrix9] [float] NULL,
	[Stor2CompMatrix10] [float] NULL,
	[Stor2CompMatrix11] [float] NULL,
	[Stor2CompMatrix12] [float] NULL,
	[Stor2CompMatrix13] [float] NULL,
	[Stor2CompMatrix14] [float] NULL,
	[Stor2CompMatrix15] [float] NULL,
	[Stor2CompMatrix16] [float] NULL,
	[HeightStorageType] [tinyint] NULL,
	[LonNormStorageOpt] [tinyint] NULL,
	[GeodeticDatum] [smallint] NULL,
	[Ellipsoid] [smallint] NULL,
	[EquatorialRadius] [float] NULL,
	[InverseFlattening] [float] NULL,
	[ProjAlgorithm] [smallint] NULL,
	[AzimuthAngle] [float] NULL,
	[FalseX] [float] NULL,
	[FalseY] [float] NULL,
	[Hemisphere] [tinyint] NULL,
	[LatOfOrigin] [float] NULL,
	[LatOfTrueScale] [float] NULL,
	[LonOfOrigin] [float] NULL,
	[RadOfStandCircle] [float] NULL,
	[ScaleReductFact] [float] NULL,
	[StandPar1] [float] NULL,
	[StandPar2] [float] NULL,
	[Zone] [smallint] NULL,
	[PathNumber] [smallint] NULL,
	[RowNumber] [smallint] NULL,
	[Satellite] [smallint] NULL,
	[XAzDefOpt] [tinyint] NULL,
	[GeomHeightOfOrig] [float] NULL,
	[GeomHeightOfPoint1] [float] NULL,
	[GeomHeightOfPoint2] [float] NULL,
	[LatOfPoint1] [float] NULL,
	[LatOfPoint2] [float] NULL,
	[LonOfPoint1] [float] NULL,
	[LonOfPoint2] [float] NULL,
	[ArgumentOfPerigee] [float] NULL,
	[EarthRotPeriod] [float] NULL,
	[FourierExpansionDegree] [tinyint] NULL,
	[NodesInSimpsonIntegration] [tinyint] NULL,
	[OrbEarthRotPeriodRatio] [float] NULL,
	[OrbEcc] [float] NULL,
	[OrbInclination] [float] NULL,
	[OrbOff] [float] NULL,
	[OrbPeriod] [float] NULL,
	[OrbSemimajAxis] [float] NULL,
	[OblMercDefMode] [tinyint] NULL,
	[LatOfMapCenter] [float] NULL,
	[OblLamConfConDefMode] [tinyint] NULL,
	[RotNorthPoleLat] [float] NULL,
	[RotNorthPoleLon] [float] NULL,
	[GaussianLat] [float] NULL,
	[SpherModel] [float] NULL,
	[SpherRadius] [float] NULL,
	[LatOfBasisPointA] [float] NULL,
	[LatOfBasisPointB] [float] NULL,
	[LatOfBasisPointC] [float] NULL,
	[LonOfBasisPointA] [float] NULL,
	[LonOfBasisPointB] [float] NULL,
	[LonOfBasisPointC] [float] NULL,
	[ChamTriOriginDefMode] [tinyint] NULL,
	[AngOrientationProjPlaneDefMode] [tinyint] NULL,
	[AzOfUpwardTilt] [float] NULL,
	[FocalLength] [float] NULL,
	[HeightAboveEllipAtNadir] [float] NULL,
	[HeightOrigOfLocalHorizSys] [float] NULL,
	[LatOrigOfLocalHorizSys] [float] NULL,
	[LocationOfProjPlaneDefMode] [tinyint] NULL,
	[LonOrigOfLocalHorizSys] [float] NULL,
	[PerspCenterGeocX] [float] NULL,
	[PerspCenterGeocY] [float] NULL,
	[PerspCenterGeocZ] [float] NULL,
	[PerspCenterHeight] [float] NULL,
	[PerspCenterLat] [float] NULL,
	[PerspCenterLon] [float] NULL,
	[PerspCenterXEast] [float] NULL,
	[PerspCenterYNorth] [float] NULL,
	[PerspCenterZUp] [float] NULL,
	[RefCoordSysDefMode] [tinyint] NULL,
	[RotAboutXAxis] [float] NULL,
	[RotAboutYAxis] [float] NULL,
	[RotAboutZAxis] [float] NULL,
	[SwingAng] [float] NULL,
	[TiltAng] [float] NULL,
	[ExtendProjMatrix1] [float] NULL,
	[ExtendProjMatrix2] [float] NULL,
	[ExtendProjMatrix3] [float] NULL,
	[ExtendProjMatrix4] [float] NULL,
	[ExtendProjMatrix5] [float] NULL,
	[ExtendProjMatrix6] [float] NULL,
	[ExtendProjMatrix7] [float] NULL,
	[ExtendProjMatrix8] [float] NULL,
	[ExtendProjMatrix9] [float] NULL,
	[ExtendProjMatrix10] [float] NULL,
	[ExtendProjMatrix11] [float] NULL,
	[ExtendProjMatrix12] [float] NULL,
	[ExtendProjMatrix13] [float] NULL,
	[ExtendProjMatrix14] [float] NULL,
	[ExtendProjMatrix15] [float] NULL,
	[ExtendProjMatrix16] [float] NULL,
	[VerticalDatum] [smallint] NULL,
	[UndulationModel] [smallint] NULL,
	[AverageUndulation] [float] NULL,
	[NamedGeodeticDatum] [nvarchar](100) NULL
) ON [PRIMARY]

GO
