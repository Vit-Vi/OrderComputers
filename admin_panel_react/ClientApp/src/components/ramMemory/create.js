import React, { Component } from 'react';
import { Layout } from '../Layout';

export default class Create extends Component {

    constructor(props) {
        super(props);

        this.state = {
            imageUrl: ""
        }

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
                        <form >
                            <div className="form-group">
                                <label className="control-label">Название</label>
                                <input ref={this.inputNameRef} className="form-control" />
                            </div>
                            <div className="form-group">
                                <label className="control-label">Тип</label>
                                <select ref={this.inputTypeRef} className="form-control">
                                    <option value="DDR2">DDR2</option>
                                    <option value="DDR3">DDR3</option>
                                    <option value="DDR4">DDR4</option>
                                    <option value="DDR5">DDR5</option>
                                </select>
                            </div>
                            <div className="form-group">
                                <label className="control-label">Объем(Mb)</label>
                                <input ref={this.inputCountRef} className="form-control" type="number" />
                            </div>
                            <div className="form-group">
                                <label className="control-label">Частота(MGz)</label>
                                <input ref={this.inputFrequencyRef} className="form-control" type="number" />
                            </div>
                            <div className="form-group">
                                <label className="control-label">URL изображения</label>
                                <input onChange={(ev) => { this.setState({ imageUrl: ev.target.value }) }} 
                                className="form-control" type="url" />
                            </div>
                            <div className="form-group">
                                <img src={this.state.imageUrl} />
                            </div>
                            <div className="form-group">
                                <label className="control-label">Цена</label>
                                <input ref={this.inputPriceRef} className="form-control" type="number" />
                            </div>
                            <div className="form-group">
                                <button onClick={(ev) => {
                                    ev.preventDefault();
                                    this.createItem();
                                }} className="btn btn-primary">Добавить</button>
                            </div>
                        </form>
                    </div>
                </div>
                <div>
                    <a onClick={(ev) => {

                        this.setTypePage("Index");
                    }
                    }>Вернуться к списку</a>
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
            + '&imgUrl=' + this.state.imageUrl
            + '&price=' + this.inputPriceRef.current.value);
        if (response.status == 200) {

            this.setTypePage("Index");
            Layout.setMessage('RAM добавлена! ');
        } else {

            Layout.setMessage('Ошибка при добавлении RAM: ' + response.status);
        }
    }
}