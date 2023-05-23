import React from 'react';
import './Content.css';


const Content = () => {
    return <div className='content'>
        <div className="heart">
            <img src='https://psv4.userapi.com/c236331/u274297601/docs/d48/9fda5a8aa8b9/png-transparent-minecraft-video-game-health-game-result.png?extra=lrp00L2amX4DxfBykq7wu5RQdOCoCgRUxbD2jC2HoXKf2HG7InWLdPMCV7LKtGsuMoRdyYTtQcLN31r2UiTgbNIHbWbZ90PkQMnuELijUHqHA96_ygjwFUIoZhg8a8nHGxt0vT_DWN7NbYGgvK0FmYDtLw' />
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
        <button class="btn">
            Random combo
        </button>
    </div>;
}

export default Content;