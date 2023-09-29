import React from 'react';

const Header: React.FC = () => {
  return (
    <header className="bg-blue-700 text-white px-24 py-6">
      <div className="container">
        <h1 className="text-2xl font-bold">Weather App</h1>
      </div>
    </header>
  );
};

export default Header;