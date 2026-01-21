namespace PAS.NTouch.Application;

/// <summary>
/// Application layer marker class
/// This layer will contain:
/// - DTOs (Data Transfer Objects)
/// - Services (Business Logic)
/// - Validators (FluentValidation)
/// - Mappers (AutoMapper profiles)
/// - MediatR handlers (CQRS pattern)
/// </summary>
public static class ApplicationMarker
{
    public const string LayerName = "Application";
}
