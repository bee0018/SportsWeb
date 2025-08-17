import React from 'react';
import logo from './logo.svg';
import './App.css';
import {Api} from "./API/SportsWebApiClient";

async function fetchTodo() {
    // const result = await fetch("https://localhost:44369/todo?id=4&scream=true")
    // const data = await result.json();
    // console.log(data);

    const api = new Api();
    const response = await api.todo.sportsWebApiEndPointsTodoEndPoint({id: 123, scream: true})
    const data = response.data;
    console.log(data)
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
