import React from 'react';

const ListOfPlayers = () => {
  const players = [
    { name: 'Virat Kohli', score: 90 },
    { name: 'Rohit Sharma', score: 85 },
    { name: 'Shubman Gill', score: 40 },
    { name: 'Hardik Pandya', score: 50 },
    { name: 'Rishabh Pant', score: 77 },
    { name: 'KL Rahul', score: 67 },
    { name: 'Jadeja', score: 33 },
    { name: 'Shami', score: 71 },
    { name: 'Bumrah', score: 88 },
    { name: 'Axar Patel', score: 45 },
    { name: 'Iyer', score: 92 },
  ];

  const players70 = [];

  players.map((item) => {
    if (item.score <= 70) {
      players70.push(item);
    }
  });

  return (
    <div>
      <h2>All Players</h2>
      {players.map((item, index) => (
        <div key={index}>
          <li>
            Mr. {item.name} <span>{item.score}</span>
          </li>
        </div>
      ))}

      <h3>Players with score ≤ 70</h3>
      {players70.map((item, index) => (
        <div key={index}>
          <li>
            Mr. {item.name} <span>{item.score}</span>
          </li>
        </div>
      ))}
    </div>
  );
};

export default ListOfPlayers;
