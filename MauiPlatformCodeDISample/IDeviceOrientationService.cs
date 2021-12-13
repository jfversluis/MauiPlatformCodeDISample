using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlatformCodeDISample
{
    public enum DeviceOrientation
    {
        Undefined,
        Landscape,
        Portrait
    }

    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
