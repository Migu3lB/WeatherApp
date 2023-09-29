const Footer = () => {
    return (
        <footer className="bg-blue-700 text-white p-4 mt-8">
            <div className="container mx-auto">
                <p className="text-center">© {new Date().getFullYear()} Weather App</p>
            </div>
        </footer>
    );
};

export default Footer;
