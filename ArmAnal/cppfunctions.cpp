#include <iostream>



extern "C" {
    // __declspec(dllexport) exposes the function outside the DLL
    __declspec(dllexport) void Check () {
        std::cout << "Running check..." << std::endl;
    }
}



void runcheck () {
    std::cout << "Running check..." << std::endl;
}


class joint {

    public  Vec2D ReactionsForces = Vec2D();
    public double ReactionMoment;
    public Vec3D Position = Vec3D();
    public Vec3D Direction = Vec3D();

    joint() {

    }
};

class Angles {
    public double ActuatorArm;
    public double BarHeight;
    public double BarArm;

    public Angles (){
    }

    public Angles(double angleA, double angleB, double angleC) {
        this.ActuatorArm = angleA;
        this.BarHeight = angleB;
        this.BarArm = angleC;
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
Angles calculateAngles(const double A, const double B, const double C) {
    const double angleA = acos((B * B + C * C - A * A) / (2 * B * C));
    const double angleB = acos((A * A + C * C - B * B) / (2 * A * C));
    const double angleC = acos((A * A + B * B - C * C) / (2 * A * B));
    return Angles(angleA, angleB, angleC);
}

Vec2D <double> FindActuatorWeightForce(double ActuatorBarAngle, double weight, double ActuatorLength) {
    Vec2D AppliedForce = Vec2D();
    double Weight = weight * 9.81;
    AppliedForce.y = (Weight * (sin(ActuatorBarAngle) * sin(ActuatorBarAngle)) - (sin(ActuatorBarAngle) * Weight * ActuatorLength * 0.5) * (cos(ActuatorBarAngle) + (sin(ActuatorBarAngle))) / (ActuatorLength * (sin(ActuatorBarAngle) * sin(ActuatorBarAngle) + ActuatorLength * sin(ActuatorbarAngle) * (cos(ActuatorBarAngle) + (sin(ActuatorBarAngle)))));
    AppliedForce.x = ((sin(ActuatorBarAngle) * Weight * ActuatorLength * 0.5) - AppliedForce.y * ActuatorLength * sin(ActuatorBarAngle)) / (ActuatorLength * sin(ActuatorBarAngle));

    std::cout << "Applied Force X: " << AppliedForce.x << std::endl;
    return AppliedForce;
}

bool isValidTriangle(double A, double B, double C) {
    return (A + B > C) && (A + C > B) && (B + C > A);
}

bool CheckMaxLengthValid(double maxLength, double  Height, double Offset, double ArmConnect) {
    Vec3D ArmAngles = calculateAngles(maxLength, Height, Offset);
    if (ArmAngles.x + ArmAngles.y + ArmAngles.z > 3.14159) {
        return false;
    }
    else {
        return true;
    }
}



//main function to fine the maximim force needed to find the requied actuator force for the arm to lift a given weight 
double FindMaxForce(double ActuatorLength, double ArmLength, double ArmConnectLength, double Height, double offset, double ForceThreshold) {
    
    bool MaxValid = CheckMaxLengthValid(ArmLength, Height, offset, ArmConnectLength);
    if (!MaxValid) {
        
    }
    else {
        double maxForce = FindMaxForceHelper(ArmAngles, ActuatorLength, ArmLength, ArmConnectLength, Height, offset);
        if (maxForce < ForceThreshold) {
             return maxForce;
    }

Angles calcBarAngles (double Height, double offset) {
    double barActuator = std::atan2(Height, offset);
    double barArm = std::PI / 2 - barActuator;
    return Angles ()
}
    



// Helper function to find the maximum force in the case that the max geometry is valid
double FindMaxForceHelper (double barAngle, double ArmWeight, double AppliedForce, double ActuatorWeight, double L, double lp, double expected_acceleration) {
    Angles ArmAngles = calculateAngles(ArmLength, Height, offset);
    ArmWeightForce = ArmWeight * 9.81;
    double I = 0.3333 * ArmLength * ArmLength * Fwl;


        


}



