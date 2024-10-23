using NASCAR.Data.Client.NATS.Models.OpticalTrackingData;
using NASCAR.Data.Client.NATS.Models.TelemetricData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.NATS.DataPoints
{
    public class DataPoint
    {
        private string Name { get; }
        private string ProdID { get; }
        private string IntegID { get; }
        private Type ReturnType { get; }

        public DataPoint(string name, string prodID, string devID, Type returnType)
        {
            Name = name;
            ProdID = prodID;
            IntegID = devID;
            ReturnType = returnType;
        }

        public string GetID(bool production = true)
        {
            return production ? ProdID : IntegID;
        }

        public static readonly DataPoint EngineSpeed = new DataPoint("EngineSpeed", "DP6d4b5b09", "DP6d4b5b09", typeof(TelemetricData));
        public static readonly DataPoint aSteering = new DataPoint("aSteering", "DPc5d5bef7", "DPc5d5bef7", typeof(TelemetricData));
        public static readonly DataPoint ThrottlePosition = new DataPoint("ThrottlePosition", "DPe65ddcf1", "DPe65ddcf1", typeof(TelemetricData));
        public static readonly DataPoint BrakePressure = new DataPoint("Brake Pressure", "DPd374b11e", "DPd374b11e", typeof(TelemetricData));
        public static readonly DataPoint nGear = new DataPoint("nGear", "DPff57f3e2", "DPff57f3e2", typeof(TelemetricData));
        public static readonly DataPoint VehicleHealth = new DataPoint("vehicle_health", "DPabb98bbb", "-none-", typeof(TelemetricData));

        public static readonly DataPoint Acc = new DataPoint("Acc", "DP31c8b11f", "DPa54017f0", typeof(TelemetricData));
        public static readonly DataPoint Gyro = new DataPoint("Gyro", "DP0be8030e", "DPb1a483f5", typeof(TelemetricData));

        public static readonly DataPoint LowLatency = new DataPoint("Low-Latency", "DPec9613e1", "DPec9613e1", typeof(LocationData));
        public static readonly DataPoint HighLatency = new DataPoint("High-Latency", "DP167bb8d3", "DP167bb8d3", typeof(LocationData));

        public static readonly DataPoint PitRoad = new DataPoint("pitroad", "DP46dcc986", "DP46dcc986", typeof(PitRoadData));
    }

}
