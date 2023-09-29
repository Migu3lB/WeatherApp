import { ForecastResponse } from "./interfaces";

export async function fetchWeatherForecast(address: string): Promise<ForecastResponse | null> {
    try {
        const response = await fetch(`https://localhost:7184/api/geocoding/location?address=${encodeURIComponent(address)}`);
        if (!response.ok) {
            throw new Error(`Error getting weather forecast: ${response.statusText}`);
        }
        return await response.json();
    } catch (error) {
        console.error('Error getting weather forecast:', error);
        return null;
    }
}