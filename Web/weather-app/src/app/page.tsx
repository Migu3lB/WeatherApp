'use client';
import Footer from "@/components/Footer";
import Forecast from "@/components/Forecast";
import Header from "@/components/Header";
import { useRef, useState } from "react";

export default function Home() {
  const [address, setAddress] = useState<string>('');
  const inputAddress = useRef<HTMLInputElement | null>(null);

  const handleSearchClick = (e: React.MouseEvent<HTMLButtonElement>) => {
    e.preventDefault();
    const enteredAddress = inputAddress.current?.value;
    if (enteredAddress) {
      setAddress(enteredAddress);

    }
  };

  const handleClearClick = () => {
    setAddress('');
    if (inputAddress.current) {
      inputAddress.current.value = '';
    }
  };

  return (
    <>
      <Header />
      <main className="flex min-h-screen flex-col px-10 lg:px-24 py-10">
        <div className='flex flex-col gap-8'>
          <div className='flex flex-col w-full gap-4'>
            <label className='text-2xl font-bold' htmlFor="inputAddress">Address</label>
            <div className='flex gap-2 flex-col md:flex-row'>
              <input
                onChange={() => handleSearchClick}
                ref={inputAddress}
                type="text"
                name='inputAddress'
                className='rounded-full border border-blue-700  focus:ring-red-950 w-full h-10 p-5'
              />
              <button
                onClick={handleSearchClick}
                className='bg-slate-800 text-white p-2 lg:w-28 md:w-36 rounded-full w-full'
                type='submit'
              >
                Search
              </button>
              {address && (
                <button
                  onClick={handleClearClick}
                  className='bg-red-600 text-white p-2 lg:w-28 md:w-36 rounded-full w-full'
                >
                  Clear
                </button>
              )}
            </div>
          </div>
          <div>
            {address && <Forecast address={address} />}
          </div>
        </div>
      </main>
      <Footer />
    </>
  )
}