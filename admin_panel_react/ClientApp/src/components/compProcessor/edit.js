import React, { Component } from 'react';

export default class Detail extends Component {

    constructor(props) {
        super(props);
        this.state = {
            item: null,
            loading: true,
            itemId: props.itemId
        };
        this.setTypePage = props.setTypePage;


        this.inputNameRef = React.createRef();
        this.inputProducerRef = React.createRef();
        this.inputSocketRef = React.createRef();
        this.inputCoresRef = React.createRef();
        this.inputThreadsRef = React.createRef();
        this.inputFrequencyRef = React.createRef();
        this.inputTurboRef = React.createRef();
        this.inputVideoCardRef = React.createRef();
        this.inputRamRef = React.createRef();
        this.inputPriceRef = React.createRef();
        this.inputIdRef = React.createRef();
    }

    componentDidMount() {
        this.getItem(this.state.itemId);

    }

    renderCompBody(item) {
        return (
            <>
                <div>
                    <div className="row">
                        <div className="col-md-4">
                            <form method="post">
                                <input ref={this.inputIdRef} type="hidden" defaultValue={item.id}></input>
                                <div className="form-group">
                                    <label htmlFor="Name" className="control-label">Name</label>
                                    <input ref={this.inputNameRef} className="form-control" defaultValue={item.name } />
                                </div>
                                <div className="form-group">
                                    <label htmlFor="Producer" className="control-label">Producer</label>
                                    <input ref={this.inputProducerRef} className="form-control" defaultValue={item.producer} />
                                </div>
                                <div className="form-group">
                                    <label htmlFor="Socket" className="control-label">Socket</label>
                                    <input ref={this.inputSocketRef} className="form-control" defaultValue={item.socket} />
                                </div>
                                <div className="form-group">
                                    <label htmlFor="CountCores" className="control-label">Count cores</label>
                                    <input ref={this.inputCoresRef} className="form-control" type="number" defaultValue={item.countCores} />
                                </div>
                                <div className="form-group">
                                    <label htmlFor="CountThreads" className="control-label">Count threads</label>
                                    <input ref={this.inputThreadsRef} className="form-control" type="number" defaultValue={item.countThreads} />
                                </div>
                                <div className="form-group">
                                    <label htmlFor="Frequency" className="control-label">Frequency</label>
                                    <input ref={this.inputFrequencyRef} className="form-control" type="number" defaultValue={item.frequency} />
                                </div>
                                <div className="form-group">
                                    <label htmlFor="TurboTechnology" className="control-label">Turbo technology</label>
                                    <select ref={this.inputTurboRef} className="form-control" defaultValue={item.turboTechnology}>
                                        <option value="NONE">NONE</option>
                                        <option value="Turbo Boost">Turbo Boost</option>
                                        <option value="Turbo Core">Turbo Core</option>
                                    </select>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="TypeRam" className="control-label">Type of RAM</label>
                                    <select ref={this.inputRamRef} className="form-control" defaultValue={item.typeRam}>
                                        <option value="DDR2">DDR2</option>
                                        <option value="DDR3">DDR3</option>
                                        <option value="DDR4">DDR4</option>
                                        <option value="DDR5">DDR5</option>
                                    </select>
                                </div>
                                <div className="form-group form-check">
                                    <label className="form-check-label">
                                        <input className="form-check-input" type="checkbox" ref={this.inputVideoCardRef} defaultValue={item.haveVideoCard} /> Have video card?
                                    </label>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="Price" className="control-label">Price</label>
                                    <input ref={this.inputPriceRef} className="form-control" defaultValue={item.price} />
                                </div>
                                <div className="form-group">
                                    <button onClick={(ev) => {
                                        ev.preventDefault();
                                        this.editItem();
                                    }} className="btn btn-dark" >Save</button>
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
            </>

        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCompBody(this.state.item);

        return (
            <div>
                {contents}
            </div>
        );
    }

    async getItem(Id) {
        const response = await fetch('compprocessors/detail?id=' + Id);
        const data = await response.json();
        this.setState({ item: data, loading: false });
    }

    async editItem() {
        let haveVideo = this.inputVideoCardRef.current.value == "on" ? "true" : "false";

        const response = await fetch('compprocessors/edit?id=' + this.inputIdRef.current.value
            + '&name= ' + this.inputNameRef.current.value
            + '&price=' + this.inputPriceRef.current.value
            + '&producer=' + this.inputProducerRef.current.value
            + '&socket=' + this.inputSocketRef.current.value
            + '&countCores=' + this.inputCoresRef.current.value
            + '&countThreads=' + this.inputThreadsRef.current.value
            + '&frequency=' + this.inputFrequencyRef.current.value
            + '&turboTechnology=' + this.inputTurboRef.current.value
            + '&haveVideoCard=' + haveVideo
            + '&typeRam=' + this.inputRamRef.current.value);

        console.log(response);
        if (response.statusText == "OK")
            this.setTypePage("Index");
        else {
            console.log(response);
        }
    }
}