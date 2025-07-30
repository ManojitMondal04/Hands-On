import React from 'react';
import { OddPlayers } from './OddPlayers';

const IndianPlayers = () => {
  const allPlayers = ['Virat', 'Rohit', 'Gill', 'Hardik', 'Pant', 'Rahul'];

  const T20players = ['Bumrah', 'Surya', 'Chahal'];
  const RanjiPlayers = ['Pujara', 'Rahane', 'Unadkat'];

  const mergedPlayers = [...T20players, ...RanjiPlayers];

  // Separate odd and even index players
  const oddTeam = allPlayers.filter((_, i) => i % 2 !== 0);
  const evenTeam = allPlayers.filter((_, i) => i % 2 === 0);

  return (
    <div>
      <h2>Odd Index Players</h2>
      <OddPlayers players={oddTeam} />

      <h2>Even Index Players</h2>
      <ul>
        {evenTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Merged Players (T20 + Ranji)</h2>
      <ul>
        {mergedPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
