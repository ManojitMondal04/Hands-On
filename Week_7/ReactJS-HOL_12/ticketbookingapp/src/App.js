import React, { useState } from "react";

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  return (
    <div style={styles.container}>
      {!isLoggedIn ? (
        <>
          <h2 style={styles.text}>Please sign up</h2>
          <button style={styles.button} onClick={() => setIsLoggedIn(true)}>
            Login
          </button>
        </>
      ) : (
        <>
          <h2 style={styles.text}>Welcome back</h2>
          <button style={styles.button} onClick={() => setIsLoggedIn(false)}>
            Logout
          </button>
        </>
      )}
    </div>
  );
}

const styles = {
  container: {
    marginTop: "100px",
    marginLeft: "50px", // Adjust this value for how far left you want
    fontFamily: "Arial, sans-serif"
  },
  text: {
    textAlign: "left"
  },
  button: {
    padding: "10px 20px",
    fontSize: "16px",
    marginTop: "10px",
    cursor: "pointer",
    display: "block",
    textAlign: "left"
  }
};

export default App;
