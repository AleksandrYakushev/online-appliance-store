using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Business.Models.Output
{
    public class ProductOutputModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Manufacturer { get; set; }
        public string ProductionYear { get; set; }
        public float MaxPower { get; set; }
        public int NumberOfPrograms { get; set; }
        public string Color { get; set; }
        public float BowlVolume { get; set; }
        public string ProductShape { get; set; }
        public int ProductLife { get; set; }
        public int NoiseLevel { get; set; }
        public int MinTemperature { get; set; }
        public int NumberOfToasts { get; set; }
        public int BatteryLife { get; set; }
        public bool PowerRegulator { get; set; }
        public bool Timer { get; set; }
        public bool Defrost { get; set; }
        public bool SuperFrost { get; set; }
        public bool Backlight { get; set; }
        public bool Display { get; set; }
        public bool CarboneFilter { get; set; }
        public bool WetCleaning { get; set; }
        public bool GlassCase { get; set; }
        public bool RemoteController { get; set; }
        public bool WithBattery { get; set; }
        public bool IsDeleted { get; set; }
    }
}
