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

public enum LogfileColumns
{
#if !ENABLE_WINMD_SUPPORT
    [Description("Date (UTC+1.00)")]
#endif
    UTCDeviceDate = 0,
#if !ENABLE_WINMD_SUPPORT
    [Description("Time (UTC+1.00)")]
#endif
    UTCDeviceTime = 1,
#if !ENABLE_WINMD_SUPPORT
    [Description("TimeFromStart (s)")]
#endif
    LocationServiceEnabled = 2,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosLat (deg)")]
#endif
    LocationServiceEnabled = 3,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosLon (deg)")]
#endif
    LocationServiceEnabled = 4,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosLon (deg)")]
#endif
    LocationServiceEnabled = 5,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosLon (deg)")]
#endif
    LocationServiceEnabled = 6,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosLon (deg)")]
#endif
    LocationServiceEnabled = 7,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosAlt (m)")]
#endif
    LocationServiceEnabled = 8,
#if !ENABLE_WINMD_SUPPORT
    [Description("Distance (m)")]
#endif
    LocationServiceEnabled = 9,
#if !ENABLE_WINMD_SUPPORT
    [Description("VelNorth (km/h)")]
#endif
    LocationServiceEnabled = 10,
#if !ENABLE_WINMD_SUPPORT
    [Description("VelEast (km/h)")]
#endif
    LocationServiceEnabled = 11,
#if !ENABLE_WINMD_SUPPORT
    [Description("VelDown (km/h)")]
#endif
    LocationServiceEnabled = 12,
#if !ENABLE_WINMD_SUPPORT
    [Description("VelForward (km/h)")]
#endif
    LocationServiceEnabled = 13,
#if !ENABLE_WINMD_SUPPORT
    [Description("VelLateral (km/h)")]
#endif
    LocationServiceEnabled = 14,
#if !ENABLE_WINMD_SUPPORT
    [Description("Speed3D (km/h)")]
#endif
    LocationServiceEnabled = 15,
#if !ENABLE_WINMD_SUPPORT
    [Description("AccelX (m/s²)")]
#endif
    LocationServiceEnabled = 16,
#if !ENABLE_WINMD_SUPPORT
    [Description("AccelY (m/s²)")]
#endif
    LocationServiceEnabled = 17,
#if !ENABLE_WINMD_SUPPORT
    [Description("AccelZ (m/s²)")]
#endif
    LocationServiceEnabled = 18,
#if !ENABLE_WINMD_SUPPORT
    [Description("AccelForward (m/s²)")]
#endif
    LocationServiceEnabled = 19,
#if !ENABLE_WINMD_SUPPORT
    [Description("AccelLateral (m/s²)")]
#endif
    LocationServiceEnabled = 20,
#if !ENABLE_WINMD_SUPPORT
    [Description("AccelDown (m/s²)")]
#endif
    LocationServiceEnabled = 21,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleHeading (deg)")]
#endif
    LocationServiceEnabled = 22,
#if !ENABLE_WINMD_SUPPORT
    [Description("AnglePitch (deg)")]
#endif
    LocationServiceEnabled = 23,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleRoll (deg)")]
#endif
    LocationServiceEnabled = 24,
#if !ENABLE_WINMD_SUPPORT
    [Description("lpsOmega (deg)")]
#endif
    LocationServiceEnabled = 25,
#if !ENABLE_WINMD_SUPPORT
    [Description("lpsPhi  (deg)")]
#endif
    LocationServiceEnabled = 26,
#if !ENABLE_WINMD_SUPPORT
    [Description("lpsKappa (deg)")]
#endif
    LocationServiceEnabled = 27,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleSlip (deg)")]
#endif
    LocationServiceEnabled = 28,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleTrack (deg)")]
#endif
    LocationServiceEnabled = 29,
#if !ENABLE_WINMD_SUPPORT
    [Description("Curvature (1/m)")]
#endif
    LocationServiceEnabled = 30,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleRateX (deg/s)")]
#endif
    LocationServiceEnabled = 31,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleRateY (deg/s)")]
#endif
    LocationServiceEnabled = 32,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleRateZ (deg/s)")]
#endif
    LocationServiceEnabled = 33,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleRateForward (deg/s)")]
#endif
    LocationServiceEnabled = 34,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleRateLateral (deg/s)")]
#endif
    LocationServiceEnabled = 35,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleRateDown (deg/s)")]
#endif
    LocationServiceEnabled = 36,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleGradient (deg)")]
#endif
    LocationServiceEnabled = 37,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngAccelX (deg/s²)")]
#endif
    LocationServiceEnabled = 38,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngAccelY (deg/s²)")]
#endif
    LocationServiceEnabled = 39,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngAccelZ (deg/s²)")]
#endif
    LocationServiceEnabled = 40,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngAccelForward (deg/s²)")]
#endif
    LocationServiceEnabled = 41,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngAccelLateral (deg/s²)")]
#endif
    LocationServiceEnabled = 42,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngAccelDown (deg/s²)")]
#endif
    LocationServiceEnabled = 43,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosLatStdev (m)")]
#endif
    LocationServiceEnabled = 44,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosLonStdev (m)")]
#endif
    LocationServiceEnabled = 45,
#if !ENABLE_WINMD_SUPPORT
    [Description("PosAltStdev (m)")]
#endif
    LocationServiceEnabled = 46,
#if !ENABLE_WINMD_SUPPORT
    [Description("VelNorthStdev (km/h)")]
#endif
    LocationServiceEnabled = 47,
#if !ENABLE_WINMD_SUPPORT
    [Description("VelEastStdev (km/h)")]
#endif
    LocationServiceEnabled = 48,
#if !ENABLE_WINMD_SUPPORT
    [Description("VelDownStdev (km/h)")]
#endif
    LocationServiceEnabled = 49,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleHeadingStdev (deg)")]
#endif
    LocationServiceEnabled = 50,
#if !ENABLE_WINMD_SUPPORT
    [Description("AnglePitchStdev (deg)")]
#endif
    LocationServiceEnabled = 51,
#if !ENABLE_WINMD_SUPPORT
    [Description("AngleRollStdev (deg)")]
#endif
    LocationServiceEnabled = 52,
#if !ENABLE_WINMD_SUPPORT
    [Description("location service enabled")]
#endif
    LocationServiceEnabled = 53,
#if !ENABLE_WINMD_SUPPORT
    [Description("location service intializing")]
#endif
    LocationServiceInitializing = 54,
#if !ENABLE_WINMD_SUPPORT
    [Description("location updated")]
#endif
    LocationUpdated = 55,
#if !ENABLE_WINMD_SUPPORT
    [Description("userheading updated")]
#endif
    UserHeadingUpdated = 56,
#if !ENABLE_WINMD_SUPPORT
    [Description("location provider")]
#endif
    LocationProvider = 57,
#if !ENABLE_WINMD_SUPPORT
    [Description("location provider class")]
#endif
    LocationProviderClass = 58
}

/*GpsPosMode	
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
GpsNumSats#2##1#
*/
