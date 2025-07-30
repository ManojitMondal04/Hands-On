import React from 'react';
import OfficeCard from './OfficeCard';

function App() {
  const offices = [
    {
      id: 1,
      name: 'Downtown WorkHub',
      rent: 55000,
      address: '123 Main St, Mumbai',
      image: 'https://as1.ftcdn.net/v2/jpg/04/44/67/92/1000_F_444679273_dLQHT4Gn2cXtf76hHi0kHGpfiAU0cbSf.jpg'
    },
    {
      id: 2,
      name: 'Skyline Space',
      rent: 75000,
      address: '456 Marine Drive, Mumbai',
      image: 'https://as1.ftcdn.net/v2/jpg/03/96/30/84/1000_F_396308417_ihQBeZTXi2NqkK6kGElXseuFd6fAn5WL.jpg'
    },
    {
      id: 3,
      name: 'Tech Park View',
      rent: 60000,
      address: '789 Hinjewadi, Pune',
      image: 'https://as2.ftcdn.net/v2/jpg/03/39/06/67/1000_F_339066729_zCf9icIjEsSEIWwCxr2ytFlCO17H74cx.jpg'
    }
  ];

  return (
    <div className="container">
      <h1>Office Space Rental Listings</h1>
      <div className="office-list">
        {offices.map((office) => (
          <OfficeCard key={office.id} office={office} />
        ))}
      </div>
    </div>
  );
}

export default App;
