import React from 'react';
import './App.css';


function App() {
  return (
    <div className='app-wraper'>
      <header className='header'>

      </header >

      <div className='content'>
        <div className="heart">
          <img src='https://upload.wikimedia.org/wikipedia/commons/thumb/f/f1/Heart_coraz%C3%B3n.svg/1200px-Heart_coraz%C3%B3n.svg.png' />
          <p className='pp'>
            GameHarmony
          </p>
          <p className='ppp'>
            Finally, the answer to "What will we play together in the evening?"
          </p>
        </div>
        <div className="windows">
          <div className="window">
            <input type="text" placeholder="Pick your Game" />
          </div>
          <div className="plus">
            +
          </div>
          <div className="window">
            <input type="text" placeholder="Pick their Game" />
          </div>
        </div>
      </div>
      <div className='footer'>
        <p className='p'>
          Choose two games. We'll combine them to show recommendations you'll love!
        </p>
      </div>
    </div>
  );
}

export default App;
