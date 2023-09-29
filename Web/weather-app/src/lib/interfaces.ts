export interface Period {
    number: number
    name: string
    startTime: string
    endTime: string
    isDaytime: boolean
    temperature: number
    temperatureUnit: string
    temperatureTrend: any
    probabilityOfPrecipitation: ProbabilityOfPrecipitation
    dewpoint: Dewpoint
    relativeHumidity: RelativeHumidity
    windSpeed: string
    windDirection: string
    icon: string
    shortForecast: string
    detailedForecast: string
}

export interface ProbabilityOfPrecipitation {
    unitCode: string
    value: number
}

export interface Dewpoint {
    unitCode: string
    value: number
}

export interface RelativeHumidity {
    unitCode: string
    value: number
}

export interface ForecastResponse {
    periods: Period[];
}