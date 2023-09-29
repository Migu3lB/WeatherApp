import React from 'react';
import { Period } from '@/lib/interfaces';

interface CardProps {
    period: Period;
}

const Card = ({ period }: CardProps) => (
    <div className="rounded overflow-hidden shadow-lg flex flex-col h-full">
        <img className="w-full" src={period?.icon} alt="Sunset in the mountains" />
        <div className="px-6 py-4 flex-grow">
            <div className="font-bold text-xl mb-2">{period?.name}</div>
            <p className='text-gray-700 text-base'>{period?.shortForecast}</p>
            <p className={`${period?.isDaytime ? "text-red-600" : "text-blue-600"} `}>
                {period?.isDaytime ? "High" : "Low"}: {period.temperature} &#8457;
            </p>
        </div>
    </div>
);

export default Card;
