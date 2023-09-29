# Weather Forecast Application

This repository contains an application that utilizes .NET Core to connect to public geocoding services and the U.S. National Weather Service API to display a 7-day weather forecast for a specific postal address on a React web page.

## Features

- Converts a postal address into latitude and longitude coordinates using the U.S. Census Geocoding Service.
- https://geocoding.geo.census.gov/geocoder/Geocoding_Services_API.pdf
- Retrieves the 7-day weather forecast for the geographic coordinates of the postal address from the U.S. National Weather Service API.
- https://www.weather.gov/documentation/services-web-api
- Displays the weather forecast on a React web page, including details such as high and low temperatures, weather conditions, and more.

## Usage

### Prerequisites

- Ensure that you have the following components installed:
  - .NET Core: [Download and Instructions](https://dotnet.microsoft.com/download)
  - Node.js and npm: [Download and Instructions](https://nodejs.org/)

### Configuration

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/Migu3lB/WeatherApp.git)https://github.com/Migu3lB/WeatherApp.git
   cd WeatherApp
