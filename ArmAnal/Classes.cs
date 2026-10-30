using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URCarmApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;
    using System.Xml.Schema;
    using URCarmApp.ArmAnalysisApp;
    namespace ArmAnalysisApp
    {
        internal class bar
        {
            public double RAX = 0;
            public double RAY = 0;
            public double RFX = 0;
            public double RFY = 0;
            public double ActuatorForce = 0;
            public bar(double Fwl, double Fcy, double Fd, double Fxc, double L, double lp, double angle, double moment)
            {
                this.RAY = (-Math.Sin(Math.PI * 0.5 - angle) * Fwl * 0.5 - Fcy * Math.Sin(Math.PI * 0.5 - angle) * L - Fd * Math.Sin(Math.PI * 0.5 - angle) * L - moment) / (Math.Sin(Math.PI * 0.5 - angle));
                this.RFY = Fwl + Fcy + Fd - this.RAY;
                this.RFX = (Fd * Math.Sin(Math.PI * 0.5 - angle) * lp + Fcy * Math.Sin(Math.PI * 0.5 - angle) * lp + Fd * Math.Sin(Math.PI * 0.5 - angle) * L) / (Math.Sin(Math.PI * 0.5 - angle) * lp);
                this.RAX = -Fxc - this.RFX;
            }
        };
        public class PistonLever
        {
            public double PistonMinDistance = 0;
            public double PistonMaxDistance = 0;
            public double LinkHeight = 0;
            public double LinkLength = 0;
            public Dictionary<string, double> Angles = new Dictionary<string, double>();
            public double PercentConnect = 0;
            public double MaxAllowableForce = 0;
            public double barWeight = 0;
            public double ActuatorWeight = 0;
            public double AppliedForce = 0;
            public double percentconnect = 0;
            public double intervals = 100;
            public important_numbers Solutions = new important_numbers(1, 2, 3, 4, 5, 6, 7, 8);
            public PistonLever
                (
                double pistonmindistance,
                double pistonmaxdistance,
                double linkheight,
                double linklength,
                double percentconnect,
                double max_force,
                double AppliedForce,
                double weight,
                double actuatorweight,
                double expected_acceleration,
                double intervals = 100
                )
            {
                this.PistonMinDistance = pistonmindistance;
                this.PistonMaxDistance = pistonmaxdistance;
                this.LinkHeight = linkheight;
                this.LinkLength = linklength;
                this.PercentConnect = percentconnect;
                this.Angles.Add("StationaryPiston", 0);
                this.Angles.Add("StationaryLink", 0);
                this.Angles.Add("LinkPiston", 0);
                this.MaxAllowableForce = 0;
                this.ActuatorWeight = actuatorweight * 9.81;
                this.barWeight = weight * 9.81;
                this.AppliedForce = AppliedForce;
                this.percentconnect = percentconnect;
                this.intervals = intervals;
                this.Solutions = new important_numbers(pistonmindistance, pistonmaxdistance, 0, 0, 0, 0, 0, 0);
            }
            public void CalculateAngles(double CurrentPistonLength)
            {
                this.Angles["StationaryLink"] = Math.Acos(Math.Pow(this.LinkHeight, 2) + Math.Pow(this.LinkLength, 2) - Math.Pow(CurrentPistonLength, 2) / (2 * this.LinkHeight * this.LinkLength));
                this.Angles["StationaryPiston"] = Math.Acos(Math.Pow(this.LinkHeight, 2) + Math.Pow(CurrentPistonLength, 2) - Math.Pow(this.LinkLength, 2) / (2 * this.LinkHeight * CurrentPistonLength));
                this.Angles["LinkPiston"] = Math.PI * 0.5 - this.Angles["StationaryLink"] - this.Angles["StationaryPiston"];
            }
            public Dictionary<string, double> Order_66()
            {
                Dictionary<string, double> return_dict = new Dictionary<string, double>();
                bool foundmax = false;
                bool foundmin = false;
                for (int i = 1; i < this.intervals - 1; i++)
                {
                    double length = this.PistonMinDistance + (i * (this.PistonMaxDistance - this.PistonMinDistance) / this.intervals);
                    this.CalculateAngles(length);
                    link LinearActuatorReactions = new link(this.LinkLength, this.Angles["StationaryPiston"], this.ActuatorWeight);
                    Console.WriteLine($"reactions: RAX: {LinearActuatorReactions.RAX}, RAY: {LinearActuatorReactions.RAY}, RBX: {LinearActuatorReactions.RBX}, RBY: {LinearActuatorReactions.RBY}");
                    double Force = this.CalculateActuatorForce(this.barWeight, LinearActuatorReactions.RBY, this.AppliedForce, LinearActuatorReactions.RBX, this.LinkLength, this.LinkLength * this.percentconnect, Math.PI * 0.5 - this.Angles["StationaryLink"], 0.5);
                    Console.WriteLine($"Force: {Force} at Length: {length}, for iteration {i}");
                    if (Force > this.MaxAllowableForce && !foundmax)
                    {
                        this.Solutions.MaxF = Force;
                        this.Solutions.AngleMax = this.Angles["StationaryPiston"];
                        this.Solutions.HeightMax = this.LinkLength * Math.Sin(this.Angles["Stationarylink"]);
                        return_dict.Add("MinLength", length);
                    }
                    if (Force < 0)
                    {
                        return_dict.Add("MaxLength", length);
                        this.Solutions.MinF = Force;
                        this.Solutions.AngleMin = this.Angles["StationaryPiston"];
                        this.Solutions.HeightMin = this.LinkLength * Math.Sin(this.Angles["StationaryLink"]);
                        break;
                    }
                }
                if (!foundmax)
                {
                    Console.WriteLine("MinLength not bounded");
                    return_dict.Add("MinLength", this.PistonMinDistance);
                    Console.WriteLine($"MinLength {this.PistonMaxDistance}");

                    this.CalculateAngles(this.PistonMinDistance);
                    link first_reaction = new link(this.LinkLength, this.Angles["StationaryPiston"], this.ActuatorWeight);
                    double InnitForce = this.CalculateActuatorForce(this.barWeight, first_reaction.RBY, this.AppliedForce, first_reaction.RBX, this.LinkLength, this.LinkLength * this.percentconnect, Math.PI * 0.5 - this.Angles["StationaryLink"], 0.5);
                    this.Solutions.MaxF = InnitForce;
                    this.Solutions.AngleMax = this.Angles["StationaryPiston"];
                    this.Solutions.HeightMax = this.LinkLength * Math.Sin(Math.PI * 0.5 - this.Angles["StationaryLink"]);
                    this.Solutions.PistonMinDistance = this.PistonMinDistance;
                }
                if (!foundmin)
                {
                    Console.WriteLine("MaxLength not bounded");
                    return_dict.Add("MaxLength", this.PistonMaxDistance);
                    Console.WriteLine($"MaxLength {this.PistonMaxDistance}");
                    this.CalculateAngles(this.PistonMaxDistance);
                    link last_reaction = new link(this.LinkLength, this.Angles["StationaryPiston"], this.ActuatorWeight);
                    double InnitForce = this.CalculateActuatorForce(this.barWeight, last_reaction.RBY, this.AppliedForce, last_reaction.RBX, this.LinkLength, this.LinkLength * this.percentconnect, Math.PI * 0.5 - this.Angles["StationaryLink"], 0.5);
                    this.Solutions.MinF = InnitForce;
                    this.Solutions.AngleMin = this.Angles["StationaryPiston"];
                    this.Solutions.HeightMin = this.LinkLength * Math.Sin(Math.PI * 0.5 - this.Angles["StationaryLink"]);
                    this.Solutions.PistonMaxDistance = this.PistonMaxDistance;
                }
                return return_dict;
            }
            public double CalculateActuatorForce(double Fwl, double Fcy, double Fd, double Fxc, double L, double lp, double angle, double expected_acceleration)
            {
                double I = 0.3333 * L * L * Fwl / 9.81;
                bar bar1 = new bar(Fwl, Fcy, Fd, Fxc, L, lp, angle, I * expected_acceleration);
                Console.WriteLine("Sucessfully calculated actuator force");
                return Math.Sqrt(bar1.RFX * bar1.RFX + bar1.RFY * bar1.RFY);
            }
        }
        internal class link
        {
            public double RAX = 0;
            public double RAY = 0;
            public double RBX = 0;
            public double RBY = 0;
            public link(double length, double angle, double weight)
            {
                weight = weight * 9.81;
                this.RBY = ((weight * Math.Sin(angle) * Math.Sin(angle) - Math.Sin(angle) * weight * length * 0.5) * (Math.Cos(angle) + Math.Sin(angle))) / (length * Math.Sin(angle) * Math.Sin(angle) + length * Math.Sin(angle) * (Math.Cos(angle) + Math.Sin(angle)));
                this.RAY = weight - this.RBY;
                this.RBX = (Math.Sin(angle) * weight * length * 0.5 - this.RBY * length * Math.Sin(angle)) / (length * Math.Sin(angle));
                this.RAX = -this.RBX;
            }
        }
    }

    public class important_numbers
    {
        public double PistonMinDistance = 0;
        public double PistonMaxDistance = 0;
        public double MaxF = 0;
        public double MinF = 0;
        public double AngleMax = 0;
        public double AngleMin = 0;
        public double HeightMax = 0;
        public double HeightMin = 0;
        public important_numbers(double pistonmindistance, double pistonmaxdistance, double MaxF, double MinF, double AngleMax, double AngleMin, double HeightMax, double HeightMin)
        {
            this.PistonMinDistance = pistonmindistance;
            this.PistonMaxDistance = pistonmaxdistance;
            this.MaxF = MaxF;
            this.MinF = MinF;
            this.AngleMax = AngleMax;
            this.AngleMin = AngleMin;
            this.HeightMax = HeightMax;
            this.HeightMin = HeightMin;
        }
        public void Print()
        {
            Console.WriteLine($"PistonMinDistance: {this.PistonMinDistance}");
            Console.WriteLine($"PistonMaxDistance: {this.PistonMaxDistance}");
            Console.WriteLine($"MaxF: {this.MaxF}");
            Console.WriteLine($"MinF: {this.MinF}");
            Console.WriteLine($"AngleMax: {this.AngleMax}");
            Console.WriteLine($"AngleMin: {this.AngleMin}");
            Console.WriteLine($"HeightMax: {this.HeightMax}");
            Console.WriteLine($"HeightMin: {this.HeightMin}");
        }
    }
}
