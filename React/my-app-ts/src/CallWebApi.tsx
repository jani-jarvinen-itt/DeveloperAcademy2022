import React from 'react';

class CallWebApi extends React.Component {

    handleButtonClick() {
        console.log("Button clicked, it works!");

        console.log("Starting to call the Express.js API.");
        fetch('http://localhost:3300/')
            .then(response => response.json())
            .then(data => {
                console.log("Express.js API has been called.");
                console.log(data);
                // document.getElementById("resultsArea").innerText = data.myproperty;
            });
    }

    render() {
        return <div>
            <h1>CallWebApi</h1>
            <button onClick={this.handleButtonClick}>My button</button>
        </div>;
    }
}

export default CallWebApi;
