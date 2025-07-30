import React from 'react';

function OfficeCard({ office }) {
  const rentStyle = {
    color: office.rent < 60000 ? 'red' : 'green',
    fontWeight: 'bold'
  };

  return (
    <div className="card">
      <img src={office.image} alt={office.name} />
      <h2>{office.name}</h2>
      <p style={rentStyle}>Rent: ₹{office.rent}</p>
      <p>Address: {office.address}</p>
    </div>
  );
}

export default OfficeCard;
