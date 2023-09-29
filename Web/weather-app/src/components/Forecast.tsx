import { ForecastResponse, Period } from '@/lib/interfaces';
import { fetchWeatherForecast } from '@/lib/weatherApi';
import { useEffect, useState } from 'react';
import Card from './Card';

interface ForecastProps {
    address: string;
}

const Forecast = ({ address }: ForecastProps) => {
    const [forecast, setForecast] = useState<ForecastResponse | null>({ periods: [] });

    useEffect(() => {
        const getWeatherForecast = async () => {
            const data = await fetchWeatherForecast(address);
            setForecast(data);
        };

        getWeatherForecast();
    }, [address]);

    return (
        <div>
            {forecast ? (
                <div>
                    <h2 className='text-2xl pb-5'>Weather Forecast for {address}</h2>
                    <ul className="grid gap-4 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 xl:grid-cols-6">
                        {forecast.periods.map((period: Period) => (
                            <li key={period.number}>
                                <Card period={period} />
                            </li>
                        ))}
                    </ul>
                </div>
            ) : (
                <div className="bg-orange-100 border-l-4 border-orange-500 text-orange-700 p-4" role="alert">
                    <p className="font-bold">Data not found</p>
                    <p>Please check the address or try again later.</p>
                </div>
            )}
        </div>
    );
};

export default Forecast;
