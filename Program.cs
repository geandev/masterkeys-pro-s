using MasterKeys.Core;
using MasterKeys.Core.Types;

namespace MasterKeys
{
    public class Program
    {
        public static void Main()
        {
			Keyboard.SetControlDevice(DeviceType.DEV_MKeys_S);
            var teste = Keyboard.EnableLedControl(false);
            var teste2 = Keyboard.SwitchLedEffect(EffectsKeyboard.EFF_SNAKE);
        }
    }
}
