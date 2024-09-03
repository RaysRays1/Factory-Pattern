using System.Diagnostics;
using System.Net.Http.Headers;

namespace FactoryPattern;
 
public static class VehicleFactory
{
    public static IVehicle GetVehicle(int NumberOfTires)
    {
        
        switch(NumberOfTires)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            default:
                return new Motorcycle();
            
        }
        
        
    }

    
}