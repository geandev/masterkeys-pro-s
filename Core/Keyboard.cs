using System.Runtime.InteropServices;
using MasterKeys.Core.Types;

namespace MasterKeys.Core
{
    public static class Keyboard
	{
		private const string SdkPath = @"C:\dev\masterkeys-pro-s\packages\sdk\SDKDLL.dll";

		[DllImport(SdkPath)]
		public static extern bool EnableLedControl(bool bEnable);

		[DllImport(SdkPath)]
		public static extern bool IsDevicePlug();

		[DllImport(SdkPath)]
		public static extern int GetNowCPUUsage();

		[DllImport(SdkPath)]
		public static extern float GetNowVolumePeekValue();

		[DllImport(SdkPath)]
		public static extern LayoutKeyboard GetDeviceLayout();
	}

}
