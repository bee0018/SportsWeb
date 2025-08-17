import React from 'react';
import logo from './logo.svg';
import './App.css';
import {Client} from "./API/SportsWebApiClient";

async function fetchTodo() {
    const sportsWebApiClient = new Client()
    const response = await sportsWebApiClient.sportsWebAPIEndPointsTodoEndPoint(123, false)
    console.log(response)
}

function App() {
    fetchTodo();
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
