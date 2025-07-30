import React from 'react';

function WelcomeButton() {
  const sayWelcome = (message) => {
    alert(message);
  };

  const buttonStyle = {
    width: '150px',
    padding: '10px',
    fontSize: '16px',
  };

  return (
    <div style={{ marginBottom: '20px' }}>
      <button style={buttonStyle} onClick={() => sayWelcome("Welcome!")}>Say Welcome</button>
    </div>
  );
}

export default WelcomeButton;
