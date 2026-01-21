# PAS NTouch - Insurance Policy Administration System

A .NET 9 Clean Architecture solution for Insurance Policy Administration, configured for NeonDB (PostgreSQL).

## Project Structure

```
PAS.NTouch/
├── src/
│   ├── PAS.NTouch.SharedKernel/     # Base entities, common interfaces
│   ├── PAS.NTouch.Domain/           # Domain entities organized by module
│   │   ├── Product/                 # 7 entities, 2 enums
│   │   ├── MasterSettings/          # 5 entities, 2 enums
│   │   ├── Member/                  # 7 entities, 10 enums
│   │   ├── Contracts/               # 6 entities, 3 enums
│   │   └── Billing/                 # 5 entities, 6 enums
│   ├── PAS.NTouch.Application/      # DTOs, services, validators
│   ├── PAS.NTouch.Infrastructure/   # DbContext, EF configurations
│   └── PAS.NTouch.API/              # ASP.NET Core Web API
└── PAS.NTouch.sln
```

## Prerequisites

- .NET 9 SDK
- NeonDB account (or local PostgreSQL)

## Getting Started

### 1. Clone and Restore

```bash
cd /path/to/pas-ntouch
dotnet restore
```

### 2. Configure NeonDB Connection

Edit `src/PAS.NTouch.API/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=<your-project-id>.neon.tech;Database=neondb;Username=<username>;Password=<password>;SSL Mode=Require;Trust Server Certificate=true"
  }
}
```

### 3. Run Migrations

```bash
# Add initial migration
dotnet ef migrations add InitialCreate \
    --project src/PAS.NTouch.Infrastructure \
    --startup-project src/PAS.NTouch.API \
    --output-dir Persistence/Migrations

# Apply to database
dotnet ef database update \
    --project src/PAS.NTouch.Infrastructure \
    --startup-project src/PAS.NTouch.API
```

### 4. Run the API

```bash
dotnet run --project src/PAS.NTouch.API
```

API will be available at:
- Swagger UI: https://localhost:5001
- Health endpoint: https://localhost:5001/health

## Modules

| Module | Entities | Description |
|--------|----------|-------------|
| Product | 7 | Product definitions, FOBs, rates, eligibility |
| MasterSettings | 5 | Country, Currency, Tax, Organization, BillingFee |
| Member | 7 | Members, addresses, contacts, identities, brokers |
| Contracts | 6 | Contracts, categories, enrollments, endorsements |
| Billing | 5 | Accounts, installments, invoices, payments |

## Technology Stack

- **Framework**: .NET 9, ASP.NET Core
- **Database**: NeonDB (PostgreSQL) via Npgsql
- **ORM**: Entity Framework Core 9
- **API Documentation**: Swagger/OpenAPI

## License

Proprietary - All rights reserved
