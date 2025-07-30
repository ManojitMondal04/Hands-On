import React from 'react';

export function OddPlayers({ players }) {
  const [first, , third, , fifth] = players; // Destructuring pattern from your image

  return (
    <div>
      <li> First : {first} </li>
      <li> Third : {third} </li>
      <li> Fifth : {fifth} </li>
    </div>
  );
}
