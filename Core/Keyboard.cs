using System;
using System.Runtime.InteropServices;
using System.Text;
using MasterKeys.Core.Types;

namespace MasterKeys.Core
{
    public static class Keyboard
    {
        private const string SdkPath = @"SDKDLL.dll";

        [DllImport(SdkPath)]
        public static extern bool EnableLedControl(bool bEnable);

        [DllImport(SdkPath)]
        public static extern bool IsDevicePlug();

        [DllImport(SdkPath)]
        public static extern long GetNowCPUUsage();

        [DllImport(SdkPath)]
        public static extern string GetRamUsage();

        [DllImport(SdkPath)]
        public static extern float GetNowVolumePeekValue();

        [DllImport(SdkPath)]
        public static extern LayoutKeyboard GetDeviceLayout();

        [DllImport(SdkPath)]
        public static extern bool SwitchLedEffect(EffectsKeyboard iEffectIndex);

        [DllImport(SdkPath)]
        public static extern bool RefreshLed(bool bAuto = false);
        [DllImport(SdkPath)]
        public static extern void SetControlDevice(DeviceType devIndex);
        [DllImport(SdkPath)]
        public static extern char GetNowTime();

    }

}
