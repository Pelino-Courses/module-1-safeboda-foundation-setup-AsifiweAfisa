namespace SafeBoda.Core.Models;

public record Location(double Latitude, double Longitude);

public record Rider(Guid Id, string Name, string PhoneNumber);

public record Driver(Guid Id, string Name, string PhoneNumber, string MotoPlateNumber);

public record Trip(Guid Id, Guid RiderId, Guid DriverId, Location Start, Location End, decimal Fare, DateTime RequestTime);