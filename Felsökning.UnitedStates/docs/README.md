# Felsökning.UnitedStates NuGet Package

The `Felsökning.UnitedStates` NuGet package provides a collection of classes and methods for interacting with various services in the United States, including the National Weather Service (NWS), National Aeronautics and Space Administration (NASA), Federal Aviation Administration (FAA), and Louis Armstrong Airport (MSY).

## Available Methods

### National Weather Service (NWS)

#### `NwsWrapper`
- **Constructor**: `NwsWrapper([Optional] string locationCode)`
  - Initializes a new instance of the `NwsWrapper` class.
  - Default `locationCode`: `"DCC001"`.

- **Methods**:
  - `Task<ActiveAlerts> GetActiveAlertsAsync()`
    - Retrieves the current active alerts for a given area.
    - **Returns**: `Task<ActiveAlerts>`
  - `Task<HistoricAlerts> GetHistoricAlertsAsync()`
    - Retrieves historic alerts for a given area.
    - **Returns**: `Task<HistoricAlerts>`

---

### NASA

#### `ApodWrapper`
- **Constructor**: `ApodWrapper([Optional] string apiKey)`
  - Initializes a new instance of the `ApodWrapper` class.
  - Default `apiKey`: `"DEMO_KEY"`.

- **Methods**:
  - `Task<AstronomyPictureOfTheDay> GetTheAstronomyPictureOfTheDayAsync()`
    - Retrieves the Astronomy Picture of the Day (APOD) from the NASA Planetary API.
    - **Returns**: `Task<AstronomyPictureOfTheDay>`

---

### FAA

#### `NotamsWrapper`
- **Constructor**: `NotamsWrapper()`
  - Initializes a new instance of the `NotamsWrapper` class.

- **Methods**:
  - `Task<List<string>> GetPublishedNotamsForAirportAsync(string icaoId)`
    - Retrieves NOTAMs for a given airport or aerodrome via the ICAO ID.
    - **Returns**: `Task<List<string>>`
  - `Task<IAsyncEnumerable<string>> GetPublishedNotamsForAirportIAsync(string icaoId)`
    - Retrieves NOTAMs for a given airport or aerodrome via the ICAO ID as an asynchronous enumerable.
    - **Returns**: `Task<IAsyncEnumerable<string>>`

---

### Louis Armstrong Airport (MSY)

#### `MsyWrapper`
- **Constructor**: `MsyWrapper()`
  - Initializes a new instance of the `MsyWrapper` class.

- **Methods**:
  - `Task<List<Flight>> GetFlightsAsync()`
    - Retrieves all flights to/from MSY Airport.
    - **Returns**: `Task<List<Flight>>`

---

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/felsokning/Fels-kning.UnitedStates.git
   ```
2. Navigate to the folder:
   ```bash
   cd Fels-kning.UnitedStates
   ```
3. Build and test the project:
   ```bash
   dotnet restore --verbosity=normal
   dotnet build --verbosity=normal
   dotnet test --verbosity=normal
   ```

## Contribute

Contributions are welcome! Feel free to submit a pull request or open an issue.

![contributions](https://img.shields.io/badge/contributions-welcome-green)