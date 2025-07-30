import React from 'react';
import Counter from './components/Counter';
import WelcomeButton from './components/WelcomeButton';
import ClickButton from './components/ClickButton';
import CurrencyConverter from './components/CurrencyConverter';

function App() {
  return (
    <div style={{ padding: "20px" }}>
      <h1>Event Examples App</h1>
      <Counter />
      <WelcomeButton />
      <ClickButton />
      <CurrencyConverter />
    </div>
  );
}

export default App;
