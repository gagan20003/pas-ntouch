using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.MasterSettings.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.SeedData;

/// <summary>
/// Seed data for Countries and Currencies
/// </summary>
public static class CountryCurrencySeedData
{
    public static void SeedCountries(EntityTypeBuilder<Country> builder)
    {
        builder.HasData(
            new Country { Id = 1, CountryCode = "IN", CountryName = "India" },
            new Country { Id = 2, CountryCode = "US", CountryName = "United States" },
            new Country { Id = 3, CountryCode = "GB", CountryName = "United Kingdom" },
            new Country { Id = 4, CountryCode = "AE", CountryName = "United Arab Emirates" },
            new Country { Id = 5, CountryCode = "SA", CountryName = "Saudi Arabia" },
            new Country { Id = 6, CountryCode = "SG", CountryName = "Singapore" },
            new Country { Id = 7, CountryCode = "AU", CountryName = "Australia" },
            new Country { Id = 8, CountryCode = "CA", CountryName = "Canada" },
            new Country { Id = 9, CountryCode = "DE", CountryName = "Germany" },
            new Country { Id = 10, CountryCode = "FR", CountryName = "France" },
            new Country { Id = 11, CountryCode = "JP", CountryName = "Japan" },
            new Country { Id = 12, CountryCode = "CN", CountryName = "China" },
            new Country { Id = 13, CountryCode = "HK", CountryName = "Hong Kong" },
            new Country { Id = 14, CountryCode = "MY", CountryName = "Malaysia" },
            new Country { Id = 15, CountryCode = "TH", CountryName = "Thailand" },
            new Country { Id = 16, CountryCode = "ID", CountryName = "Indonesia" },
            new Country { Id = 17, CountryCode = "PH", CountryName = "Philippines" },
            new Country { Id = 18, CountryCode = "VN", CountryName = "Vietnam" },
            new Country { Id = 19, CountryCode = "KR", CountryName = "South Korea" },
            new Country { Id = 20, CountryCode = "NZ", CountryName = "New Zealand" },
            new Country { Id = 21, CountryCode = "ZA", CountryName = "South Africa" },
            new Country { Id = 22, CountryCode = "BR", CountryName = "Brazil" },
            new Country { Id = 23, CountryCode = "MX", CountryName = "Mexico" },
            new Country { Id = 24, CountryCode = "IT", CountryName = "Italy" },
            new Country { Id = 25, CountryCode = "ES", CountryName = "Spain" },
            new Country { Id = 26, CountryCode = "NL", CountryName = "Netherlands" },
            new Country { Id = 27, CountryCode = "CH", CountryName = "Switzerland" },
            new Country { Id = 28, CountryCode = "SE", CountryName = "Sweden" },
            new Country { Id = 29, CountryCode = "NO", CountryName = "Norway" },
            new Country { Id = 30, CountryCode = "DK", CountryName = "Denmark" },
            new Country { Id = 31, CountryCode = "FI", CountryName = "Finland" },
            new Country { Id = 32, CountryCode = "IE", CountryName = "Ireland" },
            new Country { Id = 33, CountryCode = "AT", CountryName = "Austria" },
            new Country { Id = 34, CountryCode = "BE", CountryName = "Belgium" },
            new Country { Id = 35, CountryCode = "PT", CountryName = "Portugal" },
            new Country { Id = 36, CountryCode = "PL", CountryName = "Poland" },
            new Country { Id = 37, CountryCode = "RU", CountryName = "Russia" },
            new Country { Id = 38, CountryCode = "TR", CountryName = "Turkey" },
            new Country { Id = 39, CountryCode = "EG", CountryName = "Egypt" },
            new Country { Id = 40, CountryCode = "NG", CountryName = "Nigeria" },
            new Country { Id = 41, CountryCode = "KE", CountryName = "Kenya" },
            new Country { Id = 42, CountryCode = "GH", CountryName = "Ghana" },
            new Country { Id = 43, CountryCode = "PK", CountryName = "Pakistan" },
            new Country { Id = 44, CountryCode = "BD", CountryName = "Bangladesh" },
            new Country { Id = 45, CountryCode = "LK", CountryName = "Sri Lanka" },
            new Country { Id = 46, CountryCode = "NP", CountryName = "Nepal" },
            new Country { Id = 47, CountryCode = "QA", CountryName = "Qatar" },
            new Country { Id = 48, CountryCode = "KW", CountryName = "Kuwait" },
            new Country { Id = 49, CountryCode = "BH", CountryName = "Bahrain" },
            new Country { Id = 50, CountryCode = "OM", CountryName = "Oman" }
        );
    }

    public static void SeedCurrencies(EntityTypeBuilder<Currency> builder)
    {
        builder.HasData(
            // India
            new Currency { Id = 1, CountryId = 1, CurrencyCode = "INR", CurrencyName = "Indian Rupee" },
            // United States
            new Currency { Id = 2, CountryId = 2, CurrencyCode = "USD", CurrencyName = "US Dollar" },
            // United Kingdom
            new Currency { Id = 3, CountryId = 3, CurrencyCode = "GBP", CurrencyName = "British Pound Sterling" },
            // United Arab Emirates
            new Currency { Id = 4, CountryId = 4, CurrencyCode = "AED", CurrencyName = "UAE Dirham" },
            // Saudi Arabia
            new Currency { Id = 5, CountryId = 5, CurrencyCode = "SAR", CurrencyName = "Saudi Riyal" },
            // Singapore
            new Currency { Id = 6, CountryId = 6, CurrencyCode = "SGD", CurrencyName = "Singapore Dollar" },
            // Australia
            new Currency { Id = 7, CountryId = 7, CurrencyCode = "AUD", CurrencyName = "Australian Dollar" },
            // Canada
            new Currency { Id = 8, CountryId = 8, CurrencyCode = "CAD", CurrencyName = "Canadian Dollar" },
            // Germany (Euro)
            new Currency { Id = 9, CountryId = 9, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // France (Euro)
            new Currency { Id = 10, CountryId = 10, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Japan
            new Currency { Id = 11, CountryId = 11, CurrencyCode = "JPY", CurrencyName = "Japanese Yen" },
            // China
            new Currency { Id = 12, CountryId = 12, CurrencyCode = "CNY", CurrencyName = "Chinese Yuan Renminbi" },
            // Hong Kong
            new Currency { Id = 13, CountryId = 13, CurrencyCode = "HKD", CurrencyName = "Hong Kong Dollar" },
            // Malaysia
            new Currency { Id = 14, CountryId = 14, CurrencyCode = "MYR", CurrencyName = "Malaysian Ringgit" },
            // Thailand
            new Currency { Id = 15, CountryId = 15, CurrencyCode = "THB", CurrencyName = "Thai Baht" },
            // Indonesia
            new Currency { Id = 16, CountryId = 16, CurrencyCode = "IDR", CurrencyName = "Indonesian Rupiah" },
            // Philippines
            new Currency { Id = 17, CountryId = 17, CurrencyCode = "PHP", CurrencyName = "Philippine Peso" },
            // Vietnam
            new Currency { Id = 18, CountryId = 18, CurrencyCode = "VND", CurrencyName = "Vietnamese Dong" },
            // South Korea
            new Currency { Id = 19, CountryId = 19, CurrencyCode = "KRW", CurrencyName = "South Korean Won" },
            // New Zealand
            new Currency { Id = 20, CountryId = 20, CurrencyCode = "NZD", CurrencyName = "New Zealand Dollar" },
            // South Africa
            new Currency { Id = 21, CountryId = 21, CurrencyCode = "ZAR", CurrencyName = "South African Rand" },
            // Brazil
            new Currency { Id = 22, CountryId = 22, CurrencyCode = "BRL", CurrencyName = "Brazilian Real" },
            // Mexico
            new Currency { Id = 23, CountryId = 23, CurrencyCode = "MXN", CurrencyName = "Mexican Peso" },
            // Italy (Euro)
            new Currency { Id = 24, CountryId = 24, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Spain (Euro)
            new Currency { Id = 25, CountryId = 25, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Netherlands (Euro)
            new Currency { Id = 26, CountryId = 26, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Switzerland
            new Currency { Id = 27, CountryId = 27, CurrencyCode = "CHF", CurrencyName = "Swiss Franc" },
            // Sweden
            new Currency { Id = 28, CountryId = 28, CurrencyCode = "SEK", CurrencyName = "Swedish Krona" },
            // Norway
            new Currency { Id = 29, CountryId = 29, CurrencyCode = "NOK", CurrencyName = "Norwegian Krone" },
            // Denmark
            new Currency { Id = 30, CountryId = 30, CurrencyCode = "DKK", CurrencyName = "Danish Krone" },
            // Finland (Euro)
            new Currency { Id = 31, CountryId = 31, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Ireland (Euro)
            new Currency { Id = 32, CountryId = 32, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Austria (Euro)
            new Currency { Id = 33, CountryId = 33, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Belgium (Euro)
            new Currency { Id = 34, CountryId = 34, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Portugal (Euro)
            new Currency { Id = 35, CountryId = 35, CurrencyCode = "EUR", CurrencyName = "Euro" },
            // Poland
            new Currency { Id = 36, CountryId = 36, CurrencyCode = "PLN", CurrencyName = "Polish Zloty" },
            // Russia
            new Currency { Id = 37, CountryId = 37, CurrencyCode = "RUB", CurrencyName = "Russian Ruble" },
            // Turkey
            new Currency { Id = 38, CountryId = 38, CurrencyCode = "TRY", CurrencyName = "Turkish Lira" },
            // Egypt
            new Currency { Id = 39, CountryId = 39, CurrencyCode = "EGP", CurrencyName = "Egyptian Pound" },
            // Nigeria
            new Currency { Id = 40, CountryId = 40, CurrencyCode = "NGN", CurrencyName = "Nigerian Naira" },
            // Kenya
            new Currency { Id = 41, CountryId = 41, CurrencyCode = "KES", CurrencyName = "Kenyan Shilling" },
            // Ghana
            new Currency { Id = 42, CountryId = 42, CurrencyCode = "GHS", CurrencyName = "Ghanaian Cedi" },
            // Pakistan
            new Currency { Id = 43, CountryId = 43, CurrencyCode = "PKR", CurrencyName = "Pakistani Rupee" },
            // Bangladesh
            new Currency { Id = 44, CountryId = 44, CurrencyCode = "BDT", CurrencyName = "Bangladeshi Taka" },
            // Sri Lanka
            new Currency { Id = 45, CountryId = 45, CurrencyCode = "LKR", CurrencyName = "Sri Lankan Rupee" },
            // Nepal
            new Currency { Id = 46, CountryId = 46, CurrencyCode = "NPR", CurrencyName = "Nepalese Rupee" },
            // Qatar
            new Currency { Id = 47, CountryId = 47, CurrencyCode = "QAR", CurrencyName = "Qatari Riyal" },
            // Kuwait
            new Currency { Id = 48, CountryId = 48, CurrencyCode = "KWD", CurrencyName = "Kuwaiti Dinar" },
            // Bahrain
            new Currency { Id = 49, CountryId = 49, CurrencyCode = "BHD", CurrencyName = "Bahraini Dinar" },
            // Oman
            new Currency { Id = 50, CountryId = 50, CurrencyCode = "OMR", CurrencyName = "Omani Rial" }
        );
    }
}
