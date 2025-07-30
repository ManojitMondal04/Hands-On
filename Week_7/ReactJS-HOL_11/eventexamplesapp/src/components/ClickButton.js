import React from 'react';

function ClickButton() {
  const handleClick = (event) => {
    console.log("Synthetic Event:", event);
    alert("I was clicked");
  };

  const buttonStyle = {
    width: '150px',
    padding: '10px',
    fontSize: '16px',
  };

  return (
    <div style={{ marginBottom: '20px' }}>
      <button style={buttonStyle} onClick={handleClick}>Click Me</button>
    </div>
  );
}

export default ClickButton;
