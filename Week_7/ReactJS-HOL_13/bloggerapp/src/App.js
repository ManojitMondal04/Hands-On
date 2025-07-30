import React from 'react';
import './App.css';

export const books = [
  { id: 101, bname: 'Master React', price: 670 },
  { id: 102, bname: 'Deep Dive into Angular 11', price: 800 },
  { id: 103, bname: 'Mongo Essentials', price: 450 }
];

function App() {
  const coursedet = (
    <div>
      <h3>React</h3>
      <p>Start Date: 01-Aug-2025</p>
      <p>End Date: 30-Aug-2025</p>

      <h3>Angular</h3>
      <p>Start Date: 05-Sep-2025</p>
      <p>End Date: 04-Oct-2025</p>
    </div>
  );

  const bookdet = (
    <ul style={{ listStyle: 'none', padding: 0 }}>
      {books.map((book) => (
        <div key={book.id}>
          <h3>{book.bname}</h3>
          <h4>{book.price}</h4>
        </div>
      ))}
    </ul>
  );

  const content = (
    <div>
      <h3>React Learning</h3>
      <p>Author: Stephan Biz</p>
      <p>Welcome to learning React!</p>

      <h3>Installation</h3>
      <p>Author: Schewzdenier</p>
    </div>
  );

  return (
    <div className="container">
      <div className="mystyle1">
        <h1>Course Details</h1>
        {coursedet}
      </div>

      <div className="vline"></div>

      <div className="st2">
        <h1>Book Details</h1>
        {bookdet}
      </div>

      <div className="vline"></div>

      <div className="v1">
        <h1>Blog Details</h1>
        {content}
      </div>
    </div>
  );
}

export default App;
