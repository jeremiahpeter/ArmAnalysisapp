#include <iostream>
#include <cuda_runtime.h>
class joint {

    public ReactionsForces = Vec2D();
    double ReactionMoment;
    public Position = Vec3D();
    public Direction = Vec3D();

    joint() {
        
    }
};


class Vec2D {
    public double x;
    public double y;
    

    Vec(double x, double y, double z) {
        this.x = x;
        this.y = y;
        
    }

};

class Vec3D {
    public double x;
    public double y;
    public double z;
    Vec(double x, double y, double z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
};

//Takes in lengths of the sides of a triangle and returns the angles in radians
std::vector <double> calculateAngles(const double A, const double B, const double C) {
    const double angleA = acos((B * B + C * C - A * A) / (2 * B * C));
    const double angleB = acos((A * A + C * C - B * B) / (2 * A * C));
    const double angleC = acos((A * A + B * B - C * C) / (2 * A * B));
    return std::vector <double> { angleA, angleB, angleC };
}

Vec2D <double> FindActuatorWeightForce(double ActuatorBarAngle, double weight, double ActuatorLength) {
    Vec2D AppliedForce = Vec2D();
    double Weight = weight * 9.81;
    AppliedForce.y = (Weight * (sin(ActuatorBarAngle) * sin(ActuatorBarAngle)) - (sin(ActuatorBarAngle) * Weight * ActuatorLength * 0.5) * (cos(ActuatorBarAngle) + (sin(ActuatorBarAngle))) / (ActuatorLength * (sin(ActuatorBarAngle) * sin(ActuatorBarAngle) + ActuatorLength * sin(ActuatorbarAngle) * (cos(ActuatorBarAngle) + (sin(ActuatorBarAngle)))));
    AppliedForce.x = ((sin(ActuatorBarAngle) * Weight * ActuatorLength * 0.5) - AppliedForce.y * ActuatorLength * sin(ActuatorBarAngle)) / (ActuatorLength * sin(ActuatorBarAngle));
    return AppliedForce;
}
