import React, { useState } from 'react';

function Counter() {
  const [count, setCount] = useState(0);

  const sayHello = () => {
    console.log('Hello! This is a static message.');
  };

  const increment = () => {
    setCount(prev => prev + 1);
    sayHello();
  };

  const decrement = () => {
    setCount(prev => prev - 1);
  };

  const buttonStyle = {
    width: '150px',
    padding: '10px',
    fontSize: '16px',
  };

  return (
    <div style={{ marginBottom: '20px' }}>
      <h2>Counter: {count}</h2>
      <div style={{ display: 'flex', flexDirection: 'column', gap: '10px' }}>
        <button style={buttonStyle} onClick={increment}>Increment</button>
        <button style={buttonStyle} onClick={decrement}>Decrement</button>
      </div>
    </div>
  );
}

export default Counter;
