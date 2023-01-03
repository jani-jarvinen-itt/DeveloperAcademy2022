import React from 'react';

interface CallWebApiState {
    dataFromApiCall: string;
}

class CallWebApi extends React.Component<any, CallWebApiState> {

    constructor(props: any) {
        super(props);
        console.log("CallWebApi.constructor()");

        this.state = { dataFromApiCall: "" };

        // This binding is necessary to make `this` work in the callback
        this.handleButtonClick = this.handleButtonClick.bind(this);
    }

    handleButtonClick() {
        console.log("Button clicked, it works!");

        console.log("Starting to call the Express.js API.");
        fetch('http://localhost:3300/')
            .then(response => response.json())
            .then(data => {
                console.log("Express.js API has been called.");
                console.log(data);

                this.setState({ dataFromApiCall: data.myproperty });
                console.log("Updated component state!");
            });
    }

    render() {
        console.log("CallWebApi.render()");

        return <div>
            <h1>CallWebApi</h1>
            <button onClick={this.handleButtonClick}>My button</button>
            <h2>Data from API: {this.state.dataFromApiCall}</h2>
        </div>;
    }
}

export default CallWebApi;
