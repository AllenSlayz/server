﻿namespace UlteriusServer.Api.Network.Models

{
    public class GpuInformation
    {
        public string Name { get; set; }
        public int RefreshRate { get; set; }
        public string DriverVersion { get; set; }
        public string ScreenInfo { get; set; }
        public string AdapterRam { get; internal set; }
        public int VideoArchitecture { get; set; }
        public int VideoMemoryType { get; set; }
        public string[] InstalledDisplayDrivers { get; set; }
        public string AdapterCompatibility { get; set; }
        public string Status { get; set; }
        public int Availability { get; set; }
        public float? Temperature { get; set; }
    }
}