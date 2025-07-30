import React, { useState } from 'react';

function CurrencyConverter() {
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState(null);

  const handleSubmit = (event) => {
    event.preventDefault();
    const euroValue = parseFloat(rupees) / 90;
    setEuro(euroValue.toFixed(2));
  };

  const buttonStyle = {
    width: '150px',
    padding: '10px',
    fontSize: '16px',
    marginTop: '10px'
  };

  const inputStyle = {
    padding: '8px',
    fontSize: '14px',
    marginTop: '10px',
    borderRadius: '4px',
    border: '1px solid #ccc',
    width: '100%'
  };

  const outputBoxStyle = {
    marginTop: '15px',
    padding: '8px',
    fontSize: '16px',
    border: '1px solid #ccc',
    borderRadius: '4px',
    backgroundColor: '#f4f4f4',
    width: '100%'
  };

  return (
    <div style={{ marginTop: '30px', maxWidth: '300px' }}>
      <h2 style={{ color: 'green' }}>Currency Converter (INR to Euro)</h2>
      <form onSubmit={handleSubmit}>
        <input
          type="number"
          value={rupees}
          onChange={(e) => setRupees(e.target.value)}
          placeholder="Enter amount in INR"
          style={inputStyle}
        />
        <br />
        <button type="submit" style={buttonStyle}>Submit</button>
      </form>
      {euro && (
        <div style={outputBoxStyle}>
          Euro: €{euro}
        </div>
      )}
    </div>
  );
}

export default CurrencyConverter;
