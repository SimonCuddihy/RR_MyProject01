/*
namespace Mapbox.Unity.Location
{


	using System;
	using System.ComponentModel;
	using System.Globalization;
	using Mapbox.VectorTile.ExtensionMethods;


	/// <summary>
	/// Base class for reading/writing location logs
	/// </summary>
	public abstract class CarLogAbstractBase
	{


		public readonly string Delimiter = ",";
		protected readonly CultureInfo _invariantCulture = CultureInfo.InvariantCulture;


		public enum LogfileColumns
		{
#if !ENABLE_WINMD_SUPPORT
			[Description("location service enabled")]
#endif
			LocationServiceEnabled = 0,
#if !ENABLE_WINMD_SUPPORT
			[Description("location service intializing")]
#endif
			LocationServiceInitializing = 1,
#if !ENABLE_WINMD_SUPPORT
			[Description("location updated")]
#endif
			LocationUpdated = 2,
#if !ENABLE_WINMD_SUPPORT
			[Description("userheading updated")]
#endif
			UserHeadingUpdated = 3,
#if !ENABLE_WINMD_SUPPORT
			[Description("location provider")]
#endif
			LocationProvider = 4,
#if !ENABLE_WINMD_SUPPORT
			[Description("location provider class")]
#endif
			LocationProviderClass = 5,
#if !ENABLE_WINMD_SUPPORT
			[Description("time device [utc]")]
#endif
			UtcTimeDevice = 6,
#if !ENABLE_WINMD_SUPPORT
			[Description("time location [utc]")]
#endif
			UtcTimeOfLocation = 7,
#if !ENABLE_WINMD_SUPPORT
			[Description("latitude")]
#endif
			Latitude = 8,
#if !ENABLE_WINMD_SUPPORT
			[Description("longitude")]
#endif
			Longitude = 9,
#if !ENABLE_WINMD_SUPPORT
			[Description("accuracy [m]")]
#endif
			Accuracy = 10,
#if !ENABLE_WINMD_SUPPORT
			[Description("user heading [°]")]
#endif
			UserHeading = 11,
#if !ENABLE_WINMD_SUPPORT
			[Description("device orientation [°]")]
#endif
			DeviceOrientation = 12,
#if !ENABLE_WINMD_SUPPORT
			[Description("speed [km/h]")]
#endif
			Speed = 13,
#if !ENABLE_WINMD_SUPPORT
			[Description("has gps fix")]
#endif
			HasGpsFix = 14,
#if !ENABLE_WINMD_SUPPORT
			[Description("satellites used")]
#endif
			SatellitesUsed = 15,
#if !ENABLE_WINMD_SUPPORT
			[Description("satellites in view")]
#endif
			SatellitesInView = 16
		}


		public string[] HeaderNames
		{
			get
			{
				Type enumType = typeof(LogfileColumns);
				Array arrEnumVals = Enum.GetValues(enumType);
				string[] hdrs = new string[arrEnumVals.Length];
				for (int i = 0; i < arrEnumVals.Length; i++)
				{
					hdrs[i] = ((LogfileColumns)Enum.Parse(enumType, arrEnumVals.GetValue(i).ToString())).Description();

				}
				return hdrs;
			}
		}



	}
}

/*Date (UTC+1.00)	
Time (UTC+1.00)	
TimeFromStart (s)
PosLat (deg)
PosLon (deg)	
PosAlt (m)	
Distance (m)
VelNorth (km/h)	
VelEast (km/h)	
VelDown (km/h)	
VelForward (km/h)	
VelLateral (km/h)	
Speed3D (km/h)	
AccelX (m/s²)	
AccelY (m/s²)	
AccelZ (m/s²)	
AccelForward (m/s²)	
AccelLateral (m/s²)	
AccelDown (m/s²)	
AngleHeading (deg)	
AnglePitch (deg)	
AngleRoll (deg)	
lpsOmega (deg)	
lpsPhi  (deg)	
lpsKappa (deg)	
AngleSlip (deg)	
AngleTrack (deg)	
Curvature (1/m)	
AngleRateX (deg/s)	
AngleRateY (deg/s)	
AngleRateZ (deg/s)	
AngleRateForward (deg/s)	
AngleRateLateral (deg/s)	
AngleRateDown (deg/s)	
AngleGradient (deg)	
AngAccelX (deg/s²)	
AngAccelY (deg/s²)	
AngAccelZ (deg/s²)	
AngAccelForward (deg/s²)	
AngAccelLateral (deg/s²)	
AngAccelDown (deg/s²)	
PosLatStdev (m)	
PosLonStdev (m)	
PosAltStdev (m)	
VelNorthStdev (km/h)	
VelEastStdev (km/h)
VelDownStdev (km/h)
AngleHeadingStdev (deg)	
AnglePitchStdev (deg)	
AngleRollStdev (deg)	
GpsPosMode	
GpsVelMode	
GpsAttMode	
GpsPosInn1	
GpsPosInn2	
GpsPosInn3	
GpsVelInn1	
GpsVelInn2	
GpsVelInn3	
GpsAttInn1	
GpsAttInn2	
GpsAntX (m)
GpsAntY (m)
GpsAntZ (m)	
GpsAntXStdev (m)	
GpsAntYStdev (m)	
GpsAntZStdev (m)	
GpsNumSats#1#
*/
