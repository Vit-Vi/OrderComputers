import React, { Component } from 'react';

export default class Index extends Component {

    constructor(props) {
        super(props);
        this.state = {
            items: [],
            loading: true   
        };
        this.inputNameRef = React.createRef();
        this.inputTypeRef = React.createRef();
        this.inputCountRef = React.createRef();
        this.inputFrequencyRef = React.createRef();
        this.inputPriceRef = React.createRef();


        this.setTypePage = props.setTypePage;
    }


    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-md-4">
                        <form method="post">
                            <div className="form-group">
                                <label className="control-label">Name</label>
                                <input ref={this.inputNameRef} className="form-control" />
                            </div>
                            <div className="form-group">
                                <label className="control-label">Type</label>
                                <select ref={this.inputTypeRef} className="form-control">
                                    <option value="DDR2">DDR2</option>
                                    <option value="DDR3">DDR3</option>
                                    <option value="DDR4">DDR4</option>
                                    <option value="DDR5">DDR5</option>
                                </select>
                            </div>
                            <div className="form-group">
                                <label className="control-label">Count</label>
                                <input ref={this.inputCountRef} className="form-control" type="number" />
                            </div>
                            <div className="form-group">
                                <label className="control-label">Frequency</label>
                                <input ref={this.inputFrequencyRef} className="form-control" type="number" />
                            </div>
                            <div className="form-group">
                                <label className="control-label">Price</label>
                                <input ref={this.inputPriceRef} className="form-control" type="number" />
                            </div>
                            <div className="form-group">
                                <input onClick={(ev) => {
                                    this.createItem();
                                }} defaultValue="Add" className="btn btn-primary" />
                            </div>
                        </form>
                    </div>
                </div>
                <div>
                    <a onClick={(ev) => {

                        this.setTypePage("Index");
                    }
                    }>Back to list</a>
                </div>
            </div>
        );
    }

    async createItem() {
        const response = await fetch('rammemories/create?'
            + 'name=' + this.inputNameRef.current.value
            + '&type=' + this.inputTypeRef.current.value
            + '&count=' + this.inputCountRef.current.value
            + '&frequency=' + this.inputFrequencyRef.current.value
            + '&price=' + this.inputPriceRef.current.value);

        if (response.statusText == "OK") 
            this.setTypePage("Index");
        
        else
            this.setState({ problem: response.statusText, loading: false });
    }
}